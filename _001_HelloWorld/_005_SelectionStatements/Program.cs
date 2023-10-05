using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_SelectionStatements
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

            #region If statment
            if (age > 19)
            {
                Console.WriteLine("성인이시군요!");
            }
            else if (age > 19)
            {
                Console.WriteLine("미성년자 이시군요!");
            }
            else
            {
                Console.WriteLine("그럼 대체.. 몇살?");
            }
            #endregion

            #region switch statment
            switch (isMale)
            {
                case true:
                    Console.WriteLine("남성이시군요!");
                    break;
                case false:
                    Console.WriteLine("여성이시군요!");
                    break;
            }
            #endregion

            #region BMI
            //BMI를 이용한 비만도 계산은 자신의 몸무게를 키의 제곱으로 나누는 것으로 공식은 kg/㎡.
            //BMI가 18.5 이하면 저체중 ／ 18.5 ~22.9 사이면 정상 ／ 23.0 ~24.9 사이면 과체중 ／ 25.0 이상부터는 비만으로 판정.
            //ex) 키 170㎝에 몸무게 73kg이면, 계산식: 73 / (1.7×1.7) = 25.26 → 과체중


            float bmi;

            bmi = weight / (1.705f * 1.705f);
            Console.WriteLine(bmi);
            #endregion

            Console.ReadKey();
        }
    }
}
