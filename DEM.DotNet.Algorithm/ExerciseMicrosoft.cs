using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEM.DotNet.Algorithm
{
    internal class ExerciseMicrosoft
    {
        //Solution solution = new Solution();
        //solution.solution(4500);

        //int[] A = { 3, 2, 1, 2, 3, 1 };

        //solution.solution3(A);

        public void solution1(int N)
        {
            //N = Convert.ToInt32(N.ToString().TrimEnd(new Char[] { '0' }));
            int enable_print = N % 10;
            while (N > 0)
            {
                if (enable_print == 0 && N % 10 != 0)
                {
                    enable_print = 1;
                }
                else if (enable_print == 1)
                {
                    Console.Write(N % 10);
                }
                N = N / 10;
            }
        }

        public int solution3(int[] A)
        {
            // Initialize variable to find the minimum element
            int min = int.MaxValue;

            // Find minimum element in array A
            foreach (int i in A)
            {
                if (min > i)
                    min = i;
            }

            // Initialize variable to find the maximum element
            int max = int.MinValue;

            // Find maximum element in array A
            foreach (int i in A)
            {
                if (max < i)
                    max = i;
            }

            // minimum steps
            int minSteps = Math.Min(max, min);

            //int minSteps = Math.Max(max, - min);

            // Print the minimum steps
            Console.WriteLine(minSteps);
            return 1;
        }
    }
}
