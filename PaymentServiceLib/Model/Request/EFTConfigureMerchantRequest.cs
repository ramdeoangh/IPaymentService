using PaymentServiceLib.Enum;
using PaymentServiceLib.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Model.Request
{
    /// <summary>A PaymentTerminal terminal config merchant request object.</summary>
    public class EFTConfigureMerchantRequest : TerminalBaseRequest
    {
        /// <summary>Constructs a default terminal configure request object.</summary>
        public EFTConfigureMerchantRequest() : base(true, typeof(EFTConfigureMerchantResponse))
        {
        }

        /// <summary>Two digit merchant code</summary>
        /// <value>Type: <see cref="string"/><para>The default is "00"</para></value>
        public string Merchant { get; set; } = "00";

        /// <summary>The terminal ID (CatID) to configure the terminal with.</summary>
        /// <value>Type: <see cref="System.String" /></value>
        public string Catid { get; set; } = "";

        /// <summary>The terminal ID (CatID) to configure the terminal with.</summary>
        /// <value>Type: <see cref="System.String" /></value>
        [System.Obsolete("Please use Catid instead of TerminalID")]
        public string TerminalID { get { return Catid; } set { Catid = value; } }

        /// <summary>The merchant ID (CaID) to configure the terminal with.</summary>
        /// <value>Type: <see cref="System.String" /></value>
        public string Caid { get; set; } = "";

        /// <summary>The merchant ID (Caid) to configure the terminal with.</summary>
        /// <value>Type: <see cref="System.String" /></value>
        [System.Obsolete("Please use Caid instead of MerchantID")]
        public string MerchantID { get { return Caid; } set { Caid = value; } }

        /// <summary>The AIIC to configure the terminal with.</summary>
        /// <value>Type: <see cref="System.Int32" /></value>
        /// <remarks>Not support by most PIN pad terminals.</remarks>
        public int AIIC { get; set; } = 0;

        /// <summary>The NII to configure the terminal with.</summary>
        /// <value>Type: <see cref="System.Int32" /></value>
        /// <remarks>Not support by most PIN pad terminals.</remarks>
        public int NII { get; set; } = 0;

        /// <summary>The bank response timeout specified in seconds.</summary>
        /// <value>Type: <see cref="System.Int32" /></value>
        /// <remarks>Not support by most PIN pad terminals.</remarks>
        public int Timeout { get; set; } = 45;

        /// <summary>Indicates where the request is to be sent to. Should normally be PaymentTerminal.</summary>
        /// <value>Type: <see cref="TerminalApplication"/><para>The default is <see cref="TerminalApplication.EFTPOS"/>.</para></value>
        public TerminalApplication Application { get; set; } = TerminalApplication.EFTPOS;
    }

}
