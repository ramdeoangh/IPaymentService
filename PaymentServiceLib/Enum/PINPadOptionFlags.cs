using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Enum
{
    /// <summary>PIN pad terminal supported options.</summary>
    [Flags]
    public enum PINPadOptionFlags
    {
        /// <summary>Tipping enabled flag.</summary>
        Tipping = 0x0001,
        /// <summary>Pre-athourization enabled flag.</summary>
        PreAuth = 0x0002,
        /// <summary>Completions enabled flag.</summary>
        Completions = 0x0004,
        /// <summary>Cash-out enabled flag.</summary>
        CashOut = 0x0008,
        /// <summary>Refund enabled flag.</summary>
        Refund = 0x0010,
        /// <summary>Balance enquiry enabled flag.</summary>
        Balance = 0x0020,
        /// <summary>Deposit enabled flag.</summary>
        Deposit = 0x0040,
        /// <summary>Manual voucher enabled flag.</summary>
        Voucher = 0x0080,
        /// <summary>Mail-order/Telephone-order enabled flag.</summary>
        MOTO = 0x0100,
        /// <summary>Auto-completions enabled flag.</summary>
        AutoCompletion = 0x0200,
        /// <summary>Electronic Fallback enabled flag.</summary>
        EFB = 0x0400,
        /// <summary>EMV enabled flag.</summary>
        EMV = 0x0800,
        /// <summary>Training mode enabled flag.</summary>
        Training = 0x1000,
        /// <summary>Withdrawal enabled flag.</summary>
        Withdrawal = 0x2000,
        /// <summary>Funds transfer enabled flag.</summary>
        Transfer = 0x4000,
        /// <summary>Start cash enabled flag.</summary>
        StartCash = 0x8000
    }

    public class ParseStatusOptionFlagsParsee
    {
        public static PINPadOptionFlags ParseStatusOptionFlags(char[] Flags)
        {
            PINPadOptionFlags flags = 0;
            int index = 0;
            if (Flags[index++] == '1') flags |= PINPadOptionFlags.Tipping;
            if (Flags[index++] == '1') flags |= PINPadOptionFlags.PreAuth;
            if (Flags[index++] == '1') flags |= PINPadOptionFlags.Completions;
            if (Flags[index++] == '1') flags |= PINPadOptionFlags.CashOut;
            if (Flags[index++] == '1') flags |= PINPadOptionFlags.Refund;
            if (Flags[index++] == '1') flags |= PINPadOptionFlags.Balance;
            if (Flags[index++] == '1') flags |= PINPadOptionFlags.Deposit;
            if (Flags[index++] == '1') flags |= PINPadOptionFlags.Voucher;
            if (Flags[index++] == '1') flags |= PINPadOptionFlags.MOTO;
            if (Flags[index++] == '1') flags |= PINPadOptionFlags.AutoCompletion;
            if (Flags[index++] == '1') flags |= PINPadOptionFlags.EFB;
            if (Flags[index++] == '1') flags |= PINPadOptionFlags.EMV;
            if (Flags[index++] == '1') flags |= PINPadOptionFlags.Training;
            if (Flags[index++] == '1') flags |= PINPadOptionFlags.Withdrawal;
            if (Flags[index++] == '1') flags |= PINPadOptionFlags.Transfer;
            if (Flags[index++] == '1') flags |= PINPadOptionFlags.StartCash;
            return flags;
        }
    }
   

}
