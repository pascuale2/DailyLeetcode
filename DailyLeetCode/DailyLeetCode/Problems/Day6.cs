using NUnit.Framework;

namespace DailyLeetCode.Problems
{
    /// <summary>
    /// Leet Code Problem 5: Longest Palindromic Substring
    /// 
    /// Given a string s, return the longest palindromic substring in s.
    /// </summary>
    public class Day6 : ITest
    {
        string LongestPalindrome(string s)
        {
            int length = 0;
            string palindrome = "";

            for (int i = 0; i < s.Length; i++)
            {
                // Odd Case
                int L = i;
                int R = i;
                while (L >= 0 && R < s.Length && s[L] == s[R])
                {
                    if (R - L + 1 > length)
                    {
                        length = R - L + 1;
                        palindrome = s.Substring(L, length);
                    }

                    L -= 1;
                    R += 1;
                }


                // Even Case
                L = i;
                R = i + 1;

                while (L >= 0 && R < s.Length && s[L] == s[R])
                {
                    if (R - L + 1 > length)
                    {
                        length = R - L + 1;
                        palindrome = s.Substring(L, length);
                    }

                    L -= 1;
                    R += 1;
                }
            }

            return palindrome;
        }

        public void Test()
        {
            string case1 = "baba";
            string case2 = "cbaab";
            string case3 = "abcdabccba";

            Assert.AreEqual("bab", LongestPalindrome(case1));
            Assert.AreEqual("baab", LongestPalindrome(case2));
            Assert.AreEqual("abccba", LongestPalindrome(case3));
        }
    }
}
