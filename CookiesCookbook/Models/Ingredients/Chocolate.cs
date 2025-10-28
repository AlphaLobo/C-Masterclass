using CookiesCookbook.Models.BaseClasses;

namespace CookiesCookbook.Models.Ingredients;

public class Chocolate : Ingredient
{
    public override int Id => 2;
    public override string Name => "Chocolate";
    public override string Instructions => "Melt before adding to the top.";
}