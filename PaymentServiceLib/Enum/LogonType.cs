using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Enum
{
    public enum LogonType
    {
        /// <summary>Standard EFT logon to the bank.</summary>
        Standard = ' ',
        /// <summary>Standard EFT logon to the bank.</summary>
        /// <remarks>Not supported by all PIN pads.</remarks>
        RSA = '4',
        /// <summary>Standard EFT logon to the bank.</summary>
        /// <remarks>Not supported by all PIN pads.</remarks>
        TMSFull = '5',
        /// <summary>Standard EFT logon to the bank.</summary>
        /// <remarks>Not supported by all PIN pads.</remarks>
        TMSParams = '6',
        /// <summary>Standard EFT logon to the bank.</summary>
        /// <remarks>Not supported by all PIN pads.</remarks>
        TMSSoftware = '7',
        /// <exclude/>
        Logoff = '8',
        /// <summary>Enables diagnostics.</summary>
        Diagnostics = '1'
    }
}
