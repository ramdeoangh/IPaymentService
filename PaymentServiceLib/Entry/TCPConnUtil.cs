using DependenyInjector;
using NLog;

using PaymentServiceLib.Model.Request;
using PaymentServiceLib.PinPadPOS.Net;
using PaymentServiceLib.Util;
using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace PaymentServiceLib.Entry
{
    public class TCPConnUtil 
    {
        private static Logger logger = LogManager.GetLogger("PaymentServiceLibLog");
        private ITcpSocket socket = null;
        IMessageParser _parser;
        SynchronizationContext syncContext;
        bool gotResponse;
        string recvBuf;
        int recvTickCount;
        bool requestInProgess;

        public string HostName { get; set; }
        public int HostPort { get; set; }
        public bool UseSSL { get; set; }
        public bool UseKeepAlive { get; set; }
        public bool IsRequestInProgress { get; }
        public bool IsConnected { get;}
        public bool UseSynchronizationContextForEvents { get; set; }
        private PINTRequest _currentStartTxnRequest;
        public TCPConnUtil() {
           
        }

        public void Initialise()
        {
            recvBuf = "";
            recvTickCount = 0;
            _parser = DependencyInjector.Get<IMessageParser, DefaultMessageParser>();

            socket = DependencyInjector.Get<ITcpSocket, TcpSocket>(HostName, HostPort);
            socket.OnTerminated += new TcpSocketEventHandler(_OnTerminated);
            socket.OnDataWaiting += new TcpSocketEventHandler(_OnDataWaiting);
            socket.OnError += new TcpSocketEventHandler(_OnError);
            socket.OnSend += new TcpSocketEventHandler(_OnSend); 
        }

        public bool CheckConnectState()
        {
            throw new NotImplementedException();
        }



        /// <summary>Disconnect from the PC-EFTPOS client IP interface.</summary>
        public void Disconnect()
        {
            socket.Stop();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool DoHideDialogs()
        {
            throw new NotImplementedException();
        }

        public bool DoLogon()
        {
            throw new NotImplementedException();
        }

        public bool DoLogon(PINPADLogonRequest request)
        {
            throw new NotImplementedException();
        }

        public bool DoRequest(PINTRequest request, [CallerMemberName] string member = "")
        {
            throw new NotImplementedException();
        }

        public bool DoTransaction(PINPADTransactionRequest request)
        {
            throw new NotImplementedException();
        }

      
        public bool Connect()
        {            
            socket.HostName = HostName;
            socket.HostPort = HostPort;
            socket.UseKeepAlive = UseKeepAlive;
            socket.UseSSL = UseSSL;
            return socket.Start();
        }


        #region Parse response

        bool ReceiveEFTResponse(byte[] data)
        {
            // Clear the receive buffer if 5 seconds has lapsed since the last message
            var tc = System.Environment.TickCount;
            if (tc - recvTickCount > 5000)
            {
                logger.Error($"Data is being cleared from the buffer due to a timeout. Content {recvBuf.ToString()}");
                recvBuf = "";
            }
            recvTickCount = System.Environment.TickCount;

            // Append receive data to our buffer
            recvBuf += System.Text.Encoding.ASCII.GetString(data, 0, data.Length);

            // Keep parsing until no more characters
            try
            {
                int index = 0;
                while (index < recvBuf.Length)
                {
                    // Look for start character
                    if (recvBuf[index] == (byte)'#')
                    {
                        // Check that we have enough bytes to validate length, if not wait for more
                        if (recvBuf.Length < index + 5)
                        {
                            recvBuf = recvBuf.Substring(index);
                            break;
                        }

                        // We have enough bytes to check for length
                        index++;

                        // Try to get the length of the new message. If it's not a valid length 
                        // we might have some corrupt data, keep checking for a valid message
                        if (!int.TryParse(recvBuf.Substring(index, 4), out int length) || length <= 5)
                        {
                            continue;
                        }

                        // We have a valid length
                        index += 4;

                        // If our buffer doesn't contain enough data, wait for more 
                        if (recvBuf.Length < index + length - 5)
                        {
                            recvBuf = recvBuf.Substring(index - 5);
                            continue;
                        }

                        // We have a valid response
                        var response = recvBuf.Substring(index, length - 5);
                        FireOnTcpReceive(response);

                        // Process the response
                        PINTResponse eftResponse = null;
                        try
                        {
                            eftResponse = _parser.StringToEFTResponse(response);
                            ProcessEFTResponse(eftResponse);
                            if (eftResponse.GetType() == _currentStartTxnRequest?.GetPairedResponseType())
                            {
                               // dialogUIHandler.HandleCloseDisplay();
                            }
                        }
                        catch (ArgumentException argumentException)
                        {
                            logger.Error("Error parsing response string", argumentException);
                        }


                        index += length - 5;
                    }

                    // Clear our buffer if we are all done
                    if (index == recvBuf.Length)
                    {
                        recvBuf = "";
                    }
                }
            }
            catch (Exception ex)
            {
                // Fail gracefully.
                FireOnSocketFailEvent(ClientIPErrorType.Client_ParseError, ex.Message);
                logger.Error($"Exception (ReceiveEFTResponse): {ex.Message}");
                return false;
            }

            return true;
        }


        void ProcessEFTResponse(PINTResponse response)
        {
            try
            {
                switch (response)
                {
                    case null:
                       logger.Error($"Unable to handle null param {nameof(response)}");
                        break;

                    //case SetDialogResponse r:
                    //    if (currentRequest is SetDialogRequest)
                    //    {
                    //        gotResponse = true;
                    //        hideDialogEvent.Set();
                    //    }
                    //    break;

                    //case PINTReceiptResponse r:
                    //    SendReceiptAcknowledgement();
                    //   logger.Error($"IsPrePrint={((PINTReceiptResponse)response).IsPrePrint}");

                    //    if (r.IsPrePrint == false)
                    //    {
                    //        FireClientResponseEvent(nameof(OnReceipt), OnReceipt, new EFTEventArgs<EFTReceiptResponse>(r));
                    //    }
                    //    break;

                    case PINPADDisplayResponse r:
                        //DialogUIHandler.HandleDisplayResponse(r);
                        FireClientResponseEvent(nameof(OnDisplay), OnDisplay, new EFTEventArgs<PINPADDisplayResponse>(r));
                        break;
 

                    case PINPADLogonResponse r:
                        FireClientResponseEvent(nameof(OnLogon), OnLogon, new EFTEventArgs<PINPADLogonResponse>(r));
                        break;



                    //case ECRTransactionRequest r:
                    //    FireClientResponseEvent(nameof(OnTransaction), OnTransaction, new EFTEventArgs<ECRTransactionRequest>(r));
                    //    break;

                    //case TerminalGetLastTransactionResponse r:
                    //    FireClientResponseEvent(nameof(OnGetLastTransaction), OnGetLastTransaction, new EFTEventArgs<EFTGetLastTransactionResponse>(r));
                    //    break;


                    //case EFTStatusResponse r:
                    //    FireClientResponseEvent(nameof(OnStatus), OnStatus, new EFTEventArgs<EFTStatusResponse>(r));
                    //    break;


                    default:
                        logger.Error($"Unknown response type", response);
                        break;
                }
            }
            catch (Exception Ex)
            {
                logger.Error($"Unhandled error in {nameof(ProcessEFTResponse)}");               
            }
        }


        void SendReceiptAcknowledgement()
        {
            socket.Send("#00073 ");
        }
        #endregion

        #region Events

        /// <summary>Fired when a client socket is terminated.</summary>
        public event EventHandler<SocketEventArgs> OnTerminated;
        /// <summary>Fired when a socket error occurs.</summary>
        public event EventHandler<SocketEventArgs> OnSocketFail;
        /// <summary>Fired when a get config merchant result is received.</summary>
        public event EventHandler<SocketEventArgs> OnTcpSend;
        /// <summary>Fired when a get config merchant result is received.</summary>
        public event EventHandler<SocketEventArgs> OnTcpReceive;

        /// <summary>Fired when a display is received.</summary>
        public event EventHandler<EFTEventArgs<PINPADDisplayResponse>> OnDisplay;

        /// <summary>Fired when a receipt is received.</summary>
        //public event EventHandler<EFTEventArgs<EFTReceiptResponse>> OnReceipt;




        /// <summary>Fired when a logon result is received.</summary>
        private event EventHandler<EFTEventArgs<PINPADLogonResponse>> OnLogon;


        ///// <summary>Fired when a transaction result is received.</summary>
        //public event EventHandler<EFTEventArgs<ECRTransactionRequest>> OnTransaction;

        ///// <summary>Fired when a get last transaction result is received.</summary>
        //public event EventHandler<EFTEventArgs<EFTGetLastTransactionResponse>> OnGetLastTransaction;


        void FireClientResponseEvent<TEFTResponse>(string name, EventHandler<EFTEventArgs<TEFTResponse>> eventHandler, EFTEventArgs<TEFTResponse> args) where TEFTResponse : PINTResponse
        {
            logger.Info($"Handle {name}");
            requestInProgess = false;

            var tmpEventHandler = eventHandler;
            if (tmpEventHandler != null)
            {
                if (UseSynchronizationContextForEvents && syncContext != null && syncContext != SynchronizationContext.Current)
                {
                    syncContext.Post(o => tmpEventHandler.Invoke(this, args), null);
                }
                else
                {
                    tmpEventHandler.Invoke(this, args);
                }
            }
            else
            {
                throw (new Exception($"There is no event handler defined for {name}"));
            }
        }






        void _OnError(object sender, TcpSocketEventArgs e)
        {
            ClientIPErrorType errorType =ClientIPErrorType.Socket_GeneralError;

            ////Log(LogLevel.Error, tr => tr.Set($"OnError: {e.Error}"));
            switch (e.ExceptionType)
            {
                case TcpSocketExceptionType.ConnectException:
                    errorType = ClientIPErrorType.Socket_ConnectError;
                    break;
                case TcpSocketExceptionType.GeneralException:
                    errorType = ClientIPErrorType.Socket_GeneralError;
                    break;
                case TcpSocketExceptionType.ReceiveException:
                    errorType = ClientIPErrorType.Socket_ReceiveError;
                    break;
                case TcpSocketExceptionType.SendException:
                    errorType = ClientIPErrorType.Socket_SendError;
                    break;
            }

            FireOnSocketFailEvent(errorType, e.Error);
        }
        void _OnDataWaiting(object sender, TcpSocketEventArgs e)
        {
            ////Log(LogLevel.Debug, tr => tr.Set($"Rx>>{System.Text.ASCIIEncoding.ASCII.GetString(e.Bytes)}<<"));
            ReceiveEFTResponse(e.Bytes);
        }
        void _OnTerminated(object sender, TcpSocketEventArgs e)
        {
            FireOnTerminatedEvent(e.Error);
        }
        void _OnSend(object sender, TcpSocketEventArgs e)
        {
            FireOnTcpSend(e.Message);
        }
         
        void FireOnSocketFailEvent(ClientIPErrorType errorType, string message)
        {
            logger.Error($"OnSocketFail: {message}");
            OnSocketFail?.Invoke(this, new SocketEventArgs() { ErrorMessage = message, ErrorType = ClientIPErrorType.Socket_GeneralError });
        }
        void FireOnTcpSend(string message)
        {
            OnTcpSend?.Invoke(this, new SocketEventArgs() { TcpMessage = message });
        }
        void FireOnTcpReceive(string message)
        {
            OnTcpReceive?.Invoke(this, new SocketEventArgs() { TcpMessage = message });
        }
        void FireOnTerminatedEvent(string message)
        {
            logger.Error($"OnTerminated: {message}");
            OnTerminated?.Invoke(this, new SocketEventArgs() { ErrorMessage = message, ErrorType = ClientIPErrorType.Socket_GeneralError });
        }
       
        #endregion
    }

    
}
