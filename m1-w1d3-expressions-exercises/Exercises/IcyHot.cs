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
         Given two temperatures, 
         return true if one is less than 0 and the other is greater than 100.
         icyHot(120, -1) → true
         icyHot(-1, 120) → true
         icyHot(2, 120) → false
         */
        public bool IcyHot(int temp1, int temp2)
        {
            bool result = false;
            if( ( temp1 > 100 && temp2 < 0 ) || ( temp1 < 0 && temp2 > 100 ) )
            {
                result = true;
            }
            return result;
        }

    }
}
