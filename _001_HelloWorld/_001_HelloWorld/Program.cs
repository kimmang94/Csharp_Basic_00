﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("Hello World : " + args[0]);
            }
            else
            {
                Console.WriteLine("Hello World : agrs.Length = 0");
            }

            Console.ReadKey();
        }
    }
}
