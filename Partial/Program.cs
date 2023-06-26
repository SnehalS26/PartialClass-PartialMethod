using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            int c=calc.Addition(1, 1);
            int c1= calc.Substraction(10,5);
            int c2 = calc.Add(10, 5);
            int c3 = calc.Multiply(10,5);
            Console.WriteLine($"Addition = {c}");
            Console.WriteLine($"Substraction = {c1}");
            Console.WriteLine($"Add ={c2}");
            Console.WriteLine($"Multiplication= {c3}");
            calc.Display(20, 10);
            
        }
    }
}
