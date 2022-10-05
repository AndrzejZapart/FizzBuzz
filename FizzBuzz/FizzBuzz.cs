using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        public string CheckFizzBuzz(int numtocheck)
        {
            if (numtocheck % 3 == 0 & numtocheck % 5 == 0)
            {
                return "FizzBuzz";

            }
            if (numtocheck % 3 == 0 & numtocheck % 5 != 0)
            {
                return "Fizz";

            }
            if (numtocheck % 5 == 0 & numtocheck % 3 != 0)
            {
                return "Buzz";
            }
            else
            {
                return numtocheck.ToString();

            }

        }
    }


}
