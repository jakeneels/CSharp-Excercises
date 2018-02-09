using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechElevator.Classes;

namespace ProductExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Feel free to use this file to instante a few objects and see how they can be used
             * in a program. While code you put here must compile, it won't be validated by the automatic
             * testing. We are more focused with the mechanics of implementing the class.
             */
<<<<<<< HEAD
            /*
           * Feel free to use this file to instante a few objects and see how they can be used
           * in a program. While code you put here must compile, it won't be validated by the automatic
           * testing. We are more focused with the mechanics of implementing the class.
           */
=======
>>>>>>> 152043d3edaabfacf5bebbd6c24778b9cd7c500e

            Product cheerios = new Product()
            {
                Name = "cheerios",
                Price = 0
            };

            cheerios.WeightInOunces = 12;

            Console.WriteLine($"Name:{cheerios.Name} Price:{cheerios.Price} Weight:{cheerios.WeightInOunces}oz");
<<<<<<< HEAD
            Console.ReadKey();

=======
            Console.ReadKey();  
>>>>>>> 152043d3edaabfacf5bebbd6c24778b9cd7c500e
        }
    }
}
