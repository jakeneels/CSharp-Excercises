using PostageCalculator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
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
            Order balls = new Order(Order.SomePlaces[r.Next( Order.SomePlaces.Count - 1)],
                                    Order.OtherPlaces[e.Next(Order.OtherPlaces.Count - 1)], 4);
            Thread.Sleep(500);

            Order paddle = new Order(Order.SomePlaces[r.Next( Order.SomePlaces.Count )],
                                     Order.OtherPlaces[e.Next(Order.OtherPlaces.Count)], 4, 2);
            Order paddles = new Order(Order.SomePlaces[r.Next(Order.SomePlaces.Count )],
                                   Order.OtherPlaces[e.Next(  Order.OtherPlaces.Count)], 30);

            maps.goToPlace(paddle.Destination);
            Console.WriteLine($"Origin: {paddle.Origin} \tDestination: {paddle.Destination}\tDist:  {paddle.Distance} Price:{paddle.Price}" );
            Console.WriteLine($"Origin: {paddles.Origin}\t Destination: {paddles.Destination}\tDist:  {paddles.Distance}\t Price:{paddles.Price}");


            Console.ReadKey();

            
        }
    }
}
