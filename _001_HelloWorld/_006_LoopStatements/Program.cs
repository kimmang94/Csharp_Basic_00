using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_LoopStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 18;
            int money = 15;
            /*
            for (int i = 0; i < age; i++)
            {
                Console.WriteLine(i);
            }
            */


            while (money <= age)
            {
              
                Console.WriteLine("돈과 나이가같다니!");
                money++;
            }

            Console.ReadKey();
        }
    }
}
