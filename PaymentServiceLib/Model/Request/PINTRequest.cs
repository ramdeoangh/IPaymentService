using PaymentServiceLib.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Model.Request
{
    public abstract class PINTRequest
    {
        protected bool isStartOfTransactionRequest = true;
        protected Type pairedResponseType = null;   

        private PINTRequest()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isStartOfTransactionRequest"></param>
        /// <param name="pairedResponseType"></param>
        public PINTRequest(bool isStartOfTransactionRequest, Type pairedResponseType)
        {
            if (pairedResponseType != null && pairedResponseType.IsSubclassOf(typeof(PINTResponse)) != true)
            {
                throw new InvalidOperationException("pairedResponseType must be based on TerminalBaseResponse");
            }

            this.isStartOfTransactionRequest = isStartOfTransactionRequest;
            this.pairedResponseType = pairedResponseType;
        }

        /// <summary>
        /// True if this request starts a paired transaction request/response with displays etc (i.e. transaction, logon, settlement etc)
        /// </summary>
        public virtual bool GetIsStartOfTransactionRequest() { return isStartOfTransactionRequest; }

        /// <summary>
        /// Indicates the paired TerminalBaseResponse for this TerminalBaseRequest if one exists. Null otherwise.
        /// e.g. EFTLogonRequest will have a paired EFTLogonResponse response
        /// </summary>
        public virtual Type GetPairedResponseType() { return pairedResponseType; }
    }
}
