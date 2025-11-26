# Inheritance - Quick Review

## Definition
A class inherits members from a base class, creating an **IS-A** relationship. C# supports **single inheritance** only.

## Key Use Cases
- Code reusability across related classes
- Polymorphism via base class references
- Type hierarchy modeling

## Critical Points
- **Single inheritance**: One direct base class only
- **System.Object**: All classes inherit from it implicitly
- **Not inherited**: Constructors, static constructors, finalizers
- **sealed**: Prevents further inheritance
- **Upcasting**: Derived → Base (implicit, always safe)

```csharp
class Base { }
class Derived : Base { }  // OK
Base b = new Derived();   // Implicit upcast ✅