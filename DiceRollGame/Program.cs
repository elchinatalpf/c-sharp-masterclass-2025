using DiceRollGame.Game;

// Original dice game code (commented out to run polymorphism demo)
/*
var random = new Random();
var diceRollResult = random.Next(1, 7);
var dice = new Dice(random);
var guessingGame = new GuessingGame(dice);

GameResult gameResult = guessingGame.Play();
GuessingGame.PrintResult(gameResult);

Console.WriteLine(gameResult);
*/

// Run the polymorphism learning examples
PolymorphismDemo.Run();

Console.ReadKey();
