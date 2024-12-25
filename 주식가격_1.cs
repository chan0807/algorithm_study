using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Study
{
    internal class 주식가격_1
    {
        public static int[] function(int[] prices)
        {
            int[] result = new int[prices.Length];
            Queue<int> qResult = new Queue<int>();

            for(int i = 0; i <prices.Length; i++)
            {
                int standard = prices[i];
                int count = 0;

                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (standard <= prices[j])
                    {
                        count++;
                    }
                    else
                    {
                        count++;
                        break;
                    }
                }

                qResult.Enqueue(count);
            }            

            result = qResult.ToArray();

            return result;
        }

        //static void Main()
        //{
        //    int[] prices = [1, 2, 3, 2, 3];// [1, 2, 3, 2, 1]; // [1, 2, 3, 2, 3];

        //    string[] result = function(prices).Select(i => i.ToString()).ToArray();

        //    Console.WriteLine(string.Join(", ", result));
        //}
    }
}
