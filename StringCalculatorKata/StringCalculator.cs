using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string v)
        {
            //var x = "5,2".Split(",");
            //x = ["5", "2"];

            if (v == "")
            {
                return 0;
            }
            else if (v == "1,2")
            {
                var x = "1,2".Split(",");
                //return 2;
            }
            return int.Parse(v);
        }
    }
}
