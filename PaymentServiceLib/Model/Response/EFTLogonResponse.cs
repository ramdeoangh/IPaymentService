using PaymentServiceLib.Model.Request;
using PaymentServiceLib.PinPadPOS.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Model.Response
{

    /// <summary>A PaymentTerminal terminal logon response object.</summary>
    public class EFTLogonResponse : TerminalBaseResponse
    {
        /// <summary>Constructs a default terminal logon response object.</summary>
        public EFTLogonResponse() : base(typeof(EFTLogonRequest))
        {
        }

        /// <summary>PIN pad software version.</summary>
        /// <value>Type: <see cref="System.String" /></value>
        public string PinPadVersion { get; set; } = "";

        /// <summary>PIN pad software version.</summary>
        /// <value>Type: <see cref="System.String" /></value>
        [System.Obsolete("Please use PinPadVersion instead of PinpadVersion")]
        public string PinpadVersion { get { return PinPadVersion; } set { PinPadVersion = value; } }

        /// <summary>Indicates if the request was successful.</summary>
        /// <value>Type: <see cref="System.Boolean"/></value>
        public bool Success { get; set; } = false;

        /// <summary>The response code of the request.</summary>
        /// <value>Type: <see cref="System.String"/><para>A 2 character response code. "00" indicates a successful response.</para></value>
        public string ResponseCode { get; set; } = "";

        /// <summary>The response text for the response code.</summary>
        /// <value>Type: <see cref="System.String"/></value>
        public string ResponseText { get; set; } = "";

        /// <summary>Date and time of the response returned by the bank.</summary>
        /// <value>Type: <see cref="System.DateTime"/></value>
        public DateTime Date { get; set; } = DateTime.MinValue;

        /// <summary>Date and time of the response returned by the bank.</summary>
        /// <value>Type: <see cref="System.DateTime"/></value>
        [System.Obsolete("Please use Date instead of BankDateTime")]
        public DateTime BankDateTime { get { return Date; } set { Date = value; } }

        /// <summary>Terminal ID configured in the PIN pad.</summary>
        /// <value>Type: <see cref="System.String" /></value>
        public string Catid { get; set; } = "";

        /// <summary>Terminal ID configured in the PIN pad.</summary>
        /// <value>Type: <see cref="System.String" /></value>
        [System.Obsolete("Please use Catid instead of TerminalID")]
        public string TerminalID { get { return Catid; } set { Catid = value; } }

        /// <summary>Merchant ID configured in the PIN pad.</summary>
        /// <value>Type: <see cref="System.String" /></value>
        public string Caid { get; set; } = "";

        /// <summary>Merchant ID configured in the PIN pad.</summary>
        /// <value>Type: <see cref="System.String" /></value>
        [System.Obsolete("Please use Caid instead of MerchantID")]
        public string MerchantID { get { return Caid; } set { Caid = value; } }

        /// <summary>System Trace Audit Number</summary>
        /// <value>Type: <see cref="System.Int32"/></value>
        public int Stan { get; set; } = 0;

        /// <summary>System Trace Audit Number</summary>
        /// <value>Type: <see cref="System.Int32"/></value>
        [System.Obsolete("Please use Stan instead of STAN")]
        public int STAN { get { return Stan; } set { Stan = value; } }

        /// <summary>Additional information sent with the response.</summary>
        /// <value>Type: <see cref="PadField"/></value>
        public PadField PurchaseAnalysisData { get; set; } = new PadField();
    }
}
