# Virtual Function Members

## Definition
Virtual members allow derived classes to override base class behavior, enabling runtime polymorphism.

## Usage
Mark methods/properties with `virtual` in base class, use `override` in derived classes:
```csharp
public class Shape
{
public virtual double Area => 0;
}

public class Circle : Shape
{
public double Radius { get; set; }
public override double Area => Math.PI * Radius * Radius;
}
```

## Key Points
- Virtual members provide default implementation
- Override changes behavior for derived types
- Use `base.Method()` to call parent implementation
- Cannot override non-virtual members
- Must match signature exactly
- Static methods cannot be virtual
- Slight performance overhead due to runtime lookup
