using PaymentServiceLib.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Model.Request
{
    /// <summary>A PaymentTerminal cloud logon request object.</summary>
    public class EFTCloudLogonRequest : TerminalBaseRequest
    {
        /// <summary>Constructs a default cloud logon request object.</summary>
        public EFTCloudLogonRequest() : base(true, typeof(EFTCloudLogonResponse))
        {
        }

        /// <summary>The cloud logon username</summary>
        /// <value>Type: <see cref="System.String" /><para>The default is ""</para></value>
        public string ClientID { get; set; } = "";

        /// <summary>The cloud logon password</summary>
        /// <value>Type: <see cref="System.String" /><para>The default is ""</para></value>
        public string Password { get; set; } = "";

        /// <summary>The cloud logon pairing code created by the pinpad</summary>
        /// <value>Type: <see cref="System.String" /><para>The default is ""</para></value>
        public string PairingCode { get; set; } = "";
    }

}
