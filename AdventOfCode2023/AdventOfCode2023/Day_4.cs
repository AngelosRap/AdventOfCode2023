using AdventOfCode2023.Utilities;

namespace AdventOfCode2023;
public class Day_4
{
    public void Part1()
    {
        var text = Helpers.GetText(4).Replace(':', ',').Replace(" | ", " ");

        var lines = Helpers.GetLines(text)
            .Select(x => x.Split(','))
            .ToList();

        var numbers = lines
            .Select(x => x[1])
            .Select(y => y.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(z => int.Parse(z)).ToList())
            .ToList();
        var sum = 0;

        foreach (var number in numbers)
        {
            sum += CardPoints(number);
        }
        Console.WriteLine(sum);
    }

    public void Part2()
    {

        var text = Helpers.GetText(4).Replace(':', ',').Replace(" | ", " ");

        var lines = Helpers.GetLines(text)
            .Select(x => x.Split(','))
            .ToList();

        var numbers = lines
            .Select(x => x[1])
            .Select(y => y.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(z => int.Parse(z)).ToList())
            .ToList();

        var cardCopies = numbers.Select(numbers => 0).ToList();

        var sum = 0;

        for (var i = 0; i < numbers.Count; i++)
        {
            var diff = numbers[i].Count - numbers[i].Distinct().ToList().Count;

            for (var j = 0; j < diff; j++)
            {
                cardCopies[i + j + 1] += cardCopies[i];
                cardCopies[i + j + 1]++;
            }
            sum += cardCopies[i];
        }
        sum += numbers.Count;
        Console.WriteLine(sum);
    }

    private int CardPoints(List<int> numbers)
    {
        var diff = numbers.Count - numbers.Distinct().ToList().Count;
        var points = 0;

        if (diff == 1)
        {
            points++;
            return points;
        }
        if (diff == 2)
        {
            points += 2;
            return points;
        }
        else if (diff > 2)
        {
            points = 1;
            for (var i = 1; i < diff; i++)
            {
                points *= 2;
            }
        }
        return points;
    }
}
