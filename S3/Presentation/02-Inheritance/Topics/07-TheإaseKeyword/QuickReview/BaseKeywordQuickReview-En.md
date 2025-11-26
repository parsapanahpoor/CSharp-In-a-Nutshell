## Definition
`base` keyword accesses members of the base class from within a derived class.

## Usage
Call base constructors, methods, or properties:
```csharp
public class Base
{
public Base(int x) { }
public virtual void Method() { }
}

public class Derived : Base
{
public Derived(int x) : base(x) { }  // Call base constructor

public override void Method()
{
base.Method();  // Call base method
}
}
```
## Key Points
- Access base class members from derived class
- Use `: base()` to call base constructor
- Use `base.Method()` to call base methods
- Required when base has no parameterless constructor
- Cannot use in static methods
- Useful for extending base functionality
- Common in override methods

