# Primary Constructors - Quick Review

## Definition
Primary Constructor is a C# 12 feature that allows writing constructor parameters directly in the class or struct definition, using a more concise syntax instead of writing a separate constructor.

## Usage
- Reducing boilerplate code in class definitions
- Direct access to constructor parameters in all members
- Simplifying dependency injection
- Replacing auto-properties in simple scenarios
- Reducing lines of code in simple classes

## Key Points
- **Syntax**: Parameters after class name: `class MyClass(int x, string y)`
- **Scope**: Parameters are accessible in scope of all class members
- **No Backing Fields**: Parameters don't automatically create backing fields
- **Capture**: Parameters are captured when used in members
- **Records**: Already existed in record types since C# 9
- **Classes/Structs**: Available for class and struct since C# 12
- **Additional Constructors**: Can have additional constructors with `this()`
- **Field Initialization**: Can use parameters to initialize fields
- **Property Initialization**: Can use them in object initializer or property
- **Validation**: Can use field initializer or property for validation
- **Performance**: Unused parameters may create overhead
- **Readability**: Increases readability for simple classes
- **Base Constructor**: Can call base class constructor with `base(...)`
- **Immutability**: Combine with `init` for immutable types
