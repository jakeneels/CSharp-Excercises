﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string and an int n, return a string made of the first and last n chars from the string.
         The string length will be at least n.
         nTwice("Hello", 2) → "Helo"
         nTwice("Chocolate", 3) → "Choate"
         nTwice("Chocolate", 1) → "Ce"
         */
        public string NTwice(string str, int n)
        {
            string first = "";
            string last = "";
            for (int i = 0; i <= n-1; i++)
            {
                first += str[i];
            }
            for (int i = str.Length - n ; i < str.Length; i++)
            {
                last += str[i];
            }

            return first + last;
        }
    }
}
