using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Babarian baba = new Babarian();
            baba.Run();
            baba.Attack();

            Console.ReadLine();
        }
    }
    class Army
    {
        protected int hp;
        protected int mp;
        protected int moveSpeed;
        protected int attack;

        public virtual void Run()
        {
            Console.WriteLine("이동!");
        }

        public virtual void Attack()
        {
            Console.WriteLine($"공격 ! {attack}");
        }
    }

    class Babarian : Army
    {
        public Babarian()
        {
            hp = 10;
            mp = 10;
            moveSpeed = 1;
            attack = 1;
        }

        public override void Run()
        {
            base.Run();
            Console.WriteLine("Babarian 달리기!");
        }

        public override void Attack()
        {
            base.Attack();
            Console.WriteLine($"Babarian 공격! {attack}");
        }
    }
}
