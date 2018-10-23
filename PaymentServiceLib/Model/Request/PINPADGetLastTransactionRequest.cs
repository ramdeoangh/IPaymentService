using PaymentServiceLib.Enum;
using PaymentServiceLib.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Model.Request
{
  public  class TerminalGetLastTransactionRequest:TerminalBaseRequest
    {
        /// <summary>Constructs a default EFTGetLastTransactionRequest object.</summary>
        public TerminalGetLastTransactionRequest() : base(true, typeof(TerminalGetLastTransactionResponse))
        {
        }

        /// <summary>Constructs an EFTGetLastTransactionRequest with a TxnRef parameter to look up transaction by.</summary>
        public TerminalGetLastTransactionRequest(string TxnRef) : base(true, typeof(TerminalGetLastTransactionResponse))
        {
            this.TxnRef = TxnRef ?? "";
        }

        /// <summary>The transaction reference to look up a past transaction by (optional when passed into constructor)</summary>
        public string TxnRef { get; private set; } = "";

        /// <summary>Two digit merchant code</summary>
        /// <value>Type: <see cref="string"/><para>The default is "00"</para></value>
        public string Merchant { get; set; } = "00";

        /// <summary>Indicates where the request is to be sent to. Should normally bePaymentTerminal.</summary>
        /// <value>Type: <see cref="TerminalApplication"/><para>The default is <see cref="TerminalApplication.EFTPOS"/>.</para></value>
        public TerminalApplication Application { get; set; } = TerminalApplication.EFTPOS;
    }
}
