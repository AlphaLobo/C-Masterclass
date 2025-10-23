using CookiesCookbook.Models.BaseClasses;

namespace CookiesCookbook.Models.Ingredients;

public class Milk : Ingredient
{
    public override int Id => 3;
    public override string Name => "Milk";
    public override string Instructions => "Add to thin dough out.";
}