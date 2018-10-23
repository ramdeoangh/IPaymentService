using PaymentServiceLib.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.PinPadPOS.Utility
{
    public static class TerminalApplicationExtension
    {
        public static string ToApplicationString(this TerminalApplication v)
        {
            switch (v)
            {
                case TerminalApplication.EFTPOS:
                    return "00";
                case TerminalApplication.Agency:
                    return "01";
                case TerminalApplication.Loyalty:
                case TerminalApplication.PrePaidCard:
                case TerminalApplication.ETS:
                    return "02";                // PCEFTCSA
                case TerminalApplication.GiftCard:
                    return "03";
                case TerminalApplication.Fuel:
                    return "04";
                case TerminalApplication.Medicare:
                    return "05";
                case TerminalApplication.Amex:
                    return "06";
                case TerminalApplication.ChequeAuth:
                    return "07";
            }

            return "00";    // Default to PaymentTerminal.
        }

        //public static string ToMerchantString(this TerminalApplication v)
        //{
        //    switch (v)
        //    {
        //        case TerminalApplication.EFTPOS:
        //        case TerminalApplication.Agency:
        //            return "00";
        //        case TerminalApplication.GiftCard:
        //            return "01";
        //        case TerminalApplication.Loyalty:
        //            return "02";
        //        case TerminalApplication.ChequeAuth:
        //            return "03";
        //        case TerminalApplication.PrePaidCard:
        //            return "04";
        //        case TerminalApplication.Medicare:
        //            return "05";
        //        case TerminalApplication.Amex:
        //            return "08";
        //    }

        //    return "00";    // Default to PaymentTerminal.
        //}
    }

    public static class AccountTypeExtension
    {
        public static AccountType FromString(this AccountType v, string s)
        {
            if (s.ToUpper().TrimEnd() == "CREDIT")
                return AccountType.Credit;
            else if (s.ToUpper().TrimEnd() == "SAVINGS")
                return AccountType.Savings;
            else if (s.ToUpper().TrimEnd() == "CHEQUE")
                return AccountType.Cheque;

            return AccountType.Default;
        }
    }

    public static class TransactionTypeExtension
    {
        public static string ToTransactionString(this TransactionType t)
        {
            switch (t)
            {
                case TransactionType.PurchaseCash:
                    return "P";
                case TransactionType.AddCard:
                    return "L";
                case TransactionType.AddPointsToCard:
                    return "N";
                case TransactionType.AuthPIN:
                    return "X";
                case TransactionType.Balance:
                    return "B";
                case TransactionType.CancelVoid:
                    return "I";
                case TransactionType.CardActivate:
                    return "A";
                case TransactionType.CardDeactivate:
                    return "F";
                case TransactionType.CardSale:
                    return "D";
                case TransactionType.CardSaleTopUp:
                    return "T";
                case TransactionType.CashOut:
                    return "C";
                case TransactionType.Completion:
                    return "M";
                case TransactionType.DecrementPointsFromCard:
                    return "K";
                case TransactionType.MiniTransactionHistory:
                    return "H";
                case TransactionType.NotSet:
                    return " ";
                case TransactionType.OrderRequest:
                    return "O";
                case TransactionType.Refund:
                    return "R";
                case TransactionType.RefundFromCard:
                    return "W";
                case TransactionType.Voucher:
                    return "V";
                //case TransactionType.None:
                //    return "0";
                default:
                    return "0";
            }
        }
        public static string DescriptionAttr<T>(this T source)
        {
            FieldInfo fi = source.GetType().GetField(source.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0) return attributes[0].Description;
            else return source.ToString();
        }
    }
}
