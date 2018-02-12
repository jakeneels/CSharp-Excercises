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
        public int TotalCoachSeats { get; private set; }
        public int AvailableFirstClassSeats { get => TotalFirstClassSeats - BookedFirstClassSeats; }
        public int AvailibleCoachSeats { get => TotalCoachSeats - BookedCoachSeats; }

        public Airplane()
        {

        }
        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            PlaneNumber = planeNumber;
            TotalFirstClassSeats = totalFirstClassSeats;
            TotalCoachSeats = totalCoachSeats;
        }
        bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            if (forFirstClass)
            {
                BookedFirstClassSeats += totalNumberOfSeats;
            }
            else
            {
                BookedCoachSeats += totalNumberOfSeats;
            }
            return true;
        }
    }
}
