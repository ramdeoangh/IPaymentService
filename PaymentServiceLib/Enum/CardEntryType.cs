using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Enum
{
    /// <summary>The card entry type of the transaction.</summary>
    public enum CardEntryType
    {
        /// <summary>Manual entry type was not set by the PIN pad.</summary>
        NotSet = 00,
        /// <summary>Unknown manual entry type. PIN pad may not support this flag.</summary>
        Unknown = '0',
        /// <summary>Card was swiped.</summary>
        Swiped = 'S',
        /// <summary>Card number was keyed.</summary>
        Keyed = 'K',
        /// <summary>Card number was read by a bar code scanner.</summary>
        BarCode = 'B',
        /// <summary>Card number was read from a chip card.</summary>
        ChipCard = 'E',
        /// <summary>Card number was read from a contactless reader.</summary>
        Contactless = 'C',
    }
}
