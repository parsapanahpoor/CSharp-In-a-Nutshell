Selection Statements
 C# has the following mechanisms to conditionally control the flow of program
 execution:
 •
 • Selection statements (if, switch)
 •
 • Conditional operator (?:)
 •
 • Loop statements (while, do-while, for, foreach)
 This section covers the simplest two constructs: the if statement and the switch
 statement.
 The if statement
 An if statement executes a statement if a bool expression is true:
 if (5 < 2 * 3)
  Console.WriteLine ("true");       // true
 The statement can be a code block:
 if (5 < 2 * 3)
 {
  Console.WriteLine ("true");
  Console.WriteLine ("Let’s move on!");
 }
 The else clause
 An if statement can optionally feature an else clause:
 if (2 + 2 == 5)
  Console.WriteLine ("Does not compute");
 else
  Console.WriteLine ("False");        // False
 Within an else clause, you can nest another if statement:
 if (2 + 2 == 5)
 Console.WriteLine ("Does not compute");
 else
 if (2 + 2 == 4)
 Console.WriteLine ("Computes");    // Computes

 ## دستورات انتخاب (Selection Statements)

سی شارپ C# مکانیسم‌های زیر را برای کنترل شرطی جریان اجرای برنامه دارد:

- **دستورات انتخاب** (`if`, `switch`)
- **عملگر شرطی** (`?:`)
- **دستورات حلقه** (`while`, `do-while`, `for`, `foreach`)

این بخش دو ساختار ساده‌تر را پوشش می‌دهد: دستور `if` و دستور `switch`.

### دستور if

یک دستور `if` یک دستور را اجرا می‌کند اگر یک عبارت `bool` صحیح (true) باشد:
```csharp
if (5 < 2 * 3)
  Console.WriteLine ("true");       // true
```
دستور می‌تواند یک بلوک کد باشد:

```csharp
if (5 < 2 * 3)
{
  Console.WriteLine ("true");
  Console.WriteLine ("Let's move on!");
}
```
### بند else

یک دستور `if` می‌تواند به صورت اختیاری شامل یک بند `else` باشد:

```csharp
if (2 + 2 == 5)
  Console.WriteLine ("Does not compute");
else
  Console.WriteLine ("False");        // False
```
در داخل یک بند `else`، می‌توانید یک دستور `if` دیگر تو در تو قرار دهید:

```csharp
if (2 + 2 == 5)
  Console.WriteLine ("Does not compute");
else
  if (2 + 2 == 4)
Console.WriteLine ("Computes");    // Computes
```
