﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given three ints, a b c, 
         return true if b is greater than a, 
         and c is greater than b. However, with 
         the exception that if "bOk" is true, 
         b does not need to be greater than a.
         inOrder(1, 2, 4, false) → true
         inOrder(1, 2, 1, false) → false
         inOrder(1, 1, 2, true) → true
         */
        public bool InOrder(int a, int b, int c, bool bok)
        {
            bool result = false;
            if(bok == false)
            {
                if( (b > a) && (c > b) )
                {
                    result = true;
                }
            }
            else
            {
                if(c > b)
                {
                    result = true;
                }
            }

            return result;
        }

    }
}