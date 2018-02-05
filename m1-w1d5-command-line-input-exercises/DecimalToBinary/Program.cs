using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        /*
        Write a command line program which prompts the user for a series of decimal integer values  
        and displays each decimal value as itself and its binary equivalent

        C:\Users> DecimalToBinary
        
        Please enter in a series of decimal values (separated by spaces): 460 8218 1 31313 987654321
        
        460 in binary is 111001100
        8218 in binary is 10000000011010
        1 in binary is 1
        31313 in binary is 111101001010001
        987654321 in binary is 111010110111100110100010110001
        */

        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                int menuSelection;
                Console.WriteLine("enter 1 to convert binary to int \nenter 0 to quit");
                int.TryParse(Console.ReadLine() , out menuSelection);
                switch (menuSelection)
                {

                    case 1:
                        Console.WriteLine("Enter a number to be converted to binary");
                        int value = int.Parse(Console.ReadLine());
                        Console.WriteLine(Convert.ToString(value, 2));
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 0:
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("invalid input");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}

