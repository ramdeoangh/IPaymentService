using PaymentServiceLib.Enum;
using PaymentServiceLib.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Model.Request
{
    /// <summary>A PaymentTerminal set dialog request object.</summary>
    public class SetDialogRequest : TerminalBaseRequest
    {
        /// <summary>Constructs a default set dialog request object.</summary>
        public SetDialogRequest() : base(false, typeof(SetDialogResponse))
        {
        }

        /// <summary>Indicates the type of PaymentTerminal dialog to use.</summary>
        /// <value>Type: <see cref="DialogType" /><para>The default is <see cref="DialogType.Standard" />.</para></value>
        public DialogType DialogType { get; set; } = DialogType.Standard;

        /// <summary>Indicates if the type of PaymentTerminal dialog to use.</summary>
        /// <value>Type: <see cref="DialogType" /><para>The default is <see cref="DialogType.Standard" />.</para></value>
        [System.Obsolete("Please use DialogType instead of Type")]
        public DialogType Type { get { return DialogType; } set { DialogType = value; } }

        /// <summary>Indicates the X position of the PaymentTerminal dialog.</summary>
        /// <value>Type: <see cref="System.Int32" /></value>
        public int DialogX { get; set; } = 0;

        /// <summary>Indicates the Y position of the PaymentTerminal dialog.</summary>
        /// <value>Type: <see cref="System.Int32" /></value>
        public int DialogY { get; set; } = 0;

        /// <summary>Indicates the position of the PaymentTerminal dialog.</summary>
        /// <value>Type: <see cref="DialogPosition" /><para>The default is <see cref="DialogPosition.Centre" />.</para></value>
        public DialogPosition DialogPosition { get; set; } = DialogPosition.Centre;

        /// <summary>Indicates the position of the PaymentTerminal dialog.</summary>
        /// <value>Type: <see cref="DialogPosition" /><para>The default is <see cref="DialogPosition.Centre" />.</para></value>
        [System.Obsolete("Please use DialogPosition instead of Position")]
        public DialogPosition Position { get { return DialogPosition; } set { DialogPosition = value; } }

        /// <summary>Indicates if the PaymentTerminal dialog is to be on top.</summary>
        /// <value>Type: <see cref="System.Boolean" /><para>The default is TRUE.</para></value>
        public bool EnableTopmost { get; set; } = true;

        /// <summary>Indicates if the PaymentTerminal dialog is to be on top.</summary>
        /// <value>Type: <see cref="System.Boolean" /><para>The default is TRUE.</para></value>
        [System.Obsolete("Please use EnableTopmost instead of TopMost")]
        public bool TopMost { get { return EnableTopmost; } set { EnableTopmost = value; } }


        /// <summary>Set the title of the PaymentTerminal dialog.</summary>
        /// <value>Type: <see cref="System.String" /></value>
        public string DialogTitle { get; set; } = "";

        /// <summary>Set the title of the PaymentTerminal dialog.</summary>
        /// <value>Type: <see cref="System.String" /></value>
        [System.Obsolete("Please use DialogTitle instead of Title")]
        public string Title { get { return DialogTitle; } set { Title = DialogTitle; } }

        /// <summary>Disable all future display events to the POS</summary>
        /// <value>Type: <see cref="System.Boolean" /><para>The default is FALSE.</para></value>
        public bool DisableDisplayEvents { get; set; } = false;
    }

}
