using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearConvert
{
    class Program
    {
        /*
         The foot to meter conversion formula is:
 	        m = f * 0.3048
 	
         The meter to foot conversion formula is:
 	        f = m * 3.2808399
 	
         Write a command line program which prompts a user to enter a length,
         and whether the measurement is in (m)eters or (f)eet.
         Convert the length to the opposite measurement, \
         and display the old and new measurements to the console.
  
         C:\Users> LinearConvert
         Please enter the length: 58
         Is the measurement in (m)eter, or (f)eet? f
         58f is 17m.
         */

        static void Main(string[] args)
        {
            bool isRunning = true;
            while(isRunning)
            {
                Console.WriteLine("1: to convert feet to meters");
                Console.WriteLine("2: to convert meters to feet");
                Console.WriteLine("0: to quit");
                int userSelection;
                int.TryParse(Console.ReadLine(), out userSelection);
                
                switch(userSelection)
                {
                    case 1:
                        Console.WriteLine("enter number in meters to convert");
                        double meters;
                        double.TryParse(Console.ReadLine(), out meters);
                        Console.WriteLine($" is {meters * 3.2808399} feet enter to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("enter number in feet to convert");
                        double feet;
                        double.TryParse(Console.ReadLine(), out feet);
                        Console.WriteLine($" is {feet * 0.3048} meters enter to continue");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 0:
                        Console.WriteLine("Quitting");
                        Console.ReadKey();
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("invalid input");
                        break;
                    
                }
            }
        }
    }
}
