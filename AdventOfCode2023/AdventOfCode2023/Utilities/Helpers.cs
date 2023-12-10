namespace AdventOfCode2023.Utilities;

public static class Helpers
{
    private const string PATH = "C:\\SourceControl\\AdventOfCode2023\\AdventOfCode2023\\AdventOfCode2023\\Resources\\";

    public static List<string> GetLines(int day) => [.. File.ReadAllLines(GetPath(day))];

    public static string GetText(int day) => File.ReadAllText(GetPath(day));

    public static string ListToString<T>(this IEnumerable<T> value) => string.Join("\n", value);

    private static string GetPath(int day) => $"{PATH}Day_{day}.txt";

    public static List<string> GetLines(string text) => [.. text.Split("\n")];
}
