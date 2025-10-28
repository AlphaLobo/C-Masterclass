using CookiesCookbook.Models.BaseClasses;

namespace CookiesCookbook.Utilities;

public static class InputValidator
{
    public static bool ValidateInput(string? input, List<Ingredient> ingredients, out int number)
    {
        number = 0;
        
        if (!int.TryParse(input, out var originalNumber))
            return false;

        if (originalNumber < 1 || originalNumber > ingredients.Count)
            return false;
        
        number = originalNumber - 1;
        return true;
    }
}