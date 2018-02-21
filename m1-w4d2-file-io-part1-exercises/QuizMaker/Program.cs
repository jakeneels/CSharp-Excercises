using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    public class Program
    {
        static void Main(string[] args)
        {
            Quiz jakesQuiz = new Quiz();
            jakesQuiz.PopulateQuiz();
            int userScore = 0;

            Console.WriteLine("Starting quiz");

            for (int i = 0; i < jakesQuiz.QuizList.Count; i++)
            {
                int userAns = 0;
                Console.WriteLine(jakesQuiz.PrintQuestion(i));
                int.TryParse(Console.ReadLine(), out userAns);
                if (userAns == jakesQuiz.QuizList[i].CorrectAnswerIndex)
                {
                    userScore++;
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Boo000000!");
                }
                Console.WriteLine("press any key");
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine($"You got {userScore}/{jakesQuiz.MaxScore} Correct. you can do better! cmon srsly");
            Console.ReadKey();
        }
    }

}
