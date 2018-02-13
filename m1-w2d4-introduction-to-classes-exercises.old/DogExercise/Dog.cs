using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechElevator.Classes;

namespace DogExercise
{
    class Dog
    {
        public bool IsSleeping { get; private set; }
        public Dog() => IsSleeping = false;

        private string MakeSound() => (IsSleeping) ? "woof!" : "Zzzzz...";
        private void Sleep() => IsSleeping = true;
        private void WakeUp() => IsSleeping = false;

    }
}
