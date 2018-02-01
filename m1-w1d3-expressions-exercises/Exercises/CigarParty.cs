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
         When squirrels get together for a party, they like to have cigars. 
         1.A squirrel party is successful
         when the number of cigars is between 40 and 60, inclusive. 
         2.Unless it is the weekend, in which case 
         there is no upper bound on the number of cigars.
         
         cigarParty(30, false) → false
         cigarParty(50, false) → true
         cigarParty(70, true) → true
         */
        public bool CigarParty(int cigars, bool isWeekend)
        {
            bool isSuccess = false;
            if(!isWeekend && cigars >= 40 && cigars <= 60 )
            {
                isSuccess = true;
            }
            else if (isWeekend && cigars >= 40)
            {
                isSuccess = true;
            }
            return isSuccess;
        }

    }
}
