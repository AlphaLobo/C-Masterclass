using System.Text;

namespace CookiesCookbook.Models.BaseClasses;

public class Recipe
{
    public List<Ingredient> Ingredients { get; set; } = [];

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        foreach(var ingredient in Ingredients)
            sb.Append($"{ingredient.Name}. {ingredient.Instructions}{Environment.NewLine}");
        
        return sb.ToString();
    }
}