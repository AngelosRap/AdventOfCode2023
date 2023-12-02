namespace AdventOfCode2023.Utilities;
public class Helpers
{
    public static string path = "C:\\SourceControl\\AdventOfCode2023\\AdventOfCode2023\\AdventOfCode2023\\Resources\\Day_2.txt";
    public static List<string> GetLines()
    {
        return [.. File.ReadAllLines(path)];
    }

}
