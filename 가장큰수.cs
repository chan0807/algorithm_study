using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Study
{
    internal class 가장큰수
    {
        public static string solution(int[] numbers)
        {
            string answer = string.Empty;
            StringBuilder sb = new StringBuilder();

            Array.Sort(numbers, (x, y) => string.Compare(y.ToString() + x.ToString(), x.ToString() + y.ToString()));
            //Array.Sort(numbers, (x, y) => string.Compare(x.ToString() + y.ToString(), y.ToString() + x.ToString())); // 작은 숫자 순

            //foreach (int number in numbers)
            //    sb.Append(number.ToString());

            // 이게 더 빠름
            for (int i = 0; i < numbers.Count(); i++)
                sb.Append(numbers[i].ToString());
             
            answer = sb.ToString();

            if (answer.StartsWith("0"))
                answer = "0";

            return answer;
        }

        static void Main()
        {
            int[] numbers = [6, 10, 2];// [1, 10, 100, 1000];// [1213, 12];// [1010, 1];// [547, 54, 5]; // [6, 10, 2];//[3, 30, 34, 5, 9];
            string result = solution(numbers);

            Console.WriteLine(result);

        }
    }
}
