using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Study
{
    internal class 체육복
    {
        public static int solution(int n, int[] lost, int[] reserve)
        {
            int answer = 0;

            Array.Sort(lost);
            Array.Sort(reserve);

            int lostCnt = lost.Length;

            answer = n - lostCnt;

            int startNum = 0;

            foreach(int lostNo in lost)
            {
                foreach (int reserveNo in reserve)
                {
                    if (lostNo == reserveNo)
                    {
                        answer++;
                        lost = lost.Where(x => x != lostNo).ToArray();
                        reserve = reserve.Where(x => x != reserveNo).ToArray();
                        break;
                    }                   
                }
            }

            for (int i = 0; i < lost.Length; i++)
            {
                for (int j = startNum; j < reserve.Length; j++)
                {
                    if (lost[i] == reserve[j] + 1 || lost[i] == reserve[j] - 1)
                    {
                        answer++;
                        startNum = j + 1;
                        break;
                    }
                   
                }
            }

            return answer;
        }

        static void Main()
        {
            int n =5;
            int[] lost = [2, 3];// [1,3,4]; //{ 2, 4 }; //{ 3 };// { 2, 4 };
            int[] reserve = [3, 4]; //[1,2,3];//{ 3};// { 1 }; //{ 3 };//{ 1, 3, 5 };

            int result = solution(n, lost, reserve);

            System.Console.WriteLine(result.ToString());
        }
    }
}
