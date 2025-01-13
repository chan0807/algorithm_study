using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Algorithm_Study
{
    internal class k번째수
    {
        public static int[] solution(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.GetLength(0)];

            for(int i = 0; i < commands.GetLength(0); i++)
            {
                int startIndex = commands[i, 0] - 1;
                int endIndex = commands[i, 1];
                int resultIndex = commands[i, 2] - 1;

                int length = endIndex - startIndex;

                int[] resultArray = new int[length];

                Array.Copy(array, startIndex, resultArray, 0, length);

                Array.Sort(resultArray);

                answer[i] = resultArray[resultIndex];
            }

            return answer;
        }

        //static void Main()
        //{
        //    int[] array = [1, 5, 2, 6, 3, 7, 4];
        //    int[,] commands = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };

        //    int[] result = solution(array, commands);

        //    string answer = string.Empty;

        //    foreach (int i in result)
        //    {
        //        if (string.IsNullOrEmpty(answer))
        //            answer = i.ToString();
        //        else
        //            answer += "," + i.ToString();
        //    }

        //    Console.WriteLine(answer);

        //}
    }
}
