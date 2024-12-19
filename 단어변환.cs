using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class 단어변환
    {
        /*static void Main()
        {
            int[] prices = new int[] { 1, 2, 3, 2, 3 };
            int[] result = solution(prices);
        }*/

        public int solution(string begin, string target, string[] words)
        {
            //int answer = 0;
            Queue<string> wordsQue = new Queue<string>(words);

            if (!wordsQue.Contains(target))
                return 0;

         
            List<string> visitList = new List<string>();
            return DFS(begin , target , words, visitList , 0);
            

             
        }

        private int DFS(string begin, string target, string[] words, List<string> visitList , int step)
        {
            
            if (begin.Equals(target))
                return step;

            visitList.Add(begin);
            
            foreach (string word in words)
            {

                
                if(!visitList.Contains(word) && strConvert(begin, word))
                {
                    int result = DFS(word, target, words, visitList, step++);

                }
                
            }
            

            return;
              
        }

        private bool strConvert(string str, string target)
        {
            List<char> charList = target.ToList();
            int cnt = 0;
            foreach (char chr in str)
            {
                if (!charList.Contains(chr))
                {
                    cnt++;
                }

                if (cnt > 1)
                    return false;
            }
           
            

            return true;
        }
    }

    
}
