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
         Given 2 strings, return their concatenation, except omit the first char of each. The strings will 
         be at least length 1.
         nonStart("Hello", "There") → "ellohere"
         nonStart("java", "code") → "avaode"
         nonStart("shotl", "java") → "hotlava"
         */
        public string NonStart(string a, string b)
        {
            a = a.Remove(0, 1);
            b = b.Remove(0, 1);
            return a+b;
        }
    }
}
