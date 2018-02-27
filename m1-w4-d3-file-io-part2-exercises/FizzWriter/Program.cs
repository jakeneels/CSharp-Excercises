using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FizzWriter
{
    class Program
    {

        public static void Main(string[] args)
        {
            string FileName = "FizzBuzz.txt";

           string fizzBuzzFolder = Environment.CurrentDirectory + @"C:\..\..\FizzBuzz.txt";

            //string filePath = Path.Combine(fizzBuzzFolder, FileName);


            try
            {
                
                    if (!File.Exists(FileName))
                    {


                        using (StreamWriter sw = new StreamWriter(FileName, true))
                        {
                            for (int i = 1; i <= 300; i++)
                            {
                            // if a number is multiple of  3 and 5
                            if ((i % 3 == 0) && (i % 5 == 0))
                            {
                                sw.WriteLine("FizzBuzz");

                            }
                            // number multiple of 3
                            else if (i % 3 == 0)
                            {
                                sw.WriteLine("Fizz");

                            }
                            // number multiple of 5
                            else if (i % 5 == 0)
                            {
                                sw.WriteLine("Buzz");

                            }

                            else if (i < 1 || i > 300)
                            {
                                sw.WriteLine("");

                            }
                            else
                            //return string num
                            {
                                sw.WriteLine(i);

                                }


                            }

                        }
                    }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
