# Partial Types and Methods - Quick Review

## Definition
Partial Types allow splitting the definition of a class, struct, interface, or record across multiple files. Partial Methods also allow defining a method in one part and implementing it in another. They are defined with the `partial` keyword.

## Usage
- Separating generated code from user code
- Team collaboration on large classes
- Organizing code into logical files
- Designer-generated code (Windows Forms, WPF)
- Separation of concerns in complex classes
- Code generation scenarios

## Key Points
- **Syntax**: `partial class ClassName { }`
- **Multiple Files**: Can be defined in multiple files
- **Same Assembly**: All parts must be in the same assembly
- **Merge at Compile**: Merged together at compile time
- **Access Modifiers**: Must be the same in all parts
- **Base Class**: Base class can only be specified in one part (or same in all)
- **Interfaces**: Different interfaces can be implemented in different parts
- **Attributes**: Attributes from all parts are combined
- **Generic Types**: Can have partial generic types
- **Partial Methods**: Method defined in one part and implemented in another
- **Optional Implementation**: Partial method implementation is optional (pre-C# 9)
- **C# 9 Changes**: Partial methods can have return type and access modifier
- **Code Generation**: Ideal for source generators
- **Designer Support**: Used in Visual Studio designers
- **Nested Types**: Can have nested partial types
