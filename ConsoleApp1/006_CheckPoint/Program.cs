using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_CheckPoint
{

        class CStudent
        {
            private int id;
            private int kor;
            private int math;
            private int eng;
            private int total;

            public int ID { get { return id; } }
            public int KOR { get {  return kor; } }
            public int MATH { get { return math; } }
            public int ENG { get { return eng; } }
            public int TOTAL { get { return total; } }

            public CStudent (int id, int kor, int math, int eng)
            {
                this.id = id;
                this.kor = kor;
                this.math = math;
                this.eng = eng;
                this.total = kor + math + eng;
            }
        }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<CStudent> listData = new List<CStudent>();
            bool isLoop = true;

            InitData(listData);
            do
            {
                Console.WriteLine("메뉴를 골라주세요");
                Console.Write("(1) ID 정렬 (2) 성적순 정렬 (3) 국어점수 정렬 (4) 점수 검색 (5)특정점수 이상 (5)특정점수 이하 (0) 나가기 ");
                string inputNum = Console.ReadLine();
                switch (inputNum)
                {
                    case "0":
                        Console.WriteLine("프로그램 종료");
                        isLoop = false;
                        break;
                    case "1":
                        break;
                    case "2":
                    break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("다시 입력하세요");
                        break;
                }
                
            } while(isLoop);

            PrintList(listData);
            Console.ReadKey();
        }
        /// <summary>
        /// 학생 데이터를 생성
        /// </summary>
        /// <param name="_listData"></param>
        static void InitData(List<CStudent> _listData)
        {
            Random rd = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                CStudent data = new CStudent(i, rd.Next(0, 100), rd.Next(0, 100), rd.Next(0, 100));
                _listData.Add(data);
            }

        }
        static void PrintList(List<CStudent> _listData)
        {
            Console.WriteLine("ID  KOR  MATH  ENG  TOTAL");
            foreach (var item in _listData)
            {
                Console.WriteLine($"{item.ID},  {item.KOR},  {item.MATH},  {item.ENG},  {item.TOTAL}");
                
            }
        }

        static void SortID(List<CStudent> _listData)
        {
            _listData.Sort(delegate(CStudent a, CStudent b)
            {
                if (a.ID > b.ID)
                {
                    return 1;
                }
                else if (a.ID < b.ID)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            );
        }
    }
}
