using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSplitter
{
    class FileSplit
    {

        public void SplitFile(string fileToSplit, int howManyLines)
        {
            string currentDirectory = Environment.CurrentDirectory + "\\..\\../";

            string readDirectory = fileToSplit;
            if (fileToSplit == "")
            {
                fileToSplit = "alices_adventures_in_wonderland";
                readDirectory = Environment.CurrentDirectory + "\\..\\../alices_adventures_in_wonderland.txt";
            }

            int fileNumberCounter = 1;
            using (StreamReader sr = new StreamReader(readDirectory))
            {
                for (int i = 1; !sr.EndOfStream; i++)
                {
                    using (StreamWriter sw = new StreamWriter(currentDirectory + fileToSplit + "-" + 
                           fileNumberCounter.ToString() + ".txt", true))
                    {
                        var line = sr.ReadLine();
                        sw.WriteLine(line);

                        if (i % howManyLines == 0)
                        {
                            fileNumberCounter++;
                        }
                    }
                }
            }
        }
    }
}
