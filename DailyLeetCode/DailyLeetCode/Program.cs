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
        Day3 day3 = new Day3();
        Day4 day4 = new Day4();
        Day5 day5 = new Day5();
        Day6 day6 = new Day6();

        _problems.Add(day1);
        _problems.Add(day2);
        _problems.Add(day3);
        _problems.Add(day4);
        _problems.Add(day5);
        _problems.Add(day6);
    }
}