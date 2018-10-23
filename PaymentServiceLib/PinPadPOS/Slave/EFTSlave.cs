using PaymentServiceLib.Model;
using PaymentServiceLib.Model.Request;
using PaymentServiceLib.Model.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentServiceLib.PinPadPOS.Slave
{
    public class EFTSlaveRequest : TerminalBaseRequest
    {
        public EFTSlaveRequest() : base(false, typeof(EFTSlaveResponse))
        {

        }

        /// <summary>
        /// If != null, <see cref="Command"/> will be serialised into a slave command string and sent, otherwise the contents of <see cref="RawCommand"/> will be sent
        /// </summary>
        public string RawCommand { get; set; }

        /// <summary>
        /// If != null, <see cref="Command"/> will be serialised into a slave command string and sent, otherwise the contents of <see cref="RawCommand"/> will be sent
        /// </summary>
        public SlaveCommandResponse Command { get; set; } = null;
    }

    public class EFTSlaveResponse : TerminalBaseResponse
    {
        public EFTSlaveResponse() : base(typeof(EFTSlaveRequest))
        {

        }

        public bool Success { get { return ResponseCode == "00"; } }
        public string ResponseCode { get; set; }
        public string Response { get; set; }
    }
}
