using PaymentServiceLib.Entry;
using PaymentServiceLib.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Util
{
  public interface IDialogUIHandler
    {
        /// <summary>
        /// An instance to the ITerminalUtil. Used to send key press requests
        /// </summary>
        ITerminalUtil PinpadClientIP { get; set; }

        /// <summary>
        /// Called by the TerminalClientIP when a EFTDisplayResponse is received
        /// </summary>
        void HandleDisplayResponse(PINPADDisplayResponse eftDisplayResponse);

        /// <summary>
        /// Called by the TerminalClientIP when the dialog needs to be closed
        /// </summary>
        void HandleCloseDisplay();
    }
}
