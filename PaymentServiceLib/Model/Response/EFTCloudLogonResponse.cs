using PaymentServiceLib.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Model.Response
{
    /// <summary>A PaymentTerminal cloud logon response object.</summary>
    public class EFTCloudLogonResponse : TerminalBaseResponse
    {
        /// <summary>Constructs a default terminal logon response object.</summary>
        public EFTCloudLogonResponse() : base(typeof(EFTCloudLogonRequest))
        {
        }

        /// <summary>Success flag for the call. TRUE for successful</summary>
        /// <value>Type: <see cref="System.Boolean" /></value>
        public bool Success { get; set; } = false;

        /// <summary>Response code for the call</summary>
        /// <value>Type: <see cref="System.String" /></value>
        public string ResponseCode { get; set; } = "";

        /// <summary>Response text for the call</summary>
        /// <value>Type: <see cref="System.String" /></value>
        public string ResponseText { get; set; } = "";
    }
}
