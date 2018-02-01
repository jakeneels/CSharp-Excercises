using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {


        /*
         Your cell phone rings. Return true if you should answer it. 
         1. not in the morning 
         2. if you are asleep, you do not answer.
                  you only answer if it is your mom calling. In all cases, 

         answerCell(false, false, false) → true
         answerCell(false, false, true) → false
         answerCell(true, false, false) → false
         */
        public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {

            bool answer = true;

            if (isAsleep)
            {
                answer = false;
            }
            else if (isMorning && !isMom) 
            {
                answer = false;
            }
           
            return answer;
        }
    }
}
