## Definition
Method overloading allows multiple methods with same name but different parameters. Compiler selects best match at compile-time.

## Usage
Overload methods by parameter type, count, or order:
```csharp
public class Math
{
public int Add(int a, int b) { }
public double Add(double a, double b) { }
public int Add(int a, int b, int c) { }
}
```
## Key Points
- Methods must differ in parameters (type, count, or order)
- Return type alone cannot distinguish overloads
- Compiler selects most specific match
- Resolution occurs at compile-time
- Inherited methods participate in overload resolution
- `params` parameters have lowest priority
- Null matches reference types, not value types
