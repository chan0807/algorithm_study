using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class 최소직사각형
    {
        //static void Main(string[] args)
        //{
        //    int[,] sizes = new int[,] { { 60, 50 }, { 30, 70 }, { 60, 30 }, { 80, 40 } };
        //    int result = solution(sizes);
        //}
        public static int solution(int[,] sizes)
        {
            int maxWidth = 0;  
            int maxHeight = 0; 

            

            
            for (int i = 0; i < sizes.GetLength(0); i++)
            {
                
                int w = sizes[i, 0];
                int h = sizes[i, 1];

                
                int rw = Math.Max(w, h);
                int rh = Math.Min(w, h);

                maxWidth = Math.Max(maxWidth, rw);
                maxHeight = Math.Max(maxHeight, rh);
            }

         
            return maxWidth * maxHeight;

        }

        
    }
}
