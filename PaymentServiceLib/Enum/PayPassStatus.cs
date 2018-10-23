
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Enum
{
    /// <summary>The currency conversion status for the transaction.</summary>
    public enum CurrencyStatus
    {
        /// <summary>Currency conversion status was not set by the PIN pad.</summary>
        NotSet = ' ',
        /// <summary>Transaction amount was processed in Australian Dollars.</summary>
        AUD = '0',
        /// <summary>Transaction amount was currency converted.</summary>
        Converted = '1'
    }

    /// <summary>The Pay Pass status of the transcation.</summary>
    public enum PayPassStatus
    {
        /// <summary>Pay Pass conversion status was not set by the PIN pad.</summary>
        NotSet = ' ',
        /// <summary>Pay Pass was used in the transaction.</summary>
        PayPassUsed = '1',
        /// <summary>Pay Pass was not used in the transaction.</summary>
        PayPassNotUsed = '0'
    }
}
