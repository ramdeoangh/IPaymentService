using PaymentServiceLib.Enum;
using PaymentServiceLib.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Model.Request
{
  
    /// <summary>A PaymentTerminal receipt response object.</summary>
	public class PINTReceiptResponse : PINTResponse
    {
        public PINTReceiptResponse() : base(typeof(PINTRequest))
        {

        }

        /// <summary>Constructs a default display response object.</summary>
        //public EFTReceiptResponse(): base(false, typeof(EFTReceiptRequest))
        //{
        //}

        /// <summary>The receipt type.</summary>
        /// <value>Type: <see cref="ReceiptType" /></value>
        public ReceiptType Type { get; set; } = ReceiptType.Customer;

        /// <summary>Receipt text to be printed.</summary>
        /// <value>Type: <see cref="System.String">String array</see></value>
        public string[] ReceiptText { get; set; } = new string[] { "" };

        /// <summary>Receipt response is a pre-print.</summary>
        /// <value>Type: <see cref="System.Boolean" /></value>
        public bool IsPrePrint { get; set; } = false;
    }
}
