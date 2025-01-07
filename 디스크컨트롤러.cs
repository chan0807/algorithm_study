using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class 디스크컨트롤러
    {
        static void Main(string[] args)
        {
            int[,] jobs = new int[,] { { 10, 100 }, { 50, 34 }, { 81, 2 } };
            int result = solution(jobs);
        }
        public static int solution(int[,] jobs)
        {
            Queue<(int idx, int strTm, int tm)> waitQue = new Queue<(int idx, int strTm, int tm)>();
            int totTm = 0;
            List<int> resultList = new List<int>();
            for (int i = 0; i < jobs.GetLength(0); i++)
            {
                waitQue.Enqueue((i, jobs[i, 0], jobs[i, 1]));
            }
            //작업의 소요시간이 짧은 것, 작업의 요청 시각이 빠른 것, 작업의 번호가
            waitQue = new Queue<(int idx, int strTm, int tm)>(waitQue.OrderBy(x => x.tm).ThenBy(x => x.strTm).ThenBy(x => x.idx));


          

            while (waitQue.Count > 0)
            {
                int resultTm = 0;
                var vo = waitQue.Dequeue();
                if (vo.strTm > totTm)
                {
                    resultTm = vo.tm;
                    totTm = vo.strTm + vo.tm;
                }
                else
                {
                    resultTm = totTm - vo.strTm + vo.tm ;
                    totTm += vo.tm; 
                }
                
                resultList.Add(resultTm);



            }
            return resultList.Sum() / resultList.Count;
            
        }
    }
}
