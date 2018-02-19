using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Classes
{
    public class Truck : IVehicle
    {
        public int NumberOfAxles { get; }

        public Truck(int numberofAxles)
        {
            NumberOfAxles = numberofAxles;
        }

        public double CalculateToll(int distance)
        {
            double toll = 0;
            if (NumberOfAxles == 4)
            {
                toll = 0.040 * distance; /// rpm = .04
            }
            else if (NumberOfAxles == 6)
            {
                toll = 0.045 * distance;
            }
            else if (NumberOfAxles >= 8)
            {
                toll = 0.048 * distance;
            }
            return toll;
        }
    }
}