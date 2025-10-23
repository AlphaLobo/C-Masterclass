namespace CookiesCookbook.Utilities;

public static class FileReader
{
    public static string ReadFromFile(FileType fileType)
    {
        return File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"Cookbook.recipes.{fileType}"));
    }

    public static void WriteToFile(FileType fileType, string data)
    {
        File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"Cookbook.recipes.{fileType}"), data);
    }
}

public enum FileType
{
    Json,
    Txt
}