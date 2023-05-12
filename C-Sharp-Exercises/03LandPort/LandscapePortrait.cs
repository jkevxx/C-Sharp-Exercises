using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Exercises._03LandPort
{
    public class LandscapePortrait
    {
        private readonly int _width;
        private readonly int _height;

        public LandscapePortrait(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public void calculateLandscapePortrait()
        {
            if(_width > _height)
            {
                Console.WriteLine("The image is Landscape");
            }else if(_height > _width)
            {
                Console.WriteLine("The image is Portrait");
            }
            else
            {
                Console.WriteLine("The image is Square");
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
