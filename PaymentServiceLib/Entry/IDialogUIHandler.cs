using PaymentServiceLib.Model;
using PaymentServiceLib.Model.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentServiceLib.Entry
{
    /// <summary>
    /// An interface for a UI that implements the PaymentTerminal dialog messages
    /// Uses ITerminalUtil to send key press messages to the EFT-Client
    /// </summary>
    public interface IDialogUIHandler
    {
        /// <summary>
        /// An instance to the ITerminalUtil. Used to send key press requests
        /// </summary>
        ITerminalUtil TerminalClientIP { get; set; }

        /// <summary>
        /// Called by the TerminalClientIP when a EFTDisplayResponse is received
        /// </summary>
        void HandleDisplayResponse(EFTDisplayResponse eftDisplayResponse);

        /// <summary>
        /// Called by the TerminalClientIP when the dialog needs to be closed
        /// </summary>
        void HandleCloseDisplay();
    }
}
