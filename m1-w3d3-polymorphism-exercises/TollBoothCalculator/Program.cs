using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothCalculator.Classes;

namespace TollBoothCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVehicle> vehicles = new List<IVehicle>();
            vehicles.Add(new Car(true));
            vehicles.Add(new Car(false));
            vehicles.Add(new Car(true));
            vehicles.Add(new Tank());
            vehicles.Add(new Tank());
            vehicles.Add(new Tank());
            vehicles.Add(new Truck(4));
            vehicles.Add(new Truck(6));
            vehicles.Add(new Truck(8));
            vehicles.Add(new Truck(12));

            PrintVehicles(vehicles);

        }
        static void PrintVehicles(List<IVehicle> vehicles)
        {
            Random rand = new Random();

            Console.WriteLine("Vehicle \t\t Distance Traveled \t\tToll");

            foreach (var vehicle in vehicles)
            {
                int distance = rand.Next(10, 240);

                Console.WriteLine($"{GetType(vehicle)}\t\t\t {distance}\t\t\t\t${vehicle.CalculateToll(distance)}");
            }
            Console.ReadKey();
        }
        static string GetType(IVehicle vehicle)
        {
            return vehicle.GetType().ToString().Replace("TollBoothCalculator.Classes.", "");
        }
    }
}