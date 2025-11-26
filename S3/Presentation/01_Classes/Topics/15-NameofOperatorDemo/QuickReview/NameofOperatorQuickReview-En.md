# nameof Operator - Quick Review

## Definition
The `nameof` operator is a compile-time operator that returns the name of a variable, type, or member as a string. It is refactoring-safe and prevents hard-coded strings.

## Usage
- Argument validation
- Implementing INotifyPropertyChanged
- Logging and exception messages
- Attribute arguments
- MVC action names
- Dependency injection registration
- Serialization property names
- Raising events with property names

## Key Points
- **Syntax**: `nameof(variable)` or `nameof(Type.Member)`
- **Compile-Time**: Converted to string at compile time
- **Refactoring-Safe**: Updates with rename in IDE
- **No Runtime Cost**: No runtime overhead
- **Simple Name**: Returns only simple name (not fully qualified)
- **Generic Types**: Works with generic types
- **Members**: Can return name of method, property, field, etc.
- **Parameters**: Can return parameter names
- **Local Variables**: Works with local variables
- **Expression Body**: Useful in expression-bodied members
- **ArgumentNullException**: Ideal for throwing with parameter name
- **CallerArgumentExpression**: New option in C# 10+ for validation
- **INotifyPropertyChanged**: Replacement for magic strings
- **No Type Checking**: Only returns name, no type safety
- **Case Sensitive**: Case sensitive
