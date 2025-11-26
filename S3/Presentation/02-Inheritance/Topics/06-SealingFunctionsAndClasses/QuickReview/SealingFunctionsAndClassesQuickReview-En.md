## Definition
`sealed` prevents further inheritance of classes or overriding of methods.

## Usage
Seal classes or override methods:
```csharp
public sealed class FinalClass { }  // Cannot inherit

public class Base
{
public virtual void Method() { }
}

public class Derived : Base
{
public sealed override void Method() { }  // Cannot override again
}
```
## Key Points
- Sealed classes cannot be inherited
- Sealed methods cannot be overridden in derived classes
- Must use `sealed` with `override` keyword
- Cannot seal non-virtual or non-override methods
- Performance benefit - compiler optimization
- `System.String` is a sealed class
- Use for security or design integrity
