using System;

namespace _02_Inheritance.Chapters._04_AbstractClasses;

public class AbstractDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Abstract Classes and Members Demo ===\n");

        // 1. Abstract classes - cannot instantiate
        // Animal animal = new Animal(); // Error!

        Animal[] animals = { new Dog("Max"), new Cat("Whiskers"), new Bird("Tweety") };

        foreach (var animal in animals)
        {
            animal.MakeSound();
            animal.Move();
            Console.WriteLine();
        }

        // 2. Abstract properties
        IShape[] shapes = { new Square(5), new CircleShape(3) };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"{shape.GetType().Name}: Area = {shape.Area:F2}, Perimeter = {shape.Perimeter:F2}");
        }

        Console.WriteLine();

        // 3. Mix of abstract and concrete members
        Vehicle car = new Car("Toyota");
        Vehicle bike = new Motorcycle("Yamaha");

        car.Start();
        car.Drive();
        car.Stop();

        Console.WriteLine();

        bike.Start();
        bike.Drive();
        bike.Stop();
    }
}

// Abstract class with abstract methods
public abstract class Animal
{
    public string Name { get; set; }

    protected Animal(string name) => Name = name;

    public abstract void MakeSound();  // Must be implemented
    public abstract void Move();       // Must be implemented

    public void Sleep() => Console.WriteLine($"{Name} is sleeping...");  // Concrete method
}

public class Dog : Animal
{
    public Dog(string name) : base(name) { }

    public override void MakeSound() => Console.WriteLine($"{Name} says: Woof!");
    public override void Move() => Console.WriteLine($"{Name} runs on four legs");
}

public class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public override void MakeSound() => Console.WriteLine($"{Name} says: Meow!");
    public override void Move() => Console.WriteLine($"{Name} walks gracefully");
}

public class Bird : Animal
{
    public Bird(string name) : base(name) { }

    public override void MakeSound() => Console.WriteLine($"{Name} says: Tweet!");
    public override void Move() => Console.WriteLine($"{Name} flies in the sky");
}

// Abstract properties
public interface IShape
{
    double Area { get; }
    double Perimeter { get; }
}

public class Square : IShape
{
    private double _side;

    public Square(double side) => _side = side;

    public double Area => _side * _side;
    public double Perimeter => 4 * _side;
}

public class CircleShape : IShape
{
    private double _radius;

    public CircleShape(double radius) => _radius = radius;

    public double Area => Math.PI * _radius * _radius;
    public double Perimeter => 2 * Math.PI * _radius;
}

// Mix of abstract and concrete
public abstract class Vehicle
{
    public string Brand { get; set; }

    protected Vehicle(string brand) => Brand = brand;

    public abstract void Drive();  // Abstract

    public void Start() => Console.WriteLine($"{Brand} engine started");     // Concrete
    public void Stop() => Console.WriteLine($"{Brand} engine stopped");      // Concrete
}

public class Car : Vehicle
{
    public Car(string brand) : base(brand) { }

    public override void Drive() => Console.WriteLine($"{Brand} car driving on road");
}

public class Motorcycle : Vehicle
{
    public Motorcycle(string brand) : base(brand) { }

    public override void Drive() => Console.WriteLine($"{Brand} motorcycle cruising");
}
