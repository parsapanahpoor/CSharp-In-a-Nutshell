## Defining a Main method
 All of our examples, so far, have used top-level statements (a feature introduced in
 C# 9).
 Without top-level statements, a simple console or Windows application looks like
 this:
 using System;
 class Program
 {
 static void Main()   // Program entry point
 {
    int x = 12 * 30;
    Console.WriteLine (x);
 }
 }
 In the absence of top-level statements, C# looks for a static method called Main,
 which becomes the entry point. The Main method can be defined inside any class
 (and only one Main method can exist).
 The Main method can optionally return an integer (rather than void) in order
 to return a value to the execution environment (where a nonzero value typically
 indicates an error). The Main method can also optionally accept an array of strings
 as a parameter (that will be populated with any arguments passed to the executable).
 For example:
 static int Main (string[] args) {...}

-------------------------------------------------------------------------------------------------------------------

 An array (such as string[]) represents a fixed number of
 elements of a particular type. Arrays are specified by placing
 square brackets after the element type. We describe them in
 “Arrays” on page 61.
 
 

 ## تعریف متد Main

تمام مثال‌های ما تا به حال از top-level statements استفاده کرده‌اند (ویژگی‌ای که در C# 9 معرفی شد).

بدون top-level statements، یک برنامهٔ ساده console یا Windows به این شکل است:
```csharp
using System;

class Program
{
  static void Main()   // Program entry point
  {
int x = 12 * 30;
Console.WriteLine (x);
  }
}
```
در غیاب top-level statements، C# به دنبال یک متد static به نام Main می‌گردد که به entry point تبدیل می‌شود. متد Main می‌تواند در داخل هر class تعریف شود (و فقط یک متد Main می‌تواند وجود داشته باشد).

متد Main می‌تواند به صورت اختیاری یک عدد صحیح برگرداند (به جای void) تا یک مقدار را به محیط اجرا (execution environment) برگرداند (جایی که یک مقدار غیرصفر معمولاً نشان‌دهندهٔ یک خطا است). متد Main همچنین می‌تواند به صورت اختیاری یک آرایه از رشته‌ها را به عنوان یک پارامتر بپذیرد (که با هر argumentی که به فایل اجرایی (executable) ارسال می‌شود، پر خواهد شد). برای مثال:

```csharp
static int Main (string[] args) {...}
```

--------------------------------------------------------------------------------------------------------------------------------------

 یک آرایه (مانند `string[]`) تعداد ثابتی از عناصر یک type خاص را نشان می‌دهد. آرایه‌ها با قرار دادن براکت‌های مربعی (square brackets) بعد از type عنصر مشخص می‌شوند. آن‌ها را در "Arrays" در صفحه 61 توضیح می‌دهیم.
