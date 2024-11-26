using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class 프로세스
    {
        /*static void Main()
        {
            Random rd = new Random();
          
            Dictionary<int , int[]> dic = new Dictionary<int, int[]>();
            dic.Add( 2 , new int[] { 2, 1, 3, 2 });
            dic.Add( 0 , new int[] { 1, 1, 9, 1, 1, 1 });
           
            int[] priorities = new int[] {  };

            foreach (var item in dic)
            {
                
               int result = solution(item.Value,item.Key);
            }
            
        }*/

        static public int solution(int[] priorities, int location)
        {
            int[] sortArr = priorities.OrderByDescending(x=>x).ToArray();
            Queue<int> que = new Queue<int>(priorities);
            int i = 0;
            int answer = 0;
      
            while (true)
            {
                
                if (sortArr[i].Equals(que.Peek()))
                {
                    que.Dequeue();
                    i++;
                    answer++;
                    if (location.Equals(0))
                    {
                        return answer;
                    }
                    
                }
                else
                {
                    que.Enqueue(que.Dequeue());
                }

                location = location -1 >= 0 ? location - 1 : que.Count() - 1;
            }
            

            


            return answer;
        }
    }
}
