# Constants - Quick Review

## Definition
A constant is a fixed value determined at compile-time that cannot be changed during program execution.

## Usage
- Defining fixed and immutable values (e.g., PI, MaxValue)
- Preventing direct use of magic numbers
- Improving code readability and maintainability
- Performance optimization (inlined at compile-time)

## Key Points
- **Compile-time Constant**: Value is determined at compile time
- **Implicitly Static**: Always static (no need for static keyword)
- **Supported Types**: Only built-in types (int, string, bool, double, ...) and enums
- **const vs readonly**: const at compile-time, readonly at runtime
- **Inlining**: Compiler directly substitutes the value
- **No Reference**: Cannot take a reference to a constant
- **Versioning Issue**: Changing a const in one assembly requires recompiling other assemblies
- **Local Constants**: Can be defined inside methods
- **Expression Constants**: Can use constant expressions (const int x = 5 + 3;)
- **Access Modifiers**: Can be public, private, internal, ...
