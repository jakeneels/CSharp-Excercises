using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartExercise
{
    class ShoppingCart
    {
        public int TotalNumberOfItems {get; private set;}
        public decimal TotalAmountOwed { get; private set; }

        private decimal GetAveragePricePerItem() => TotalAmountOwed / TotalNumberOfItems;
        private void AddItems( int numberOfItems, decimal pricePerItem)
        {
            TotalNumberOfItems = numberOfItems;
            TotalAmountOwed = (pricePerItem * numberOfItems);
        }
        private void Empty()
        {
            TotalNumberOfItems = 0;
            TotalAmountOwed = 0;
        }


    }
}
