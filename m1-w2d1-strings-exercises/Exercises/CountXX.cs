using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Count the number of "xx" in the given string. We'll say that overlapping is allowed,
         so "xxx" contains 2 "xx".
         countXX("abcxx") → 1
         countXX("xxx") → 2
         countXX("xxxx") → 
         */
        public int CountXX(string str)
        {
            int xxCount = 0;
            for (int i = str.Length - 2; i >= 0; i--)
            {
                string snip = "";
                snip += str[i];
                snip += str[i + 1];

                if (snip.Contains("xx"))
                {
                    xxCount++;
                }
            }
            return xxCount;
        }
    }
}
