using System;

namespace _02_Inheritance.Chapters._01_Polymorphism;

public class PolymorphismDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Polymorphism Demo ===\n");

        // 1. Static polymorphism (Compile-time) - Method Overloading
        Calculator calc = new Calculator();
        Console.WriteLine($"Add(2, 3) = {calc.Add(2, 3)}");
        Console.WriteLine($"Add(2.5, 3.7) = {calc.Add(2.5, 3.7)}");
        Console.WriteLine($"Add(1, 2, 3) = {calc.Add(1, 2, 3)}\n");

        // 2. Dynamic polymorphism (Runtime) - Method Overriding
        Shape shape1 = new Circle();
        Shape shape2 = new Rectangle();

        shape1.Draw();  // Circle's Draw
        shape2.Draw();  // Rectangle's Draw

        Console.WriteLine($"\nCircle Area: {shape1.GetArea()}");
        Console.WriteLine($"Rectangle Area: {shape2.GetArea()}");
    }
}

// Static Polymorphism (Overloading)
public class Calculator
{
    public int Add(int a, int b) => a + b;
    public double Add(double a, double b) => a + b;
    public int Add(int a, int b, int c) => a + b + c;
}

// Dynamic Polymorphism (Overriding)
public class Shape
{
    public virtual void Draw() => Console.WriteLine("Drawing a shape");
    public virtual double GetArea() => 0;
}

public class Circle : Shape
{
    public override void Draw() => Console.WriteLine("Drawing a circle ⭕");
    public override double GetArea() => Math.PI * 5 * 5; // Radius = 5
}

public class Rectangle : Shape
{
    public override void Draw() => Console.WriteLine("Drawing a rectangle ▭");
    public override double GetArea() => 10 * 5; // Width=10, Height=5
}
