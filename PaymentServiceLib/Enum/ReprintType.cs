using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Enum
{
    /// <summary>Reprint Type.</summary>
	public enum ReprintType
    {
        /// <summary>Get the last receipt.</summary>
        GetLast = '2',
        /// <summary>Reprint the last receipt.</summary>
        Reprint = '1'
    }
}
