using CookiesCookbook.Models.BaseClasses;

namespace CookiesCookbook.Models.Ingredients;

public class Sugar : Ingredient
{
    public override int Id => 5;
    public override string Name => "Sugar";
    public override string Instructions => "Mix in to add sweetness.";
}