using PaymentServiceLib.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Model.Response
{
    /// <summary>Abstract base class for EFT client responses.</summary>
    public abstract class TerminalBaseResponse
    {
        protected Type pairedRequestType = null;

        /// <summary>
        /// Hidden default constructor
        /// </summary>
        private TerminalBaseResponse()
        {

        }

        public TerminalBaseResponse(Type pairedRequestType)
        {
            if (pairedRequestType != null && pairedRequestType.IsSubclassOf(typeof(TerminalBaseRequest)) != true)
            {
                throw new InvalidOperationException("pairedRequestType must be based on TerminalBaseRequest");
            }

            this.pairedRequestType = pairedRequestType;
        }

        /// <summary>
        /// Indicates the paired TerminalBaseRequest for this TerminalBaseResponse if one exists. Null otherwise.
        /// e.g. EFTLogonResponse will have a paired EFTLogonRequest request
        /// </summary>
        public virtual Type GetPairedRequestType() { return pairedRequestType; }
    }
}
