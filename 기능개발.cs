using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class 기능개발
    {
        public static void Main()
        {
            int[] progresses = new int[] { 95, 90, 99, 99, 80, 99};
            int[] speeds = new int[] { 1, 1, 1, 1, 1, 1 };
            int[] result = solution(progresses, speeds);
        }
        public static int[] solution(int[] progresses, int[] speeds)
        {
            List<int> answer = new List<int>();
            
            
            Queue<int> que = new Queue<int>();
            
            for (int i = 0; i < progresses.Length; i++)
            {

                int pro = progresses[i];
                int spe = speeds[i];
                int cnt = 0;
                while(pro < 100)
                {
                    pro += spe;
                    cnt++;

                }
                que.Enqueue(cnt);
            }

            while(que.Count > 0)
            {
                int cnt = 1;
                int i = que.Dequeue();
                
                while(que.Count > 0 && que.Peek() <= i)
                {
                    que.Dequeue();
                    cnt++;
                }

                answer.Add(cnt);

            }
            
            
            return answer.ToArray();
        }
    }
}
