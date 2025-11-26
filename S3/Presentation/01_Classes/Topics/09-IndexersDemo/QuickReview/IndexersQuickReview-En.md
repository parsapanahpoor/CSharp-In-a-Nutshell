# Indexers - Quick Review

## Definition
An indexer is a special type of property that allows an object to be accessed like an array using `[]` notation, providing array-like access.

## Usage
- Accessing internal elements of class with array syntax
- Implementing collection-like behavior
- Encapsulating access to internal data structures
- Providing intuitive interface for data access
- Implementing matrix, dictionary or custom structures

## Key Points
- **Syntax**: Defined with `this[type index]` instead of property name
- **Parameters**: Can have multiple parameters with different types
- **Get/Set Accessors**: Similar to properties, has get and set
- **Overloading**: Can overload with different number or types of parameters
- **Read-only Indexer**: Only with get accessor
- **Write-only Indexer**: Only with set accessor (rare)
- **Multiple Parameters**: `this[int x, int y]` for matrices
- **Different Types**: Parameter can be string, int or any other type
- **Expression-bodied**: Short syntax with `=>` for read-only
- **Range/Index Support**: Support for `Range` and `Index` (C# 8+)
- **Null Handling**: Checking null in setter/getter
- **Performance**: Consider lookup cost for access
- **Interface Implementation**: Can be defined in interface
- **Inheritance**: Can be virtual, override and abstract
