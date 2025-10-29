using CookiesCookbook.Models.BaseClasses;

namespace CookiesCookbook.Utilities;

public static class InputValidator
{
    public static bool ValidateInput(string? input, out int number)
    {
        number = 0;
        
        if (!int.TryParse(input, out var originalNumber))
            return false;

        number = originalNumber - 1;
        
        return true;
    }

    public static bool IsRealElement(int validInput, List<Ingredient> ingredients, out Ingredient? ingredient)
    {
        ingredient = null;
        
        if (validInput < 0 || validInput > ingredients.Count - 1)
            return false;
        
        ingredient = ingredients[validInput];

        return true;
    }
}