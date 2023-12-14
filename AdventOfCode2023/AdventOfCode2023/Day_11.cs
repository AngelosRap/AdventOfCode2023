using AdventOfCode2023.Utilities;

namespace AdventOfCode2023
{
    public class Day_11()
    {
        public void Part1()
        {
            var universe = Helpers.GetText(11).Split('\n').Select(x => x.Select(y => y).ToList()).ToList();

            Console.WriteLine(universe[0].ListToString());

            for (var x = 0; x < universe[x].Count; x++)
            {
                var isEmpty = true;

                for (var y = 0; y < universe.Count; y++)
                {
                    if (universe[x][y] == '#')
                    {
                        isEmpty = false;
                    }
                }
                if (isEmpty)
                {

                }
            }
        }

        public int GetDistance(int x, int y, int targetX, int targetY)
        {
            return Math.Abs(targetX - x) + Math.Abs(targetY - y);
        }
    }

    public class Node()
    {
        public int X { get; set; }
        public int Y { get; set; }

    }
}

//var startY = lines.FindIndex(x => x.Contains('3'));
//var startX = lines[startY].IndexOf('3');

//var targetY = lines.FindIndex(x => x.Contains('6'));
//var targetX = lines[targetY].IndexOf('6');

// Console.WriteLine("Sx = " + startX + " " + "Tx = " + targetX);
//Console.WriteLine(GetDistance(startX, startY, targetX, targetY));

//for (var i = 0; i < universe.Count; i++)
//{
//    if (!universe[i].Contains('#'))
//    {
//        universe.Insert(i, universe[i]);
//        i++;
//    }
//}

//var rotatedUniverse = new List<string>();

//for (var i = 0; i < universe[0].Length; i++)
//{
//    var lala = "";

//    for (var j = 0; j < universe.Count; j++)
//    {
//        lala += universe[j][i];
//    }

//    rotatedUniverse.Add(lala);
//}
//foreach (var item in rotatedUniverse)
//{
//    Console.WriteLine(item);
//}

