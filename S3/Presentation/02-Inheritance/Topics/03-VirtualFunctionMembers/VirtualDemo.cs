namespace _02_Inheritance.Chapters._03_VirtualFunctionMembers;

public class VirtualDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Virtual Function Members Demo ===\n");

        // 1. Virtual methods - runtime polymorphism
        Shape[] shapes = { new Circle(5), new Rectangle(4, 6), new Triangle(3, 4) };

        foreach (var shape in shapes)
        {
            shape.Draw();
            Console.WriteLine($"Area: {shape.CalculateArea():F2}");
            Console.WriteLine($"Perimeter: {shape.CalculatePerimeter():F2}\n");
        }

        // 2. Virtual properties
        Employee emp1 = new Manager { BaseSalary = 5000 };
        Employee emp2 = new Developer { BaseSalary = 4000 };

        Console.WriteLine($"Manager total: ${emp1.TotalSalary}");
        Console.WriteLine($"Developer total: ${emp2.TotalSalary}\n");

        // 3. Calling base implementation
        AdvancedPrinter printer = new AdvancedPrinter();
        printer.Print("Hello World");
    }
}

// Virtual methods example
public class Shape
{
    public virtual void Draw() => Console.WriteLine("Drawing generic shape");
    public virtual double CalculateArea() => 0;
    public virtual double CalculatePerimeter() => 0;
}

public class Circle : Shape
{
    private double _radius;

    public Circle(double radius) => _radius = radius;

    public override void Draw() => Console.WriteLine("Drawing Circle ⭕");
    public override double CalculateArea() => Math.PI * _radius * _radius;
    public override double CalculatePerimeter() => 2 * Math.PI * _radius;
}

public class Rectangle : Shape
{
    private double _width, _height;

    public Rectangle(double width, double height)
    {
        _width = width;
        _height = height;
    }

    public override void Draw() => Console.WriteLine("Drawing Rectangle ▭");
    public override double CalculateArea() => _width * _height;
    public override double CalculatePerimeter() => 2 * (_width + _height);
}

public class Triangle : Shape
{
    private double _baseLength, _height;

    public Triangle(double baseLength, double height)
    {
        _baseLength = baseLength;
        _height = height;
    }

    public override void Draw() => Console.WriteLine("Drawing Triangle △");
    public override double CalculateArea() => 0.5 * _baseLength * _height;
    public override double CalculatePerimeter() => _baseLength + 2 * Math.Sqrt((_baseLength / 2) * (_baseLength / 2) + _height * _height);
}

// Virtual properties example
public class Employee
{
    public double BaseSalary { get; set; }
    public virtual double TotalSalary => BaseSalary;  // Virtual property
}

public class Manager : Employee
{
    public override double TotalSalary => BaseSalary * 1.5;  // 50% bonus
}

public class Developer : Employee
{
    public override double TotalSalary => BaseSalary * 1.2;  // 20% bonus
}

// Calling base implementation
public class Printer
{
    public virtual void Print(string text)
    {
        Console.WriteLine($"[Base] Printing: {text}");
    }
}

public class AdvancedPrinter : Printer
{
    public override void Print(string text)
    {
        Console.WriteLine("[Advanced] Pre-processing...");
        base.Print(text);  // Call base implementation
        Console.WriteLine("[Advanced] Post-processing complete");
    }
}
