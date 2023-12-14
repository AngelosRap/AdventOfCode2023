using AdventOfCode2023.Utilities;

namespace AdventOfCode2023;
public class Day_5
{

    public void Part1()
    {
        var lines = Helpers.GetText(5)
            .Split("\r\n\r")
            .Select(x => x.Trim())
            .ToList();

        var seeds = new List<long>();

        seeds = lines[0]
         .Split(":")[1]
         .Split(" ", StringSplitOptions.TrimEntries)
         .Select(long.Parse)
         .ToList();

        //var mapLines = lines.Skip(2).ToList();
        //Console.WriteLine(mapLines.ListToString());

        var maps = lines.Skip(1).Select(x => new Map(lines, lines.IndexOf(x)));
        var locations = new List<long>();



        for (var i = 0; i < seeds.Count; i++)
        {
            var location = seeds[i];
            foreach (var map in maps)
            {
                foreach (var item in map.Coordinates)
                {
                    var dstStart = item[0];
                    var srcStart = item[1];
                    var range = item[2];

                    if (location >= srcStart && location <= srcStart + range)
                    {
                        location = location - srcStart + dstStart;
                        break;
                    }
                }
            }

            Console.WriteLine("seed :" + seeds[i] + " location : " + location);

            locations.Add(location);
        }

    }
    public class Map
    {
        public string Name { get; set; }
        public List<List<long>> Coordinates { get; set; }

        public Map(List<string> lines, int index)
        {
            Name = GetName(lines, index);
            Coordinates = GetCoordinates(index, lines);
        }

        private List<List<long>> GetCoordinates(int index, List<string> lines)
        {
            return lines[index]
            .Split(":")[1]
            .Trim()
            .Split("\n")
            .Select(x => x.Split(" ").Select(y => long.Parse(y)).ToList())
            .ToList();
        }

        private string GetName(List<string> lines, int index)
        {
            return lines[index].Replace(":", "").Split("\n")[0];
        }
    }
}
