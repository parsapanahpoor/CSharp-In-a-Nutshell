using System;

namespace _02_Inheritance.Chapters._07_BaseKeyword;

public class BaseKeywordDemo
{
    public static void Run()
    {
        Console.WriteLine("=== The base Keyword Demo ===\n");

        // 1. Calling base constructor
        Student student = new Student("Ali", 20, "CS101");
        student.Display();

        Console.WriteLine();

        // 2. Calling base method
        Manager manager = new Manager("Sara", 50000, 10);
        manager.ShowDetails();

        Console.WriteLine();

        // 3. Accessing base properties
        Circle circle = new Circle(5, "Red");
        circle.ShowInfo();
    }
}

// Base constructor call
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        Console.WriteLine("Person constructor called");
    }

    public virtual void Display() => Console.WriteLine($"Name: {Name}, Age: {Age}");
}

public class Student : Person
{
    public string StudentId { get; set; }

    public Student(string name, int age, string studentId) : base(name, age)
    {
        StudentId = studentId;
        Console.WriteLine("Student constructor called");
    }

    public override void Display()
    {
        base.Display();  // Call base implementation
        Console.WriteLine($"Student ID: {StudentId}");
    }
}

// Base method call
public class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }

    public virtual void ShowDetails() => Console.WriteLine($"{Name}: ${Salary}");
}

public class Manager : Employee
{
    public int TeamSize { get; set; }

    public Manager(string name, decimal salary, int teamSize) : base(name, salary)
    {
        TeamSize = teamSize;
    }

    public override void ShowDetails()
    {
        base.ShowDetails();  // Extend base behavior
        Console.WriteLine($"Team Size: {TeamSize}");
    }
}

// Base property access
public class Shape
{
    public string Color { get; set; }

    public Shape(string color) => Color = color;
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius, string color) : base(color)
    {
        Radius = radius;
    }

    public void ShowInfo() => Console.WriteLine($"Circle: Radius={Radius}, Color={base.Color}");
}
