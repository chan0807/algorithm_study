using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class 올바른괄호
    {
        public bool solution(string s)
        {
            bool answer = true;
            List<char> charList = new List<char>();
            charList = s.ToList();
            int count1 = new int();
            int count2 = new int();

            foreach (char item in charList)
            {
                if (charList.IndexOf(item).Equals(0) && item.Equals(')'))
                    return answer = false;

                if (item.Equals('('))
                    count1++;





                if (item.Equals(')'))
                    count2++;

                if (count1 < count2)
                    return answer = false;
            }
            if (!count1.Equals(count2))
                return answer = false;
            return answer;
        }
    }
}
