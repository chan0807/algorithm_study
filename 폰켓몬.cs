using System.Collections;

namespace Algorithm_Study
{
    internal class 폰켓몬
    {
        private static int Test(int[] nums)
        {
            int maxCnt = nums.Length / 2;
            int cnt = 0;

            Hashtable mons = new Hashtable();

            foreach (int num in nums)
            {
                if (mons.ContainsKey(num))
                    mons[num] = int.Parse(mons[num].ToString()) + 1;   // 그냥 추가함     
                else
                    mons.Add(num, 1);
            }

            if (maxCnt > mons.Count)
                cnt = mons.Count;
            else
                cnt = maxCnt;

            return cnt;
        }

        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 3, 5, 2, 4, 1, 1};

            int result = Test(nums);

            Console.WriteLine(result);

        }
    }
}
