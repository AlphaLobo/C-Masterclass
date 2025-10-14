using DiceRollGame.Models;

namespace DiceRollGame.Services;

public static class DiceActionsService
{
    private static Random _random = new Random();
    
    public static void Roll(Dice dice)
    {
        Console.WriteLine("Rolling...");
        var result = _random.Next(dice.MinValue, dice.MaxValue + 1);
        dice.PreviousValue = dice.CurrentValue;
        dice.CurrentValue = result;
    }
}