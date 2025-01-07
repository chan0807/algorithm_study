using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm_Study
{
    public class Solution
    {
        public class Job
        {
            public int requestTime;
            public int taskTime;

            public Job(int requestTime, int taskTime)
            {
                this.requestTime = requestTime;
                this.taskTime = taskTime;
            }
        }

        public static int solution(int[,] jobs)
        {
            int result = 0;

            // 요청시간순 정렬
            List<Job> jobList = new List<Job>();    
            for (int i = 0; i < jobs.GetLength(0); ++i)
            {
                Job job = new Job(jobs[i, 0], jobs[i, 1]);
                jobList.Add(job);
            }

            jobList.Sort((a, b) =>
            {
                int requestTime = a.requestTime - b.requestTime;
                if (requestTime == 0)
                    return a.taskTime - b.taskTime;
                return requestTime;
            });

            // 작업순서 우선순위 처리
            int endTime = 0;

            while(jobList.Count > 0)
            {
                Job priorityJob = null;

                for (int i = 0; i < jobList.Count; ++i)
                {
                    if (jobList[i].requestTime > endTime)
                        break;

                    if (priorityJob == null)
                        priorityJob = jobList[i];
                    else
                    {
                        int priorityTime = priorityJob.taskTime - jobList[i].taskTime;

                        if(priorityTime > 0)
                            priorityJob = jobList[i];
                    }                                        
                }
                                
                if(priorityJob == null)
                    priorityJob = jobList[0];

                // 계산
                int delay = endTime - priorityJob.requestTime; // -이면 작업 쉬는 시간, +이면 대기 시간 존재  
                int totalTime = 0;

                if (delay >= 0)
                {
                    totalTime = delay + priorityJob.taskTime;
                    endTime += priorityJob.taskTime;
                }
                else
                {
                    totalTime = priorityJob.taskTime;
                    endTime += Math.Abs(delay) + priorityJob.taskTime;
                }
                               
                result += totalTime;

                jobList.Remove(priorityJob);
            }

            return result / jobs.GetLength(0);          
        }

        static void Main()
        {
            int[,] jobs = { {0, 3},  {1, 9}, {3, 5} };

            int result = solution(jobs);

            Console.WriteLine(result);

        }
    }
}
