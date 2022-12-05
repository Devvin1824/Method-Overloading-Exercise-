using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Methods
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool amountMoney)
        {
            int sum = num1 + num2;
            if (amountMoney == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (amountMoney == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (amountMoney == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            } 
            
        }
    }
}
