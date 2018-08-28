using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDAL
{
    public class Customer
    {
        public int ApplicationID { get; set; }
        public int UserID { get; set; }
        public int AccesCount { get; set; }
        public int AvgUseDuration { get; set; }
        public int InactivityPeriod { get; set; }
        public int MoneySpent { get; set; }
        public Boolean Interested { get; set; }
        public Boolean Buyers { get; set; }
    }
}
