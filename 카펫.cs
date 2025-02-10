using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class 카펫
    {
        /*static void Main(string[] args)
        {
            int brown = 24;

            int yellow = 24;
            int[] result = solution(brown, yellow);

        }*/
        public static int[] solution(int brown, int yellow)
        {
            int[] answer = new int[2];
            for (int i = 1; i <= (i == 1 ? 1 : yellow / 2); i++)
            {
                if (yellow % i == 0)
                {
                    int w = i;
                    int h = yellow / i;
                    if ((w * 2) + ((h + 2) * 2) == brown)
                    {
                        answer = new int[] { h + 2, w + 2 };
                        break;
                    }
                }
            }
            return answer;
        }
    }
}
