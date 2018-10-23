using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentServiceLib.Enum
{

    public class EnumUtil { }
    public class FilterAttribute : Attribute
    {
        public FilterAttribute(string customString)
        {
            this.customString = customString;
        }
        private string customString;
        public string CustomString
        {
            get { return customString; }
            set { customString = value; }
        }
    }

    public class DescriptionAttribute : Attribute
    {
        public DescriptionAttribute(string description)
        {
            this.description = description;
        }
        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
