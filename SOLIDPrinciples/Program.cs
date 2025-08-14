using SOLIDPrinciples.SingleResponsability;

using SOLIDPrinciples;

//int seasonNumber = 0;
//Season spring = (Season)seasonNumber;

//decimal a = 10.01m;
//int integer = 10;
//decimal b = integer;

//decimal c = 10000000000000000000000000000000000000000000.01m; // This is a valid decimal literal
//int d = (int)c; // This will cause a compile-time error because the value is too large for an int

//string s = (string)integer; // This will cause a compile-time error because int cannot be implicitly converted to string
//int secondSeasonNumber = 1;
//Season summer = (Season)secondSeasonNumber;

//internal enum Season
//{
//    Spring,
//    Summer,
//    Autumn,
//    Winter
//}

//SingleResponsabilityPrinciple.Run();

//var pizza = new Pizza();
//pizza.AddIngredient(new Cheddar());
//pizza.AddIngredient(new Mozzarella());
//pizza.AddIngredient(new TomatoSauce());

//Console.WriteLine(pizza.ToString());

Ingredient ingredient = new Cheddar(2, 12);

Ingredient randomIngredient = GenerateRandomIngredient();
Console.WriteLine("Random ingredient is " + randomIngredient);
Cheddar cheddar = (Cheddar)randomIngredient;

Console.ReadLine();

Ingredient GenerateRandomIngredient()
{
    var random = new Random();
    var number = random.Next(1,4); // Generates a random number between 1 and 3
    if (number == 1) { return new Cheddar(2, 12);  }
    if (number == 2) { return new TomatoSauce(1); }
    else return new Mozzarella(2);
}

public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);

    public override string ToString() => $"This is a pizaa with {string.Join(", ", _ingredients)}";
}

public class Ingredient
{
    public Ingredient(int priceIfExtraTopping)
    {
        Console.WriteLine("Constructor from the Ingredient class");
        PriceIfExtraTopping = priceIfExtraTopping;
    }
    public int PriceIfExtraTopping { get; }
    public override string ToString() => Name;
    public virtual string Name { get; } = "Some ingredient";
    public int PublicField;
    public string PublicMethod() => "This method is PUBLIC in the Ingredient class.";
    protected string ProtectedMethod() => "This method is PROTECTED in the Ingredient class.";
    private string PrivateMethod() => "This method is PRIVATE in the Ingredient class.";
}
public class Cheese : Ingredient
{
    public Cheese(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }
}
public class Mozzarella : Cheese
{
    public Mozzarella(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }

    public override string Name => "Mozzarella";
    public bool IsLight { get; }
}

public class  Cheddar : Ingredient
{
    public Cheddar(int priceIfExtraTopping, int agedForMonths) : base(priceIfExtraTopping)
    {
        AgedForMonths = agedForMonths;
        Console.WriteLine("Constructor from the Ingredient class");
    }
    public override string Name => $"{base.Name}, more specifically, " + $"Cheddar cheese aged for {AgedForMonths}";
    public int AgedForMonths { get; }
    public void UseMethodsFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
        Console.WriteLine(ProtectedMethod());
        // Console.WriteLine(PrivateMethod()); // This line would cause a compile-time error because PrivateMethod is not accessible here.
    }

}

public class TomatoSauce : Ingredient
{
    public TomatoSauce(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }

    public override string Name => "Tomato sauce";
    public int TomatoesIn100Grams { get; }
}