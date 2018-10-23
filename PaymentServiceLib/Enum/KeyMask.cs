using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Enum
{
    [Flags]
    public enum KeyMask { Cancel = 0x01, Enter = 0x02, Clear = 0x04, NumberKeys = 0x08, FunctionKeys = 0x10, AccountKeys = 0x20, Function = 0x40, OtherKeys = 0x80 }

}
