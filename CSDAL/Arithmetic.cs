using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDAL
{
    public class Arithmetic
    {

        public double Percentage(double x, double y)
        {
            double percentage = 0;

            percentage = (x / y) * 100;

            return percentage;
        }

        public double ratio(double x, double y)
        {
            double percentage = 0;

            percentage = (x / y);

            return percentage;
        }
        
    }
}
