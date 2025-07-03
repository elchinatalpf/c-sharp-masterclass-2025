

//var random = new Random();
//var diceRollResult = random.Next(1, 7);
//var dice = new Dice(random);
//var guessingGame = new GuessingGame(dice);

//bool xxx = guessingGame.Play();



Season firstSeason = Season.Spring;
Console.WriteLine(firstSeason);
Console.ReadKey();

public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}


class GuessingGame
{
    private readonly Dice _dice;
    private const int InitialTries = 3;

    public GuessingGame(Dice dice)
    {
        _dice = dice;
    }

    public bool Play()
    {
        var diceRollResult = _dice.Roll();
        Console.WriteLine($"Guess the number in {InitialTries} tries: ");

        var triesLeft = InitialTries;
        while(triesLeft > 0)
        {
            var guess = ConsoleReader.ReadInteger("Enter a number:");
            if (guess == diceRollResult)
            {
                return true;
            }
            Console.WriteLine("Wrong Number.");
            --triesLeft;
        }
        return false;
    }
}

public static class ConsoleReader
{
    public static int ReadInteger(string message)
    {
        int result;
        do
        {
            Console.WriteLine(message);
        }
        while (!int.TryParse(Console.ReadLine(), out result));
        return result;
    }
}

public class Dice
{
    private readonly Random _random;
    private const int SidesCount = 6;

    public Dice(Random random)
    {
        _random = random;
    }

    public int Roll()
    {
        return _random.Next(1, SidesCount + 1);
    }

    public void Describe() => Console.WriteLine($"This is a dice with {SidesCount} sides");



}