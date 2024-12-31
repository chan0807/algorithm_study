using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class 주식가격
    {
        public int[] solution(int[] prices)
        {
            int[] answer = new int[prices.Count()];

            Stack<int> stkIndex = new Stack<int>();
            for (int i = 0; i < prices.Length; i++)
            {
                while ((stkIndex.Count > 0) && prices[stkIndex.Peek()] > prices[i])
                {
                    int idx = stkIndex.Pop();
                    answer[idx] = i - idx;
                }
                stkIndex.Push(i);
            }




            while (stkIndex.Count > 0)
            {
                int idx = stkIndex.Pop();
                answer[idx] = prices.Length - 1 - idx;
            }

            return answer;
        }
    }
}
