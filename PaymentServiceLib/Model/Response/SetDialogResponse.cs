using PaymentServiceLib.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Model.Response
{
    /// <summary>A PaymentTerminal set dialog response object.</summary>
    public class SetDialogResponse : TerminalBaseResponse
    {
        /// <summary>Constructs a default set dialog response object.</summary>
        public SetDialogResponse() : base(typeof(SetDialogRequest))
        {
        }

        /// <summary>Indicates if the set dialog request was successful.</summary>
        /// <value>Type: <see cref="System.Boolean" /></value>
        public bool Success { get; set; }
    }
}
