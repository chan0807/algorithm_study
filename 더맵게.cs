using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Study
{
    internal class 더맵게
    {
        public static int function(int[] scoville, int k)
        {           
            int result = 0;
            int[] aResult = scoville;            

            // c#은 PriorityQueue가 없음
            Queue<int> q = new Queue<int>();
            
            Array.Sort(aResult);

            foreach (int i in aResult)
            {
                q.Enqueue(i);
            }

            while (q.Peek() < k)
            {
                if (q.Count < 2) return -1;

                int first = q.Dequeue();
                int second = q.Dequeue();
                                
                int newScoville = first + (second * 2);

                q.Enqueue(newScoville);

                aResult = q.ToArray();
                Array.Sort(aResult);

                q = new Queue<int>();

                foreach (int i in aResult)
                    q.Enqueue(i);

                result++;
            }                        

            return result;
        }

        static void Main()
        {
            int[] scoville = [1, 1, 2, 6];// [1, 1, 2, 2, 6]; // [2, 3];// [1, 1, 1, 1, 1]; // [0, 0, 5, 5, 5];//  [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]; // [1, 2, 3]; // [13, 14, 15, 16, 17]; //[3, 4, 5, 6, 7];// [5, 5, 5, 5, 5]; // [1, 1]; // [1, 2, 3, 9, 10, 12];
            int k = 30;// 4;// 7;// 3;// 2;//7;//  45;// 0;//10; // 4; //7;

            int result = function(scoville, k);

            Console.WriteLine(result);
        }
    }
}

