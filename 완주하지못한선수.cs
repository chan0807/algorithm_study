using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class 완주하지못한선수
    {
        /*public static void Main()
        {
            //string[] participant = new string[] { "leo", "kiki", "eden" };
            //string[] completion = new string[] { "eden", "kiki" };
            //string[] participant = new string[] { "marina", "josipa", "nikola", "vinko", "filipa" };
            //string[] completion =  new string[]  {"josipa", "filipa", "marina", "nikola" };
            string[] participant = new string[] {"mislav", "stanko", "mislav", "ana"};
            string[] completion = new string[] {"stanko", "ana", "mislav"};

            string result = solution(participant, completion);
        }*/
        public static String solution(String[] participant, String[] completion)
        {
            List<string> parList = new List<string>(participant);

            foreach (string item in completion)
            {
                parList.Remove(item);
            }

            return string.IsNullOrEmpty(parList.FirstOrDefault()) ? string.Empty : parList.FirstOrDefault();
        }
    }
}
