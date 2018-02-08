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
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").  
         * 
         * The animal name should be case insensitive so "elephant", "Elephant", and 
         * "ELEPHANT" should all return "herd". 
         * 
         * If the name of the animal is not found, null, or empty, return "unknown". 
         * 
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * animalGroupName("giraffe") → "Tower"
         * animalGroupName("") -> "unknown"         
         * animalGroupName("walrus") -> "unknown"
         * animalGroupName("Rhino") -> "Crash"
         * animalGroupName("rhino") -> "Crash"
         * animalGroupName("elephants") -> "unknown"
         * 
         */
        public string AnimalGroupName(string animalName)
        {
            var animals = new Dictionary<string, string>();
            animals.Add("rhino",        "Crash");
            animals.Add("giraffe",      "Tower");
            animals.Add("elephant",     "Herd");
            animals.Add("lion",         "Pride");
            animals.Add("crow",         "Murder");
            animals.Add("pigeon",       "Kit");
            animals.Add("flamingo",     "Pat");
            animals.Add("deer",         "Herd");
            animals.Add("dog",          "Pack");
            animals.Add("crocodile",    "Float");
            string result = "";
            bool exists = animals.TryGetValue(animalName.ToLower(), out result);

            return exists ? result : "unknown";
        }
    }
}
