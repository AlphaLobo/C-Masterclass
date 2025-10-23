using CookiesCookbook.Models.BaseClasses;

namespace CookiesCookbook.Models.Ingredients;

public class Butter : Ingredient
{
        public override int Id => 0;
        public override string Name => "Butter";
        public override string Instructions => "Mix into other ingredients.";
}