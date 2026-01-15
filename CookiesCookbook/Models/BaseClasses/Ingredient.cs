namespace CookiesCookbook.Models.BaseClasses;

public class Ingredient // come back to this. We don't want to allow instantiation here. Cannot deserialize abstract classes.
{
    public virtual int Id { get; init; }
    public virtual string Name { get; init; } = "";
    public virtual string Instructions { get; init; } = "";

    public override string ToString()
    {
        return Name;
    }
}