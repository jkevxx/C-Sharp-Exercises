using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Exercises._05Message
{
    public class Names
    {
        private List<string> _names = new List<string>();

        public void addName(string name)
        {
            _names.Add(name);
        }

        public void showName()
        {
            if (_names.Count == 0)
            {
                Console.WriteLine("");
            }
            else if (_names.Count == 1)
            {
                Console.WriteLine($"{_names[0]} likes your post");
            }
            else if (_names.Count == 2)
            {
                Console.WriteLine($"{_names[0]} and {_names[1]} likes your post");
            }
            else
            {
                Console.WriteLine($"{_names[0]}, {_names[1]} and {_names.Count - 2} others like your post");

            }
        }
    }
}
