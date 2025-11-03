using System.Text.Json.Nodes;

namespace CookiesCookbook.Utilities;

public static class FileHelper
{
    public static string? ReadFromFile(FileType fileType)
    {
        try
        {
            return File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                $"Cookbook.recipes.{fileType}"));
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public static void WriteToFile(FileType fileType, string data, bool create = false)
    {
        var fileName = $"Cookbook.recipes.{fileType}";
        if(create)
            File.Create(fileName).Close();
        File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName), data);
    }
}

public enum FileType
{
    Json,
    Txt
}