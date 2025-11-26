# This Reference - Quick Review

## Definition
`this` is a keyword that refers to the current instance of the class and can only be used in instance methods, properties, indexers, and constructors.

## Usage
- Disambiguating between method parameters and class fields
- Passing the current instance to other methods
- Calling other constructors (Constructor Chaining)
- Returning current instance for Fluent Interface
- Accessing instance members when hidden

## Key Points
- **Instance Only**: Only usable in instance members, not in static members
- **Implicit**: In most cases, using this is optional (compiler adds it automatically)
- **Disambiguation**: Necessary to distinguish between parameters and fields
- **Constructor Chaining**: `this(...)` to call another constructor in same class
- **Extension Methods**: In first parameter of extension method to specify extended type
- **Fluent Interface**: Returning `this` for method chaining
- **Indexers**: Used in indexer definition with `this[...]`
- **Anonymous Functions**: Accessing this in lambda expressions and anonymous methods
- **Capturing**: In closures, this can be captured
- **Value Types**: In structs, this has different reference semantics (readonly in readonly methods)
- **Read-only Context**: In readonly members, this is readonly
- **Event Handlers**: Used for subscribing/unsubscribing events
