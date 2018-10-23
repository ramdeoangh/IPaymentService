using PaymentServiceLib.Enum;
using PaymentServiceLib.PinPadPOS.Utility;
using System;

namespace PaymentServiceLib.Model.Request
{
    public class PINPADTransactionRequest:PINTRequest
    {
        /// <summary>Constructs a default EFTTransactionRequest object.</summary>
		public PINPADTransactionRequest() : base(true, typeof(PINPADTransactionResponse))
        {
        }

        /// <summary>The type of transaction to perform.</summary>
        /// <value>Type: <see cref="TransactionType"/><para>The default is <see cref="TransactionType.PurchaseCash"></see></para></value>
        public TransactionType TxnType { get; set; } = TransactionType.PurchaseCash;

        /// <summary>Two digit merchant code</summary>
        /// <value>Type: <see cref="string"/><para>The default is "00"</para></value>
        public string Merchant { get; set; } = "00";

        /// <summary>The currency code for this transaction.</summary>
        /// <value>Type: <see cref="System.String"/><para>A 3 digit ISO currency code. The default is "   ".</para></value>
        public string CurrencyCode { get; set; } = "  ";

        /// <summary>The original type of transaction for voucher entry.</summary>
        /// <value>Type: <see cref="TransactionType"/><para>The default is <see cref="TransactionType.PurchaseCash"></see></para></value>
        public TransactionType OriginalTxnType { get; set; } = TransactionType.PurchaseCash;

        /// <summary>Date. Used for voucher or completion only</summary>
        /// <value>Type: <see cref="DateTime"/><para>The default is null</para></value>
        public DateTime? Date { get; set; } = null;

        /// <summary>Time. Used for voucher or completion only</summary>
        /// <value>Type: <see cref="DateTime"/><para>The default is null</para></value>
        public DateTime? Time { get; set; } = null;

        /// <summary>Determines if the transaction is a training mode transaction.</summary>
        /// <value>Type: <see cref="System.Boolean"/><para>Set to TRUE if the transaction is to be performed in training mode. The default is FALSE.</para></value>
        public bool TrainingMode { get; set; } = false;

        /// <summary>Indicates if the transaction should be tipable.</summary>
        /// <value>Type: <see cref="System.Boolean"/><para>Set to TRUE if tipping is to be enabled for this transaction. The default is FALSE.</para></value>
        public bool EnableTip { get; set; } = false;

        /// <summary>Indicates if the transaction should be tipable.</summary>
        /// <value>Type: <see cref="System.Boolean"/><para>Set to TRUE if tipping is to be enabled for this transaction. The default is FALSE.</para></value>
        [System.Obsolete("Please use EnableTip instead of EnableTipping")]
        public bool EnableTipping { get { return EnableTip; } set { EnableTip = value; } }

        /// <summary>The cash amount for the transaction.</summary>
        /// <value>Type: <see cref="System.Decimal"/><para>The default is 0.</para></value>
        /// <remarks>This property is mandatory for a <see cref="TransactionType.CashOut"></see> transaction type.</remarks>
        public decimal AmtCash { get; set; } = 0;

        /// <summary>The cash amount for the transaction.</summary>
        /// <value>Type: <see cref="System.Decimal"/><para>The default is 0.</para></value>
        /// <remarks>This property is mandatory for a <see cref="TransactionType.CashOut"></see> transaction type.</remarks>
        [System.Obsolete("Please use AmtCash instead of AmountCash")]
        public decimal AmountCash { get { return AmtCash; } set { AmtCash = value; } }

        /// <summary>The purchase amount for the transaction.</summary>
        /// <value>Type: <see cref="System.Decimal"/><para>The default is 0.</para></value>
        /// <remarks>This property is mandatory for all but <see cref="TransactionType.CashOut"></see> transaction types.</remarks>
        public decimal AmtPurchase { get; set; } = 0;

        /// <summary>The purchase amount for the transaction.</summary>
        /// <value>Type: <see cref="System.Decimal"/><para>The default is 0.</para></value>
        /// <remarks>This property is mandatory for all but <see cref="TransactionType.CashOut"></see> transaction types.</remarks>
        [System.Obsolete("Please use AmtPurchase instead of AmountPurchase")]
        public decimal AmountPurchase { get { return AmtPurchase; } set { AmtPurchase = value; } }

        /// <summary>The authorisation number for the transaction.</summary>
        /// <value>Type: <see cref="System.Int32"/></value>
        /// <remarks>This property is required for a <see cref="TransactionType.Completion"></see> transaction type.</remarks>
        public int AuthCode { get; set; } = 0;

        /// <summary>The authorisation number for the transaction.</summary>
        /// <value>Type: <see cref="System.Int32"/></value>
        /// <remarks>This property is required for a <see cref="TransactionType.Completion"></see> transaction type.</remarks>
        [System.Obsolete("Please use AuthCode instead of AuthNumber")]
        public int AuthNumber { get { return AuthCode; } set { AuthCode = value; } }


        /// <summary>The reference number to attach to the transaction. This will appear on the receipt.</summary>
        /// <value>Type: <see cref="System.String"/></value>
        /// <remarks>This property is optional but it usually populated by a unique transaction identifier that can be used for retrieval.</remarks>
        public string TxnRef { get; set; } = "";

        /// <summary>The reference number to attach to the transaction. This will appear on the receipt.</summary>
        /// <value>Type: <see cref="System.String"/></value>
        /// <remarks>This property is optional but it usually populated by a unique transaction identifier that can be used for retrieval.</remarks>
        [System.Obsolete("Please use TxnRef instead of ReferenceNumber")]
        public string ReferenceNumber { get { return TxnRef; } set { TxnRef = value; } }



        /// <summary>Indicates the source of the card number.</summary>
        /// <value>Type: <see cref="PanSource"/><para>The default is <see cref="PanSource.Default"></see>.</para></value>
        /// <remarks>Use this property for card not present transactions.</remarks>
        public PanSource PanSource { get; set; } = PanSource.Default;


        /// <summary>Indicates the source of the card number.</summary>
        /// <value>Type: <see cref="PanSource"/><para>The default is <see cref="PanSource.Default"></see>.</para></value>
        /// <remarks>Use this property for card not present transactions.</remarks>
        [System.Obsolete("Please use PanSource instead of CardPANSource")]
        public PanSource CardPANSource { get { return PanSource; } set { PanSource = value; } }

        /// <summary>The card number to use when pan source of POS keyed is used.</summary>
        /// <value>Type: <see cref="System.String"/></value>
        /// <remarks>Use this property in conjunction with <see cref="PanSource"></see>.</remarks>
        public string Pan { get; set; } = "";

        /// <summary>The card number to use when pan source of POS keyed is used.</summary>
        /// <value>Type: <see cref="System.String"/></value>
        /// <remarks>Use this property in conjunction with <see cref="PanSource"></see>.</remarks>
        [System.Obsolete("Please use Pan instead of CardPAN")]
        public string CardPAN { get { return Pan; } set { Pan = value; } }

        /// <summary>The expiry date of the card when of POS keyed is used.</summary>
        /// <value>Type: <see cref="System.String"/><para>In MMYY format.</para></value>
        /// <remarks>Use this property in conjunction with <see cref="PanSource"></see> when passing the card expiry date to PINPAD.</remarks>
        public string DateExpiry { get; set; } = "";

        /// <summary>The expiry date of the card when of POS keyed is used.</summary>
        /// <value>Type: <see cref="System.String"/><para>In MMYY format.</para></value>
        /// <remarks>Use this property in conjunction with <see cref="PanSource"></see> when passing the card expiry date to PINPAD.</remarks>
        [System.Obsolete("Please use DateExpiry instead of ExpiryDate")]
        public string ExpiryDate { get { return DateExpiry; } set { DateExpiry = value; } }

        /// <summary>The track 2 to use when of POS swiped is used.</summary>
        /// <value>Type: <see cref="System.String"/></value>
        /// <remarks>Use this property when <see cref="PanSource"></see> is set to <see cref="PanSource.POSSwiped"></see> and passing the full Track2 from the card magnetic stripe to PINPAD.</remarks>
        public string Track2 { get; set; } = "";

        /// <summary>The account to use for this transaction.</summary>
        /// <value>Type: <see cref="AccountType"/><para>Default is <see cref="AccountType.Default"></see>. Use default to prompt user to enter the account type.</para></value>
        /// <remarks>Use this property in conjunction with <see cref="PanSource"></see> when passing the account type to PINPAD.</remarks>
        public AccountType AccountType { get; set; } = AccountType.Default;

        /// <summary>The account to use for this transaction.</summary>
        /// <value>Type: <see cref="AccountType"/><para>Default is <see cref="AccountType.Default"></see>. Use default to prompt user to enter the account type.</para></value>
        /// <remarks>Use this property in conjunction with <see cref="PanSource"></see> when passing the account type to PINPAD.</remarks>
        [System.Obsolete("Please use AccountType instead of CardAccountType")]
        public AccountType CardAccountType { get { return AccountType; } set { AccountType = value; } }

        /// <summary>The retrieval reference number for the transaction.</summary>
        /// <value>Type: <see cref="System.String"/></value>
        /// <remarks>This property is required for a <see cref="TransactionType.TipAdjust"></see> transaction type.</remarks>
        public string RRN { get; set; } = "";

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

        /// <summary>Indicates whether PINPAD should cut receipts.</summary>
        /// <value>Type: <see cref="ReceiptCutModeType"/><para>The default is DontCut. This property only applies when <see cref="TerminalBaseRequest.ReceiptPrintMode"/> is set to EFTClientPrinter.</para></value>
        public ReceiptCutModeType CutReceipt { get; set; } = ReceiptCutModeType.DontCut;

        /// <summary>Indicates whether PINPAD should cut receipts.</summary>
        /// <value>Type: <see cref="ReceiptCutModeType"/><para>The default is DontCut. This property only applies when <see cref="TerminalBaseRequest.ReceiptPrintMode"/> is set to EFTClientPrinter.</para></value>
        [System.Obsolete("Please use CutReceipt instead of ReceiptCutMode")]
        public ReceiptCutModeType ReceiptCutMode { get { return CutReceipt; } set { CutReceipt = value; } }

        /// <summary>
        /// 
        /// </summary>
        public int CVV { get; set; } = 0;
    }

  
}
