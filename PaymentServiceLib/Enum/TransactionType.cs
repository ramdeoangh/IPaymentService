using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Enum
{
    /// <summary>PaymentTerminal transaction types.</summary>
    public enum TransactionType
    {
        /// <summary>// Sell/Purchase</summary>
        [DescriptionAttribute("00")]
        Purchase=0,
        /// <summary>A pre-authorization EFT transaction type ('A').</summary>
        [DescriptionAttribute("01")]
        PreAuth = 1,
        /// <summary>A pre-authorization / completion EFT transaction type ('L').</summary>
        [DescriptionAttribute("02")]
        PreAuthCompletion = 2,
        /// <summary>A completion EFT transaction type ('M').</summary>
        [DescriptionAttribute("M")]
        Completion = 'M',
        /// <summary>A refund EFT transaction type ('R').</summary>
        [DescriptionAttribute("03")]
        Refund = 3,
        /// <summary> Forcefully by Credit Transaction </summary>
        [DescriptionAttribute("04")]
        Force =4,
        /// <summary> Void Transaction </summary>
        [DescriptionAttribute("05")]
        Void =5,

        Batch= 'B',
        IncrementalAuth = 8 ,
        /// <summary>Transaction type was not set by the PIN pad (' ').</summary>
        NotSet = ' ',
        /// <summary>A purchase with optional cash-out EFT transaction type ('P').</summary>
        PurchaseCash = 'P',
        /// <summary>A cash-out only EFT transaction type ('C').</summary>
        CashOut = 'C',
       
        
       
        /// <summary>A pre-authorization / enquiry EFT transaction type ('N').</summary>
        PreAuthEnquiry = 'N',
        /// <summary>A pre-authorization / cancel EFT transaction type ('Q').</summary>
        PreAuthCancel = 'Q',
        
        /// <summary>A tip adjustment EFT transaction type ('T').</summary>
        TipAdjust = 'T',
        /// <summary>A deposit EFT transaction type ('D').</summary>
        Deposit = 'D',
        /// <summary>A witdrawal EFT transaction type ('W').</summary>
        Withdrawal = 'W',
        /// <summary>A balance EFT transaction type ('B').</summary>
        Balance = 'B',
        /// <summary>A voucher EFT transaction type ('V').</summary>
        Voucher = 'V',
        /// <summary>A funds transfer EFT transaction type ('F').</summary>
        FundsTransfer = 'F',
        /// <summary>A order request EFT transaction type ('O').</summary>
        OrderRequest = 'O',
        /// <summary>A mini transaction history EFT transaction type ('H').</summary>
        MiniTransactionHistory = 'H',
        /// <summary>A auth pin EFT transaction type ('X').</summary>
        AuthPIN = 'X',
        /// <summary>A enhanced pin EFT transaction type ('K').</summary>
        EnhancedPIN = 'K',

        /// <summary>A Redemption allows the POS to use the card as a payment type. This will take the amount from the Card balance ('P').</summary>
        [Filter("ETS")]
        Redemption = 'P',
        /// <summary>A Refund to Card allows the POS to return the value of a previous sale to a  Card ('R').</summary>
        [Filter("ETS")]
        RefundToCard = 'R',
        /// <summary></summary>
        [Filter("ETS")]
        CardSaleTopUp = 'T',
        /// <summary></summary>
        [Filter("ETS")]
        CardSale = 'D',
        /// <summary>A Refund from card  allows the POS to instruct the host to take an amount from a Card ('W').</summary>
        [Filter("ETS")]
        RefundFromCard = 'W',
        /// <summary>A Balance returns the current balance of funds on the card ('B').</summary>
        [Filter("ETS")]
        CardBalance = 'B',
        /// <summary>Activates the card ('A').</summary>
        [Filter("ETS")]
        CardActivate = 'A',
        /// <summary>A de-activate returns a cards to state where the card requires activation before it can be used ('F'). </summary>
        [Filter("ETS")]
        CardDeactivate = 'F',
        /// <summary>This command will add a number of points (or dollars) to a card ('N').</summary>
        [Filter("ETS")]
        AddPointsToCard = 'N',
        /// <summary>This command will subtract a number of points (or dollars) from a card ('K').</summary>
        [Filter("ETS")]
        DecrementPointsFromCard = 'K',
        /// <summary>This command allows a POS to transfer points from a card to another source ('M').</summary>
        [Filter("ETS")]
        TransferPoints = 'M',
        /// <summary>This command will return the amount of cash that is currently on the card and decrement the entire amount from the card ('X').</summary>
        [Filter("ETS")]
        CashBackFromCard = 'X',
        /// <summary>This command will cancel or void a previous sale ('I').</summary>
        [Filter("ETS")]
        CancelVoid = 'I',
        /// <summary>This command adds a card to the card list on the Host ('L').</summary>
        [Filter("ETS")]
        AddCard = 'L',

      
    }


    /// <summary>PaymentTerminal transaction types.</summary>
    public enum TransactionStatus
    {
        /// <summary>// </summary>
        Approved = 00,
        /// <summary>A pre-authorization EFT transaction type ('A').</summary>
        Partial = 01,
        DeclinedByAcquirer=10,
        CommunicationError=11,
        CancelledbyUser=12,
        TimedoutonUserInput=13,
        TransactionNotCompleted=14,
        BatchEmpty=15,
        DeclinedbyMerchant=16,
        RecordNotFound=17,        
        TransactionAlreadyVoided=18,
        None = 03
    }

}
