using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Enum
{
    public enum TenderType     {
        All=0,
        Debit=1,
        Credit=2,
        Cash=7,
        Gift=8,
        Loylity=9
    };

    public enum CardTypeDescription {
        Unknown,
        Debit,
        Bankcard,
        Mastercard,
        Visa,
        America,
        Diner,
        JCB,Other
        ///	</remarks>
    }
}
