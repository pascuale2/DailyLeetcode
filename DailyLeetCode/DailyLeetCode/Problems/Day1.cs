using NUnit.Framework;

namespace DailyLeetCode.Problems
{
    /// <summary>
    /// Leetcode Problem 1: Two Sum Problem
    /// 
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// 
    /// You can return the answer in any order.
    /// </summary>
    public class Day1 : ITest
    {
        /// <summary>
        /// Psuedo Code Solution:
        /// 
        /// if nums is Empty or only has one element:
        ///     return empty_array;
        ///    
        /// Construct Dictionary of key int and value int
        /// dict<int, int> 
        /// 
        /// from i to arr.Length:
        ///     if dict has the converse value (meaning target - arr[i], eg. 9 - 7)
        ///         return [dict[target - arr[i], i];
        ///     elif dict does not have key
        ///         dict.Add();
        /// </summary>
        int[] TwoSum(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2) { return new int[2]; }

            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(target - nums[i]))
                {
                    return new int[2] { dic[target - nums[i]], i };
                }
                else if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], i);
                }
            }

            return new int[2];
        }

        public void Test()
        {
            int[] case1 = new int[] { 2, 7, 11, 15 };
            int[] case2 = new int[] { 3, 2, 4 };
            int[] case3 = new int[] { 3, 3 };

            Assert.AreEqual(new int[] { 0, 1 }, TwoSum(case1, 9));
            Assert.AreEqual(new int[] { 1, 2 }, TwoSum(case2, 6));
            Assert.AreEqual(new int[] { 0, 1 }, TwoSum(case3, 6));
        }
    }
}
