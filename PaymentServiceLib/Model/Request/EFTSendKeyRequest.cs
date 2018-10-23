using PaymentServiceLib.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Model.Request
{
    /// <summary>A PaymentTerminal client list request object.</summary>
    public class EFTSendKeyRequest : TerminalBaseRequest
    {
        /// <summary>Constructs a default client list object.</summary>
        public EFTSendKeyRequest() : base(false, null)
        {
            isStartOfTransactionRequest = false;
        }

        /// <summary> The type of key to send </summary>
        public EFTPOSKey Key { get; set; } = EFTPOSKey.OkCancel;

        /// <summary> Data entered by the POS (e.g. for an 'input entry' dialog type) </summary>
        public string Data { get; set; } = "";
    }
}
