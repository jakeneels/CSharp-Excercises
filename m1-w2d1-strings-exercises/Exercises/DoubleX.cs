using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return true if the first instance of "x" in the string is 
         immediately followed by another "x".
         doubleX("axxbb") → true
         doubleX("axaxax") → false
         doubleX("xxxxx") → true
         */
        public bool DoubleX(string str)
        {
            
            var xx = str.IndexOf("xx"); // || Regex.IsMatch(str, "^[^x]+xx")
            return xx >= 0 && xx == str.IndexOf('x');
        }
    }
}
