using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    public class Question
    {
        public string Text { get; set; }
        public int CorrectAnswerIndex { get; set; }
        public List<string> Answers { get; set; } = new List<string>();

        public string ListAnswers()
        {
            return $"1. {Answers[1]}\n2. {Answers[2]}\n3. {Answers[3]}\n4. {Answers[4]}";

        }
        //METHODS
        
    }
}
