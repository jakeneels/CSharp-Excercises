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
         Given a List of string, return a new list in reverse order of the original. One obvious solution is to
         simply loop through the original list in reverse order, but see if you can come up with an alternative
         solution. (Hint: Think LIFO (i.e. stack))
         reverseList( ["purple", "green", "blue", "yellow", "green" ])  -> ["green", "yellow", "blue", "green", "purple" ]
         reverseList( ["jingle", "bells", "jingle", "bells", "jingle", "all", "the", "way"} )
            -> ["way", "the", "all", "jingle", "bells", "jingle", "bells", "jingle"]
         */
        public List<string> ReverseList(List<string> objectList)
        {
            Stack<string> stk = new Stack<string>();
            foreach (var obj in objectList)
            {
                stk.Push(obj);
            }
            objectList.Clear();
            foreach (var obj in stk)
            {
                objectList.Add(obj);
            }

            return objectList;
        }

    }
}
