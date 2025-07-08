// 1. What is Polymorphism?
// Polymorphism is one of the core principles of Object-Oriented Programming (OOP).
// The word "polymorphism" means "many forms," and in programming, it refers to the ability of a single interface to represent different underlying forms (data types).
// In C#, polymorphism is achieved through inheritance and virtual methods.

// 2. Base Class (Parent Class)
// Let's create a base class called 'Shape'. This class will have a method called 'Draw'.
// We use the 'virtual' keyword to allow derived classes to override this method.
public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

// 3. Derived Classes (Child Classes)
// Now, let's create a few derived classes that inherit from the 'Shape' class.
// Each of these classes will override the 'Draw' method to provide its own specific implementation.

public class Circle : Shape
{
    // 4. Overriding the method
    // The 'override' keyword is used to provide a new implementation of a virtual method from the base class.
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

public class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a triangle");
    }
}

// 8. Extensibility
// Let's add a new shape. Notice we don't have to change the existing code that draws the shapes.
public class Pentagon : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a pentagon");
    }
}

// 5. Putting it all together
// Now, let's see how polymorphism works in action.
public class PolymorphismExample
{
    public static void Run()
    {
        // 6. Creating a list of shapes
        // We can create a list that holds objects of the base class 'Shape'.
        var shapes = new List<Shape>
        {
            new Circle(),
            new Rectangle(),
            new Triangle(),
            new Pentagon() // We can add a new shape without changing the loop below.
        };

        // 7. Demonstrating Polymorphism
        // We can iterate through the list and call the 'Draw' method on each object.
        // Even though we are calling the same method, the output will be different for each object
        // because each class has its own implementation of the 'Draw' method.
        // This is polymorphism in action!
        // THE KEY: This loop doesn't need to be changed if we add more shapes.
        // It's flexible and extensible.
        foreach (var shape in shapes)
        {
            shape.Draw();
        }
    }
}
