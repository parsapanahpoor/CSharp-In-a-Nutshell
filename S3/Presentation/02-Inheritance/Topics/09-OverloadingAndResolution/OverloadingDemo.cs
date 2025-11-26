using System;

namespace _02_Inheritance.Chapters._09_OverloadingAndResolution;

public class OverloadingDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Overloading and Resolution Demo ===\n");

        // 1. Method overloading
        Calculator calc = new Calculator();
        Console.WriteLine($"Add(5, 3) = {calc.Add(5, 3)}");
        Console.WriteLine($"Add(5.5, 3.2) = {calc.Add(5.5, 3.2)}");
        Console.WriteLine($"Add(1, 2, 3) = {calc.Add(1, 2, 3)}");

        Console.WriteLine();

        // 2. Resolution with inheritance
        Base baseObj = new Base();
        Derived derivedObj = new Derived();
        baseObj.Process(10);
        derivedObj.Process(10);
        derivedObj.Process("Hello");

        Console.WriteLine();

        // 3. Ambiguous overload resolution
        Printer printer = new Printer();
        printer.Print(42);           // int
        printer.Print(3.14);         // double
        printer.Print("Text");       // string
        printer.Print(null);         // string (most specific)
    }
}

// Method overloading
public class Calculator
{
    public int Add(int a, int b) => a + b;

    public double Add(double a, double b) => a + b;

    public int Add(int a, int b, int c) => a + b + c;
}

// Resolution with inheritance
public class Base
{
    public void Process(int x) => Console.WriteLine($"Base.Process(int): {x}");
}

public class Derived : Base
{
    public void Process(string s) => Console.WriteLine($"Derived.Process(string): {s}");
}

// Overload resolution
public class Printer
{
    public void Print(int value) => Console.WriteLine($"Printing int: {value}");

    public void Print(double value) => Console.WriteLine($"Printing double: {value}");

    public void Print(string value) => Console.WriteLine($"Printing string: {value}");

    public void Print(object value) => Console.WriteLine($"Printing object: {value}");
}
