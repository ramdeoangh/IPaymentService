using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Enum
{
    /// <summary>PIN pad terminal communication option.</summary>
	public enum TerminalCommsType
    {
        /// <summary>Cable link communications.</summary>
        Cable = '0',
        /// <summary>Intrared link communications.</summary>
        Infrared = '1',
        /// <summary>Unknown link communications.</summary>
        Unknown
    }

}
