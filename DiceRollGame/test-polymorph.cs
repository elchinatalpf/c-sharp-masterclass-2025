using System;
using System.Collections.Generic;
using System.Linq;

public class PolymorphismDemo
{
    public static void Run()
    {
        // --- Original Number Calculator Example ---
        //Console.WriteLine("--- Number Calculator Example ---");
        var numbers = new List<int> { 1, 4, 6, -1, 12, 44, -8, -19 };
        bool shallAddPositiveOnly = true;

        // Polymorphism: same variable type, different behavior based on actual object
        NumbersSumCalculator calculator = shallAddPositiveOnly ? new PositiveNumbersSumCalculator() : new NumbersSumCalculator();

        var sum = calculator.Calculate(numbers); // Uses the appropriate Calculate method

        //Console.WriteLine($"Add positive only: {shallAddPositiveOnly}");
        //Console.WriteLine($"The sum of the numbers is: {sum}");
        //Console.WriteLine();

        // --- New Pizza Ingredients Example ---
        Console.WriteLine("--- Pizza Ingredients Example ---");
        DemonstratePizzaCreation();

        Console.ReadLine();
    }

    public static void DemonstratePizzaCreation()
    {
        //var pizza = new Pizza();

        //// Polymorphism: Adding different objects that are all of type "Ingredient"
        //pizza.AddIngredient(new Cheddar());
        //pizza.AddIngredient(new Mozzarella());
        //pizza.AddIngredient(new TomatoSauce());

        var cheddar = new Cheddar();

        //Console.WriteLine(pizza.ToString());
        //Console.WriteLine(cheddar);
        //var gen = new System.Collections.Generic.List<Ingredient>();
        //Console.WriteLine(new List<int>());
    }
}

// --- Number Calculator Example Classes ---

public class NumbersSumCalculator
{
    public int Calculate(List<int> numbers)
    {
        int sum = 0;
        foreach (var number in numbers)
        {
            if (ShallBeAdded(number))
            {
                sum += number;
            }
        }
        return sum;
    }
    protected virtual bool ShallBeAdded(int number)
    {
        return true;
    }
}

public class PositiveNumbersSumCalculator : NumbersSumCalculator
{
    protected override bool ShallBeAdded(int number)
    {
        return number > 0;
    }
}

// --- Pizza Example Classes ---

public class Pizza
{
    private readonly List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);

    // This method uses polymorphism. It calls the "Name" property on each
    // ingredient, and the correct name is returned based on the object's actual type.
    public override string ToString() => $"This is a pizza with: {string.Join(", ", _ingredients.Select(i => i.Name))}";
}

// Base class for all ingredients
public class Ingredient
{
    public Ingredient()
    {
        Console.WriteLine("Constructor from the Ingredient Class");
    }
    public override string ToString() => Name;
    // A virtual property that can be overridden by derived classes
    public virtual string Name { get; } = "Some ingredient";
    public int PublicField;
    public string PublicMethod() => "This method is public in the Ingredient class.";
    protected string ProtectedMethod() => "this method is Protected in the Ingredient class.";
    private string PrivateMethod() => "this methos is Private in the Ingredient class.";
}

public class ItalianFoodItem
{

}

// A class that inherits from Ingredient
public class Cheese : Ingredient
{
    public override string Name => "cheese";
}

// A class that inherits from Cheese
public class Cheddar : Ingredient
{
    public Cheddar()
    {
        Console.WriteLine("Constructor from the Ingredient Class");
    }
    public override string Name => "Cheddar cheese";
    public int AgeForMonths { get; }
    public void UseMethodsFromBaseClass()
    {
        Console.WriteLine(PublicMethod()); // Calls the public method from Ingredient
        Console.WriteLine(ProtectedMethod()); // Calls the protected method from Ingredient
        // Console.WriteLine(PrivateMethod()); // This line would cause a compile error because PrivateMethod is not accessible here
    }
}

// A class that inherits from Ingredient
public class Mozzarella : Cheese
{
    public override string Name => "Mozzarella cheese";
}

// This class now correctly inherits from Ingredient
public class TomatoSauce : Ingredient
{
    public override string Name => "Tomato sauce";
}


// Animal Class example
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic animal sound");
    }
}

class HousePet : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow or Woof");
    }
}

class  Feline : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class DomesticCat : Feline
{

}