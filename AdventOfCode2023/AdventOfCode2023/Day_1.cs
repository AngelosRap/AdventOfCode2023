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
        var lines = Helpers.GetLines();
        var solution = 0;

        foreach (var line in lines)
        {

        }
    }
    public static void Part1()
    {
        var lines = Helpers.GetLines();
        var solution = 0;

        foreach (var line in lines)
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
        }
        Console.WriteLine(solution);
    }


}
