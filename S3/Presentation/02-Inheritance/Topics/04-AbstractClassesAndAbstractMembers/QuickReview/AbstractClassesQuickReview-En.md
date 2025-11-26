## Definition
Abstract classes cannot be instantiated and may contain abstract members that must be implemented by derived classes.

## Usage
Use `abstract` keyword for class and members:
```csharp
public abstract class Animal
{
public abstract void MakeSound();  // No implementation
public void Eat() { }              // Can have concrete methods
}

public class Dog : Animal
{
public override void MakeSound() => Console.WriteLine("Woof");
}
```
## Key Points
- Abstract classes cannot be instantiated directly
- Abstract members have no implementation
- Derived classes must implement all abstract members
- Can contain both abstract and concrete members
- Abstract methods are implicitly virtual
- Cannot be sealed
- Can have constructors for derived classes
- Use when sharing code with partial implementation

