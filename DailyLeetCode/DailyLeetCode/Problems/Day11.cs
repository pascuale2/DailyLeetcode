using NUnit.Framework;

namespace DailyLeetCode.Problems
{
    public class Day11 : ITest
    {
        int BinarySearch(int[] nums, int target)
        {
            int LP = 0;
            int RP = nums.Length - 1;

            while (LP <= RP)
            {
                int mid = (LP + RP) / 2;

                if (target > nums[mid])
                {
                    LP = mid + 1;
                }
                else if (target < nums[mid])
                {
                    RP = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }

        public void Test()
        {
            int[] testArr = { -1, 0, 3, 5, 9, 12 };

            Assert.AreEqual(-1, BinarySearch(testArr, 2));
            Assert.AreEqual(0, BinarySearch(testArr, -1));
            Assert.AreEqual(4, BinarySearch(testArr, 9));
            Assert.AreEqual(5, BinarySearch(testArr, 12));
        }
    }
}
