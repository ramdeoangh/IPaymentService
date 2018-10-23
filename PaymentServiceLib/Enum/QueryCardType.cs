using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Enum
{


 
    /// <summary>Indicates the type of logon to perform.</summary>
    public enum QueryCardType
    {
        /// <summary>Read card only</summary>
        ReadCard = '0',
        /// <summary>Read card + select account</summary>
        ReadCardAndSelectAccount = '1',
        /// <summary>Select account only</summary>
        SelectAccount = '5',
        /// <summary>Pre-swipe</summary>
        /// <remarks>Do not use</remarks>
        [Filter("WW")]
        PreSwipe = '7',
        /// <summary>Pre-swipe special</summary>
        /// <remarks>Do not use</remarks>
        [Filter("WW")]
        PreSwipeSpecial = '8',
        /// <summary>Pre-swipe special 2</summary>
        /// <remarks>Do not use</remarks>
        [Filter("WW")]
        PreSwipeSpecial2 = '8'
    }

}
