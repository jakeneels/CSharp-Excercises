using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
        //TotalMarks int X X Gets or sets the total number of correct marks received on the assignment.
        public int TotalMarks { get; set; }

        //PossibleMarks int X readonly Gets the number of possible marks on the assignment.
        public int PossibleMarks { get; }

        //SubmitterName string X readonly Gets or sets the submitters name for the assignment.
        public string SubmitterName { get; }

        //LetterGrade string X Gets the letter grade for the assignment.
        public string LetterGrade
        {
            get
            {
                double grade = ((double)TotalMarks / PossibleMarks) * 100;
                string letterGrade = "NA";
                if (PossibleMarks > 0)
                {
                    if ((grade) >= 90)
                    {
                        letterGrade = "A";
                    }
                    else if ((grade) < 90 &&
                             (grade) >= 80)
                    {
                        letterGrade = "B";
                    }
                    else if ((grade) < 80 &&
                            (grade ) >= 70)
                    {
                        letterGrade = "C";
                    }
                    else if ((grade) < 70 &&
                            (grade) >= 60)
                    {
                        letterGrade = "D";
                    }
                    else if ((grade) < 60)
                    {
                        letterGrade = "F";
                    }

                }
                return letterGrade;
            }

        }


        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            PossibleMarks = possibleMarks;
            SubmitterName = submitterName;
        }

        //PossibleMarks and SubmitterName are readonly properties that can only be set from the constructor.

        //LetterGrade is a derived property that is calculated using totalMarks and possibleMarks.

        //For 90% or greater return "A" 80-89% return "B" 70-79% return "C" 60-69% return "D" otherwise return "F" 
        //hint: PossibleMarks and TotalMarks are integers, what happens when a smaller integer is divided by a larger integer






    }
}