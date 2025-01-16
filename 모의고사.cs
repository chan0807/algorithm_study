using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Study
{
    internal class 모의고사
    {
        public static int[] solution(int[] answers)
        {
            int[] answer = new int[] { };
            List<int> answerList = new List<int>();

            Dictionary<int, int[]> students = new Dictionary<int, int[]>();

            int[] temp1 = { 1, 2, 3, 4, 5 };
            int[] temp2 = { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] temp3 = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

            //students.Add(1, [1, 2, 3, 4, 5]);
            //students.Add(2, [2, 1, 2, 3, 2, 4, 2, 5]);
            //students.Add(3, [3, 3, 1, 1, 2, 2, 4, 4, 5, 5]);
            students.Add(1, temp1);
            students.Add(2, temp2);
            students.Add(3, temp3);

            Dictionary<int, int> studentScore = new Dictionary<int, int>();            

            studentScore.Add(1, 0);
            studentScore.Add(2, 0);
            studentScore.Add(3, 0);

            foreach (KeyValuePair<int, int[]> student in students)
            {
                int name = student.Key;
                int[] value = student.Value;

                int score = 0;

                for (int i = 0; i < answers.Length; i++)
                {
                    if (answers[i] == value[i % value.Length])
                        score++;
                }

                studentScore[name] = score;
            }

            // 정렬
            var scoreSort = studentScore.OrderByDescending(x => x.Value);

            //var firstName = studentScore.OrderByDescending(x => x.Value).First().Key;
            var max = studentScore.OrderByDescending(x => x.Value).First().Value;

            foreach (KeyValuePair<int, int> score in scoreSort)
            {
                if (answerList.Count == 0)
                {
                    answerList.Add(score.Key);
                }
                else
                {
                    if (score.Value == max)
                        answerList.Add(score.Key);
                    else
                        break;
                }                
            }

            answer = answerList.ToArray();            

            return answer;
        }

        static void Main()
        {
            int[] answers = [2, 1, 2, 3, 2, 1, 2];// [1, 3, 2, 4, 2];//[1, 2, 3, 4, 5];

            string[] result = solution(answers).Select(i => i.ToString()).ToArray();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
