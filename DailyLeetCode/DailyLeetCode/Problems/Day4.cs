using NUnit.Framework;

namespace DailyLeetCode.Problems
{
    /// <summary>
    /// Leet Code Problem 53: Maximum Subarray
    /// 
    /// Given an integer array nums, find the subarray with the largest sum, and return its sum.
    /// </summary>
    public class Day4 : ITest
    {
        int MaxSubArray(int[] nums)
        {
            if (nums.Length == 0) { return 0; }

            // Using Kadane's Algorithm
            int maxSum = nums[0];
            int curSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                curSum = Math.Max(curSum, 0);
                curSum += nums[i];
                maxSum = Math.Max(curSum, maxSum);
            }

            return maxSum;
        }

        public void Test()
        {
            int[] case1 = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int[] case2 = new int[] { 1 };
            int[] case3 = new int[0];
            int[] case4 = new int[] { 5, 4, -1, 7, 8 };

            Assert.AreEqual(6, MaxSubArray(case1));
            Assert.AreEqual(1, MaxSubArray(case2));
            Assert.AreEqual(0, MaxSubArray(case3));
            Assert.AreEqual(23, MaxSubArray(case4));
        }
    }
}
