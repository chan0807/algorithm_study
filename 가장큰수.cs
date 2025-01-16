using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class 가장큰수
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 30, 34, 5, 9 };
            string reulst = solution(numbers);
        }
        public static string solution(int[] numbers)
        {
            Array.Sort(numbers, (i, j) => {
                string ij = i.ToString() + j.ToString();
                string ji = j.ToString() + i.ToString();
                return ji.CompareTo(ij);
            });
            if (numbers[0] == 0)
                return "0";


            return string.Join("", numbers);
        }
    }
}
