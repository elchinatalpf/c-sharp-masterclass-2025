int[] numbers = new int[] { 2, 4, 5, 7, 9, 15 };

var sum = 0;
for(var i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}

Console.WriteLine("Loop sum total is: " + sum);
Console.ReadLine();

//for (int i=0; i < 4; i++)
//{
//var data = GetFromDatabase();
//    for(int j = 0; j < 4; j++)
//    {
//        for (int k = 0; k < 4; k++)
//        {

//        Console.WriteLine($"i: {i}, j: {j} , k: {k}");
//        }
//    }
//}
//string GetFromDatabase(int i)
//{
//    return $"Data {i}";
//}

//Console.WriteLine("Loop finished");
//Console.ReadLine();

//for (var i = 0; i < 20; ++i)
//{
//    if (i % 3 != 0)
//    {
//        continue;
//    }
//    Console.WriteLine("Loop run " + i);

//}
//Console.WriteLine("The loop has finished");

//int userNumber;
//do
//{
//    Console.WriteLine("Enter a number larger than 10:");
//    var userInput = Console.ReadLine();
//    if (userInput == "stop")
//    {
//        break;
//    }
//    bool isParsebleToInt = userInput.All(char.IsDigit);
//    if (!isParsebleToInt)
//    {
//        Console.WriteLine("Please enter a valid number.");
//        userNumber = 0;
//        continue;
//    }
//    userNumber = int.Parse(userInput);
//}
//while ( userNumber <= 10);

//Console.ReadLine();

//Console.WriteLine("Enter a word");
//var userInput = Console.ReadLine();

////while (userInput.Length < 15)
////{
////    userInput += 'a';
////    Console.WriteLine(userInput);
////}

//string word;
//do
//{
//    Console.WriteLine("Enter a word longer than 10 letters");
//    word = Console.ReadLine();
//}
//while(word.Length < 10);

//Console.WriteLine("The loop is finsihed.");

//Console.ReadLine();


//char ConvertPointsToGrade(int points)
//{
//    return points switch
//    {
//        10 or 9 => 'A',
//        8 or 7 or 6 => 'B',
//        5 or 4 or 3 => 'C',
//        2 or 1 => 'D',
//        0 => 'E',
//        _ => '!',
//    };

//return points switch
//{
//    >= 90 => "A",
//    >= 80 => "B",
//    >= 50 => "C",
//    _ => "D",
//};
//}


//Console.WriteLine("What do you wnat to do?");
//Console.WriteLine("[S]ee all todos");
//Console.WriteLine("[A]dd a todo");
//Console.WriteLine("[Remove a todo]");
//Console.WriteLine("[E]xit");

//var userChoise = Console.ReadLine();

//switch(userChoise)
//{
//    case "s":
//    case "S":
//        PrintSelectedOption("See all todos");
//        break;
//    case "a":
//    case "A":
//        PrintSelectedOption("Add a todo");
//        break;
//    case "r":
//    case "R":
//        PrintSelectedOption("Remove a todo");
//        break;
//    case "e":
//    case "E":
//        PrintSelectedOption("Exit");
//        break;
//    default: Console.WriteLine("Invalid choice. Please enter S, A, R, or E.");
//        break;
//}

//static void PrintSelectedOption(string option)
//{
//    Console.WriteLine($"You selected: {option}");
//}


//Console.ReadLine();
