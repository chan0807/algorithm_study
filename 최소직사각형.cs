using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Study
{
    internal class 최소직사각형
    {
        public static int solution(int[,] sizes)
        {
            int answer = 0;

            int length = sizes.GetLength(0);

            int[] largeNo = new int[length];
            int[] smallNo = new int[length];

            for (int i = 0; i < length; i++)
            {
                if (sizes[i, 0] > sizes[i, 1])
                {
                    largeNo[i] = sizes[i, 0];
                    smallNo[i] = sizes[i, 1];
                }
                else
                {
                    largeNo[i] = sizes[i, 1];
                    smallNo[i] = sizes[i, 0];
                }
            }

            Array.Sort(largeNo);
            Array.Sort(smallNo);

            answer = largeNo[length-1] * smallNo[length - 1];

            return answer;
        }

        //static void Main()
        //{
        //    int[,] sizes = { { 60, 50 }, { 30, 70 }, { 60, 30 }, { 80, 40 } };

        //    int result = solution(sizes);

        //    Console.WriteLine(result);
        //}
    }
}
