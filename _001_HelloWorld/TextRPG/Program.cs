using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TextRpg
{
    internal class Program
    {

        static void Main(string[] args)
        {
            void Knight()
            {
                int hp = 100;
                int att = 10;
                int def = 5;
                Console.WriteLine($"기사의 HP : {hp}, 기사의 공격력 : {att}, 기사의 방어력 : {def}");
            }

            void Archer()
            {
                int hp = 80;
                int att = 15;
                int def = 2;
                Console.WriteLine($"궁수의 HP : {hp}, 기사의 공격력 : {att}, 기사의 방어력 : {def}");
            }

            void Mage()
            {
                int hp = 50;
                int att = 30;
                int def = 1;
                Console.WriteLine($"마법사의 HP : {hp}, 기사의 공격력 : {att}, 기사의 방어력 : {def}");
            }

            void EnterLobby()
            {
                Console.WriteLine("로비에 접속합니다!");
                Console.WriteLine("[0]필드로 입장 [1]마을로 입장");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        EnterField();
                        break;
                    case "1":
                        EnterContry();
                        break;
                }
            }

            void EnterField()
            {
                CreateMonster();
            }

            void EnterContry()
            {
                Console.WriteLine("마을로 입장!");
            }

            void CreateMonster()
            {
                Console.WriteLine("몬스터 생성!");
                Random rand = new Random();
                int monster = rand.Next(0, 2);

                switch (monster)
                {
                    case 0:
                        CreateSlim();
                        break;
                    case 1:
                        CreateOrc();
                        break;
                    case 2:
                        CreateSkeleton();
                        break;
                }
            }

            void CreateSlim()
            {
                int hp = 10;
                int att = 2;
                int def = 1;
                Console.WriteLine($"슬라임 출현! HP : {hp}, Att : {att}, Def : {def}");
            }

            void CreateOrc()
            {
                int hp = 15;
                int att = 3;
                int def = 1;
                Console.WriteLine($"오크 출현! HP : {hp}, Att : {att}, Def : {def}");
            }
            void CreateSkeleton()
            {
                int hp = 13;
                int att = 4;
                int def = 0;
                Console.WriteLine($"스켈레톤 출현! HP : {hp}, Att : {att}, Def : {def}");
            }

            Console.WriteLine("환엽합니다");
            Console.WriteLine("직업을 선택해주세요! [0]기사 [1]궁수 [2]마법사");

            while (true)
            {

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        Console.WriteLine("기사를 선택하셨군요!");
                        Knight();
                        EnterLobby();
                        break;
                    case "1":
                        Console.WriteLine("궁수를 선택하셨군요!");
                        Archer();
                        EnterLobby();
                        break;
                    case "2":
                        Console.WriteLine("마법사를 선택하셨군요!");
                        Mage();
                        EnterLobby();
                        break;
                    default:
                        Console.WriteLine("[0]기사 [1]궁수 [2]마법사 를 골라주세요");
                        break;
                }

            }


        }

    }



}
