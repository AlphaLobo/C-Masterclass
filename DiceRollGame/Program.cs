// See https://aka.ms/new-console-template for more information

using DiceRollGame.Engine;

GameEngine gameEngine = new GameEngine(1, 6);
gameEngine.StartEngine();

if (gameEngine.GameOver && gameEngine.LoserUser)
{
    Console.WriteLine("Game Over. You lose. Press any key to accept the fact that you are a loser.");
    Console.ReadKey();
}

Console.WriteLine("Goodbye.");
