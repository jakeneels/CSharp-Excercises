using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearch
{
    class WordSearch
    {
        //properties
        public int WordCount { get; private set; }


        //METHOD
        public int GetWordCount(string userWord, string userFileName)
        {
            int wordCounter = 0;
            //take the file name provided by the user and combine it with the path so we can access it in the streamreader
            string filePath = "";
            string currentDirectory = Environment.CurrentDirectory;
            string actualFileFolder = currentDirectory + @"/../../../";
            filePath = Path.Combine(actualFileFolder, userFileName);

           //put streamreader in a try/get since it is prone to bugs
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    
                    while (!sr.EndOfStream)
                    {
                        //Read in the line
                        string line = sr.ReadLine();
                        if(line.Contains(userWord))
                        {
                            wordCounter++;
                        }
                        //else
                        //{
                        //    Console.WriteLine("This word does not appear in the file.");
                        //}

                    }
                    Console.WriteLine(sr.ReadToEnd());
                    
                }
            }
            catch (Exception)
            {

                throw new Exception("Darn it. :-( ");
            }
        
            return wordCounter;
        }
    }
}
