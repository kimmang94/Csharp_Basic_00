using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Data1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            sbyte a = 120;
            byte b = 255;
            short c = 30000;
            long d = 100000;
            ulong f = 10000000;

            Console.WriteLine("sbyte a : " + a);
            Console.WriteLine("byte b : " + b);
            Console.WriteLine("short c : " + c);
            Console.WriteLine("long d : " + d);
            Console.WriteLine("ulong f : " + f);

            // 각 데이터형의 최솟값 최댓값
            Console.WriteLine($"short.MaxValue : {short.MaxValue}, short.MaxValue : {short.MaxValue}");
        }
    }
}
