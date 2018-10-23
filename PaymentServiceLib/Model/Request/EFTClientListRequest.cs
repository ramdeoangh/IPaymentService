using PaymentServiceLib.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Model.Request
{
    /// <summary>A PaymentTerminal client list request object.</summary>
    public class EFTClientListRequest : TerminalBaseRequest
    {
        /// <summary>Constructs a default client list object.</summary>
        public EFTClientListRequest() : base(false, typeof(EFTClientListResponse))
        {
        }
    }

}
