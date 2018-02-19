using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    class FedEx : IDeliveryDriver
    {

        //        rate = 20.00
        //if distance > 500 miles then rate = rate + 5.00
        //if weight > 48 ounces then rate = rate + 3.00


        public double CalculateRate(int distance, double weight)
        {
            double rate = 0;
            rate = (distance > 500) ? rate = rate + 5d : rate;
            rate = (weight > 48) ? rate = rate + 3d : rate;
            return rate;
        }
    }
}
