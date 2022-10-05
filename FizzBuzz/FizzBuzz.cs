using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
        class FizzBuzz
        {
        public string answer;
        public string CheckFizzBuzz(int numtocheck)
        {
            if (numtocheck % 3 == 0  & numtocheck % 5 == 0)
            {
                var answer = "FizzBuzz";
                return answer;
            }
            if (numtocheck % 3 == 0 & numtocheck % 5 != 0)
                {
                var answer = "Fizz";
                return answer;
                }
            if (numtocheck % 5 == 0 & numtocheck % 3 != 0)
            {
                
                
                
                var answer = "Buzz";
                
                
                
                
                return answer;
            }
            else 
            {
                var answer = numtocheck.ToString();
                return answer;
            }

        }
        }
           
   
}
