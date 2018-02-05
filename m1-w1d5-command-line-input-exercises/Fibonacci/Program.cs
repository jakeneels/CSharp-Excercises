using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        /*
         The Fibonacci numbers are the integers in the following sequence:  
	        0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ...
         By definition, the first two numbers in the Fibonacci sequence are 0 and 1,
         and each subsequent number is the sum of the previous two.
 
         Write a command line program which prompts the user for an integer value
         and display the Fibonacci sequence leading up to that number.
  
         C:\Users> Fiboncci
         Please enter the Fibonacci number: 25
         
         0, 1, 1, 2, 3, 5, 8, 13, 21
         */
        static void Main(string[] args)
        {

<<<<<<< HEAD
            bool isRunning = true;
            while (isRunning)
            {
                byte menuInput;

                Console.WriteLine("Enter 1 to make the Fibbonacci sequence");
                Console.WriteLine("Enter 0 to quit");
                Byte.TryParse(Console.ReadLine(), out menuInput);

                switch (menuInput)
                {
                    case 1:
                        Console.WriteLine("Enter how many Fibbonacci numbers you want to display");
                        long iterations;
                        long fib = 0;
                        long prev = 1;
                        long prevPrev = 1;
                        long.TryParse(Console.ReadLine(), out iterations);
                        Console.WriteLine(fib);
                        Console.WriteLine(prevPrev);

                        Console.WriteLine(prev);

                        for (long i = 2; i < iterations; i++)
                        {
                            fib = prev + prevPrev;
                            prevPrev = prev;
                            prev = fib;
                            Console.WriteLine(fib);
                                                        
                        }

                        break;

                    case 0:
                        Console.WriteLine("TY COME AGAIN");
                        isRunning = false;

                        break;

                }
            }

=======
>>>>>>> a873a05563ed7d132cf0077b2e3b4739aed5b06b
        }
    }
}
