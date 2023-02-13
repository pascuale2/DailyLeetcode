using NUnit.Framework;

namespace DailyLeetCode.Problems
{
    /// <summary>
    /// Leet Code Problem 3: Longest Substring Without Repeating Characters
    /// 
    /// Given a string s, find the length of the longest substring without repeating characters.
    /// </summary>
    public class Day5 : ITest
    {
        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> charSet = new HashSet<char>();
            int left = 0;
            int right = 0;
            int max = 0;

            while (right < s.Length)
            {
                if (!charSet.Contains(s[right]))
                {
                    charSet.Add(s[right]);
                    right++;
                    max = Math.Max(max, charSet.Count);
                }
                else
                {
                    charSet.Remove(s[left]);
                    left++;
                }
            }

            return max;
        }

        public void Test()
        {
            string case1 = "abcabcbb";
            string case2 = " ";
            string case3 = "bbbbbbbbbb";
            string case4 = "au";
            string case5 = "pwwkew";

            Assert.AreEqual(3, LengthOfLongestSubstring(case1));
            Assert.AreEqual(1, LengthOfLongestSubstring(case2));
            Assert.AreEqual(1, LengthOfLongestSubstring(case3));
            Assert.AreEqual(2, LengthOfLongestSubstring(case4));
            Assert.AreEqual(3, LengthOfLongestSubstring(case5));
        }
    }
}
