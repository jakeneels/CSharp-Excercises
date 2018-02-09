using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Company
    {
        public string Name { get; private set; }
        public int NumberOfEmployees { get; set; }
        public decimal Revenue { get; set; }
        public decimal Expenses { get; set; }

        public Company(string startingName)
        {
            Name = startingName;
        }

        public string GetCompanySize()
        {
            string companySize = "large";
            if (NumberOfEmployees < 50)
            { companySize = "small"; }
            if (NumberOfEmployees < 250 && NumberOfEmployees >= 50)
            { companySize = "medium"; }

            return companySize;
        }
        public decimal GetProfit() => Revenue - Expenses;
    }
}
