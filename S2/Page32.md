At the outermost level, types are organized into namespaces. Many commonly used
 types—including the Console class—reside in the System namespace. The .NET
 libraries are organized into nested namespaces. For example, the System.Text
 namespace contains types for handling text, and System.IO contain types for input/
 output.
 Qualifying the Console class with the System namespace on every use adds clutter.
 The using directive lets you avoid this clutter by importing a namespace:
 using System;
             // Import the System namespace
 int x = 12 * 30;
 Console.WriteLine (x);    // No need to specify System.
 A basic form of code reuse is to write higher-level functions that call lower-level
 functions. We can refactor our program with a reusable method called FeetToInches
 that multiplies an integer by 12, as follows:
 using System;
 Console.WriteLine (FeetToInches (30));      // 360
 Console.WriteLine (FeetToInches (100));     // 1200
 int FeetToInches (int feet)
 {
 int inches = feet * 12;
 return inches;
 }

----------------------------------------------------------------------------------------------------------------------------------------------------

Our method contains a series of statements surrounded by a pair of braces. This is
 called a statement block.
 A method can receive input data from the caller by specifying parameters and output
 data back to the caller by specifying a return type. Our FeetToInches method has a
 parameter for inputting feet, and a return type for outputting inches:
 int FeetToInches (int feet)
 ...
 The literals 30 and 100 are the arguments passed to the FeetToInches method.
 If a method doesn’t receive input, use empty parentheses. If it doesn’t return any
thing, use the void keyword:
 using System;
 SayHello();
 void SayHello()
 {
  Console.WriteLine ("Hello, world");
 }
 Methods are one of several kinds of functions in C#. Another kind of function we
 used in our example program was the * operator, which performs multiplication.
 There are also constructors, properties, events, indexers, and finalizers

----------------------------------------------------------------------------------------------------------------------------------------------------

در سطح بیرونی‌ترین، type‌ها در namespace‌ها سازماندهی می‌شوند. بسیاری از type‌های رایج—از جمله class به نام Console—در namespace به نام System قرار دارند. کتابخانه‌های .NET در namespace‌های تو در تو سازماندهی شده‌اند. به عنوان مثال، namespace به نام System.Text شامل type‌هایی برای مدیریت متن است، و System.IO شامل type‌هایی برای input/output است.

واجد شرایط بودن کردن class به نام Console با namespace به نام System در هر استفاده، شلوغی ایجاد می‌کند. directive به نام using به شما اجازه می‌دهد با import کردن یک namespace از این شلوغی جلوگیری کنید:

```csharp
using System;             // Import the System namespace
int x = 12 * 30;
Console.WriteLine (x);    // No need to specify System.
```
یک شکل پایه‌ای از code reuse این است که توابع سطح بالاتری بنویسیم که توابع سطح پایین‌تر را فراخوانی می‌کنند. می‌توانیم برنامهٔ خود را با یک method قابل استفادهٔ مجدد به نام FeetToInches که یک integer را در 12 ضرب می‌کند، refactor کنیم، به شکل زیر:

```csharp
using System;
Console.WriteLine (FeetToInches (30));      // 360
Console.WriteLine (FeetToInches (100));     // 1200
int FeetToInches (int feet)
{
int inches = feet * 12;
return inches;
}
```

------------------------------------------------------------------------------------------------------------------------------------------------------------



متد ما شامل یک سری statement است که توسط یک جفت brace محصور شده‌اند. به این statement block گفته می‌شود.

یک method می‌تواند با مشخص کردن parameter‌ها، داده‌های ورودی را از فراخواننده دریافت کند و با مشخص کردن return type، داده‌های خروجی را به فراخواننده برگرداند. متد FeetToInches ما یک parameter برای دریافت feet دارد، و یک return type برای خروجی inches دارد:
```csharp
int FeetToInches (int feet)
...
```
مقادیر literal به صورت 30 و 100 همان argument‌هایی هستند که به متد FeetToInches ارسال می‌شوند.

اگر یک method ورودی دریافت نکند، از پرانتزهای خالی استفاده کنید. اگر چیزی را برنگرداند، از کلمه‌کلیدی void استفاده کنید:

```csharp
using System;
SayHello();
void SayHello()
{
  Console.WriteLine ("Hello, world");
}
```
متدها یکی از انواع مختلف function‌ها در C# هستند. نوع دیگری از function که در برنامهٔ نمونهٔ ما استفاده کردیم، عملگر `*` بود که عمل ضرب را انجام می‌دهد. همچنین constructor‌ها، property‌ها، event‌ها، indexer‌ها و finalizer‌ها نیز وجود دارند.

 
