using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Study
{
    internal class 미완주선수
    {
        public static string function(String[] participant, String[] completion)
        {
            string result = string.Empty;

            Hashtable htParticipant = new Hashtable();

            // 참석자 명단
            foreach (string parName in participant)
            {
                if (htParticipant.ContainsKey(parName))
                    htParticipant[parName] = int.Parse(htParticipant[parName].ToString()) + 1;    
                else
                    htParticipant.Add(parName, 1);
            }

            // 완주자 차감
            foreach (string comName in completion)
            {
                if(htParticipant.ContainsKey(comName))
                    htParticipant[comName] = int.Parse(htParticipant[comName].ToString()) - 1;
            }

            // 남은 참가자 
            foreach (string parName in htParticipant.Keys)
            {
               int remainNum = int.Parse(htParticipant[parName].ToString());

                if (remainNum == 1)
                {
                    result = parName;
                    break;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            string[] participant = ["mislav", "stanko", "mislav", "ana"];
            string[] completion  = ["stanko", "ana", "mislav"];

            string result = function(participant, completion);

            Console.WriteLine(result);
        }
    }
}
