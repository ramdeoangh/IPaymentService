using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Enum
{
    //
    // Summary:
    //     The 7 possible logging levels
    [Flags]
    public enum LogLevel
    {
        //
        // Summary:
        //     All logging levels
        All = 0,
        //
        // Summary:
        //     A trace logging level
        Trace = 1,
        //
        // Summary:
        //     A debug logging level
        Debug = 2,
        //
        // Summary:
        //     A info logging level
        Info = 4,
        //
        // Summary:
        //     A warn logging level
        Warn = 8,
        //
        // Summary:
        //     An error logging level
        Error = 16,
        //
        // Summary:
        //     A fatal logging level
        Fatal = 32,
        //
        // Summary:
        //     Do not log anything.
        Off = 64
    }
}
