using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Study
{
    internal class 카펫
    {
        public static int[] solution(int brown, int yellow)
        {
            int[] answer = new int[2];

            int addxy = 2 + (brown / 2); // x+y = 2 + (b/2)
            int xy = brown + yellow; // x, y의 최소값은 3

            int x = 0;
            int y = 0;

            for(y = 3; y <= addxy / 2; y++)
            {
                x = addxy - y;

                if (xy == x * y)
                {
                    answer[0] = x;
                    answer[1] = y;
                }                    
            }

            return answer;
        }

        static void Main()
        {
            int brown = 10;
            int yellow = 2;

            string[] result = solution(brown, yellow).Select(i => i.ToString()).ToArray();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
