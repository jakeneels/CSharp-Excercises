using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class FruitTree
    {
        public string TypeOfFruit { get; }

        public int PiecesOfFruitLeft { get; private set; }

        public bool PickFruit(int NumberOfPiecesToRemove)
        {
            bool result = false;
            if (PiecesOfFruitLeft > 0)
            {
                PiecesOfFruitLeft -= NumberOfPiecesToRemove;
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        public FruitTree(string typeOfFruit, int startingPiecesOfFruit)
        {
            PiecesOfFruitLeft = startingPiecesOfFruit;
            TypeOfFruit = typeOfFruit;

        }
    }
}