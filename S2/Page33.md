## Compilation
 The C# compiler compiles source code (a set of files with the .cs extension) into
 an assembly. An assembly is the unit of packaging and deployment in .NET. An
 assembly can be either an application or a library. A normal console or Windows
 application has an entry point, whereas a library does not. The purpose of a library
 is to be called upon (referenced) by an application or by other libraries. .NET itself is
 a set of libraries (as well as a runtime environment).
 Each of the programs in the preceding section began directly with a series of state
ments (called top-level statements). The presence of top-level statements implicitly
 creates an entry point for a console or Windows application. (Without top-level
 statements, a Main method denotes an application’s entry point—see “Custom
 Types” on page 37.)

## کامپایل

کامپایلر C# کد منبع (مجموعه‌ای از فایل‌ها با پسوند .cs) را به یک assembly تبدیل می‌کند. یک assembly واحد بسته‌بندی و استقرار در .NET است. یک assembly می‌تواند یک application یا یک library باشد. یک application معمولی console یا Windows دارای یک entry point است، در حالی که یک library ندارد. هدف یک library این است که توسط یک application یا library‌های دیگر فراخوانی (reference) شود. خود .NET مجموعه‌ای از library‌هاست (و همچنین یک runtime environment).

هر یک از برنامه‌ها در بخش قبلی مستقیماً با یک سری statement شروع می‌شدند (که به آن‌ها top-level statements می‌گویند). وجود top-level statements به صورت ضمنی یک entry point برای یک application از نوع console یا Windows ایجاد می‌کند. (بدون top-level statements، یک متد Main نشان‌دهندهٔ entry point یک application است—به "Custom Types" در صفحهٔ 37 مراجعه کنید.)



Unlike .NET Framework, .NET 8 assemblies never have a .exe
 extension. The .exe that you see after building a .NET 8
 application is a platform-specific native loader responsible for
 starting your application’s .dll assembly.
 .NET 8 also allows you to create a self-contained deployment
 that includes the loader, your assemblies, and the required
 portions of the .NET runtime—all in a single .exe file. .NET
 8 also allows ahead-of-time (AOT) compilation, where the
 executable contains precompiled native code for faster startup
 and reduced memory consumption.

 برخلاف .NET Framework، assembly‌های .NET 8 هرگز پسوند .exe ندارند. فایل .exe که پس از build کردن یک application از نوع .NET 8 می‌بینید، یک native loader مختص پلتفرم است که مسئول راه‌اندازی assembly با پسوند .dll برنامهٔ شماست.

همچنین .NET 8 به شما اجازه می‌دهد یک self-contained deployment ایجاد کنید که شامل loader، assembly‌های شما، و بخش‌های مورد نیاز از .NET runtime است—همهٔ این‌ها در یک فایل .exe واحد. .NET 8 همچنین اجازهٔ کامپایل ahead-of-time (AOT) را می‌دهد، جایی که فایل اجرایی شامل کد native از پیش کامپایل‌شده است برای startup سریع‌تر و کاهش مصرف حافظه.


The dotnet tool (dotnet.exe on Windows) helps you to manage .NET source code
 and binaries from the command line. You can use it to both build and run your
 program, as an alternative to using an integrated development environment (IDE)
 such as Visual Studio or Visual Studio Code.
 You can obtain the dotnet tool either by installing the .NET 8 SDK or by instal
ling Visual Studio. Its default location is %ProgramFiles%\dotnet on Windows
 or /usr/bin/dotnet on Ubuntu Linux.
 To compile an application, the dotnet tool requires a project file as well as one or
 more C# files. The following command scaffolds a new console project (creates its
 basic structure):
 dotnet new Console -n MyFirstProgram
 This creates a subfolder called MyFirstProgram containing a project file called
 MyFirstProgram.csproj and a C# file called Program.cs that prints “Hello world.”
 To build and run your program, run the following command from the MyFirstPro
gram folder:
 dotnet run MyFirstProgram
 Or, if you just want to build without running:
 dotnet build MyFirstProgram.csproj
 The output assembly will be written to a subdirectory under bin\debug.
 We explain assemblies in detail in Chapter 17

 ابزار dotnet (dotnet.exe در Windows) به شما کمک می‌کند تا کد منبع و فایل‌های باینری .NET را از command line مدیریت کنید. می‌توانید از آن برای build و اجرای برنامه‌تان استفاده کنید، به عنوان جایگزینی برای استفاده از یک integrated development environment (IDE) مانند Visual Studio یا Visual Studio Code.

می‌توانید ابزار dotnet را یا با نصب .NET 8 SDK یا با نصب Visual Studio به دست آورید. مکان پیش‌فرض آن در Windows برابر `%ProgramFiles%\dotnet` و در Ubuntu Linux برابر `/usr/bin/dotnet` است.

برای کامپایل یک application، ابزار dotnet به یک project file و همچنین یک یا چند فایل C# نیاز دارد. دستور زیر یک console project جدید را scaffold می‌کند (ساختار پایه‌ای آن را ایجاد می‌کند):
```bash
dotnet new Console -n MyFirstProgram
```
این دستور یک زیرپوشه به نام MyFirstProgram ایجاد می‌کند که شامل یک project file به نام MyFirstProgram.csproj و یک فایل C# به نام Program.cs است که عبارت "Hello world" را چاپ می‌کند.

برای build و اجرای برنامه‌تان، دستور زیر را از پوشهٔ MyFirstProgram اجرا کنید:

```bash
dotnet run MyFirstProgram
```
یا، اگر فقط می‌خواهید build کنید بدون اجرا:

```bash
dotnet build MyFirstProgram.csproj
```
خروجی assembly در یک زیردایرکتوری تحت `bin\debug` نوشته خواهد شد.

ما assembly‌ها را به تفصیل در فصل 17 توضیح می‌دهیم.
