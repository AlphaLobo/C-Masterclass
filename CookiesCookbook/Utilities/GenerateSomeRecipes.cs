using CookiesCookbook.Models.BaseClasses;
using CookiesCookbook.Models.Ingredients;

namespace CookiesCookbook.Utilities;

public static class GenerateSomeRecipes
{
    private static readonly Butter _butter = new ();
    private static readonly Chocolate _chocolate = new ();
    private static readonly Dough _dough = new ();
    private static readonly Milk _milk = new ();
    private static readonly Sugar _sugar = new ();
    
    private static List<Recipe> GenerateRecipes()
    {
        List<Recipe> recipes = [];
        
        Recipe recipe1 = new Recipe() { Ingredients = [_butter, _chocolate, _dough, _milk, _sugar] };
        Recipe recipe2 = new Recipe() { Ingredients = [_butter, _chocolate, _dough, _milk] };
        Recipe recipe3 = new Recipe() { Ingredients = [_butter, _dough, _milk, _sugar] };
        
        recipes.Add(recipe1);
        recipes.Add(recipe2);
        recipes.Add(recipe3);
        
        return recipes;
    }

    public static void GenerateAndWriteToFile(FileType fileType)
    {
        if(fileType == FileType.Json)
            Serialization.SerializeJsonToFile(GenerateRecipes());
    }
}