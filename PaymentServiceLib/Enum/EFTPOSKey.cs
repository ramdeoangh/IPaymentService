using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Enum
{
    /// <summary>PaymentTerminal key types.</summary>
    public enum EFTPOSKey
    {
        /// <summary>The OK/CANCEL key.</summary>
        OkCancel = '0',
        /// <summary>The YES/ACCEPT key.</summary>
        YesAccept = '1',
        /// <summary>The NO/DECLINE key.</summary>
        NoDecline = '2',
        /// <summary>The AUTH key.</summary>
        Authorise = '3'
    }
}
