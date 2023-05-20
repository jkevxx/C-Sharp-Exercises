using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Exercises._04SpeedLimit
{
    public class SpeedLimit
    {
        private readonly int _speedLimit;
        private readonly int _speedCar;
        public SpeedLimit(int speedLimit, int speedCar) {
            _speedLimit = speedLimit;
            _speedCar = speedCar;
        }

        public void calculateLimit ()
        {
            if (_speedCar <= _speedLimit) {
                Console.WriteLine("Ok");
            }
            else 
            {
                int demerit = (_speedCar - _speedLimit) / 5;
                Console.WriteLine("Demirit points: "+ demerit);

                if(demerit > 12) Console.WriteLine("License Suspended");
            }
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
