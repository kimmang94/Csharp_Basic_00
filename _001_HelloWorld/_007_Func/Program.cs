using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Func
{
    internal class Program
    {

        static int AddParam(int c, int d)
        {
            int sum = c + d;
            return sum;
        }

        static int AddNoneParam()
        {
            int c = 0;
            int d = 0;
            int sum = c + d;
            return sum;
        }

        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            int c = 4;
            int d = 5;



            int Add()
            {
                int sum = a + b;
                return sum;
            }


            int add = AddNoneParam();

            Console.WriteLine(add);

            Console.ReadLine();


        }


    }
}
