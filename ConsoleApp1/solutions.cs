using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class solutions
    {
        public int[] solution(int[] array, int[,] commands)
        {


            int[] answer = new int[commands.GetLength(0)];


            List<int> numList = new List<int>(array);



            for (int s = 0; s < commands.GetLength(0); s++)
            {
                int i = commands[s, 0];
                int j = commands[s, 1];
                int k = commands[s, 2];

                List<int> dataList = numList.Where((x, index) => index >= i - 1 & index < j).OrderBy(x => x).ToList();
                answer[s] = dataList[k - 1];


            }

            return answer;

        }
    
    }
}
