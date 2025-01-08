using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class 이중우선순위큐
    {
        //static void Main(string[] args)
        //{
        //    string[] operations = new string[] { "I 16", "I -5643", "D -1", "D 1", "D 1", "I 123", "D -1" };
        //    int[] result = solution(operations);
        //}
        public static int[] solution(string[] operations)
        {
            List<int> resultList = new List<int>();
            foreach (string op in operations)
            {
                List<string> opList = op.Split(' ').ToList();
                if (opList.Count < 1)
                    return null;
                if (opList[0].Equals("I"))
                    resultList.Add(int.Parse(opList[1]));
                else
                {
                    if (resultList.Count < 1)
                        continue;

                    if (int.Parse(opList[1]) < 0)
                        resultList.Remove(resultList.Min());
                    else
                        resultList.Remove(resultList.Max());



                }
            }
            int[] answer = new int[] { };
            answer = resultList.Count < 1 ? new int[] { 0, 0 } : new int[] { resultList.Max(), resultList.Min() };
            return answer;
        }
    }
}
