using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort u = 65;
            char c = (char)u;
            Console.WriteLine(u);
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
