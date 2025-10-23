using CookiesCookbook.Models.BaseClasses;

namespace CookiesCookbook.Models.Ingredients;

public class Dough : Ingredient
{
    public override int Id => 2;
    public override string Name => "Dough";
    public override string Instructions => "Kneed.";
}
