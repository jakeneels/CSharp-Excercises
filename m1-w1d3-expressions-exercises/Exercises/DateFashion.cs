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
        You and your date are trying to get a table at a restaurant.
         The parameter "you" is the stylishness of your clothes, in the range 0..10, and 
         "date" is the stylishness of your date's clothes. 
        The result getting the table is encoded as an int value with 0=no, 1=maybe, 2=yes. 
        1. If either of you is very stylish, 8 or more, then the result is 2 (yes).
        2.  With the exception that if either of you has style of 
        2 or less, then the result is 0 (no). Otherwise the result is 1 (maybe).
        dateFashion(5, 10) → 2
        dateFashion(5, 2) → 0
        dateFashion(5, 5) → 1
        */
        public int DateFashion(int you, int date)
        {
            int happyEnding = 0;
            if(you > 2 && date > 2 )
            {
                happyEnding = 1;
                if (you >= 8 || date >= 8)
                {
                    happyEnding = 2;
                }
            }

            return happyEnding;
        }

    }
}
