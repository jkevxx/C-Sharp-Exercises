using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Exercises._01ValidateNum
{
    public class ValidateNum
    {
        private readonly int _num;
        public ValidateNum(int num) { 
            _num = num;
        }

        public static int ValideType(string a)
        {
            int number;
            if(int.TryParse(a, out number))
            {
                return number;
            }
            number = 0;
            return number;
        }

        public string ValideNumber()
        {
            if(_num > 0 && _num <= 10)
            {
                return "Valid";
            }
            return "Invalid";
        }
    }
}
