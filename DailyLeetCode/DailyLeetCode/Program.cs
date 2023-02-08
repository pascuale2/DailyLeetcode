using DailyLeetCode.Problems;

internal class Program
{
    static List<ITest> _problems = new List<ITest>();
    
    static void Main(string[] args)
    {
        Initialize();

        for (int i = 0; i < _problems.Count; i++)
        {
            try
            {
                _problems[i].Test();
                Console.WriteLine($"Problem {i + 1} - Succeeded");
            }
            catch (Exception)
            {
                Console.WriteLine($"Problem {i + 1} - Failed");
            }
        }
    }

    static void Initialize()
    {
        Day1 day1 = new Day1();
        Day2 day2 = new Day2();

        _problems.Add(day1);
        _problems.Add(day2);
    }
}