using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class 체육복
    {
        //static void Main(string[] args)
        //{

        //    int n = 2;
        //    int[] lost = new int[] { 2, 4 };
        //    int[] reserve = new int[] { 3};
        //    int result = solution(n, lost, reserve);

        //}
        public static int solution(int n, int[] lost, int[] reserve)
        {

            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < n ; i++)
            {
                int st = i + 1;
                int item = 1;
                if (lost.Where(x => x.Equals(st)).Any() && reserve.Where(x => x.Equals(st)).Any())
                {
                    dic.Add(i, item);
                    continue;
                }

                if (lost.Where(x => x.Equals(st)).Any())
                    item = 0;
                else if (reserve.Where(x => x.Equals(st)).Any())
                    item = 2;
                else
                    item = 1;
                dic.Add(i, item);
            }
            for (int i = 0; i < dic.Count; i++)
            {
                if (dic[i].Equals(0))
                {

                    if (i > 0 && dic[i - 1] > 1)
                    {
                        dic[i - 1] --;
                        dic[i] ++;
                    }
                    else if (i < n-1&& dic[i + 1] > 1)
                    {
                        dic[i + 1]--;
                        dic[i]++;
                    }
                }
            }
            
            
            return dic.Where(x=>x.Value > 0).Count();
        }
    }
}
