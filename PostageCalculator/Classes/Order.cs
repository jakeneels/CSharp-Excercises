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
                    "1622+paddy+lane+ontario+ny",
                    "16271+soriano+drive+california",
                    "west+5th+street+dayton+oh"
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
                    "traubenweg+heidelberg+germany",
                    "little+spring+run+fairport+ny",
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
            Thread.Sleep(2000);
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
            Thread.Sleep(2000);
            Distance = maps.GetDistance();
            Price = spu.CalculateRate(Distance, weight);

        }
        public static string getSomePlaces(int index)
        {
            SomePlaces.Remove(SomePlaces[index]);
            return SomePlaces[index];
        }
        public static string getOtherPlaces(int index)
        {
            OtherPlaces.Remove(OtherPlaces[index]);
            return OtherPlaces[index];
        }
    }
}
