using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectSwap
{
    class Elephant
    {
        public string Name;
        public int EarSize;

        public void WhoAmI()
        {
            Console.WriteLine($"My name is {Name}.");
            Console.WriteLine($"My ears are {EarSize} inches tall.");
        }
    }
}
