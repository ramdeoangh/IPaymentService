using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Enum
{
    public enum CommandCode
    {
        NullCommand = ' ', SlaveMode = 'S', Status = 'N', DisplayMode = 'Z', Display = 'D', Print = 'P', MagneticCardRead = 'J', Audio = 'A', Key = 'K', Input = 'E', Storage = 'M',
        Connection = 'C', External = '+', SendReceive = 'X', ICC = 'I',
    }
    public enum SlaveStatusType { Version = '0', DateTime = '1', SerialNumber = '2' }
    public enum LightStatus { NoChange = ' ', Off = '0', On = '1', Auto = 'A' }
    public enum TextAlignment { Left, Centre, Right }
    public enum CardReadOptions { Once = '1', Off = '0', Multiple = '2' }
    public enum KeyOptions { Once = '1', Off = '0', Multiple = '2' }
    public enum InputPromptMode { Default = ' ', AmountEntry = '$', Apha = 'A', Password = '*' }



}
