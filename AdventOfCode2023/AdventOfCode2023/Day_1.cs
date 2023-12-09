using AdventOfCode2023.Utilities;

namespace AdventOfCode2023;

public enum Nums
{
    zero, one, two, three, four, five, six, seven, eight, nine
}
public class Day1
{
    public static void Part2()
    {
        var lines = Helpers.GetLines(1);
        List<string> modifiedLines = new();

        foreach (var line in lines)
        {
            Dictionary<int, int> numIndexes = new();
            foreach (var item in Enum.GetValues(typeof(Nums)))
            {
                if (line.IndexOf(item.ToString()) < 0)
                {
                    continue;
                }

                numIndexes.Add(line.IndexOf(item.ToString()), (int)item);
            }

            var sorted = numIndexes.OrderBy(x => x.Key);
            var newLine = line;
            if (sorted.Count() > 0)
            {
                newLine = line.Replace(Enum.GetName(typeof(Nums), (Nums)sorted.ElementAt(0).Value), sorted.ElementAt(0).Value.ToString()).Replace(Enum.GetName(typeof(Nums), (Nums)sorted.ElementAt(^1).Value), sorted.ElementAt(^1).Value.ToString());
            }

            modifiedLines.Add(newLine);
        }
        Console.WriteLine(Solution(modifiedLines));

    }
    public static void Part1()
    {
        var lines = Helpers.GetLines(1);

        Console.WriteLine(Solution(lines));
    }

    private static int Solution(List<string> strings)
    {
        var solution = 0;
        foreach (var line in strings)
        {
            var charList = new List<char>();
            string stringSum;
            foreach (var item in line)
            {
                if (char.IsDigit(item))
                {
                    charList.Add(item);
                }
            }
            if (charList.Count == 0)
            {
                stringSum = charList[0].ToString() + charList[0].ToString();
            }
            else
            {
                stringSum = charList[0].ToString() + charList[^1].ToString();
            }
            solution += int.Parse(stringSum);
            Console.WriteLine(stringSum);
        }
        return solution;
    }


}
