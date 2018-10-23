using PaymentServiceLib.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Model.Response
{
    /// <summary>A PaymentTerminal terminal logon response object.</summary>
    public class EFTClientListResponse : TerminalBaseResponse
    {
        public enum EFTClientState { Available, Unavailable }

        public class EFTClient
        {
            public string Name { get; set; } = "";
            public string IPAddress { get; set; } = "";
            public int Port { get; set; } = 0;
            public EFTClientState State { get; set; } = EFTClientState.Unavailable;
        }

        /// <summary>Constructs a default EFT-Client list response object.</summary>
        public EFTClientListResponse() : base(typeof(EFTClientListRequest))
        {
        }

        public bool Success { get; set; } = true;

        public List<EFTClient> EFTClients { get; set; } = new List<EFTClient>();
    }

}
