using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Enum
{
    /// <summary>Supported PaymentTerminal account types.</summary>
    public enum AccountType
    {
        /// <summary>The default account type for a card.</summary>
        Default = ' ',
        /// <summary>The savings account type.</summary>
        Savings = '3',
        /// <summary>The cheque account type.</summary>
        Cheque = '1',
        /// <summary>The credit account type.</summary>
        Credit = '2'
    }
}
