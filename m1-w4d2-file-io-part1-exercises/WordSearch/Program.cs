using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            WordSearch letsCountAWord = new WordSearch();
            //1. Ask the user for the search string
            //2. Ask the user for the file path
            //3. Open the file
            //4. Loop through each line in the file
            //5. If the line contains the search string, print it out along with its line number

            bool isRunning = true;

            while (isRunning)
            {

                Console.Clear();
                Console.WriteLine("Please enter a word:");
                string userWord = Console.ReadLine();

                //Console.WriteLine("Is your search case-sensitive? (y/n)");
                //string yesOrNo = Console.ReadLine();
                //if(yesOrNo == "n")
                //{
                //    userWord.
                //}

                Console.Write("Please enter the file name: ");
                string userFileName = Console.ReadLine();

                Console.WriteLine($"'{userWord}' appears in {userFileName} {letsCountAWord.GetWordCount(userWord, userFileName)} times. ");
                Console.ReadKey();

            }
        }
    }
}
