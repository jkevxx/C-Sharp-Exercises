

using C_Sharp_Exercises._01ValidateNum;

namespace C_Sharp_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* First Exercise */
            string test;
            Console.WriteLine("Write a number between 1 to 10");

            test = Console.ReadLine();
            
            ValidateNum validateNum = new ValidateNum();
            int number = validateNum.ValideType(test);
            if (number != 0)
            {
                Console.WriteLine(validateNum.ValideNumber(number));

            }else
            {
                Console.WriteLine("This is not a number");
            }
        }
    }
}