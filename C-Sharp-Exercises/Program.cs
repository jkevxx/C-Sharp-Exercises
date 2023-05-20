

using C_Sharp_Exercises._01ValidateNum;
using C_Sharp_Exercises._02MaxNum;
using C_Sharp_Exercises._03LandPort;
using C_Sharp_Exercises._04SpeedLimit;

namespace C_Sharp_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1° Exercise */
            //Console.WriteLine("Write a number between 1 to 10");

            //int number = ValidateNum.ValideType(Console.ReadLine());
            //if (number != 0)
            //{
            //    ValidateNum validateNum = new ValidateNum(number);
            //    Console.WriteLine(validateNum.ValideNumber());
            //}
            //else
            //{
            //    Console.WriteLine("This is not a number");
            //}

            /* 2° Exercise */
            //Console.WriteLine("Please write a number");
            //int num1 = MaxNum.ValideType(Console.ReadLine());

            //Console.WriteLine("Please write other number");
            //int num2 = MaxNum.ValideType(Console.ReadLine());

            //if (num1 != 0 && num2 != 0)
            //{
            //    MaxNum maxNum = new MaxNum(num1, num2);
            //    maxNum.ValidateMaxNum();
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}

            //Console.WriteLine(num1.GetType());

            /* 3° Exercise */
            //Console.WriteLine("Please write the width");
            //int width = LandscapePortrait.ValideType(Console.ReadLine());

            //Console.WriteLine("Please write the height");
            //int height = LandscapePortrait.ValideType(Console.ReadLine());
            //if(width != 0 && height != 0)
            //{
            //    LandscapePortrait landscapePortrait = new LandscapePortrait(width, height);
            //    landscapePortrait.calculateLandscapePortrait();
            //}else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}

            /* 4° Exercise */
            Console.WriteLine("Please write the speed limit");
            int speedLimit = SpeedLimit.ValideType(Console.ReadLine());

            Console.WriteLine("Please write the speed car");
            int speedCar = SpeedLimit.ValideType(Console.ReadLine());

            if (speedLimit != 0 && speedCar != 0)
            {
                SpeedLimit landscapePortrait = new SpeedLimit(speedLimit, speedCar);
                landscapePortrait.calculateLimit();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}