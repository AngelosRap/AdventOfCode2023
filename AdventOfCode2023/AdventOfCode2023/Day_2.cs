﻿using AdventOfCode2023.Utilities;

namespace AdventOfCode2023;
public class Day_2
{
    public static void Part2()
    {
        var lines = Helpers.GetText(2)
            .Replace(":", ",")
            .Replace(";", ",")
            .Split(",")
            .Select(x => x.Trim())
            .ToList();

        Console.WriteLine(lines.ListToString());
        var sum = 0;

        //foreach (var game in lines)
        //{
        //    var red = 0;
        //    var green = 0;
        //    var blue = 0;

        //    var newLine = game.Replace(":", ",").Replace(";", ",");
        //    var stringArr = newLine.Split(",");

        //    foreach (var item in stringArr)
        //    {
        //        var trimed = item.Trim().Replace(" ", ",");
        //        var myArr = trimed.Split(",");

        //        if (myArr[0] == "Game")
        //        {
        //            continue;
        //        }

        //        _ = myArr[1] switch
        //        {
        //            "red" => red < int.Parse(myArr[0]) ? red = int.Parse(myArr[0]) : red = red,
        //            "blue" => blue < int.Parse(myArr[0]) ? blue = int.Parse(myArr[0]) : blue = blue,
        //            "green" => green < int.Parse(myArr[0]) ? green = int.Parse(myArr[0]) : green = green,
        //            _ => throw new NotImplementedException()
        //        };
        //    }
        //    sum += red * blue * green;
        //}
        //Console.WriteLine(sum);
    }
    public static void Part1()
    {
        var lines = Helpers.GetText(2)
            .Replace(":", ",")
            .Replace(";", ",")
            .Split(",")
            .Select(x => x.Trim())
            .ToList();



        Console.WriteLine(lines[0]);

        var gameSum = 0;
        var gameId = 0;

        foreach (var game in lines)
        {

        }
        //    foreach (var item in game)
        //    {
        //        Console.WriteLine(item);

        //    }
        //    var isGameValid = true;
        //    var red = 0;
        //    var green = 0;
        //    var blue = 0;


        //    if (game[0] == "Game")
        //    {
        //        gameId++;
        //        continue;
        //    }

        //    _ = game[1] switch
        //    {
        //        "red" => red = int.Parse(game[0]),
        //        "blue" => blue = int.Parse(game[0]),
        //        "green" => green = int.Parse(game[0]),
        //        _ => throw new NotImplementedException()
        //    };
        //    if (red > 12 || green > 13 || blue > 14)
        //    {
        //        isGameValid = false;
        //    }
        //    if (isGameValid)
        //    {
        //        gameSum += gameId;
        //    }
        //}
    }
}

