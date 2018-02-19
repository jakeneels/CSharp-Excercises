using PostageCalculator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting");
            Random r = new Random();
            Random e = new Random();
            MapsAPI maps = new MapsAPI();
            // r.Next(Order.Places.Count-1)
            Order balls = new Order( "paddy+lane+ontario+ny", "Cincinnati", 5);
            Order paddle = new Order(Order.SomePlaces[r.Next(Order.SomePlaces.Count - 1)],
                                     Order.OtherPlaces[e.Next(Order.OtherPlaces.Count - 1)], 4);
            Console.WriteLine($"Origin: {paddle.Origin} \tDestination: {paddle.Destination}\tDist:  {paddle.Distance} Price:{paddle.Price}");
            Console.WriteLine($"Origin: {balls.Origin}\t Destination: {balls.Destination}\tDist:  {balls.Distance}\t Price:{balls.Price}");


            Console.ReadKey();

            
        }
    }
}
