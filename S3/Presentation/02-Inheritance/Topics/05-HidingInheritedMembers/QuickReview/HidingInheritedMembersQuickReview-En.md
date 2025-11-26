# Hiding Inherited Members

## Definition
Hiding allows derived class to define a member with same name as base class member, using `new` keyword.

## Usage
Use `new` to hide base member:
```csharp
public class Base
{
public void Method() => Console.WriteLine("Base");
}

public class Derived : Base
{
public new void Method() => Console.WriteLine("Derived");
}

## Key Points
- Use `new` keyword to hide inherited members
- Not polymorphic - called method depends on reference type
- Generates compiler warning if `new` omitted
- Can hide methods, properties, fields, events
- Base member still accessible via base class reference
- Different from overriding - no runtime polymorphism
- Avoid unless necessary - prefer virtual/override