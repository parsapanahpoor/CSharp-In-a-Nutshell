Statements
 Functions comprise statements that execute sequentially in the textual order in
 which they appear. A statement block is a series of statements appearing between
 braces (the {} tokens).
 Declaration Statements
 A variable declaration introduces a new variable, optionally initializing it with
 an expression. You may declare multiple variables of the same type in a comma
separated list:
 string someWord = "rosebud";
 int someNumber = 42;
 bool rich = true, famous = false;
 A constant declaration is like a variable declaration except that it cannot be changed
 after it has been declared, and the initialization must occur with the declaration (see
 “Constants” on page 104):
 const double c = 2.99792458E08;
 c += 10;                        // Compile-time Error


 ## دستورات (Statements)

توابع شامل دستوراتی هستند که به ترتیب متنی که در آن ظاهر می‌شوند به صورت پی‌در‌پی اجرا می‌شوند. یک بلوک دستور (statement block) یک سری دستور است که بین آکولادها (توکن‌های `{}`) ظاهر می‌شوند.

### دستورات اعلان (Declaration Statements)

یک اعلان متغیر (variable declaration) یک متغیر جدید معرفی می‌کند که به صورت اختیاری آن را با یک عبارت مقداردهی اولیه می‌کند. شما می‌توانید چندین متغیر از یک نوع را در یک لیست جدا شده با کاما اعلان کنید:
```csharp
string someWord = "rosebud";
int someNumber = 42;
bool rich = true, famous = false;
```
یک اعلان ثابت (constant declaration) مانند یک اعلان متغیر است با این تفاوت که نمی‌تواند پس از اعلان تغییر کند، و مقداردهی اولیه باید همراه با اعلان رخ دهد (به "Constants" در صفحه 104 مراجعه کنید):

```csharp
const double c = 2.99792458E08;
c += 10;                        // خطای زمان کامپایل
```
