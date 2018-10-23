using PaymentServiceLib.Enum;
using PaymentServiceLib.Model.Response;
using PaymentServiceLib.PinPadPOS.Utility;

namespace PaymentServiceLib.Model.Request
{
    /// <summary>A PaymentTerminal terminal logon request object.</summary>
    public class EFTLogonRequest : TerminalBaseRequest
    {
        /// <summary>Constructs a default terminal logon request object.</summary>
        public EFTLogonRequest() : this(LogonType.Standard)
        {
        }

        /// <summary>Constructs a terminal logon request object.</summary>
        /// <param name="LogonType">The logon type to perform.</param>
        public EFTLogonRequest(LogonType LogonType) : base(true, typeof(EFTLogonResponse))
        {
            this.LogonType = LogonType;
        }

        /// <summary>Two digit merchant code</summary>
        /// <value>Type: <see cref="string"/><para>The default is "00"</para></value>
        public string Merchant { get; set; } = "00";

        /// <summary>type of logon to perform.</summary>
        /// <value>Type: <see cref="LogonType" /><para>The default is <see cref="LogonType.Standard" />.</para></value>
        public LogonType LogonType { get; set; } = LogonType.Standard;

        /// <summary>Additional information sent with the request.</summary>
        /// <value>Type: <see cref="PadField"/></value>
        public PadField PurchaseAnalysisData { get; set; } = new PadField();

        /// <summary>Indicates where the request is to be sent to. Should normally bePaymentTerminal.</summary>
        /// <value>Type: <see cref="TerminalApplication"/><para>The default is <see cref="TerminalApplication.EFTPOS"/>.</para></value>
        public TerminalApplication Application { get; set; } = TerminalApplication.EFTPOS;

        /// <summary>Indicates whether to trigger receipt events.</summary>
        /// <value>Type: <see cref="ReceiptPrintModeType"/><para>The default is POSPrinter.</para></value>
        public ReceiptPrintModeType ReceiptAutoPrint { get; set; } = ReceiptPrintModeType.POSPrinter;

        /// <summary>Indicates whether to trigger receipt events.</summary>
        /// <value>Type: <see cref="ReceiptPrintModeType"/><para>The default is POSPrinter.</para></value>
        [System.Obsolete("Please use ReceiptAutoPrint instead of ReceiptPrintMode")]
        public ReceiptPrintModeType ReceiptPrintMode { get { return ReceiptAutoPrint; } set { ReceiptAutoPrint = value; } }

        /// <summary>Indicates whether PaymentTerminal should cut receipts.</summary>
        /// <value>Type: <see cref="ReceiptCutModeType"/><para>The default is DontCut. This property only applies when <see cref="TerminalBaseRequest.ReceiptPrintMode"/> is set to EFTClientPrinter.</para></value>
        public ReceiptCutModeType CutReceipt { get; set; } = ReceiptCutModeType.DontCut;

        /// <summary>Indicates whether PaymentTerminal should cut receipts.</summary>
        /// <value>Type: <see cref="ReceiptCutModeType"/><para>The default is DontCut. This property only applies when <see cref="TerminalBaseRequest.ReceiptPrintMode"/> is set to EFTClientPrinter.</para></value>
        [System.Obsolete("Please use CutReceipt instead of ReceiptCutMode")]
        public ReceiptCutModeType ReceiptCutMode { get { return CutReceipt; } set { CutReceipt = value; } }
    }
}
