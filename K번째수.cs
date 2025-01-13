using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class K번째수
    {
        //static void Main(string[] args)
        //{
        //    int[] array = new int[] { 1, 5, 2, 6, 3, 7, 4 };
        //    int[,] commands = new int[,] { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };
        //    int[] result = solution(array, commands);
        //}
        public static int[] solution(int[] array, int[,] commands)
        {
            List<int> answer = new List<int>();
            List<int> arrList = new List<int>(array);
            for (int i = 0; i < commands.GetLength(0); i++)
            {
                int str = commands[i,0]-1;
                int end = commands[i, 1]-1;
                int idx = commands[i, 2]-1;
                answer.Add(arrList.Where((x, index) => index >= str && index <= end ).OrderBy(x=>x).ElementAt(idx));


            }
          
            
            return answer.ToArray();
        }
    }
}
