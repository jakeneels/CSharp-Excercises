using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    class SPU : IDeliveryDriver
    {
        public int ShippingTime { get; set; }
        //If four-day ground then rate = (weight * 0.0050) * distance
        //If two-day business then rate = (weight * 0.050) * distance
        //if next day then rate = (weight * 0.075) * distance
        public double CalculateRate(int distance, double weight)
        {
            ShippingTime = ShippingTime;
            double rate = 0;
            rate = (ShippingTime == 4) ? (weight *0.0050) * distance : rate;
            rate = (ShippingTime == 2) ? (weight * 0.050) * distance : rate;
            rate = (ShippingTime == 1) ? (weight * 0.075) * distance : rate;

            return rate;
        }
    }
}
