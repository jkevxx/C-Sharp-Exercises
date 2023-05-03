using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Exercises._01ValidateNum
{
    public class ValidateNum
    {

        public int ValideType(string a)
        {
            int number;
            if(int.TryParse(a, out number))
            {
                return number;
            }
            number = 0;
            return number;
        }

        public string ValideNumber(int a)
        {
            if(a > 0 && a <= 10)
            {
                return "Valid";
            }
            return "Invalid";
        }
    }
}
