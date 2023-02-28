using NUnit.Framework;

namespace DailyLeetCode.Problems
{
    /// <summary>
    /// Leetcode Problem 50: Pow(x,n)
    /// 
    /// Implement pow(x, n), which calculates x raised to the power n (i.e., x ^ n).
    /// </summary>
    public class Day12 : ITest
    {
        double MyPow(double x, int n)
        {
            long pow = n;
            if (pow < 0) { pow *= -1; }

            double ans = 1.0;

            while (pow > 0)
            {
                if (pow % 2 == 1)
                {
                    ans *= x;
                    pow -= 1;
                }
                else
                {
                    x *= x;
                    pow /= 2;
                }
            }

            return n < 0 ? 1 / ans : ans;
        }

        public void Test()
        {
            double test_epsilon = 1e-4;

            int case1 = 10;
            int case2 = 3;
            int case3 = -2;

            Assert.IsTrue(Math.Abs(1024.0 - MyPow(2.0, case1)) < test_epsilon);
            Assert.IsTrue(Math.Abs(9.2610 - MyPow(2.1, case2)) < test_epsilon);
            Assert.IsTrue(Math.Abs(0.250 - MyPow(2.0, case3)) < test_epsilon);
        }
    }
}
