using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Study
{
    internal class 주식가격
    {
        public static int[] function(int[] prices)
        {
            int[] result = new int[prices.Length];
            Stack<int> stack = new Stack<int>();

            for(int i = 0; i < prices.Length; i++)
            {
                while (stack.Count > 0 && prices[i] < prices[stack.Peek()])
                {
                    result[stack.Peek()] = i - stack.Peek();
                    stack.Pop();
                }

                stack.Push(i);
            }

            while (stack.Count > 0)
            {
                result[stack.Peek()] = prices.Length - stack.Peek() - 1;
                stack.Pop();
            }

            return result;
        }

        static void Main()
        {
            int[] prices = [1, 2, 3, 2, 3];// [1, 2, 3, 2, 1]; // [1, 2, 3, 2, 3];

            string[] result = function(prices).Select(i => i.ToString()).ToArray();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
