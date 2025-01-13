using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Study
{
    internal class 이중우선순위큐
    {
        public class Solution
        {
            public static int[] solution(string[] operations)
            {
                int[] answer = new int[] { };

                List<int> numList = new List<int>();

                for(int i = 0; i < operations.Count(); i++)
                {
                    if (operations[i].StartsWith("I"))
                    {
                        string[] strNum = operations[i].Split(' ');
                        int num = int.Parse(strNum[1]);

                        numList.Add(num);
                    }

                    if (numList.Count > 0)
                    {
                        if (operations[i].Equals("D 1"))
                        {
                            if (numList.Count < 1) return [0, 0];

                            numList.RemoveAt(numList.IndexOf(numList.Max()));
                        }
                        else if (operations[i].Equals("D -1"))
                        {
                            if (numList.Count < 1) return [0, 0];

                            numList.RemoveAt(numList.IndexOf(numList.Min()));
                        }
                    }
                }             

                if (numList.Count < 1)
                    answer = [0, 0];
                else
                    answer = [numList.Max(), numList.Min()];

                return answer;
            }

            static void Main()
            {
                string[] operations = { "D 1", "I 1207", "I 3471", "I 3574", "I -5575", "D -1", "D 1", "D 1", "D -1", "D -1", "D -1", "I 8088", "D 1", "I 5585", "I 9097", "I -6416", "D 1", "D -1" }; //{ "D 1", "I 1207", "I 3471", "I 3574", "I -5575", "D -1", "D 1", "D 1", "D -1", "D -1", "D -1", "I 8088", "D 1", "I 5585", "I 9097", "I -6416", "D 1", "D -1" };// { "I 1", "I 2", "I 3", "I 4", "I 5", "I 6", "I 7", "I 8", "I 9", "I 10", "D 1", "D -1", "D 1", "D -1", "I 1", "I 2", "I 3", "I 4", "I 5", "I 6", "I 7", "I 8", "I 9", "I 10", "D 1", "D -1", "D 1", "D -1" }; //{ "I 10", "I 20", "D 1", "I 30", "I 40", "D -1", "D -1" };// { "I 2", "I 3", "D -1", "I 1", "D 1" };// { "I 2", "I 4", "D 1", "I 4", "D -1", "D 1", "I 4", "D - 1", "I 3", "D -1", "D 1", "I 2", "I 1", "D 1", "D -1", "I 0", "D 1", "D -1", "D 1", "I 0", "I 3", "D 1", "D -1", "D -1", "D 1", "D 1", "D 1", "D -1", "I 4", "D -1", "I 1", "D -1", "D -1", "D 1", "D 1", "D 1", "D -1", "I 2", "D 1", "I 2", "I 2", "D -1", "D 1", "D -1", "I 1", "D 1", "D -1", "I 3", "D 1", "D -1" };// { "I 5", "I 3", "I 7", "I 6", "D 1", "D -1", "D -1" }; // { "I 100", "I 100", "D 1" }; ;// ["I -45", "I 653", "D 1", "I -642", "I 45", "I 97", "D 1", "D -1", "I 333"];//["I 16", "I -5643", "D -1", "D 1", "D 1", "I 123", "D -1"];

                int[] result = solution(operations);

                Console.WriteLine("[" + result[0] + ", " + result[1] + "]");

            }
        }
    }
}

//{"I 1", "I 2", "I 3", "I 4", "I 5", "I 6", "I 7", "I 8", "I 9", "I 10", "D 1", "D -1", "D 1", "D -1", "I 1", "I 2", "I 3", "I 4", "I 5", "I 6", "I 7", "I 8", "I 9", "I 10", "D 1", "D -1", "D 1", "D -1"}


//{ "D 1","I 1207","I 3471","I 3574","I -5575","D -1","D 1","D 1","D -1","D -1","D -1","I 8088","D 1","I 5585","I 9097","I -6416","D 1","D -1"}
