using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Enum
{
    /// <summary>Indicates the EFT terminal hardware type.</summary>
    public enum EFTTerminalType
    {
        /// <summary>Ingenico DESK 5 PIN pad terminal.</summary>
        IngenicoDESK5000,
        Unknown,
        IngenicoNPT710,
        IngenicoPX328,
        Ingenicoi3070,
        Ingenicoi5110


    }

    public class EFTTerminalTypeParser
    {
      public static  EFTTerminalType ParseEFTTerminalType(string TerminalType)
        {
            EFTTerminalType terminalType = EFTTerminalType.Unknown;

            if (TerminalType == "0062") terminalType = EFTTerminalType.IngenicoNPT710;
            else if (TerminalType == "0069") terminalType = EFTTerminalType.IngenicoPX328;
            else if (TerminalType == "7010") terminalType = EFTTerminalType.Ingenicoi3070;
            else if (TerminalType == "5110") terminalType = EFTTerminalType.Ingenicoi5110;
            else if (TerminalType == "5000") terminalType = EFTTerminalType.IngenicoDESK5000;
            return terminalType;
        }
    }

}
