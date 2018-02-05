using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConvert
{
    class Program
    {
        /*
         The Fahrenheit to Celsius conversion formula is:
 	        Tc = (Tf - 32) / 1.8
 	        where 'Tc' is the temperature in Celsius, and 'Tf' is the temperature in Fahrenheit
 	
         The Celsius to Fahrenheit conversion formula is:
 	        Tf = Tc * 1.8 + 32
 	         
        Write a command line program which prompts a user to enter a temperature, and whether its in degrees (C)elsius or (F)arenheit.
        Convert the temperature to the opposite degrees, and display the old and new temperatures to the console.

         C:\Users> TempConvert
         Please enter the temperature: 58
         Is the temperature in (C)elcius, or (F)arenheit? F
         58F is 14C.
        
         */
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("1: to convert feet to meters");
                Console.WriteLine("2: to convert meters to feet");
                Console.WriteLine("0: to quit");
                int userSelection;
                int.TryParse(Console.ReadLine(), out userSelection);

                switch (userSelection)
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
