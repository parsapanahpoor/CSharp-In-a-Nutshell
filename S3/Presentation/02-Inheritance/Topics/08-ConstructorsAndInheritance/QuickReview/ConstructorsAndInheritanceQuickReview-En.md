## Definition
Constructors execute from base to derived class in inheritance hierarchy.

## Usage
Use `: base()` to call base constructor:
```csharp
public class Base
{
public Base(int x) { }
}

public class Derived : Base
{
public Derived(int x) : base(x) { }  // Must call base
}
```
## Key Points
- Base constructor executes before derived constructor
- Must call base constructor if no parameterless constructor exists
- Use `: base(args)` to pass parameters to base constructor
- Execution order: Grandparent → Parent → Child
- Cannot inherit constructors
- Static constructors execute before instance constructors
- Use `: this()` to call another constructor in same class
