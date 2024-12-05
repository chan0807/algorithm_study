using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class 게임_맵_최단거리
    {
        /*static void Main()
        {

           
            int[,] a = new int[,] {
                                     {1, 0, 1, 1, 1},
                                     {1, 0, 1, 0, 1},
                                     {1, 0, 1, 1, 1},
                                     {1, 1, 1, 0, 1},
                                     {0, 0, 0, 0, 1}
                                  };

            int result = solution(a);

       }*/

       
        public static int solution(int[,] maps)
        {
           

            int rows = maps.GetLength(0);
            int cols = maps.GetLength(1);
            bool[,] visited = new bool[rows, cols];


            int[] dx = { 1, -1, 0, 0 };
            int[] dy = { 0, 0, 1, -1 };


            
            Queue<(int x, int y, int distance)> queue = new Queue<(int, int, int)>();
            queue.Enqueue((0, 0, 1));
            visited[0, 0] = true;

            while (queue.Count > 0)
            {
                var (x, y, distance) = queue.Dequeue();


                if (x == rows - 1 && y == cols - 1)
                {
                    return distance;
                }


                for (int i = 0; i < 4; i++)
                {
                    int nx = x + dx[i];
                    int ny = y + dy[i];


                    if (nx < 0 || ny < 0 || nx >= rows || ny >= cols || visited[nx, ny] || maps[nx, ny] == 0)
                    {
                        continue;
                    }

                    //방문여부 
                    visited[nx, ny] = true;
                    //방문정보입력
                    queue.Enqueue((nx, ny, distance + 1));
                }
            }


            return -1;
        }
        }
    }

