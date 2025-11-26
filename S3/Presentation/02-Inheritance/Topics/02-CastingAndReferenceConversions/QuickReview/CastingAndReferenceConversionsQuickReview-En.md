# Casting and Reference Conversions - Quick Review

## Definition
**Casting** converts a reference from one type to another in an inheritance hierarchy. Reference conversions change how we view an object, not the object itself.

## Two Directions

### 1. Upcasting (Derived → Base)
- **Implicit** conversion (no cast needed)
- **Always safe** - every derived object IS-A base object
- Loses access to derived-specific members

```csharp
Dog dog = new Dog();
Animal animal = dog;  // Implicit upcast ✅

```
### 2. Downcasting (Base → Derived)
- **Explicit** conversion (cast required)
- **Runtime check** needed - may fail
- Gains access to derived-specific members

```csharp
Animal animal = new Dog();
Dog dog = (Dog)animal;  // Explicit downcast - OK if actually Dog
```

## Safe Casting Patterns

### Using `as` operator
- Returns `null` if cast fails (no exception)
- Works only with reference types


```csharp
Dog? dog = animal as Dog;
if (dog != null)
{
dog.Bark();  // Safe
}
```

### Using `is` operator with pattern matching
- Type check + cast in one step
- Modern C# approach

```csharp
if (animal is Dog d)
{
d.Bark();  // d is already Dog type
}
```

### Direct cast
- Throws `InvalidCastException` if fails
- Use when you're certain of the type

```csharp
Dog dog = (Dog)animal;  // ❌ Exception if not Dog
```

## Key Points
- **Upcasting**: Implicit, safe, restricts interface
- **Downcasting**: Explicit, risky, expands interface
- **as operator**: Safe, returns null on failure
- **is operator**: Type check before access
- Reference conversions don't change the object, only how we access it

## Common Pitfalls
- Downcasting without checking can throw exceptions
- Cannot cast between unrelated types in hierarchy
- Casting doesn't convert the object, only the reference type

