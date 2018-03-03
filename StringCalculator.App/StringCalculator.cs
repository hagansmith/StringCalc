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
            int numInt;
            
            bool result = int.TryParse(numbers, out numInt);
            if (result)
            {
                return numInt;
            }
            else
            {
              return numInt = 0;
            }
            
        }
    }

    //public class Add
    //{
    //    public string Numbers { get; set; }
    //}

}
