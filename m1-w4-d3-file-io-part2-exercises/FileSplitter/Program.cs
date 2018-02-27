using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of the input file? (Enter for default file)");
            string inputFileName = Console.ReadLine();
            Console.WriteLine("How many lines in each split file?");
            string numLinesToSplit = Console.ReadLine();
            int.TryParse(numLinesToSplit, out int lines);

            FileSplit fs = new FileSplit();
            fs.SplitFile(inputFileName, lines);

        }
    }
}
