using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.App
{
    public class Calculator
    {
        public int Add (string numbers)
        {
            int numInt = 0;

            var parsedNums = numbers.Split(',');

            if (parsedNums.Count() < 1)
            {
                return int.Parse(numbers);
            }
            else
            {
                int sum = 0;
                foreach (string num in parsedNums)
                {
                    bool result = int.TryParse(num, out numInt);

                    if (result)
                    {
                        sum += numInt;
                    }
                    else
                    {
                        return numInt = 0;
                    }
                }
                numInt = sum;
            }
            return numInt;
        }
    }
}
