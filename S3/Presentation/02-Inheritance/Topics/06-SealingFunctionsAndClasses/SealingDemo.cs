using System;

namespace _02_Inheritance.Chapters._06_SealingFunctionsAndClasses;

public class SealingDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Sealing Functions and Classes Demo ===\n");

        // 1. Sealed class - cannot inherit
        FinalClass final = new FinalClass();
        final.Display();
        // class CannotInherit : FinalClass { } // Error!

        Console.WriteLine();

        // 2. Sealed override method
        Level2 obj = new Level2();
        obj.Calculate();

        Console.WriteLine();

        // 3. Real-world example
        Rectangle rect = new Rectangle(5, 3);
        Console.WriteLine($"Area: {rect.GetArea()}");
    }
}

// Sealed class
public sealed class FinalClass
{
    public void Display() => Console.WriteLine("This class cannot be inherited");
}

// Sealed override
public class Level1
{
    public virtual void Calculate() => Console.WriteLine("Level1 calculation");
}

public class Level2 : Level1
{
    public sealed override void Calculate() => Console.WriteLine("Level2 calculation (sealed)");
}

public class Level3 : Level2
{
    // public override void Calculate() { } // Error: Cannot override sealed method
}

// Real-world: System.String is sealed
public abstract class Shape
{
    public abstract double GetArea();
}

public sealed class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea() => Width * Height;
}
