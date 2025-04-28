using System;
Console.WriteLine("Hello!");
Console.WriteLine("Enter first number:");
var firstNumberText = Console.ReadLine();
var number1 = int.Parse(firstNumberText);

Console.WriteLine("Enter second number:");
var secondNumberText = Console.ReadLine();
var number2 = int.Parse(secondNumberText);

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
var choice = Console.ReadLine();

if (CaseInsensitiveEquals(choice, "a"))
{
    var result = number1 + number2;
    FinalResult(number1, number2, "+", result);
}
else if (CaseInsensitiveEquals(choice, "s"))
{
    var result = number1 - number2;
    FinalResult(number1, number2, "-", result);
}
else if (CaseInsensitiveEquals(choice, "m"))
{
    var result = number1 * number2;
    FinalResult(number1, number2, "*", result);
}
else
{
    Console.WriteLine("Invalid choice. Please enter A, S, or M.");
}

void FinalResult(int number1, int number2, string operation, int result)
{
    Console.WriteLine($"The result of {number1} {operation} {number2} is: {result}");
}

bool CaseInsensitiveEquals(string str1, string str2)
{
    return str1.ToUpper() == str2.ToUpper();
}

Console.WriteLine("Press any key to close.");
Console.ReadLine();
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");
            
            bool continueCalculating = true;
            
            while (continueCalculating)
            {
                try
                {
                    // Get first number
                    Console.WriteLine("Enter first number:");
                    var firstNumberText = Console.ReadLine();
                    var number1 = int.Parse(firstNumberText);
                    
                    // Get second number
                    Console.WriteLine("Enter second number:");
                    var secondNumberText = Console.ReadLine();
                    var number2 = int.Parse(secondNumberText);
                    
                    // Display operation menu
                    Console.WriteLine("What do you want to do with those numbers?");
                    Console.WriteLine("[A]dd");
                    Console.WriteLine("[S]ubtract");
                    Console.WriteLine("[M]ultiply");
                    Console.WriteLine("[D]ivide");
                    Console.WriteLine("[Q]uit");
                    
                    // Get operation choice
                    string choice = Console.ReadLine();
                    
                    if (CaseInsensitiveEquals(choice, "q"))
                    {
                        continueCalculating = false;
                        continue;
                    }
                    
                    // Perform calculation and display result
                    if (CaseInsensitiveEquals(choice, "a"))
                    {
                        var result = number1 + number2;
                        FinalResult(number1, number2, "+", result);
                    }
                    else if(CaseInsensitiveEquals(choice, "s"))
                    {
                        var result = number1 - number2;
                        FinalResult(number1, number2, "-", result);
                    }
                    else if (CaseInsensitiveEquals(choice, "m"))
                    {
                        var result = number1 * number2;
                        FinalResult(number1, number2, "*", result);
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter A, S, or M.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter a valid number.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                }
                
                Console.WriteLine("\nPress Enter to continue or type 'exit' to quit.");
                if (Console.ReadLine()?.ToLower() == "exit")
                {
                    continueCalculating = false;
                }
                
                Console.Clear();
            }
            
            Console.WriteLine("Thank you for using the Calculator!");
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();
        }

        static void FinalResult(int number1, int number2, string operation, int result)
        {
            Console.WriteLine($"The result of {number1} {operation} {number2} is: {result}");
        }

        static bool CaseInsensitiveEquals(string str1, string str2)
        {
            return str1.ToUpper() == str2.ToUpper();
        }
    }
}