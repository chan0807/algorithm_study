using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class 같은숫자는싫어
    {
     /*   public static void Main()
        {
            int[] arr = new int[] { 1, 1, 3, 3, 0, 1, 1 };
            int[] result = solution(arr);
        }*/
        public static int[] solution(int[] arr)
        {
            Queue<int> que = new Queue<int>(arr);
            Stack<int> resultStack = new Stack<int>();
            
            while (que.Count > 0)
            {
                int i = que.Dequeue();
                if (resultStack.Count < 1)
                    resultStack.Push(i);
                if(!resultStack.Peek().Equals(i))
                    resultStack.Push(i);

            }
             
            // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.



            return resultStack.ToArray();
        }
    }
}
