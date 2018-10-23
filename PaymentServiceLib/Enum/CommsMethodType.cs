using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Enum
{
    /// <summary>The communications method used to process the transaction.</summary>
    public enum CommsMethodType
    {
        /// <summary>Comms method type was not set by the PIN pad.</summary>
        NotSet = ' ',
        /// <summary>Transaction was sent to the bank using an unknown method.</summary>
        Unknown = '0',
        /// <summary>Transaction was sent to the bank using a P66 modem.</summary>
        P66 = '1',
        /// <summary>Transaction was sent to the bank using an Argent.</summary>
        Argent = '2',
        /// <summary>Transaction was sent to the bank using an X25.</summary>
        X25 = '3'
    }
}
