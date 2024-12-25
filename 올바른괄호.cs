using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Study
{
    internal class 올바른괄호
    {
        public static bool function(string s)
        {
            bool result = true;
            Queue<string> qResult = new Queue<string>();

            foreach(char c in s)
            {
                if(c.Equals('('))
                    qResult.Enqueue("(");
                else if (c.Equals(')'))
                {
                    if (qResult.Count < 1)
                    {
                        result = false;
                        break;
                    }

                    qResult.Dequeue();
                }
            }

            if(qResult.Count > 0)
                result = false;

            return result;
        }

        //static void Main()
        //{
        //    string s = "())(()"; // "())("; // "(()))";//"())(()";// "())((()))(()";// "(";//")))";//"(()(";// ")()("; // "(())()"; //"()())";

        //    Console.WriteLine(function(s));            
        //}
    }
}
