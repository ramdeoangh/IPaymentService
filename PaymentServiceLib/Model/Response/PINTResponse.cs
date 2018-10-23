using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Model.Request
{
  public abstract  class PINTResponse
    {
        protected Type pairedRequestType = null;

        /// <summary>
        /// Hidden default constructor
        /// </summary>
        private PINTResponse()
        {

        }

        public PINTResponse(Type pairedRequestType)
        {
            if (pairedRequestType != null && pairedRequestType.IsSubclassOf(typeof(PINTResponse)) != true)
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
