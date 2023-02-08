using NUnit.Framework;

namespace DailyLeetCode.Problems
{
    public class Day2 : ITest
    {
        /// <summary>
        /// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
        /// </summary>
        bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> result = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (result.Contains(nums[i]))
                {
                    return true;
                }

                result.Add(nums[i]);
            }

            return false;
        }

        public void Test()
        {
            int[] case1 = new int[] { 1, 2, 3, 1 };
            int[] case2 = new int[] { 1, 2, 3, 4 };
            int[] case3 = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

            Assert.AreEqual(true, ContainsDuplicate(case1));
            Assert.AreEqual(false, ContainsDuplicate(case2));
            Assert.AreEqual(true, ContainsDuplicate(case3));
        }
    }
}
