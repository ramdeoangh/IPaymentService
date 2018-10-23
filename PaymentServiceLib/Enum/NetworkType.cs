using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Enum
{
    /// <summary>PIN pad terminal network option.</summary>
    public enum NetworkType
    {
        /// <summary>Leased line bank connection.</summary>
        Leased = '1',
        /// <summary>Dial-up bank connection.</summary>
        Dialup = '2',
        /// <summary>Unknown bank connection.</summary>
        Unknown
    }

}
