using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Enum
{
    /// <summary>Indicates the requested status type.</summary>
    public enum StatusType
    {
        /// <summary>Request the EFT status from the PIN pad.</summary>
        Standard = '0',
        /// <summary>Not supported by all PIN pads.</summary>
        TerminalAppInfo = '1',
        /// <summary>Not supported by all PIN pads.</summary>
        AppCPAT = '2',
        /// <summary>Not supported by all PIN pads.</summary>
        AppNameTable = '3',
        /// <summary>Undefined</summary>
        Undefined = '4',
        /// <summary>Not supported by all PIN pads.</summary>
        PreSwipe = '5'
    }

}
