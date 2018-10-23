using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.PinPadPOS.Net
{
  
    /// <summary>EFT Client IP error types.</summary>
    public enum ClientIPErrorType

    {
        /// <summary>A socket connect error occurred.</summary>
        Socket_ConnectError,
        /// <summary>A socket receive error occurred.</summary>
        Socket_ReceiveError,
        /// <summary>A socket send error occurred.</summary>
        Socket_SendError,
        /// <summary>A general socket error occurred.</summary>
        Socket_GeneralError,
        /// <summary>An error occured while parsing a received message..</summary>
        Client_ParseError
    }
}
