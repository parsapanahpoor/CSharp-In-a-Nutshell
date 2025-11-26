# Static Classes - Quick Review

## Definition
A static class is a special type of class that contains only static members, cannot be instantiated, and cannot be used as a base class. It is defined with the `static` keyword before `class`.

## Usage
- Creating utility and helper methods
- Building extension methods (must be in static class)
- Grouping related methods without needing state
- Creating factory methods
- Mathematical or conversion function libraries

## Key Points
- **Definition**: Defined with `static class`
- **No Instantiation**: Cannot be instantiated with `new`
- **Only Static Members**: Can only contain static members
- **Sealed**: Implicitly sealed (cannot be inherited)
- **No Inheritance**: Cannot inherit from another class (except Object)
- **No Instance Constructor**: Cannot have instance constructor
- **Static Constructor**: Can have static constructor
- **Extension Methods**: Must be defined in static class
- **Thread-Safety**: Must be careful about shared state for thread-safety
- **Namespaces**: Commonly used for organization in namespaces
- **Examples**: `Math`, `Console`, `File`, `Path`, `Convert`
- **Design Pattern**: Alternative to Singleton in some scenarios
- **Testing**: More difficult to test (cannot mock)
- **Dependency Injection**: Not compatible with DI
- **Performance**: Less overhead compared to instance methods
