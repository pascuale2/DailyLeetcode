using NUnit.Framework;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace DailyLeetCode.Problems
{
    /// <summary>
    /// Leet Code Problem 58: Length of Last Word
    /// 
    /// Given a string s consisting of words and spaces, return the length of the last word in the string.
    /// A word is a maximal substring consisting of non-space characters only.
    /// </summary>
    public class Day7 : ITest
    {
        /// <summary>
        /// String split method
        /// </summary>
        int LengthOfLastWord_StringSplit(string s)
        {
            string lastWord = "";
            foreach (string ss in s.Split(" "))
            {
                if (ss.Length > 0)
                {
                    lastWord = ss;
                }
            }

            return lastWord.Length;
        }

        /// <summary>
        /// Pointer method
        /// </summary>
        int LengthOfLastWord_Index(string s)
        {
            int endIndex = s.Length - 1;
            while (endIndex >= 0 && s[endIndex] == ' ')
            {
                endIndex--;
            }

            int startIndex = endIndex;
            while (startIndex >= 0 && s[startIndex] != ' ')
            {
                startIndex--;
            }

            return endIndex - startIndex;
        }

        public void Test()
        {
            string case1 = "a";
            string case2 = "Hello World";
            string case3 = "   fly me   to   the moon  ";
            string case4 = "luffy is still joyboy";

            Assert.AreEqual(1, LengthOfLastWord_StringSplit(case1));
            Assert.AreEqual(5, LengthOfLastWord_StringSplit(case2));
            Assert.AreEqual(4, LengthOfLastWord_StringSplit(case3));
            Assert.AreEqual(6, LengthOfLastWord_StringSplit(case4));

            Assert.AreEqual(1, LengthOfLastWord_Index(case1));
            Assert.AreEqual(5, LengthOfLastWord_Index(case2));
            Assert.AreEqual(4, LengthOfLastWord_Index(case3));
            Assert.AreEqual(6, LengthOfLastWord_Index(case4));
        }
    }
}
