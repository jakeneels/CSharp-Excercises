using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given an array of strings, return a Dictionary<string, Boolean> 
         * where each different string is a key and value
         * is true only if that string appears 2 or more times in the array.
         * 
         * wordMultiple(["a", "b", "a", "c", "b"]) → {"b": true, "c": false, "a": true}
         * wordMultiple(["c", "b", "a"]) → {"b": false, "c": false, "a": false}
         * wordMultiple(["c", "c", "c", "c"]) → {"c": true}
         * 
         */
        public Dictionary<string, bool> WordMultiple(string[] words)
        {
            var dict = new Dictionary<string, bool>();
            
            foreach (var word in words)
            {
                int count = 0;
                foreach (var word1 in words)
                {
                    if(word1 == word)
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    dict.Remove(word);
                    dict.Add(word, true);
                }
                else
                    dict.Add(word, false);   
            }
                return dict; 
        }
    }
}
