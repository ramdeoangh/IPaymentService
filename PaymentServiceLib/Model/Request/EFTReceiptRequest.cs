using PaymentServiceLib.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Model.Request
{
    /// <summary>A PaymentTerminal receipt request object.</summary>
    public class EFTReceiptRequest : TerminalBaseRequest
    {
        /// <summary>Constructs a default display response object.</summary>
		public EFTReceiptRequest() : base(false, typeof(EFTReceiptResponse))
        {
        }
    }

}
