 In this chapter, we introduce the basics of the C# language.
 Almost all of the code listings in this book are available as
 interactive samples in LINQPad. Working through these sam
ples in conjunction with the book accelerates learning in that
 you can edit the samples and instantly see the results without
 needing to set up projects and solutions in Visual Studio.
 To download the samples, in LINQPad, click the Samples tab,
 and then click “Download more samples.” LINQPad is free—
 go to http://www.linqpad.net.


در این فصل، اصول پایه‌ای زبان C# را معرفی می‌کنیم.
تقریباً تمام نمونه کدهای موجود در این کتاب به صورت نمونه‌های تعاملی در LINQPad در دسترس هستند. کار کردن با این نمونه‌ها همراه با کتاب، یادگیری را تسریع می‌کند، چرا که می‌توانید نمونه‌ها را ویرایش کنید و بلافاصله نتایج را ببینید بدون اینکه نیازی به راه‌اندازی project‌ها و solution‌ها در Visual Studio داشته باشید.
برای دانلود نمونه‌ها، در LINQPad، روی تب Samples کلیک کنید و سپس روی "Download more samples" کلیک کنید. LINQPad رایگان است—به http://www.linqpad.net مراجعه کنید.

 A First C# Program
 Following is a program that multiplies 12 by 30 and prints the result, 360, to
 the screen. The double forward slash indicates that the remainder of a line is a
 comment:
 int x = 12 * 30;                  // Statement 1
 System.Console.WriteLine (x);     // Statement 2
 Our program consists of two statements. Statements in C# execute sequentially and
 are terminated by a semicolon. The first statement computes the expression 12 * 30
 and stores the result in a variable, named x, whose type is a 32-bit integer (int).
 The second statement calls the WriteLine method on a class called Console, which is
 defined in a namespace called System. This prints the variable x to a text window on
 the screen.
 A method performs a function; a class groups function members and data members
 to form an object-oriented building block. The Console class groups members
 that handle command-line input/output (I/O) functionality, such as the WriteLine
 method. A class is a kind of type, which we examine in “Type Basics” on page 36.

 ## اولین برنامه C#

برنامه زیر عدد 12 را در 30 ضرب می‌کند و نتیجه، یعنی 360، را روی صفحه نمایش چاپ می‌کند. دو اسلش رو به جلو نشان می‌دهد که بقیه خط یک comment است:
```csharp
int x = 12 * 30;                  // Statement 1
System.Console.WriteLine (x);     // Statement 2
```

برنامه ما از دو statement تشکیل شده است. statement‌ها در C# به ترتیب اجرا می‌شوند و با semicolon خاتمه می‌یابند. statement اول expression به صورت `12 * 30` را محاسبه می‌کند و نتیجه را در یک variable به نام x ذخیره می‌کند که type آن یک integer 32-بیتی (int) است.
statement دوم method به نام WriteLine را روی class ای به نام Console فراخوانی می‌کند که در namespace ای به نام System تعریف شده است. این کار variable به نام x را در یک پنجره متنی روی صفحه نمایش چاپ می‌کند.

یک method یک تابع را انجام می‌دهد؛ یک class، function member‌ها و data member‌ها را گروه‌بندی می‌کند تا یک بلوک سازنده شی‌گرا تشکیل دهد. class به نام Console، member‌هایی را گروه‌بندی می‌کند که عملکرد input/output (I/O) خط فرمان را مدیریت می‌کنند، مانند method به نام WriteLine. یک class نوعی type است که آن را در "Type Basics" در صفحه 36 بررسی می‌کنیم.

