using SOLIDPrinciples.SingleResponsability;

using SOLIDPrinciples;

int seasonNumber = 0;
Season spring = (Season)seasonNumber;

decimal a = 10.01m;
int integer = 10;
decimal b = integer; // Implicit conversion from int to decimal

internal enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}



//SingleResponsabilityPrinciple.Run();

//var pizza = new Pizza();
//pizza.AddIngredient(new Cheddar());
//pizza.AddIngredient(new Mozzarella());
//pizza.AddIngredient(new TomatoSauce());

//Console.WriteLine(pizza.ToString());

var ingredient = new Ingredient(1);
var cheddar = new Cheddar(2, 12);
Console.WriteLine(cheddar);

Console.ReadLine();

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