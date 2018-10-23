using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Enum
{
    /// <summary>PIN pad terminal key handling scheme.</summary>
    public enum KeyHandlingType
    {
        /// <summary>Single-DES encryption standard.</summary>
        SingleDES = '0',
        /// <summary>Triple-DES encryption standard.</summary>
        TripleDES = '1',
        /// <summary>Unknown encryption standard.</summary>
        Unknown
    }
}
