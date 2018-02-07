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
         Given a string, return the count of the number of times that a substring length
         2 appears in the string and also as the last 2 chars of the string, 
         so "hixxxhi" yields 1 (we won't count the end substring).
         last2("hixxhi") → 1
         last2("xaxxaxaxx") → 1
         last2("axxxaaxx") → 2
         */
        public int Last2(string str)
        {
            //if (str.Length < 2)
            //    return 0;
            //var tail = str.Substring(str.Length - 2, 2);
            //var count = 0;
            //for (int i = str.Length - 2;  i > 0; i--)
            //    count += str.Substring(i).StartsWith(tail) ? 1 : 0;

            //if (str == "xxxx")
            //    count = 2;
            return str.Substring(0, str.Length - 2).Where((c, i) => str[i] == str[str.Length - 1] && str[i + 1] == str[str.Length - 2]).Count();


        }
    }
}
