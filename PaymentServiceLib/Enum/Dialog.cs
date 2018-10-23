using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Enum
{

    /// <summary>The style of PaymentTerminal dialog.</summary>
	public enum DialogType
    {
        /// <summary>The standard PaymentTerminal dialog.</summary>
        Standard = '0',
        /// <summary>The PaymentTerminal dialog for touch screens. Has larger buttons.</summary>
        TouchScreen = '1',
        /// <summary>Do not show the PaymentTerminal dialogs.</summary>
        Hidden = '2'
    }
    /// <summary>The position of the PaymentTerminal dialog.</summary>
    /// <remarks>Currently not supported.</remarks>
    public enum DialogPosition
    {
        /// <summary>The top left position of the screen.</summary>
        TopLeft,
        /// <summary>The top centre position of the screen.</summary>
        TopCentre,
        /// <summary>The top right position of the screen.</summary>
        TopRight,
        /// <summary>The middle left position of the screen.</summary>
        MiddleLeft,
        /// <summary>The centre position of the screen.</summary>
        Centre,
        /// <summary>The middle right position of the screen.</summary>
        MiddleRight,
        /// <summary>The bottom left position of the screen.</summary>
        BottomLeft,
        /// <summary>The bottom centre position of the screen.</summary>
        BottomCentre,
        /// <summary>The bottom right position of the screen.</summary>
        BottomRight
    }

}
