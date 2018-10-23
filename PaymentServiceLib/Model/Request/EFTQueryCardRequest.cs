using PaymentServiceLib.Enum;
using PaymentServiceLib.Model.Response;
using PaymentServiceLib.PinPadPOS.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Model.Request
{
#pragma warning disable CS0618
    /// <summary>A PaymentTerminal terminal query card request object.</summary>
    public class EFTQueryCardRequest : QueryCardRequest
    {
    }
#pragma warning restore CS0618


    /// <summary>
    /// QueryCardRequest is obsolete. Please use EFTQueryCardRequest
    /// </summary>
    [Obsolete("QueryCardRequest is obsolete. Please use EFTQueryCardRequest")]
    public class QueryCardRequest : TerminalBaseRequest
    {
        /// <summary>Constructs a default terminal query card request object.</summary>
        public QueryCardRequest() : base(true, typeof(EFTQueryCardResponse))
        {
        }

        /// <summary>Two digit merchant code</summary>
        /// <value>Type: <see cref="string"/><para>The default is "00"</para></value>
        public string Merchant { get; set; } = "00";

        /// <summary>Query card type.</summary>
        /// <value>Type: <see cref="QueryCardType" /><para>The default is <see cref="QueryCardType.ReadCard" />.</para></value>
        public QueryCardType QueryCardType { get; set; } = QueryCardType.ReadCard;

        /// <summary>Additional information sent with the request.</summary>
        /// <value>Type: <see cref="PadField"/></value>
        public PadField PurchaseAnalysisData { get; set; } = new PadField();

        /// <summary>Indicates where the request is to be sent to. Should normally bePaymentTerminal.</summary>
        /// <value>Type: <see cref="TerminalApplication"/><para>The default is <see cref="TerminalApplication.EFTPOS"/>.</para></value>
        public TerminalApplication Application { get; set; } = TerminalApplication.EFTPOS;
    }
}
