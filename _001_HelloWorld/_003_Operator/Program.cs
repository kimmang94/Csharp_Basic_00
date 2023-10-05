using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int plus = a + b;
            int minus = b - a ;
            int mutiply = a * b;
            int divide = b / a;
            int remain0 = b % a;
            float remain1 = b % a;

            Console.WriteLine("plus : " + a + b);
            Console.WriteLine("minus : " + (b - a));
            Console.WriteLine("mutiply : " + (a * b));
            Console.WriteLine("divide : " + (b / a));
            Console.WriteLine("remain : " + (a % b));

            string c = "Hello";
            string d = "World";

            Console.WriteLine("string형 c 와 d를 더하면? : " + c + d);
            Console.WriteLine("Hello " + d);

            Console.ReadKey();
        }
    }
}
