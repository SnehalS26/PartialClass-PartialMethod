using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial
{
    public partial class Calc
    {
        public int Multiply(int a, int b)
        {
            Sub(a, b);
            return a * b;

        }
        // no need to write access specifier
        // by default it is private, this method can not have any return type, only void is allowed
        // we can use any other method to make a call to the partial method
        partial void Sub(int a, int b)
        {
            Console.WriteLine($"Sub= { a - b}");
        }
        // helper method to give a call to sub
        public void Display(int a, int b)
        {
            Sub(a, b);
        }

    }
}
