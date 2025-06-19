using DiceRollGame.Services;

namespace DiceRollGame.Models;

public class Dice(int minValue, int maxValue)
{
    public int CurrentValue { get; set; } = 0;
    public int PreviousValue { get; set; } = 0;
    public int MinValue => minValue;
    public int MaxValue => maxValue;
    
    public void Roll()
    {
        DiceActionsService.Roll(this);
    }
}