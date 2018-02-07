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
         Given a string, return true if it ends in "ly".
         endsLy("oddly") → true
         endsLy("y") → false
         endsLy("oddy") → false
         */
        public bool EndsLy(string str)
        {
            bool result = false;
            string snip = "";

            if (str.Length >= 2)
            {
                snip += str[str.Length - 2];
                snip += str[str.Length - 1];
            }

            if (snip.ToLower().Contains("ly"))
                result = true;

            return result;
        }
    }
}
