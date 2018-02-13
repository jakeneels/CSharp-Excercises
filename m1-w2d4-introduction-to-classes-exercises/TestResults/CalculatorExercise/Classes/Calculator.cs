using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// Represents a "simple" calculator
    /// </summary>
    public class Calculator
    {
        public int Result { get; private set; }

        public Calculator(int startingResult) => Result = startingResult;
        public int Add(int addend) => Result += addend;
        public int Subtract(int subtrahend) => Result -= subtrahend;
        public int Multiply(int multiplier) => Result *= multiplier;
        public int Power(int exponent) => Result = (int)Math.Pow(Result, exponent);

        public void Reset() => Result = 0;

    }
}
