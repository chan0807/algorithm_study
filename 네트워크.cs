using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class 네트워크
    {
        public static void Main(string[] args)
        {
            int n = 3;

            int[,] computers = new int[,] { { 1, 1, 0 }, { 1, 1, 0 }, { 0, 0, 1 } };
            int answer = solution(n,computers);
        }

        public static int solution(int n, int[,] computers)
        {
            bool[] visit = new bool[n];
            int answer = 0;

            for (int i = 0; i < n; i++)
            {
                if (!visit[i])
                { 
                    DFS(i, n, computers, visit);
                    answer++;
                }
            }



            return answer;
        }

        public static void DFS(int i, int n, int[,] computers, bool[] visit)
        {
            visit[i] = true; 

            for (int j = 0; j < n; j++)
            {
                
                if (computers[i, j] == 1 && !visit[j])
                {
                    DFS(j, n, computers, visit); 
                }
            }
        }
    }
}
