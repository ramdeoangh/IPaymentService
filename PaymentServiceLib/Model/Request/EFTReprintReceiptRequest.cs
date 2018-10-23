using PaymentServiceLib.Enum;
using PaymentServiceLib.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Model.Request
{
    /// <summary>A PaymentTerminal duplicate receipt request object.</summary>
    public class EFTReprintReceiptRequest : TerminalBaseRequest
    {
        /// <summary>Constructs a default EFTDuplicateReceiptRequest object.</summary>
        public EFTReprintReceiptRequest() : base(true, typeof(EFTReprintReceiptResponse))
        {
        }

        /// <summary>Two digit merchant code</summary>
        /// <value>Type: <see cref="string"/><para>The default is "00"</para></value>
        public string Merchant { get; set; } = "00";

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

        /// <summary>Indicates whether the receipt should be returned or reprinted.</summary>
        /// <value>Type: <see cref="ReprintType"/><para>The default is GetLast.</para></value>
        public ReprintType ReprintType { get; set; } = ReprintType.GetLast;

        public string OriginalTxnRef { get; set; } = "";
    }

}
