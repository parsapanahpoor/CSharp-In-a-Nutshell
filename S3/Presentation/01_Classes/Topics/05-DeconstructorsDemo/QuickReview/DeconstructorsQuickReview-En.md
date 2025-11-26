# Deconstructors - Quick Review

## Definition
A deconstructor is a special method named `Deconstruct` that allows you to break down an object into its constituent parts and assign the values to separate variables.

## Usage
- Extracting multiple values from an object simultaneously
- Deconstructing tuples and custom types
- Simplifying code when working with complex objects
- Creating more readable syntax for accessing object components

## Key Points
- **Fixed Name**: Method name must be `Deconstruct`
- **Return Type**: Must be void
- **Out Parameters**: All parameters must have `out` modifier
- **Overloading**: Can have multiple Deconstruct methods with different parameter counts
- **Syntax**: Using `var (x, y, z) = obj` or `(var x, var y, var z) = obj`
- **Discards**: Using `_` to ignore unnecessary values
- **Extension Methods**: Can add Deconstructor as Extension Method to existing types
- **Tuple Deconstruction**: Tuples support deconstruction by default
- **Compiler Support**: Compiler automatically invokes Deconstruct method
- **Multiple Values**: Can return 2 or more values
- **Type Safety**: All values are strongly-typed
- **Pattern Matching**: Can be used in positional patterns (C# 8+)
