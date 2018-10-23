using PaymentServiceLib.Enum;
using PaymentServiceLib.Model.Request;
using PaymentServiceLib.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Model.Request
{
  public  class EFTStatusResponse:TerminalBaseResponse
    {
        /// <summary>Constructs a default terminal status response object.</summary>
		public EFTStatusResponse()
            : base(typeof(EFTStatusRequest))
        {
        }

        /// <summary>Two digit merchant code</summary>
        /// <value>Type: <see cref="string"/><para>The default is "00"</para></value>
        public string Merchant { get; set; } = "00";

        /// <summary>The AIIC that is configured in the terminal.</summary>
        /// <value>Type: <see cref="System.String" /></value>
        public string AIIC { get; set; }

        /// <summary>The NII that is configured in the terminal.</summary>
        /// <value>Type: <see cref="System.Int32" /></value>
        public int NII { get; set; }

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

        /// <summary>The bank response timeout that is configured in the terminal.</summary>
        /// <value>Type: <see cref="System.Int32" /></value>
        public int Timeout { get; set; } = 0;

        /// <summary>Indicates if the PIN pad is currently logged on.</summary>
        /// <value>Type: <see cref="System.Boolean" /></value>
        public bool LoggedOn { get; set; } = false;

        /// <summary>The serial number of the terminal.</summary>
        /// <value>Type: <see cref="System.String" /></value>
        public string PinPadSerialNumber { get; set; } = "";

        /// <summary>The serial number of the terminal.</summary>
        /// <value>Type: <see cref="System.String" /></value>
        [System.Obsolete("Please use PinPadSerialNumber instead of PINPadSerialNumber")]
        public string PINPadSerialNumber { get { return PinPadSerialNumber; } set { PinPadSerialNumber = value; } }

        /// <summary>PIN pad software version.</summary>
        /// <value>Type: <see cref="System.String" /></value>
        public string PinPadVersion { get; set; } = "";

        /// <summary>PIN pad software version.</summary>
        /// <value>Type: <see cref="System.String" /></value>
        [System.Obsolete("Please use PinPadVersion instead of PINPadVersion")]
        public string PINPadVersion { get { return PinPadVersion; } set { PinPadVersion = value; } }

        /// <summary>The bank acquirer code.</summary>
        /// <value>Type: <see cref="System.Char" /></value>
        public char BankCode { get; set; } = ' ';

        /// <summary>The bank description.</summary>
        /// <value>Type: <see cref="System.String" /></value>
        public string BankDescription { get; set; } = "";

        /// <summary>Key verification code.</summary>
        /// <value>Type: <see cref="System.String" /></value>
        public string KVC { get; set; } = "";

        /// <summary>Current number of stored transactions.</summary>
        /// <value>Type: <see cref="System.Int32" /></value>
        public int SAFCount { get; set; } = 0;

        /// <summary>The acquirer communications type.</summary>
        /// <value>Type: <see cref="NetworkType" /></value>
        public NetworkType NetworkType { get; set; } = NetworkType.Unknown;

        /// <summary>The hardware serial number.</summary>
        /// <value>Type: <see cref="System.String" /></value>
        public string HardwareSerial { get; set; } = "";

        /// <summary>The merchant retailer name.</summary>
        /// <value>Type: <see cref="System.String" /></value>
        public string RetailerName { get; set; } = "";

        /// <summary>PIN pad terminal supported options flags.</summary>
        /// <value>Type: <see cref="PINPadOptionFlags" /></value>
        public PINPadOptionFlags OptionsFlags { get; set; } = 0;

        /// <summary>Store-and forward credit limit.</summary>
        /// <value>Type: <see cref="System.Decimal" /></value>
        public decimal SAFCreditLimit { get; set; } = 0;

        /// <summary>Store-and-forward debit limit.</summary>
        /// <value>Type: <see cref="System.Decimal" /></value>
        public decimal SAFDebitLimit { get; set; } = 0;

        /// <summary>The maximum number of store transactions.</summary>
        /// <value>Type: <see cref="System.Int32" /></value>
        public int MaxSAF { get; set; } = 0;

        /// <summary>The terminal key handling scheme.</summary>
        /// <value>Type: <see cref="KeyHandlingType" /></value>
        public KeyHandlingType KeyHandlingScheme { get; set; } = KeyHandlingType.Unknown;

        /// <summary>The maximum cash out limit.</summary>
        /// <value>Type: <see cref="System.Decimal" /></value>
        public decimal CashoutLimit { get; set; } = 0;

        /// <summary>The maximum refund limit.</summary>
        /// <value>Type: <see cref="System.Decimal" /></value>
        public decimal RefundLimit { get; set; } = 0;

        /// <summary>Card prefix table version.</summary>
        /// <value>Type: <see cref="System.String" /></value>
        public string CPATVersion { get; set; } = "";

        /// <summary>Card name table version.</summary>
        /// <value>Type: <see cref="System.String" /></value>
        public string NameTableVersion { get; set; } = "";

        /// <summary>The terminal to PC communication type.</summary>
        /// <value>Type: <see cref="TerminalCommsType" /></value>
        public TerminalCommsType TerminalCommsType { get; set; } = TerminalCommsType.Unknown;

        /// <summary>Number of card mis-reads.</summary>
        /// <value>Type: <see cref="System.Int32" /></value>
        public int CardMisreadCount { get; set; } = 0;

        /// <summary>Number of memory pages in the PIN pad terminal.</summary>
        /// <value>Type: <see cref="System.Int32" /></value>
        public int TotalMemoryInTerminal { get; set; } = 0;

        /// <summary>Number of free memory pages in the PIN pad terminal.</summary>
        /// <value>Type: <see cref="System.Int32" /></value>
        public int FreeMemoryInTerminal { get; set; } = 0;

        /// <summary>The type of PIN pad terminal.</summary>
        /// <value>Type: <see cref="EFTTerminalType" /></value>
        public EFTTerminalType EFTTerminalType { get; set; } = EFTTerminalType.Unknown;

        /// <summary>Number of applications in the terminal.</summary>
        /// <value>Type: <see cref="System.Int32" /></value>
        public int NumAppsInTerminal { get; set; } = 0;

        /// <summary>Number of available display line on the terminal.</summary>
        /// <value>Type: <see cref="System.Int32" /></value>
        public int NumLinesOnDisplay { get; set; } = 0;

        /// <summary>The date the hardware was incepted.</summary>
        /// <value>Type: <see cref="System.DateTime" /></value>
        public DateTime HardwareInceptionDate { get; set; } = DateTime.MinValue;

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
