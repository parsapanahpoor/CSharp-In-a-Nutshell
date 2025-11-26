# Object Initializers - Quick Review

## Definition
Object Initializer is a syntax that allows you to assign values to accessible properties or fields of an object immediately after calling the constructor, all in one expression.

## Usage
- Initializing properties at object creation time
- Reducing the need for multiple constructors with different parameters
- Creating more readable and concise code
- Setting multiple properties simultaneously

## Key Points
- **Syntax**: Using `{ Property = value, ... }` after constructor
- **Accessible Members**: Only public and writable properties/fields can be used
- **Constructor Call**: Constructor runs first, then initializer
- **No Parameterless Constructor**: If constructor has parameters, you must call it
- **Nested Initializers**: Can initialize nested properties too
- **Collection Initializers**: Combining with Collection Initializer for lists
- **Anonymous Types**: Used in defining Anonymous Types
- **Init-only Properties**: With `init` accessor, can only be set during initialization (C# 9+)
- **Required Members**: With `required` keyword, must be initialized (C# 11+)
- **Order Independent**: The order of property initialization doesn't matter
- **Compile-time Check**: Compiler verifies property existence
- **No Side Effects**: Properties in initializer should ideally have no side effects
