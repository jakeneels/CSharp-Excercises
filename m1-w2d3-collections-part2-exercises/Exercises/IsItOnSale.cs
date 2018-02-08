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
         * Given an string representing an item number (a.k.a. SKU), return the discount
         * percentage if the item is on sale.
         * If the item is not on sale, return 0.00.
         * 
         * If the item number key doesnt exist, return 0.00.
		 * Dictionary to start with
         * "KITCHEN4001" -> 0.20
         * "GARAGE1070" -> 0.15
         * "LIVINGROOM"	-> 0.10
         * "KITCHEN6073" -> 0.40
         * "BEDROOM3434" -> 0.60
         * "BATH0073" -> 0.15
         * The item number should be case insensitive so "kitchen4001", "Kitchen4001","
         * isItOnSale("kitchen4001") → 0.20
         * isItOnSale("") → 0.00
         * isItOnSale("GARAGE1070") → 0.15
         * isItOnSale("dungeon9999") → 0.00 
         */
        public double IsItOnSale(string itemNumber)
        {
            var inv = new Dictionary<string, double>();
            inv.Add("KITCHEN4001", 0.20);
            inv.Add("GARAGE1070", 0.15);
            inv.Add("LIVINGROOM", 0.10);
            inv.Add("KITCHEN6073", 0.40);
            inv.Add("BEDROOM3434", 0.60);
            inv.Add("BATH0073", 0.15);

            double sale = 0;
            if (inv.ContainsKey(itemNumber.ToUpper()))
                sale = inv[itemNumber.ToUpper()];
            else
                sale = 0;

            return sale;
        }
    }
}
