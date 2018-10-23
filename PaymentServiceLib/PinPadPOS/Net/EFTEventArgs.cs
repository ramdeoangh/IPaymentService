using PaymentServiceLib.Model.Request;
using PaymentServiceLib.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPaymentServiceLib.PinPadPOS.Net
{
    #region EFTEventArgs
    /// <summary>
    /// EFT Event object. Sent when an EFT event occurs
    /// </summary>
    /// <typeparam name="TEFTResponse"></typeparam>
    public class EFTEventArgs<TEFTResponse> where TEFTResponse : TerminalBaseResponse
    {
        // public event EventHandler<>
        public EFTEventArgs(TEFTResponse response)
        {
            Response = response;
        }

        public TEFTResponse Response { get; set; }
    }

    #endregion
}
