using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Exercises._02MaxNum
{
    public class MaxNum
    {
        private readonly int _num1;
        private readonly int _num2;

        public MaxNum(int num1, int num2) {
            _num1 = num1;
            _num2 = num2;
        }

        public void ValidateMaxNum()
        {
            int max = (_num1 > _num2) ? _num1 : _num2;
            Console.WriteLine("The max number is: {0}", max);

            //if ( _num1 > _num2)
            //{
            //    Console.WriteLine("The max number is: "+ _num1);
            //}else
            //{
            //    Console.WriteLine("The max number is: "+ _num2);
            //}
        }

        public static int ValideType(string a)
        {
            int number;
            if (int.TryParse(a, out number))
            {
                return number;
            }
            number = 0;
            return number;
        }
    }
}
