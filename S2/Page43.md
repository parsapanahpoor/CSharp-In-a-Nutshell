## Value Types Versus Reference Types
 All C# types fall into the following categories:
 •
 • Value types
 •
 • Reference types
 •
 • Generic type parameters
 •
 • Pointer types

 ## Value Types در مقابل Reference Types

تمام typeهای C# در دسته‌بندی‌های زیر قرار می‌گیرند:

• Value types
• Reference types
• Generic type parameters
• Pointer types

در این بخش، value types و reference types را توصیف می‌کنیم. Generic type parameters را در "Generics" در صفحه 159 و pointer types را در "Unsafe Code and Pointers" در صفحه 263 پوشش می‌دهیم.

مقادیر Value types شامل اکثر typeهای built-in (به طور خاص، تمام typeهای عددی، نوع `char`، و نوع `bool`) و همچنین typeهای سفارشی `struct` و `enum` می‌شوند.

مقادیر Reference types شامل تمام typeهای `class`، `array`، `delegate`، و `interface` می‌شوند. (این شامل نوع از پیش تعریف شدهٔ `string` نیز می‌شود.)

تفاوت اساسی بین value types و reference types نحوهٔ مدیریت آن‌ها در حافظه است.
## Value types
 The content of a value type variable or constant is simply a value. For example, the
 content of the built-in value type, int, is 32 bits of data.
 You can define a custom value type with the struct keyword (see Figure 2-1):
 public struct Point { public int X; public int Y; }
 Or more tersely:
 public struct Point { public int X, Y; }

 ### Value types

محتوای یک متغیر یا ثابت value type صرفاً یک مقدار است. برای مثال، محتوای نوع built-in value type، `int`، 32 بیت داده است.

می‌توانید یک value type سفارشی با کلمه کلیدی `struct` تعریف کنید (به شکل 2-1 مراجعه کنید):
```csharp
public struct Point { public int X; public int Y; }

یا به صورت مختصرتر:

csharp
public struct Point { public int X, Y; }
```


 The assignment of a value-type instance always copies the instance; for example:
 Point p1 = new Point();
 p1.X = 7;
 Point p2 = p1;             // Assignment causes copy
 Console.WriteLine (p1.X);  // 7
 Console.WriteLine (p2.X);  // 7


 انتساب (assignment) یک نمونهٔ value-type همیشه آن نمونه را کپی می‌کند؛ برای مثال:
```csharp
Point p1 = new Point();
p1.X = 7;
Point p2 = p1;             // Assignment causes copy
Console.WriteLine (p1.X);  // 7
Console.WriteLine (p2.X);  // 7

p1.X = 9;                  // Change p1.X
 Console.WriteLine (p1.X);  // 9
 Console.WriteLine (p2.X);  // 7

```

<img width="687" height="114" alt="image" src="https://github.com/user-attachments/assets/5f7ec38f-e822-460b-b3cf-400edda0738f" />

شکل 2-2 نشان می‌دهد که `p1` و `p2` فضای ذخیره‌سازی مستقل دارند.

**شکل 2-2. Assignment یک نمونهٔ value-type را کپی می‌کند**


ی
