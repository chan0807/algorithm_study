using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Study
{
    internal class 피로도
    {
        public static int solution(int k, int[,] dungeons)
        {
            int answer = 0;

            bool[] boolArray = new bool[dungeons.GetLength(0)];

            for(int i = 0; i < dungeons.GetLength(0); i++)            
                boolArray[i] = false;

            DFS(k, dungeons, boolArray, 0, ref answer);

            return answer;
        }

        public static void DFS(int k, int[,] dungeons, bool[] boolArray, int cnt, ref int answer)
        {
            for(int i = 0;i < dungeons.GetLength(0); i++)
            {
                if (boolArray[i] || dungeons[i, 0] > k)
                    continue;

                boolArray[i] = true;
                DFS(k - dungeons[i, 1], dungeons, boolArray, cnt +1, ref answer);
                boolArray[i] = false;
            }

            answer = Math.Max(answer, cnt);
        }


        //static void Main()
        //{
        //    int k = 80;
        //    int[,] dungeons = { { 80, 20 }, { 50, 30 }, { 30, 10 } };

        //    string result = solution(k, dungeons).ToString();

        //    Console.WriteLine(result);
        //}
    }
}
