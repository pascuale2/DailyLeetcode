using NUnit.Framework;

namespace DailyLeetCode.Problems
{
    /// <summary>
    /// Leetcode Problem 12: Integer to Roman
    /// 
    /// Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
    /// Symbol       Value
    ///  I             1
    ///  V             5
    ///  X             10
    ///  L             50
    ///  C             100
    ///  D             500
    ///  M             1000
    ///  
    /// For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II.
    /// The number 27 is written as XXVII, which is XX + V + II.
    /// 
    /// Roman numerals are usually written largest to smallest from left to right.However, the numeral for four is not IIII. Instead, the number four is written as IV.
    /// Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX.
    /// 
    /// There are six instances where subtraction is used:
    /// - I can be placed before V (5) and X(10) to make 4 and 9.
    /// - X can be placed before L(50) and C(100) to make 40 and 90. 
    /// - C can be placed before D(500) and M(1000) to make 400 and 900.
    ///
    /// Given an integer, convert it to a roman numeral.
    /// </summary>

    public class Day10 : ITest
    {
        string IntToRomanString(int x)
        {
            switch (x)
            {
                case 1:
                    return "I";
                case 4:
                    return "IV";
                case 5:
                    return "V";
                case 9:
                    return "IX";
                case 10:
                    return "X";
                case 40:
                    return "XL";
                case 50:
                    return "L";
                case 90:
                    return "XC";
                case 100:
                    return "C";
                case 400:
                    return "CD";
                case 500:
                    return "D";
                case 900:
                    return "CM";
                case 1000:
                    return "M";
                default:
                    return "";
            }
        }

        string IntToRoman(int num)
        {
            int[] numArray = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            int i = 0;
            string romanNumString = "";

            while (num != 0)
            {
                if (num < numArray[i])
                {
                    i++;
                    continue;
                }

                num -= numArray[i];
                romanNumString += IntToRomanString(numArray[i]);
            }

            return romanNumString;
        }

        public void Test()
        {
            int case1 = 3;
            int case2 = 58;
            int case3 = 1994;

            Assert.AreEqual("III", IntToRoman(case1));
            Assert.AreEqual("LVIII", IntToRoman(case2));
            Assert.AreEqual("MCMXCIV", IntToRoman(case3));
        }
    }
}
