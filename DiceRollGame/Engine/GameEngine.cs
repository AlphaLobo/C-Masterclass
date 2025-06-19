using DiceRollGame.Models;
using DiceRollGame.Services;

namespace DiceRollGame.Engine;

public class GameEngine
{
    private Dice _dice;
    public bool LoserUser { get; private set; }
    public bool GameOver { get; private set; }
    
    public GameEngine(int min, int max)
    {
        _dice = new Dice(min, max);
    }

    public void StartEngine()
    {
        _dice.Roll();
        Console.WriteLine("Good luck. You'll never guess what number I chose...");

        int maxAttempts = 3;
        int currentAttempt = 1;
        LoserUser = true;

        while (currentAttempt <= maxAttempts)
        {
            Console.WriteLine($"You are on attempt ({currentAttempt}) out of ({maxAttempts}).");
            Console.WriteLine($"Gimme your best guess between {_dice.MinValue} and {_dice.MaxValue}!");
            var input = Console.ReadLine();

            if (!InputValidator.ValidateInput(input, _dice))
            {
                Console.WriteLine("Invalid input. Try again.");
                continue;
            }

            if (input == _dice.CurrentValue.ToString())
            {
                Console.WriteLine($"Nice - you win! Please feel free to put that on your CV.");
                LoserUser = false;
                break;
            }

            currentAttempt++;
            Console.WriteLine("Wrong. Try again.");
        }
        
        GameOver = true;
    }
}