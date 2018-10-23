using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Enum
{
    /// <summary>Flags that indicate how the transaction was processed.</summary>
    public class TxnFlags
    {
        readonly char[] flags;

        /// <summary>Constructs a TxnFlags object with default values.</summary>
        public TxnFlags()
        {
        }

        /// <summary>Constructs a TxnFlags object.</summary>
        /// <param name="flags">A <see cref="System.Char">Char array</see> representing the flags.</param>
        public TxnFlags(char[] flags)
        {
            this.flags = new char[8] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
            System.Array.Copy(flags, 0, this.flags, 0, (flags.Length > 8) ? 8 : flags.Length);


            Offline = this.flags[0] == '1';
            ReceiptPrinted = this.flags[1] == '1';
            CardEntry = (CardEntryType)this.flags[2];
            CommsMethod = (CommsMethodType)this.flags[3];
            Currency = (CurrencyStatus)this.flags[4];
            PayPass = (PayPassStatus)this.flags[5];
            UndefinedFlag6 = this.flags[6];
            UndefinedFlag7 = this.flags[7];
        }

        /// <summary>Indicates if a receipt was printed for this transaction.</summary>
        /// <value>Type: <see cref="System.Boolean"/><para>Set to TRUE if a receipt was printed.</para></value>
        public bool ReceiptPrinted { get; set; } = false;

        /// <summary>Indicates if the transaction was approved offline.</summary>
        /// <value>Type: <see cref="System.Boolean"/><para>Set to TRUE if the transaction was approved offline.</para></value>
        public bool Offline { get; set; } = false;

        /// <summary>Indicates the card entry type.</summary>
        /// <value>Type: <see cref="CardEntryType"/></value>
        public CardEntryType CardEntry { get; set; } = CardEntryType.NotSet;

        /// <summary>Indicates the communications method used for this transaction.</summary>
        /// <value>Type: <see cref="CommsMethodType"/></value>
        public CommsMethodType CommsMethod { get; set; } = CommsMethodType.NotSet;

        /// <summary>Indicates the currency conversion status for this transaction.</summary>
        /// <value>Type: <see cref="CurrencyStatus"/></value>
        public CurrencyStatus Currency { get; set; } = CurrencyStatus.NotSet;

        /// <summary>Indicates the Pay Pass status for this transaction.</summary>
        /// <value>Type: <see cref="PayPassStatus"/></value>
        public PayPassStatus PayPass { get; set; } = PayPassStatus.NotSet;

        /// <summary>Undefined flag 6</summary>
        public char UndefinedFlag6 { get; set; } = ' ';

        /// <summary>Undefined flag 7</summary>
        public char UndefinedFlag7 { get; set; } = ' ';
    }
}
