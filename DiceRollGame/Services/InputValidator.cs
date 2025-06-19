using DiceRollGame.Models;

namespace DiceRollGame.Services;

public static class InputValidator
{
    public static bool ValidateInput(string? input, Dice dice)
    {
        if (!int.TryParse(input, out var number))
            return false;

        if (number < dice.MinValue || number > dice.MaxValue)
            return false;
        
        return true;
    }
}