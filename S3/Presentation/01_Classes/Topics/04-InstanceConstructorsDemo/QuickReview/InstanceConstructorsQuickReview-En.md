# Instance Constructors - Quick Review

## Definition
A constructor is a special method called when creating an instance of a class, used for initializing the object.

## Usage
- Initializing fields and properties
- Executing necessary logic during object creation
- Validating input parameters
- Setting up the initial state of the object

## Key Points
- **Same Name as Class**: Constructor name must exactly match the class name
- **No Return Type**: Not even void
- **Default Constructor**: If no constructor is defined, compiler generates a parameterless constructor
- **Constructor Overloading**: Can have multiple constructors with different parameters
- **Constructor Chaining**: Using this() to call another constructor
- **Base Class Constructor**: Using base() to call base class constructor
- **Execution Order**: Base constructor → Field initializers → Constructor body
- **Access Modifiers**: public, private, protected, internal, ...
- **Private Constructor**: For Singleton Pattern or static-only classes
- **Expression-bodied Constructor**: Shorter syntax with => (C# 7+)
- **Object Initializers**: Setting properties after constructor with { }
- **Required Members**: Using required keyword (C# 11+)
