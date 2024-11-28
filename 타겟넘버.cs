using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class 타겟넘버
    {
        int NumbersCount = 0;
        int result = 0;
        int target;
        int[] numbers = new int[] { };
        public void Main()
        {

            numbers = new int[] { 4, 1, 2, 1 };
            target = 3;
            int result = solution(numbers, target);
        }

        private int cac(int i, int sum) {

            if (i == numbers.Count())
                return sum == target ? 1 : 0;

            
            int add = cac(i + 1, sum + numbers[i]);
            int subtract = cac(i + 1, sum - numbers[i]);

         
            return add + subtract;
            }

        public int solution(int[] Pnumbers, int Ptarget)
        {
            numbers = Pnumbers;
            target = Ptarget;
            
            



            return cac(0, 0);
        }
    }
}
