using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class 폰켓몬
    {
        
        /*public static void Main()
        {
            //int[] nums = new int[] { 3, 1, 2, 3 };
            int[] nums = new int[] { 3, 3, 3, 2, 2, 4 };
            //int[] nums = new int[] { 3, 3, 3, 2, 2, 2 };
            int result = solution(nums);
        }*/
        public static int solution(int[] nums)
        {
            int maxInt = (nums.Count() / 2);
            

            HashSet<int> hsNums = new HashSet<int>(nums);
            return maxInt <= hsNums.Count() ? maxInt : hsNums.Count();
        }
    }
}
