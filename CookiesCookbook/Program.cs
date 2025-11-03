using CookiesCookbook.Models.BaseClasses;
using CookiesCookbook.Models.Ingredients;
using CookiesCookbook.Utilities;

const FileType fileType = FileType.Json;

//GenerateSomeRecipes.GenerateAndWriteToFile(fileType);

ShowUserRecipes();
CreateANewRecipe();

#region Methods

List<Recipe>? GetRecipes()
{
    try
    {
        List<Recipe>? savedRecipes;

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

void ShowUserRecipes()
{
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
}

void CreateANewRecipe()
{
    var existingRecipes = GetRecipes() ?? [];
    var newRecipe = new Recipe();
    while (true)
    {
        Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");
        PrintAvailableIngredients();
    
        var input = Console.ReadKey();
        if(InputValidator.ValidateInput(input.KeyChar.ToString(), out var validatedInput))
        {
            if (InputValidator.IsRealElement(validatedInput, GetIngredients(), out var ingredient) && ingredient != null)
            {
                newRecipe.Ingredients.Add(ingredient);
                Console.WriteLine($"{ingredient} has been added to the recipe.");
            }
            else
            {
                Console.WriteLine("This ingredient doesn't exist.");
            }
        }
        else
        {
            if (newRecipe.Ingredients.Count != 0)
            {
                Console.WriteLine("Recipe added: ingredients shown here...");
                existingRecipes.Add(newRecipe);
                Serialization.SerializeJsonToFile(existingRecipes);
            }
            else
            {
                Console.WriteLine("No ingredients have been selected. Recipe will not be saved.");
            }
        
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            break;
        }
    }
}

#endregion