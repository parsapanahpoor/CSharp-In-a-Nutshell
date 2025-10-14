## Comments
 C# offers two different styles of source-code documentation: single-line comments
 and multiline comments. A single-line comment begins with a double forward slash
 and continues until the end of the line; for example:
 int x = 3;   // Comment about assigning 3 to x
 A multiline comment begins with /* and ends with */; for example:
 int x = 3;   /* This is a comment that
                spans two lines */
 Comments can embed XML documentation tags, which we explain in “XML Docu
mentation” on page 272.


 ## Type Basics
 A type defines the blueprint for a value. In this example, we use two literals of type
 int with values 12 and 30. We also declare a variable of type int whose name is x:
 int x = 12 * 30;
 Console.WriteLine (x);

---------------------------------------------------------------------------------------------------

 Because most of the code listings in this book require types
 from the System namespace, we will omit “using System”
 from now on, unless we’re illustrating a concept relating to
 namespaces

----------------------------------------------------------------------------------------------------------

 A variable denotes a storage location that can contain different values over time. In
 contrast, a constant always represents the same value (more on this later):
 const int y = 360;
 All values in C# are instances of a type. The meaning of a value and the set of
 possible values a variable can have are determined by its type.

 ## Predefined Type Examples
 Predefined types are types that are specially supported by the compiler. The int
 type is a predefined type for representing the set of integers that fit into 32 bits of
 memory, from −231 to 231−1, and is the default type for numeric literals within this
 range. You can perform functions such as arithmetic with instances of the int type,
 as follows:
 int x = 12 * 30;
 Another predefined C# type is string. The string type represents a sequence of
 characters, such as “.NET” or http://oreilly.com. You can work with strings by calling
 functions on them, as follows:

 string message = "Hello world";
 string upperMessage = message.ToUpper();
 Console.WriteLine (upperMessage);               // HELLO WORLD
 int x = 2022;
 message = message + x.ToString();
 Console.WriteLine (message);                    // Hello world2022
 In this example, we called x.ToString() to obtain a string representation of the
 integer x. You can call ToString() on a variable of almost any type.
 The predefined bool type has exactly two possible values: true and false. The
 bool type is commonly used with an if statement to conditionally branch execution
 flow:
 bool simpleVar = false;
 if (simpleVar)
  Console.WriteLine ("This will not print");
 int x = 5000;
 bool lessThanAMile = x < 5280;
 if (lessThanAMile)
  Console.WriteLine ("This will print");
 
 

## Comments

زبان C# دو سبک متفاوت برای مستندسازی کد منبع ارائه می‌دهد: کامنت‌های تک‌خطی (single-line comments) و کامنت‌های چندخطی (multiline comments). یک single-line comment با دو اسلش رو به جلو شروع می‌شود و تا پایان خط ادامه می‌یابد؛ به عنوان مثال:
```csharp
int x = 3;   // Comment about assigning 3 to x
```
یک multiline comment با `/*` شروع و با `*/` خاتمه می‌یابد؛ به عنوان مثال:

``` csharp
int x = 3;   /* This is a comment that
spans two lines */
```
کامنت‌ها می‌توانند تگ‌های مستندسازی XML را در خود جای‌گذاری کنند، که ما آن‌ها را در "XML Documentation" در صفحهٔ 272 توضیح می‌دهیم.





 ## Type Basics

یک type الگوی اولیه (blueprint) برای یک مقدار را تعریف می‌کند. در این مثال، از دو literal از نوع int با مقادیر 12 و 30 استفاده می‌کنیم. همچنین یک متغیر از نوع int به نام x تعریف می‌کنیم:
```csharp
int x = 12 * 30;
Console.WriteLine (x);
```

-----------------------------------------------------------------------------------------------------------------

 از آنجا که بیشتر نمونه‌کدهای این کتاب به type‌هایی از namespace به نام System نیاز دارند، از این به بعد "using System" را حذف خواهیم کرد، مگر اینکه مفهومی مرتبط با namespace‌ها را توضیح دهیم.

-------------------------------------------------------------------------------------------------------------------

 یک متغیر (variable) یک مکان ذخیره‌سازی را نشان می‌دهد که می‌تواند در طول زمان مقادیر مختلفی داشته باشد. در مقابل، یک ثابت (constant) همیشه یک مقدار یکسان را نمایش می‌دهد (در این مورد بعداً بیشتر صحبت خواهیم کرد):
```csharp
const int y = 360;
```
تمام مقادیر در C# نمونه‌هایی (instances) از یک type هستند. معنی یک مقدار و مجموعهٔ مقادیر ممکنی که یک متغیر می‌تواند داشته باشد، توسط type آن تعیین می‌شود.




  ## نمونه‌هایی از Type‌های از پیش تعریف شده

تایپ های از پیش تعریف شده (Predefined types) type‌هایی هستند که به طور ویژه توسط کامپایلر پشتیبانی می‌شوند. type به نام int یک type از پیش تعریف شده برای نمایش مجموعه اعداد صحیحی است که در ۳۲ بیت حافظه جای می‌گیرند، از $-2^{31}$ تا $2^{31}-1$، و type پیش‌فرض برای literalهای عددی در این محدوده است. می‌توانید عملیاتی مانند محاسبات ریاضی را با نمونه‌هایی از type به نام int انجام دهید، به شرح زیر:
```csharp
int x = 12 * 30;
```
یکی دیگر از type‌های از پیش تعریف شدهٔ C# به نام string است. type به نام string یک توالی از کاراکترها را نمایش می‌دهد، مانند "NET." یا `http://oreilly.com`. می‌توانید با فراخوانی functionها روی رشته‌ها (strings) با آن‌ها کار کنید، به شرح زیر:

```csharp
string message = "Hello world";
string upperMessage = message.ToUpper();
Console.WriteLine (upperMessage);               // HELLO WORLD
int x = 2022;
message = message + x.ToString();
Console.WriteLine (message);                    // Hello world2022
```
در این مثال، `x.ToString()` را فراخوانی کردیم تا یک نمایش رشته‌ای (string representation) از عدد صحیح x را به دست آوریم. می‌توانید `ToString()` را روی متغیری از تقریباً هر type فراخوانی کنید.

تایپ از پیش تعریف شدهٔ bool دقیقاً دو مقدار ممکن دارد: true و false. type به نام bool معمولاً با یک statement از نوع if برای انشعاب شرطی جریان اجرا استفاده می‌شود:

```csharp
bool simpleVar = false;
if (simpleVar)
 Console.WriteLine ("This will not print");
int x = 5000;
bool lessThanAMile = x < 5280;
if (lessThanAMile)
 Console.WriteLine ("This will print");
```
