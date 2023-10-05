using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "홍길동";
            int age = 18;
            bool isMale = true;
            bool isfemale = false;
            float weight = 70.4f;
            const float height = 170.5f;
            //const float money;

            Console.WriteLine("안녕하세요, 나의 이름은 " + "name " + "이고, 나이는 "+ age +"살입니다, 성별은 남 " + isMale + " 여 " + isfemale + " , " +
                "이며 몸무게는 " + weight +"kg, 키는 "+ weight +"cm입니다 ");

            Console.WriteLine("안녕하세요, 나의 이름은 {0}이고, 나이는 {1} 살입니다, 성별은 남 :{2}, 여{3}, 이며 몸무게는 {4}kg, 키는 {5}cm입니다 ",
                name, age,isMale, isfemale, weight, height);

            Console.WriteLine($"안녕하세요, 나의 이름은 {name}이고, 나이는 {age} 살입니다, 성별은 남 :{isMale}, 여{isfemale}, 이며 몸무게는 {weight}kg, 키는 {height}cm입니다");


            //weight = 64.4f;
            //Console.WriteLine($"아차차 저는 운동을 한달정도 해서 살이빠졋어요 지금 몸무게는 {weight} 입니다!");




            Console.ReadKey();
          
        }
    }
}
