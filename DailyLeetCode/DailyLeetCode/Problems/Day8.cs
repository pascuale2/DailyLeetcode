using NUnit.Framework;

namespace DailyLeetCode.Problems
{
    /// <summary>
    /// Leetcode Problem 9: Palindrome Number
    /// 
    /// Given an integer x, return true if x is a palindrome, and false otherwise.
    /// </summary>
    public class Day8 : ITest
    {
        bool IsPalindrome(int x)
        {
            if (x < 0) { return false; }

            int sum = 0;
            int inputtedNum = x;

            while (x > 0)
            {
                sum = (sum * 10) + (x % 10);
                x /= 10;
            }

            return sum == inputtedNum;
        }

        public void Test()
        {
            int case1 = 121;
            int case2 = -121;
            int case3 = 10;
            int case4 = 123454321;

            Assert.AreEqual(true, IsPalindrome(case1));
            Assert.AreEqual(false, IsPalindrome(case2));
            Assert.AreEqual(false, IsPalindrome(case3));
            Assert.AreEqual(true, IsPalindrome(case4));
        }
    }
}
