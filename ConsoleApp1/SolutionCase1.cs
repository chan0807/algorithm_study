using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SolutionCase1
    {
        //같은 숫자는 싫어
        public int[] solution2(int[] arr)
        {
            int[] answer = new int[] { } ;
            List<int> numList = new List<int>();
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (numList.Where(x => x.Equals(arr[i])).Any())
                    continue;
                numList.Add(arr[i]);
            }
            answer = numList.ToArray();
            


            return answer;
        }

        //기능개발
        public int[] solution1(int[] progresses, int[] speeds)
        {
            int[] answer = new int[] { };
            List<int> timeTable = new List<int>();

            //작업시간을 구한다
            for (int i = 0; i < progresses.Length; i++)
            {
                int time = new int();
                int progresse = progresses[i];
                int speed = speeds[i];

                while (progresse >= 100)
                {
                    progresse += speed;
                    time++;
                }

                timeTable.Add(time);
            }

            for (int i = 0; i < timeTable.Count;)
            {

                int count = 1;
                int max = timeTable[i];

                for (int y = i; y <= timeTable.Count;)
                {
                    if (max >= timeTable[y])
                    {
                        count++;

                    }
                    else
                    {
                        break;
                    }


                }

                i += count;
                answer.Append(count);
            }


            return answer;
        }

        //올바른 괄호
        public bool solution3(string s)
        {
            bool answer = true;
            List<char> charList = new List<char>();
            charList = s.ToList();
            int count1 = new int();
            int count2 = new int();

            foreach (char item in charList)
            {
              

                if (item.Equals('('))
                    count1++;

                if (item.Equals(')'))
                    count2++;

                //)역전되는 순간 틀림
                if(count1< count2)
                    return answer = false;
            }
            if(!count1.Equals(count2))
                return answer = false;
            return answer;
        }
    }
    


 
}
