using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class 더맵게
    {
        //static void Main()
        //{
        //    int[] scoville = new int[] { 3, 5 };
        //    int K = 7;
        //    int result = solution(scoville, K);
        //}
        public static int solution(int[] scoville, int K)
        {
            List<int> scoList = new List<int>(scoville);
            int answer = 0;
            while (scoList.Count > 1 && scoList.Min() < K)
            {
                int min = scoList.Min();
                scoList.Remove(scoList.Min());
                int secMin = scoList.Min();
                scoList.Remove(scoList.Min());
                int result = min + (secMin * 2);
                scoList.Add(result);
                answer++;
            }
     
            return scoList.Where(x=> x < K).Any() ? -1 :  answer;
        }
    }
}
