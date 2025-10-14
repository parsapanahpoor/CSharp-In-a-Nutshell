(The Main method can also be declared async and return a Task or Task<int> in
 support of asynchronous programming, which we cover in Chapter 14.)

 ## Top-Level Statements
 Top-level statements (introduced in C# 9) let you avoid the baggage of a static Main
 method and a containing class. A file with top-level statements comprises three
 parts, in this order:
 1. (Optionally) using directives
 1.
 2. A series of statements, optionally mixed with method declarations
 3.
 2.
 3. (Optionally) Type and namespace declarations





(متد Main همچنین می‌تواند به صورت async اعلان شود و یک `Task` یا `Task<int>` را برای پشتیبانی از برنامه‌نویسی ناهمزمان (asynchronous programming) برگرداند، که آن را در فصل 14 پوشش می‌دهیم.)




## Top-Level Statements

ویژگی Top-level statements (که در C# 9 معرفی شد) به شما اجازه می‌دهد از بار اضافی یک متد static به نام Main و یک class محتوی اجتناب کنید. یک فایل با top-level statements شامل سه بخش است، به این ترتیب:

1. (به صورت اختیاری) directiveهای using
2. یک سری statement، که به صورت اختیاری با اعلان‌های (declarations) متد ترکیب شده‌اند
3. (به صورت اختیاری) اعلان‌های Type و namespace
برای مثال:
```csharp
using System;                           // Part 1

Console.WriteLine ("Hello, world");     // Part 2
void SomeMethod1() { ... }              // Part 2
Console.WriteLine ("Hello again!");     // Part 2
void SomeMethod2() { ... }              // Part 2

class SomeClass { ... }                 // Part 3
namespace SomeNamespace { ... }         // Part 3
```

از آنجا که CLR به صورت صریح از top-level statements پشتیبانی نمی‌کند، کامپایلر کد شما را به چیزی شبیه این تبدیل می‌کند:
```csharp
using System;                           // Part 1

static class Program$   // Special compiler-generated name
{
  static void Main$ (string[] args)   // Compiler-generated name
  {
Console.WriteLine ("Hello, world");     // Part 2
void SomeMethod1() { ... }              // Part 2
Console.WriteLine ("Hello again!");     // Part 2
void SomeMethod2() { ... }              // Part 2
  }
}

class SomeClass { ... }                 // Part 3
namespace SomeNamespace { ... }         // Part 3
```

توجه کنید که همه چیز در Part 2 در داخل متد main قرار گرفته است. این بدان معناست که `SomeMethod1` و `SomeMethod2` به عنوان متدهای محلی (local methods) عمل می‌کنند. پیامدهای کامل را در "Local methods" در صفحه 106 بحث می‌کنیم، که مهم‌ترین آن این است که متدهای محلی (مگر اینکه به عنوان static اعلان شوند) می‌توانند به متغیرهای اعلان شده در داخل متد محتوی (containing method) دسترسی پیدا کنند:

```csharp
int x = 3;
 LocalMethod();
 void LocalMethod() { Console.WriteLine (x); }   // We can access x
```

یک پیامد دیگر این است که متدهای top-level نمی‌توانند از classهای یا typeهای دیگر دسترسی پیدا کنند.

ویژگی Top-level statements می‌توانند به صورت اختیاری یک مقدار صحیح را به فراخواننده (caller) برگردانند و به یک متغیر "جادویی" از نوع `string[]` به نام args دسترسی پیدا کنند، که مطابق با argumentهای خط فرمان (command-line arguments) ارسال شده توسط فراخواننده است.

از آنجا که یک برنامه فقط می‌تواند یک entry point داشته باشد، حداکثر می‌تواند یک فایل با top-level statements در یک پروژهٔ C# وجود داشته باشد.



