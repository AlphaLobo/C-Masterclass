namespace CookiesCookbook.Models.BaseClasses;

public class Ingredient // come back to this. We don't want to allow instantiation here.
{
    public virtual int Id { get; init; }
    public virtual string Name { get; init; } = "";
    public virtual string Instructions { get; set; } = "";
}