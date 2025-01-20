using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class 모의고사
    {
     
        static void Main(string[] args)
        {
            int[] answers = new int[] { 1, 3, 2, 4, 2 };
            int[] result = solution(answers);
        }
        public static int[] solution(int[] answers)
        {
            Dictionary<int, int> result = new Dictionary<int, int> { { 1, 0 }, { 2, 0 }, { 3, 0 } };
            
            Queue<int> que1 = new Queue<int>(new int[]{ 1, 2, 3, 4, 5 });
            Queue<int> que2 = new Queue<int>(new int[] { 2, 1, 2, 3, 2, 4, 2, 5 });
            Queue<int> que3 = new Queue<int>(new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 });

            
           
            foreach (int item in answers)
            {
                int q1 = que1.Dequeue();
                int q2 = que2.Dequeue();
                int q3 = que3.Dequeue();

                que1.Enqueue(q1);
                que2.Enqueue(q2);
                que3.Enqueue(q3);
                if (q1.Equals(item))
                    result[1] += 1;
                if (q2.Equals(item))
                    result[2] += 1;
                if (q3.Equals(item))
                    result[3] += 1;

            }
            
            return result.Where(x => x.Value.Equals(result.Values.Max())).Select(x => x.Key).OrderBy(x => x).ToArray();
        }
    }
}
