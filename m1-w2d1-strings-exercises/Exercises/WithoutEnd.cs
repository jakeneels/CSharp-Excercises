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
         Given a string, return a version without the first and last char, so "Hello" yields "ell". 
         The string length will be at least 2.
         withoutEnd("Hello") → "ell"
         withoutEnd("java") → "av"
         withoutEnd("coding") → "odin"
         */
        public string WithoutEnd(string str)
        {
            string result = "";
            for (int i = 1; i < str.Length - 1; i++)
            {
                result += str[i];
            }
            return result;
        }
    }
}
