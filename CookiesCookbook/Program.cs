using CookiesCookbook.Models.BaseClasses;
using CookiesCookbook.Models.Ingredients;
using CookiesCookbook.Utilities;

var fileType = FileType.Json;

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

PrintAvailableIngredients();

while (true)
{
    var input = Console.ReadKey();
    int validatedInput; 
    if(InputValidator.ValidateInput(input.KeyChar.ToString(), GetIngredients(), out validatedInput))
    {
        Console.WriteLine($"You selected: {GetIngredients()[validatedInput]}");
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }
}


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