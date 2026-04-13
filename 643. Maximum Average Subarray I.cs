using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    internal class _643
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            var ans = nums.Take(k);

            var avg = ans.Average();

            double max = ans.Average();

            for (int i = k; i < nums.Length; i++)
            {
                var temp = avg * k - nums[i - k] + nums[i];
                avg = temp / k;
                if (avg > max)
                {
                    max = avg;
                }
            }
            return max;
        }
    }
}
