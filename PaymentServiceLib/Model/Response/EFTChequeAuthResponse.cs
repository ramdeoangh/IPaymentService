using PaymentServiceLib.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Model.Response
{
    /// <summary>A PaymentTerminal cheque authorization response object.</summary>
    public class EFTChequeAuthResponse : TerminalBaseResponse
    {
        decimal amount;
        int authNumber;
        string txnRefNum;

        /// <summary>Constructs a default cheque authorization response object.</summary>
        public EFTChequeAuthResponse()
            : base(typeof(EFTChequeAuthRequest))
        {
            amount = 0;
            authNumber = 0;
            txnRefNum = "";
        }

        /// <summary>Two digit merchant code</summary>
        /// <value>Type: <see cref="string"/><para>The default is "00"</para></value>
        public string Merchant { get; set; } = "00";

        /// <summary>The authorization amount for the cheque.</summary>
        /// <value>Type: <see cref="System.Decimal"/><para>Echoed from the request.</para></value>
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        /// <summary>The authorization number for this authorization.</summary>
        /// <value>Type: <see cref="System.Int32"/><para>The authorization number returned from the cheque authorization host.</para></value>
        public int AuthNumber
        {
            get { return authNumber; }
            set { authNumber = value; }
        }

        /// <summary>The reference number attached to the authorization.</summary>
        /// <value>Type: <see cref="System.String"/><para>Echoed from the request.</para></value>
        public string ReferenceNumber
        {
            get { return txnRefNum; }
            set { txnRefNum = value; }
        }

        /// <summary>Indicates if the request was successful.</summary>
        /// <value>Type: <see cref="System.Boolean"/></value>
        public bool Success { get; set; } = false;

        /// <summary>The response code of the request.</summary>
        /// <value>Type: <see cref="System.String"/><para>A 2 character response code. "00" indicates a successful response.</para></value>
        public string ResponseCode { get; set; } = "";

        /// <summary>The response text for the response code.</summary>
        /// <value>Type: <see cref="System.String"/></value>
        public string ResponseText { get; set; } = "";
    }
}
