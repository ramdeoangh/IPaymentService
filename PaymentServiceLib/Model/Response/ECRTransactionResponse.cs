using PaymentServiceLib.Enum;
using PaymentServiceLib.Model.Response;
using System;

namespace PaymentServiceLib.Model.Request
{

    public class ECRTransactionResponse : TerminalBaseResponse
    {
        /// <summary>Constructs a default terminal transaction response object.</summary>
        public ECRTransactionResponse() : base(typeof(TerminalGetLastTransactionRequest))
        {
        }

        /// <summary>Transaction Status.</summary>
        /// <value>Type: <see cref="TransactionType"/><para>The default is <see cref="TransactionStatus.Approved"></see></para></value>
        public TransactionStatus TxnStatus { get; set; } = TransactionStatus.Approved;

        /// <summary>Multi-Tran Flag Status.</summary>
        public string MultiTrans { get; set; }

        /// <summary>The type of transaction to perform.</summary>
        /// <value>Type: <see cref="TransactionType"/><para>The default is <see cref="TransactionType.PurchaseCash"></see></para></value>
        public TransactionType TxnType { get; set; } = TransactionType.PurchaseCash;

        /// <summary>Date and time of the response returned by the bank.</summary>
        /// <value>Type: <see cref="System.DateTime"/></value>
        public DateTime Date { get; set; } = DateTime.MinValue;


        /// <summary>Date and time of the response returned by the bank.</summary>
        /// <value>Type: <see cref="System.DateTime"/></value>
        public string Time { get; set; }


        /// <summary>The  Amount for the transaction.</summary>
        /// <value>Type: <see cref="System.Decimal"/><para>The default is 0.</para></value>
        public decimal TransAmt{ get; set; } = 0;



        /// <summary>The tip amount for the transaction.</summary>
        /// <value>Type: <see cref="System.Decimal" /><para>Echoed from the request.</para></value>
        public decimal AmtTip { get; set; } = 0;


        /// <summary>The cash back amount for the transaction.</summary>
        /// <value>Type: <see cref="System.Decimal"/><para>The default is 0.</para></value>
        public decimal AmtCash { get; set; } = 0;

        /// <summary>The SurchargeAmount amount for the transaction.</summary>
        /// <value>Type: <see cref="System.Decimal"/><para>The default is 0.</para></value>
        public decimal SurchargeAmount { get; set; } = 0;

        /// <summary>The Tax amount for the transaction.</summary>
        /// <value>Type: <see cref="System.Decimal"/><para>The default is 0.</para></value>
        public decimal TaxAmount { get; set; } = 0;


        /// <summary>The SurchargeAmount amount for the transaction.</summary>
        /// <value>Type: <see cref="System.Decimal"/><para>The default is 0.</para></value>
        public decimal TotalAmount { get; set; } = 0;

        /// <summary>AlphaNumeric Invoice Number</summary>
        /// <value>Type: <see cref="string"/><para></para></value>
        public string Invoice { get; set; }

        /// <summary>Auth Code merchant code/ Clerk ID</summary>
        /// <value>Type: <see cref="string"/><para></para></value>
        public string Merchant { get; set; }
         

        /// <summary>Indicates the card type that was used in the transaction.</summary>
        /// <value>Type: <see cref="System.Int32" /></value>
        /// <remarks><list type="table">
        /// <listheader><term>Card BIN</term><description>Card Type</description></listheader>
        ///	<item><term>0</term><description>Unknown</description></item>
        ///	<item><term>1</term><description>Debit</description></item>
        ///	<item><term>2</term><description>Bankcard</description></item>
        ///	<item><term>3</term><description>Mastercard</description></item>
        ///	<item><term>4</term><description>Visa</description></item>
        ///	<item><term>5</term><description>American Express</description></item>
        ///	<item><term>6</term><description>Diner Club</description></item>
        ///	<item><term>7</term><description>JCB</description></item>
        ///	<item><term>8</term><description>Label Card</description></item>
        ///	<item><term>9</term><description>JCB</description></item>
        ///	<item><term>11</term><description>JCB</description></item>
        ///	<item><term>12</term><description>Other</description></item></list>
        ///	</remarks>
        ///	
        /// <summary>Indicates the card type that was used in the transaction.</summary>
        /// <value>Type: <see cref="System.String" /></value>
        public int CardType { get; set; } = 0;

        public CardTypeDescription CardDesc { get; set; } = CardTypeDescription.Mastercard;
        

        /// <summary>Indicates the customer account number for transaction.</summary>
        /// <value>Type: <see cref="System.Int64" /></value>
        public int CustomerAccNo{ get; set; } = 0;

        /// <summary>Indicates the customer account number for transaction.</summary>
        /// <value>Type: <see cref="System.Int64" /></value>
        public int CustomerCardEntryMode { get; set; } =0;

        public int CardNotPresent { get; set; } = 0;

         
        /// <summary>The response code of the request.</summary>
        /// <value>Type: <see cref="System.String"/><para>A 2 character response code. "00" indicates a successful response.</para></value>
        public string ResponseCode { get; set; } = "";

        /// <summary>The response text for the response code.</summary>
        /// <value>Type: <see cref="System.String"/></value>
        public string ResponseText { get; set; } = "";

      
        /// <summary>Terminal ID configured in the PIN pad.</summary>
        /// <value>Type: <see cref="System.String" /></value>
        public string TerminalID { get; set; } = "";

        public int DemoMode { get; set; } = 0;
    }
}
