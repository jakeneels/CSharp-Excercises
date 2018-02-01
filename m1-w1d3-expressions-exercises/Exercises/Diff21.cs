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
         1.Given an int n, return the absolute difference between n and 21, 
         except 
         2.return double the absolute 
         difference if n is over 21.
         diff21(19) → 2
         diff21(10) → 11
         diff21(21) → 0
         */
        public int Diff21(int n)
        {
            int answer = 0;
            if(n > 21)
            {
                answer = 2*(n - 21);
            }
            else
            {
                answer = (21 - n);
            }
            return answer;
        }
    }
}
