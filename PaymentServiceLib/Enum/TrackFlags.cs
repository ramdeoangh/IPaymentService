using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Enum
{
    /// <summary>Indicates what tracks are available in the response.</summary>
    [Flags()]
    public enum TrackFlags
    {
        /// <summary>Track 1 is available.</summary>
        Track1,
        /// <summary>Track 2 is available.</summary>
        Track2,
        /// <summary>Track 3 is available.</summary>
        Track3
    }
    [Flags]
    public enum TrackFlags11 { Track1 = 0x01, Track2 = 0x02, Track3 = 0x04 }

}
