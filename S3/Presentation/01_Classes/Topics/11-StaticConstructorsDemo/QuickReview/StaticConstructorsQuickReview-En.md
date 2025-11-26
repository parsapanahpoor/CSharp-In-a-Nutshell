# Static Constructors - Quick Review

## Definition
A static constructor is a special type of constructor used to initialize static members of a class, called only once by the CLR before the first use of the class (creating an instance or accessing a static member).

## Usage
- Initializing static fields
- Loading settings or configuration
- Registering class in system
- Executing one-time initialization logic for entire class
- Complex initialization of static readonly fields

## Key Points
- **Syntax**: Without access modifier and without parameters: `static ClassName() { }`
- **Parameterless**: Cannot have parameters
- **No Access Modifier**: Cannot have access modifier
- **Single Execution**: Executed only once during AppDomain lifetime
- **Thread-Safe**: CLR guarantees thread-safety
- **Timing**: Executed before first instance constructor or access to static member
- **Order**: Execution order across different classes is unpredictable
- **Exception Handling**: If exception occurs, class becomes unusable (TypeInitializationException)
- **Beforefieldinit**: Without explicit static constructor, CLR may defer initialization
- **Static Fields**: Ideal for initializing static readonly fields
- **No Inheritance**: Cannot be inherited
- **Performance**: Has initial cost but only once
- **Lazy Initialization**: Alternative: `Lazy<T>` for more control
- **Debugging**: Difficult because exact timing is uncertain
