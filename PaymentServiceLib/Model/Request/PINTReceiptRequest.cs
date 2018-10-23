using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Model.Request
{
     
    public class PINTReceiptRequest:PINTRequest
    {
        /// <summary>Constructs a default display response object.</summary>
        public PINTReceiptRequest() : base(false, typeof(PINTReceiptRequest))
        {
        }
    }
}
