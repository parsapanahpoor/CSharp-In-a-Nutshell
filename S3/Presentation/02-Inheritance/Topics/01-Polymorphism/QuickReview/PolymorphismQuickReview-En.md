## Definition
**Polymorphism** means "many forms" - the ability of objects to take on different forms. A single interface can represent different underlying types.

## Two Types

### 1. Static Polymorphism (Compile-Time)
- **Method Overloading**: Same method name, different parameters
- **Operator Overloading**: Custom behavior for operators
- Resolved at **compile time**

```csharp
class Math
{
public int Add(int a, int b) => a + b;
public double Add(double a, double b) => a + b;  // Overloaded
}
```

### 2. Dynamic Polymorphism (Runtime)
- **Method Overriding**: `virtual` in base, `override` in derived
- Resolved at **runtime** based on actual object type
- Enables true polymorphic behavior via base references

```csharp
class Animal
{
public virtual void Speak() => Console.WriteLine("Animal sound");
}

class Dog : Animal
{
public override void Speak() => Console.WriteLine("Bark!");
}

Animal a = new Dog();
a.Speak();  // Output: "Bark!" (runtime decision)

```


## Key Points
- **Virtual methods** enable runtime polymorphism
- **Base reference** can hold derived object
- **Actual type** determines which method executes
- Powerful for extensible, maintainable code

## Benefits
- Write code against interfaces, not implementations
- Easy to extend with new types
- Reduces coupling, increases flexibility