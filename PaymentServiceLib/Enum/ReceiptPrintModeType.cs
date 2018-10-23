using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Enum
{
    /// <summary>Indicates the type of receipt that has been received.</summary>
    public enum ReceiptType
    {
        /// <summary>A logon receipt was received.</summary>
        Logon = 'L',
        /// <summary>A customer transaction receipt was received.</summary>
        Customer = 'C',
        /// <summary>A merchant transaction receipt was received.</summary>
        Merchant = 'M',
        /// <summary>A settlement receipt was received. This receipt usually contains the signature receipt line and should be printed immediately.</summary>
        Settlement = 'S',
        /// <summary>Receipt text was received. Used internally by component. You should never receive this receipt type.</summary>
        ReceiptText = 'R'
    }


    /// <summary> 
    /// Receipt mode (pos, windows or pinpad printer).
    /// Sometimes called the "ReceiptAutoPrint" flag
    /// </summary>
    public enum ReceiptPrintModeType
    {
        /// <summary> Receipts will be passed back to the POS in the PrintReceipt event </summary>
        POSPrinter = '0',
        /// <summary> The EFT-Client will attempt to print using the printer configured in the EFT-Client (Windows only) </summary>
        EFTClientPrinter = '1',
        /// <summary> Receipts will be printed using the pinpad printer </summary>
        PinpadPrinter = '9',
        /// <summary> Merchant receipts print on internal printer, all other print on POS </summary>
        MerchantPOSPrinter = '7',
        /// <summary> Merchant receipts print on internal printer, all other print using the printer configured in the EFT-Client (Windows only) </summary>
        MerchantEFTClientPrinter = '8'
    }

    /// <summary> 
	/// Receipt cut mode (cut or don't cut). Used when the EFT-Client is handling receipts (ReceiptPrintMode = ReceiptPrintModeType.EFTClientPrinter)
	/// Sometimes called the "CutReceipt" flag
	/// </summary>
	public enum ReceiptCutModeType
    {
        /// <summary> Don't cut receipts </summary>
        DontCut = '0',
        /// <summary> Cut receipts </summary>
        Cut = '1'
    }
}
