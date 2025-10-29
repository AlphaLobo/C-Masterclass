using CookiesCookbook.Models.BaseClasses;
using CookiesCookbook.Models.Ingredients;
using CookiesCookbook.Utilities;

const FileType fileType = FileType.Json;

//GenerateSomeRecipes.GenerateAndWriteToFile(fileType);

var recipes = GetRecipes();

if (recipes != null)
{
    Console.WriteLine("Printing existing recipes.");
    var n = 0;
    foreach (var recipe in recipes)
    {
        n++;
        Console.WriteLine($"***** {n} *****{recipe}{Environment.NewLine}");
    }
}
else
    Console.WriteLine("No recipes to display.");

while (true)
{
    Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");
    PrintAvailableIngredients();
    var input = Console.ReadKey();
    if(InputValidator.ValidateInput(input.KeyChar.ToString(), out var validatedInput))
    {
        if (InputValidator.IsRealElement(validatedInput, GetIngredients(), out var ingredient))
        {
            Console.WriteLine($"You selected: {GetIngredients()[validatedInput]}");
        }
    }
    else
    {
        break;
    }
}

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
        return null;
    }
}

List<Ingredient> GetIngredients()
{
    List<Ingredient> availableIngredients = 
    [
        new Butter(),
        new Chocolate(),
        new Dough(),
        new Milk(),
        new Sugar()
    ];
    
    return availableIngredients;
}

void PrintAvailableIngredients()
{
    var ingredients = GetIngredients();

    foreach (var ingredient in ingredients)
    {
       Console.WriteLine($"{ingredient.Id} {ingredient.Name}");
    }
}

void CreateANewRecipe()
{
    Console.WriteLine("Create a new cookie recipe! Available ingredients are:");
}