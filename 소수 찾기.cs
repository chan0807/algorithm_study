using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class 소수_찾기
    {
        public int solution(string numbers)
        {
           
            HashSet<int> allNumbers = new HashSet<int>();
            GeneratePermutations("", numbers, allNumbers);

            
            int primeCount = 0;
            foreach (int number in allNumbers)
            {
                if (IsPrime(number))
                    primeCount++;
            }

            return primeCount;
        }

        
        private void GeneratePermutations(string current, string remaining, HashSet<int> result)
        {
            if (!string.IsNullOrEmpty(current))
            {
                result.Add(int.Parse(current));
            }

            for (int i = 0; i < remaining.Length; i++)
            {
                string next = current + remaining[i];
                string rest = remaining.Substring(0, i) + remaining.Substring(i + 1);
                GeneratePermutations(next, rest, result);
            }
        }

        
        private bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
