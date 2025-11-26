using System;

namespace _02_Inheritance.Chapters._08_ConstructorsAndInheritance;

public class ConstructorsDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Constructors and Inheritance Demo ===\n");

        // 1. Constructor execution order
        Console.WriteLine("Creating Child object:");
        Child child = new Child();

        Console.WriteLine();

        // 2. Parameterized constructors
        Console.WriteLine("Creating Car object:");
        Car car = new Car("Tesla", "Model 3", 2024);
        car.Display();

        Console.WriteLine();

        // 3. Multiple constructors
        Console.WriteLine("Creating Employee objects:");
        Employee emp1 = new Employee("Reza");
        Employee emp2 = new Employee("Sara", 50000);
        emp1.Show();
        emp2.Show();
    }
}

// Constructor execution order
public class Grandparent
{
    public Grandparent() => Console.WriteLine("Grandparent constructor");
}

public class Parent : Grandparent
{
    public Parent() => Console.WriteLine("Parent constructor");
}

public class Child : Parent
{
    public Child() => Console.WriteLine("Child constructor");
}

// Parameterized constructors
public class Vehicle
{
    public string Brand { get; set; }

    public Vehicle(string brand)
    {
        Brand = brand;
        Console.WriteLine($"Vehicle constructor: {Brand}");
    }
}

public class Car : Vehicle
{
    public string Model { get; set; }
    public int Year { get; set; }

    public Car(string brand, string model, int year) : base(brand)
    {
        Model = model;
        Year = year;
        Console.WriteLine($"Car constructor: {Model} {Year}");
    }

    public void Display() => Console.WriteLine($"{Brand} {Model} ({Year})");
}

// Multiple constructors
public class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
        Console.WriteLine("Person constructor");
    }
}

public class Employee : Person
{
    public decimal Salary { get; set; }

    public Employee(string name) : base(name)
    {
        Salary = 30000;
    }

    public Employee(string name, decimal salary) : base(name)
    {
        Salary = salary;
    }

    public void Show() => Console.WriteLine($"{Name}: ${Salary}");
}
