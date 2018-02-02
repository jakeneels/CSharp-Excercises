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
         You are driving a little too fast, and a police officer stops you. Write code to compute the result, 
         encoded as an int value: 0=no ticket, 1=small ticket, 2=big ticket. If speed is 60 or less, the 
         result is 0. 
         
         1. Unless it is your birthday -- on that day, speed - 5
         2. If speed is between 61 and 80 inclusive, the result is 1.
         3. If speed is 81 or more, the result is 2. 

         caughtSpeeding(60, false) → 0
         caughtSpeeding(65, false) → 1
         caughtSpeeding(65, true) → 0


         */
        public int CaughtSpeeding(int speed, bool isBirthday)
        {
            int ticket = 0;

            if(isBirthday)
            {
                speed -= 5;
            }
            if(speed > 61)
            {
                ticket = 1;
                if(speed > 81)
                {
                ticket = 2;
                }
            }
        
            return ticket;
        }

    }
}