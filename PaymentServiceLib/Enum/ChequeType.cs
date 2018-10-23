using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Enum
{
    /// <summary>Indicates if the type of cheque authorization to perform.</summary>
	public enum ChequeType
    {
        /// <summary>Business guarantee authorization.</summary>
        BusinessGuarantee = '0',
        /// <summary>Personal guarantee authorization.</summary>
        PersonalGuarantee = '1',
        /// <summary>Personal guarantee authorization.</summary>
        PersonalAppraisal = '2',
    }
}
