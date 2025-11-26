using System;

namespace _02_Inheritance.Chapters._00_Inheritance;

public class InheritanceDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Inheritance Demo ===\n");

        // 1. Basic inheritance
        Animal animal = new Dog();
        animal.Eat();           // Inherited
        // animal.Bark();       // ❌ Not accessible via base reference

        Dog dog = new Dog();
        dog.Eat();              // Inherited
        dog.Bark();             // Own method

        // 2. Sealed class
        var final = new SealedClass();
        final.Display();
    }
}

public class Animal
{
    public void Eat() => Console.WriteLine("Animal eats");
}

public class Dog : Animal
{
    public void Bark() => Console.WriteLine("Dog barks");
}

public sealed class SealedClass
{
    public void Display() => Console.WriteLine("Sealed - cannot inherit");
}
