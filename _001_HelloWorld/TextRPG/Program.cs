﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TextRpg
{
    internal class Program
    {
        enum ClassType
        {
            None = 0,
            Knight = 1,
            Archer = 2,
            Mage = 3,
        }

        static void Main(string[] args)
        {
            ClassType choice = ClassType.None;

            while (true) 
            { 
                Console.WriteLine("직업을 선택하세요");
                Console.WriteLine("[1] 기사");
                Console.WriteLine("[1] 궁수");
                Console.WriteLine("[1] 마법사");

                string input = Console.ReadLine();

                switch (input) 
                {
                    case "1":
                        choice = ClassType.Knight;
                        break;
                    case "2":
                        choice = ClassType.Archer;
                        break;
                    case "3":
                        choice = ClassType.Mage;
                        break;
                }

                if (choice != ClassType.None) 
                {
                    break;
                }
            }
        }


    }
}
