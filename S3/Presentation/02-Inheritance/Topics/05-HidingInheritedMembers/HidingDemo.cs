using System;

namespace _02_Inheritance.Chapters._05_HidingInheritedMembers;

public class HidingDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Hiding Inherited Members Demo ===\n");

        // 1. Hiding with 'new' keyword
        Base b1 = new Base();
        Derived d1 = new Derived();
        Base b2 = new Derived();

        b1.Display();  // Output: Base Display
        d1.Display();  // Output: Derived Display
        b2.Display();  // Output: Base Display (not polymorphic!)

        Console.WriteLine();

        // 2. Hiding properties
        BaseClass bc = new DerivedClass();
        DerivedClass dc = new DerivedClass();

        Console.WriteLine($"bc.Value = {bc.Value}");  // Output: 10
        Console.WriteLine($"dc.Value = {dc.Value}");  // Output: 20

        Console.WriteLine();

        // 3. Warning without 'new'
        ParentClass parent = new ChildClass();
        ChildClass child = new ChildClass();

        parent.Info();  // Output: Parent Info
        child.Info();   // Output: Child Info
    }
}

// Hiding methods
public class Base
{
    public void Display() => Console.WriteLine("Base Display");
}

public class Derived : Base
{
    public new void Display() => Console.WriteLine("Derived Display");
}

// Hiding properties
public class BaseClass
{
    public int Value => 10;
}

public class DerivedClass : BaseClass
{
    public new int Value => 20;
}

// Without 'new' keyword (generates compiler warning)
public class ParentClass
{
    public void Info() => Console.WriteLine("Parent Info");
}

public class ChildClass : ParentClass
{
    public new void Info() => Console.WriteLine("Child Info");
}
