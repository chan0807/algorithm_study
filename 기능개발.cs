using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Study
{
    internal class 기능개발
    {        
        public static string[] function(double[] progresses, double[] speeds)
        {
            Queue<int> qDays = new Queue<int>();         // 배포까지 남은 일 수 
            Queue<string> qResult = new Queue<string>(); // 결과

            for (int i = 0; i < progresses.Length; i++) 
            {
                // 배포까지 남은 일 수 구하기
                int days = Convert.ToInt32((Math.Ceiling((100 - progresses[i]) / speeds[i])));

                qDays.Enqueue(days);
            }

            Queue<int> pDaysCopy = new Queue<int>(); // Queue 복사본

            while (qDays.Count > 0)
            {
                // Queue 복사
                pDaysCopy = new Queue<int>(qDays);

                int cnt = 0;
                int standard = pDaysCopy.Peek(); // 첫번째 수

                foreach (int compareNo in pDaysCopy)
                {
                    if (standard >= compareNo)
                    {
                        cnt++;
                        qDays.Dequeue();
                    }
                    else
                        break;
                }                
                
                qResult.Enqueue(cnt.ToString());
            }

            return qResult.ToArray();
        }

        //static void Main(string[] args)
        //{
        //    double[] progresses = [90, 98, 97, 96, 98];// [85, 88, 87];// [55, 60, 65];// [93, 30, 55, 60, 40, 65];// [90, 90, 90, 90];// [95, 90, 99, 98, 80, 99];// [99, 99, 99, 90, 90, 90];// [1, 1, 1, 1];// [96, 94];// [99, 98];// [99, 96, 94];// [98, 99, 98];// [98, 99, 97, 98];// [95, 94, 93];//[95, 95, 95, 95];// [40, 20, 30, 20]; // [70,20,50,40, 99, 88];// [93, 30, 55]; //[95, 90, 99, 99, 80, 99];
        //    double[] speeds = [1, 1, 1, 1, 1];// [1, 1, 1];// [5, 10, 7];// [1, 30, 5, 10, 60, 7];// [30, 1, 1, 1];// [1, 1, 1, 1, 1, 1];// [1, 1, 1, 1, 1, 1];// [100, 50, 99, 100];//[3, 3];// [1, 1];// [1, 3, 4]; // [1, 1, 1];// [1, 1, 1, 1];// [3, 3, 3];// [4, 3, 2, 1]; //[1, 1, 1, 1];//[1, 5, 3, 1, 1, 3]; // [1, 30, 5]; // [1, 1, 1, 1, 1, 1];

        //    string[] result = function(progresses, speeds);
        //    Console.WriteLine(string.Join(",", result));
        //}
    }
}
