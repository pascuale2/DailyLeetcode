using NUnit.Framework;

namespace DailyLeetCode.Problems
{
    /// <summary>
    /// Leet Code Problem 191: Number of 1 Bits
    /// 
    /// Write a function that takes the binary representation of an unsigned integer and returns the number of '1' bits it has (also known as the Hamming weight).
    /// </summary>
    public class Day3 : ITest
    {
        int HammingWeight(uint n)
        {
            int count = 0;

            while (n > 0)
            {
                n = n & (n - 1);
                count++;
            }

            return count;
        }

        public void Test()
        {
            int case1 = HammingWeight(11);         // 00000000000000000000000000001011 in bit representation
            int case2 = HammingWeight(128);        // 00000000000000000000000010000000 in bit representation
            int case3 = HammingWeight(4294967293); // 11111111111111111111111111111101 in bit representation

            Assert.AreEqual(3, case1);
            Assert.AreEqual(1, case2);
            Assert.AreEqual(31, case3);
        }

    }
}
