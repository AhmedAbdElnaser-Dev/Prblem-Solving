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

            int windowSum = 0;
            for (int i = 0; i < k; i++)
            {
                windowSum += nums[i];
            }

            int maxSum = windowSum;

            for (int i = k; i < nums.Length; i++)
            {
                windowSum += nums[i] - nums[i - k];
                maxSum = Math.Max(maxSum, windowSum);
            }

            return (double)maxSum / k;
        }
    }
}
