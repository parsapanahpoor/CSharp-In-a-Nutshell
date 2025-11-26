# Fields - Quick Review

## Definition
A field is a variable defined at the class or struct level that holds data associated with that type.

## Usage
- Storing the state of an object
- Holding shared data between class members
- Implementing Properties and Encapsulation
- Defining Static variables for sharing across all instances

## Key Points
- **Instance Fields**: Each object has a separate copy (stored in Heap)
- **Static Fields**: One shared copy for all instances (stored in Static Memory)
- **Readonly Fields**: Can only be assigned during declaration or in Constructor
- **Access Modifiers**: private, public, protected, internal, protected internal, private protected
- **Initialization Order**: Static fields → Instance fields → Constructor body
- **Memory Layout**: Order of field definitions affects memory structure
- **Field Padding**: Compiler may add extra bytes for Alignment
- **StructLayout Attribute**: Controls memory layout (Sequential, Explicit, Auto)
- **const vs readonly**: const at compile-time, readonly at runtime
- **Default Values**: Reference types → null, Value types → zero/default
