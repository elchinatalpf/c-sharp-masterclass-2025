using DiceRollGame.Game;

var random = new Random();
var diceRollResult = random.Next(1, 7);
var dice = new Dice(random);
var guessingGame = new GuessingGame(dice);

GameResult gameResult = guessingGame.Play();
GuessingGame.PrintResult(gameResult);


Console.WriteLine(gameResult);

PolymorphismExample.Run();

Console.ReadKey();
