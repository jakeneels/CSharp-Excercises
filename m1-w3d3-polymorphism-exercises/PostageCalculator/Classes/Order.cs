using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    class Order
    {
        MapsAPI maps = new MapsAPI();
        public string Destination { get; }
        public string Origin { get; }
        public int Weight { get; }
        public int ShippingTime { get; private set; }
        public int Distance { get; set; }
        public double Price { get; set; }

        public static List<string> SomePlaces
        {
            get
            {
                return new List<string>()
                {
                    "1776+mentor+ave+cincinatti",
                    "west+5th+street+dayton+oh",
                    "1622+paddy+lane+ontario+ny",
                };
            }
        }
        public static List<string> OtherPlaces
        {
            get
            {
                return new List<string>()
                {
                    "carr+ave+cleveland+oh",
                    "little+spring+run+fairport+ny",
                    "16271+soriano+drive+california"
                };
            }
        }

        public Order(string destination, string origin, int weight)
        {
            FedEx fedex = new FedEx();
            Destination = destination;
            Origin = origin;
            Weight = weight;
            maps.RequestDist(Origin, Destination);
            Thread.Sleep(100);
            Distance = maps.GetDistance();
            Price = fedex.CalculateRate(Distance, weight);

        }
        public Order(string destination, string origin, int weight, int shippingTime)
        {
            SPU spu = new SPU();
            spu.ShippingTime = shippingTime;
            Destination = destination;
            Origin = origin;
            Weight = weight;
            ShippingTime = shippingTime;
            maps.RequestDist(Origin, Destination);
            Thread.Sleep(100);
            Distance = maps.GetDistance();
            Price = spu.CalculateRate(Distance, weight);

        }
        public static string getSomePlaces(int index)
        {
            return SomePlaces[index];
        }
        public static string getOtherPlaces(int index)
        {
            return OtherPlaces[index];
        }
    }
}
