## Numeric Literals
Integral-type literals can use decimal or hexadecimal notation; hexadecimal is deno‐
ted with the 0x prefix. For example:
int x = 127;
long y = 0x7F;
You can insert an underscore anywhere within a numeric literal to make it more
readable:
int million = 1_000_000;
You can specify numbers in binary with the 0b prefix:
var b = 0b1010_1011_1100_1101_1110_1111;
Real literals can use decimal and/or exponential notation:
double d = 1.5;
double million = 1E06;

## Numeric literal type inference
By default, the compiler infers a numeric literal to be either double or an integral
type:
• If the literal contains a decimal point or the exponential symbol (E), it is a
double.
• Otherwise, the literal’s type is the first type in this list that can fit the literal’s
value: int, uint, long, and ulong.
For example:

--------------------------------------------------------------------------------------------
2 Technically, decimal is a floating-point type, too, although it’s not referred to as such in the C#
language specification.
--------------------------------------------------------------------------------------------

Console.WriteLine ( 1.0.GetType()); // Double (double)
Console.WriteLine ( 1E06.GetType()); // Double (double)
Console.WriteLine ( 1.GetType()); // Int32 (int)
Console.WriteLine ( 0xF0000000.GetType()); // UInt32 (uint)
Console.WriteLine (0x100000000.GetType()); // Int64 (long)

--------------------------------------------------------------------------------------------

## Numeric Literals

مقادیر تحت اللفظی - literalهای integral-type می‌توانند از نماد اعشاری (decimal) یا هگزادسیمال (hexadecimal) استفاده کنند؛ هگزادسیمال با پیشوند `0x` نشان داده می‌شود. به عنوان مثال:
```csharp
int x = 127;
long y = 0x7F;
```
می‌توانید یک underscore را در هر جایی از یک literal عددی قرار دهید تا آن را خواناتر کنید:

```csharp
int million = 1_000_000;
```
می‌توانید اعداد را به صورت باینری (binary) با پیشوند `0b` مشخص کنید:

```csharp
var b = 0b1010_1011_1100_1101_1110_1111;
```

مقادیر تحت اللفظی - literalهای real می‌توانند از نماد اعشاری و/یا نمایی (exponential) استفاده کنند:

```csharp
double d = 1.5;
double million = 1E06;
```

--------------------------------------------------------------------------------------------
## Numeric literal type inference

به طور پیش‌فرض، کامپایلر یک literal عددی را یا `double` یا یک type integral استنتاج می‌کند:

• اگر literal شامل یک نقطه اعشار یا نماد نمایی (E) باشد، `double` است.

• در غیر این صورت، type literal اولین type در این لیست است که می‌تواند مقدار literal را در خود جای دهد: `int`، `uint`، `long`، و `ulong`.

به عنوان مثال:

2 از نظر فنی، `decimal` نیز یک floating-point type است، اگرچه در مشخصات زبان C# به این صورت به آن اشاره نمی‌شود.

```csharp
Console.WriteLine ( 1.0.GetType());        // Double (double)
Console.WriteLine ( 1E06.GetType());       // Double (double)
Console.WriteLine ( 1.GetType());          // Int32 (int)
Console.WriteLine ( 0xF0000000.GetType()); // UInt32 (uint)
Console.WriteLine (0x100000000.GetType()); // Int64 (long)
```

