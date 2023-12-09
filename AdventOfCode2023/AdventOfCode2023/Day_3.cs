using AdventOfCode2023.Utilities;

namespace AdventOfCode2023;
public class Day_3
{
    private List<string> _lines = [];

    public void Part1()
    {
        _lines = Helpers.GetLines(3);
        var enginePartsSum = 0;

        for (var y = 0; y < _lines.Count; y++)
        {
            for (var x = 0; x < _lines[y].Length; x++)
            {
                if (!char.IsDigit(_lines[y][x]) && _lines[y][x] != '.')
                {
                    enginePartsSum += GetAdjacentNumbers(y, x);
                }
            }
        }
        Console.WriteLine(enginePartsSum);
    }

    public void Part2()
    {
        _lines = Helpers.GetLines(3);
        var gearRatioSum = 0;

        for (var y = 0; y < _lines.Count; y++)
        {
            for (var x = 0; x < _lines[y].Length; x++)
            {
                if (_lines[y][x] == '*')
                {
                    gearRatioSum += GetAdjacentNumbers(y, x);
                }
            }
        }
        Console.WriteLine(gearRatioSum);
    }

    private int GetAdjacentNumbers(int y, int x)
    {
        var enginePart = 0;
        List<int> gears = [];

        enginePart += GetUpNumbers(y, x, gears);
        enginePart += GetDownNumbers(y, x, gears);
        enginePart += GetRightNumbers(y, x, gears);
        enginePart += GetLeftNumbers(y, x, gears);

        if (gears.Count == 2)
        {
            return gears[0] * gears[1];
        }

        return 0;
    }

    private int GetLeftNumbers(int y, int x, List<int> gears)
    {
        var sum = 0;

        if (char.IsDigit(_lines[y][x - 1]))
        {
            var stringSum = GetLeft(y, x - 1);
            sum += string.IsNullOrEmpty(stringSum) ? 0 : int.Parse(stringSum);
            gears.Add(sum);
        }

        return sum;
    }

    private int GetRightNumbers(int y, int x, List<int> gears)
    {
        var sum = 0;

        if (char.IsDigit(_lines[y][x + 1]))
        {
            var stringSum = GetRight(y, x + 1);
            sum += string.IsNullOrEmpty(stringSum) ? 0 : int.Parse(stringSum);
            gears.Add(sum);
        }

        return sum;
    }

    private int GetDownNumbers(int y, int x, List<int> gears)
    {
        var sum = 0;

        if (_lines[y + 1][x] == '.')
        {
            if (char.IsDigit(_lines[y + 1][x - 1]))
            {
                var left = GetLeft(y + 1, x - 1);
                sum += string.IsNullOrEmpty(left) ? 0 : int.Parse(left);

                if (!string.IsNullOrEmpty(left))
                {
                    gears.Add(int.Parse(left));
                }
            }

            if (char.IsDigit(_lines[y + 1][x + 1]))
            {
                var right = GetRight(y + 1, x + 1);
                sum += string.IsNullOrEmpty(right) ? 0 : int.Parse(right);

                if (!string.IsNullOrEmpty(right))
                {
                    gears.Add(int.Parse(right));
                }
            }
        }
        else if (char.IsDigit(_lines[y + 1][x]))
        {
            var stringSum = GetLeft(y + 1, x - 1) + _lines[y + 1][x] + GetRight(y + 1, x + 1);
            sum += string.IsNullOrEmpty(stringSum) ? 0 : int.Parse(stringSum);
            gears.Add(sum);
        }

        return sum;
    }

    private int GetUpNumbers(int y, int x, List<int> gears)
    {
        var sum = 0;

        if (_lines[y - 1][x] == '.')
        {
            if (char.IsDigit(_lines[y - 1][x - 1]))
            {
                var left = GetLeft(y - 1, x - 1);
                sum += string.IsNullOrEmpty(left) ? 0 : int.Parse(left);
                if (!string.IsNullOrEmpty(left))
                {
                    gears.Add(int.Parse(left));
                }
            }

            if (char.IsDigit(_lines[y - 1][x + 1]))
            {
                var right = GetRight(y - 1, x + 1);
                sum += string.IsNullOrEmpty(right) ? 0 : int.Parse(right);
                if (!string.IsNullOrEmpty(right))
                {
                    gears.Add(int.Parse(right));
                }
            }
        }
        else if (char.IsDigit(_lines[y - 1][x]))
        {
            var stringSum = GetLeft(y - 1, x - 1) + _lines[y - 1][x] + GetRight(y - 1, x + 1);
            sum += string.IsNullOrEmpty(stringSum) ? 0 : int.Parse(stringSum);
            gears.Add(sum);
        }

        return sum;
    }

    private string GetRight(int y, int x)
    {
        var stringSum = "";
        while (_lines[y][x] != '.')
        {
            stringSum += _lines[y][x];
            x++;
            if (x > _lines[y].Length - 1)
            {
                break;
            }
        }
        return stringSum;
    }

    private string GetLeft(int y, int x)
    {
        var stringSum = "";
        while (_lines[y][x] != '.')
        {
            stringSum = _lines[y][x] + stringSum;

            x--;

            if (x < 0)
            {
                break;
            }
        }
        return stringSum;
    }
}
