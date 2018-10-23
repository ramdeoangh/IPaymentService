using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Enum
{
    /// <summary>PINPAD terminal applications.</summary>
    public enum TerminalApplication
    {

        /// <summary>The request is for the PaymentTerminal application.</summary>
        EFTPOS,
        /// <summary>The request is for the Agency application.</summary>
        Agency,
        /// <summary>The request is for the GiftCard application.</summary>
        GiftCard,
        /// <summary>The request is for the Fuel application.</summary>
        Fuel,
        /// <summary>The request is for the Medicare application.</summary>
        Medicare,
        /// <summary>The request is for the Amex application.</summary>
        Amex,
        /// <summary>The request is for the ChequeAuth application.</summary>
        ChequeAuth,
        /// <summary>The request is for the Loyalty application.</summary>
        Loyalty,
        /// <summary>The request is for the PrePaidCard application.</summary>
        PrePaidCard,
        /// <summary>The request is for the ETS application.</summary>
        ETS
    }
}
