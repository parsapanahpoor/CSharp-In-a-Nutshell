using System;

namespace _02_Inheritance.Chapters._02_CastingAndReferenceConversions;

public class CastingDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Casting and Reference Conversions Demo ===\n");

        // 1. Upcasting (implicit, always safe)
        Dog dog = new Dog { Name = "Buddy" };
        Animal animal = dog;  // Implicit upcast
        animal.Eat();
        // animal.Bark();  // ❌ Cannot access Dog members
        Console.WriteLine();

        // 2. Downcasting (explicit, needs runtime check)
        Animal animal2 = new Dog { Name = "Max" };

        // Safe downcast with 'as'
        Dog? dog2 = animal2 as Dog;
        if (dog2 != null)
        {
            dog2.Bark();
            Console.WriteLine($"Name: {dog2.Name}");
        }

        // Direct cast (throws exception if fails)
        Dog dog3 = (Dog)animal2;  // OK - actually is a Dog
        dog3.Bark();
        Console.WriteLine();

        // 3. Type checking with 'is'
        Animal animal3 = new Cat { Name = "Whiskers" };

        if (animal3 is Dog d)
        {
            d.Bark();  // Won't execute
        }
        else if (animal3 is Cat c)
        {
            c.Meow();
            Console.WriteLine($"Cat name: {c.Name}");
        }
        Console.WriteLine();

        // 4. Failed cast example
        try
        {
            Animal animal4 = new Cat();
            Dog dog4 = (Dog)animal4;  // ❌ InvalidCastException
        }
        catch (InvalidCastException ex)
        {
            Console.WriteLine($"❌ Cast failed: {ex.Message}");
        }
    }
}

public class Animal
{
    public string Name { get; set; } = "";
    public void Eat() => Console.WriteLine($"{Name} is eating");
}

public class Dog : Animal
{
    public void Bark() => Console.WriteLine($"{Name} barks: Woof!");
}

public class Cat : Animal
{
    public void Meow() => Console.WriteLine($"{Name} meows: Meow!");
}
