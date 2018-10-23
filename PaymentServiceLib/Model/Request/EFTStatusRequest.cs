using PaymentServiceLib.Enum;
using PaymentServiceLib.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Model.Request
{
   public class EFTStatusRequest:TerminalBaseRequest
    {
        /// <summary>Constructs a default terminal status request object.</summary>
		public EFTStatusRequest() : base(true, typeof(EFTStatusResponse))
        {
        }

        /// <summary>Two digit merchant code</summary>
        /// <value>Type: <see cref="string"/><para>The default is "00"</para></value>
        public string Merchant { get; set; } = "00";

        /// <summary>Type of status to perform.</summary>
        /// <value>Type: <see cref="StatusType"/><para>The default is <see cref="StatusType.Standard" />.</para></value>
        public StatusType StatusType { get; set; } = StatusType.Standard;

        /// <summary>Indicates where the request is to be sent to. Should normally bePaymentTerminal.</summary>
        /// <value>Type: <see cref="TerminalApplication"/><para>The default is <see cref="TerminalApplication.EFTPOS"/>.</para></value>
        public TerminalApplication Application { get; set; } = TerminalApplication.EFTPOS;
    }
}
