using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Study
{
    internal class 같은숫자는싫어
    {
        public static int[] function(int[] arr)
        {
            Stack<int> sResult = new Stack<int>();

            foreach (int i in arr)
            {
                if (sResult.Count == 0)
                {
                    sResult.Push(i);
                } else
                {
                    if (!sResult.Peek().Equals(i))
                        sResult.Push(i);
                }                
            }

            return sResult.Reverse().ToArray();
        }

        static void Main(string[] args)
        {
            int[] arr = [1,1,2,3,6,6,6,6,6,6,9,4,4,0,2,3];// [1, 0, 0, 0];// [1, 1];// [1, 2, 3, 4, 5];// [3, 2, 1, 0];// [4, 4, 4, 3, 3]; 
            string[] result = function(arr).Select(i => i.ToString()).ToArray();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
