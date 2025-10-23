namespace CookiesCookbook.Models.BaseClasses;

public abstract class Ingredient
{
    public virtual int Id { get; init; }
    public virtual string Name { get; init; } = "";
    public virtual string Instructions { get; set; } = "";
}