using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class 피로도
    {
        static void Main(string[] args)
        {

        }
        public int solution(int k, int[,] dungeons)
        {
            int n = dungeons.GetLength(0); 
            int maxCount = 0; 

            
            Queue<Tuple<int, List<int>>> queue = new Queue<Tuple<int, List<int>>>();

            
            queue.Enqueue(new Tuple<int, List<int>>(k, new List<int>()));

            while (queue.Count > 0)
            {
                Tuple<int, List<int>> current = queue.Dequeue();
                int currentFatigue = current.Item1;
                List<int> visited = current.Item2;

                maxCount = Math.Max(maxCount, visited.Count); 

                
                for (int i = 0; i < n; i++)
                {
                    if (!visited.Contains(i))
                    {
                        int minFatigue = dungeons[i, 0];
                        int consumeFatigue = dungeons[i, 1];

                        
                        if (currentFatigue >= minFatigue)
                        {
                            List<int> nextVisited = new List<int>(visited);
                            nextVisited.Add(i);
                            queue.Enqueue(new Tuple<int, List<int>>(currentFatigue - consumeFatigue, nextVisited));
                        }
                    }
                }
            }

            return maxCount;
        }
    }
}
