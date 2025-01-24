using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Algorithm_Study
{
    internal class 소수찾기
    {
        public static List<int> list = new List<int>();

        public static int solution(string numbers)
        {
            int answer = 0;
            bool[] boolArray = new bool[numbers.Length];
            char[] charArray = new char[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                boolArray[i] = false; // 방문 배열
                charArray[i] = numbers[i]; // 숫자 조각
            }

            DFS(boolArray, charArray, "");

            foreach (int num in list)
            {
                if (CalcPrime(num))
                    answer++;
            }

            return answer;

        }
                
        public static void DFS(bool[] boolArray, char[] charArray, string str)
        {
            if (str.Length == boolArray.Length)
                return;

            for (int i = 0; i < boolArray.Length; i++)
            {
                if (boolArray[i])
                    continue;

                boolArray[i] = true;
                DFS(boolArray, charArray, str + charArray[i]);
                boolArray[i] = false;

                int reuslt = Int32.Parse(str + charArray[i]);

                if (!list.Contains(reuslt))
                    list.Add(reuslt);
            }
        }

        public static bool CalcPrime(int num)
        {
            if (num <= 1) 
                return false;

            int root = (int)Math.Sqrt(num);

            for (int i = 2; i <= root; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

        //static void Main()
        //{
        //    string numbers = "33";

        //    string result = solution(numbers).ToString();

        //    Console.WriteLine(result);
        //}
    }
}
