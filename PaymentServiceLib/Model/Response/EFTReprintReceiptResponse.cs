using PaymentServiceLib.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Model.Response
{

    /// <summary>A PaymentTerminal duplicate receipt response object.</summary>
    public class EFTReprintReceiptResponse : TerminalBaseResponse
    {
        /// <summary>Constructs a default duplicate receipt response object.</summary>
        public EFTReprintReceiptResponse() : base(typeof(EFTReprintReceiptRequest))
        {
        }

        /// <summary>Two digit merchant code</summary>
        /// <value>Type: <see cref="string"/><para>The default is "00"</para></value>
        public string Merchant { get; set; } = "00";

        /// <summary>Duplicate receipt text.</summary>
        /// <value>Type: <see cref="System.String">String array</see></value>
        public string[] ReceiptText { get; set; } = new string[] { "" };

        /// <summary>Indicates if the request was successful.</summary>
        /// <value>Type: <see cref="System.Boolean"/></value>
        public bool Success { get; set; } = false;

        /// <summary>The response code of the request.</summary>
        /// <value>Type: <see cref="System.String"/><para>A 2 character response code. "00" indicates a successful response.</para></value>
        public string ResponseCode { get; set; } = "";

        /// <summary>The response text for the response code.</summary>
        /// <value>Type: <see cref="System.String"/></value>
        public string ResponseText { get; set; } = "";
    }
}
