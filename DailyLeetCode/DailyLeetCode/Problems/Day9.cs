using NUnit.Framework;

namespace DailyLeetCode.Problems
{
    /// <summary>
    /// Leetcode Problem 7: Reverse Integer
    /// 
    /// Given a signed 32-bit integer x, return x with its digits reversed.
    /// If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
    /// Assume the environment does not allow you to store 64-bit integers(signed or unsigned).
    /// </summary>
    public class Day9 : ITest
    {
        int Reverse(int x)
        {
            bool isNegative = x < 0;
            if (isNegative)
            {
                x *= -1;
            }

            int rev = 0;
            int rem = 0;
            while (x != 0)
            {
                rem = x % 10;

                if (rev <= Int32.MinValue / 10 || rev >= Int32.MaxValue / 10)
                {
                    return 0;
                }

                rev = (rev * 10) + rem;
                x /= 10;
            }

            return isNegative
                ? -rev
                : rev;
        }

        public void Test()
        {
            int case1 = 123;
            int case2 = -123;
            int case3 = 120;

            Assert.AreEqual(321, Reverse(case1));
            Assert.AreEqual(-321, Reverse(case2));
            Assert.AreEqual(21, Reverse(case3));
        }
    }
}
