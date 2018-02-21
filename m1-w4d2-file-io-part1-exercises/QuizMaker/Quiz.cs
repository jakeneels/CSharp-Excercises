using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
   public class Quiz
    {
        public List<Question> QuizList = new List<Question>();
        public int FinalScore { get; set; }
        public int MaxScore
        {
            get => QuizList.Count;
        }

        public string PrintQuestion(int i)
        {
            return $"{QuizList[i].Text}?\n{QuizList[i].ListAnswers()}";
        }

        public void PopulateQuiz()
        {
            Question tempQuestion;
            string directory = Environment.CurrentDirectory + "\\..\\../TestQuestionsAndAnswers.txt";
            try
            {
                using (StreamReader sr = new StreamReader(directory))
                {
                    string[] splitQuestion;
                    string[] answers;
                    while (!sr.EndOfStream)
                    {
                        tempQuestion = new Question();
                        string line = sr.ReadLine();
                        splitQuestion = line.Split('?');        //splitting all
                        tempQuestion.Text = splitQuestion[0];      //i0 is question

                        answers = splitQuestion[1].Split('|'); // splitting answers
                        tempQuestion.Answers.AddRange(answers);

                        for (int i = 0; i < answers.Length; i++)
                        {
                            if (answers[i].Contains('*'))
                            {
                                tempQuestion.CorrectAnswerIndex = i;
                                tempQuestion.Answers[i] = answers[i].Replace("*","");
                            }
                        }
                        QuizList.Add(tempQuestion);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
