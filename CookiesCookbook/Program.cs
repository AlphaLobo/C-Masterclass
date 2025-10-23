using CookiesCookbook.Models.BaseClasses;
using CookiesCookbook.Utilities;

var fileType = FileType.Json;

GenerateSomeRecipes.GenerateAndWriteToFile(fileType);

var recipes = GetRecipes();

if (recipes != null)
{
    Console.WriteLine("Printing existing recipes.");
    foreach (var recipe in recipes)
    {
        Console.WriteLine(recipe);
    }
}
else
    Console.WriteLine("No recipes to display.");

Console.ReadKey();
return;

List<Recipe>? GetRecipes()
{
    try
    {
        List<Recipe>? savedRecipes = [];

        if (fileType == FileType.Json)
            savedRecipes = Serialization.DeserializeFromJson<List<Recipe>>();

        return savedRecipes;
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        throw;
    }
}