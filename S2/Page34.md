 ##Syntax
 C# syntax is inspired by C and C++ syntax. In this section, we describe C#’s
 elements of syntax, using the following program:
 using System;
 int x = 12 * 30;
 Console.WriteLine (x);

 ## Syntax

سینتکس C# از سینتکس C و C++ الهام گرفته شده است. در این بخش، عناصر syntax زبان C# را با استفاده از برنامهٔ زیر توضیح می‌دهیم:
```csharp
using System;
int x = 12 * 30;
Console.WriteLine (x);
```

 ## Identifiers and Keywords
 Identifiers are names that programmers choose for their classes, methods, variables,
 and so on. Here are the identifiers in our example program, in the order in which
 they appear:
 System   x   Console   WriteLine
 An identifier must be a whole word, essentially made up of Unicode characters
 starting with a letter or underscore. C# identifiers are case sensitive. By convention,
 parameters, local variables, and private fields should be in camel case (e.g., myVaria
 ble), and all other identifiers should be in Pascal case (e.g., MyMethod).
 Keywords are names that mean something special to the compiler. There are two
 keywords in our example program: using and int.
 Most keywords are reserved, which means that you can’t use them as identifiers.
 Here is the full list of C# reserved keywords:
 abstract
 as
 base
 bool....

 ## Identifiers و Keywords

شناسه‌ها (Identifiers) نام‌هایی هستند که برنامه‌نویسان برای class‌ها، method‌ها، متغیرها و غیره انتخاب می‌کنند. این‌ها شناسه‌های موجود در برنامهٔ نمونهٔ ما هستند، به ترتیبی که ظاهر شده‌اند:

System x Console WriteLine

یک identifier باید یک کلمهٔ کامل باشد، که اساساً از کاراکترهای Unicode تشکیل شده و با یک حرف یا underscore شروع می‌شود. شناسه‌های C# به حروف بزرگ و کوچک حساس هستند (case sensitive). طبق قرارداد، پارامترها، متغیرهای محلی، و فیلدهای private باید به صورت camel case باشند (به عنوان مثال، myVariable)، و تمام شناسه‌های دیگر باید به صورت Pascal case باشند (به عنوان مثال، MyMethod).

کلمات کلیدی (Keywords) نام‌هایی هستند که برای compiler معنای خاصی دارند. دو keyword در برنامهٔ نمونهٔ ما وجود دارد: using و int.

اکثر keyword‌ها رزرو شده هستند (reserved)، که به این معنی است که نمی‌توانید از آن‌ها به عنوان identifier استفاده کنید. این‌ها لیست کامل کلمات کلیدی رزرو شدهٔ C# هستند:

abstract as base bool break

byte case catch char checked

class const continue decimal default

delegate do double else enum

event explicit extern false finally

fixed float for foreach goto

if implicit in int interface

internal is lock long namespace

new null object operator out

override params private protected public

readonly record ref return sbyte

sealed short sizeof stackalloc static

string struct switch this throw

true try typeof uint ulong

unchecked unsafe ushort using virtual

void volatile while



autorenew

thumb_up

thumb_down
