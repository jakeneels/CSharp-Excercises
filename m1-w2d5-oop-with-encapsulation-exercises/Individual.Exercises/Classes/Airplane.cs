using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Airplane
    {
        public string PlaneNumber { get; }
        public int BookedFirstClassSeats { get; private set; }
        public int BookedCoachSeats { get; private set; }
        public int TotalFirstClassSeats { get; }
        public int TotalCoachSeats { get; }
        public int AvailableFirstClassSeats { get => TotalFirstClassSeats - BookedFirstClassSeats; }
        public int AvailableCoachSeats { get => TotalCoachSeats - BookedCoachSeats; }

        public Airplane(){  }
        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            PlaneNumber = planeNumber;
            TotalFirstClassSeats = totalFirstClassSeats;
            TotalCoachSeats = totalCoachSeats;
        }
        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            bool result = false;
            if (forFirstClass && AvailableFirstClassSeats >= totalNumberOfSeats)
            {
                result = true;
                BookedFirstClassSeats += totalNumberOfSeats;
            }
            else if (!forFirstClass && AvailableCoachSeats >= totalNumberOfSeats)
            {
                result = true;
                BookedCoachSeats += totalNumberOfSeats;
            }

            return result;
        }
    }
}
