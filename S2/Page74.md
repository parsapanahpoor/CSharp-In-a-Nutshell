Optional parameters
 Methods, constructors, and indexers (Chapter 3) can declare optional parameters. A
 parameter is optional if it specifies a default value in its declaration:
 void Foo (int x = 23) { Console.WriteLine (x); }
 You can omit optional parameters when calling the method:
 Foo();     // 23
 The default argument of 23 is actually passed to the optional parameter x—the com
piler bakes the value 23 into the compiled code at the calling side. The preceding call
 to Foo is semantically identical to:
 Foo (23);
 because the compiler simply substitutes the default value of an optional parameter
 wherever it is used.
 Adding an optional parameter to a public method that’s called
 from another assembly requires recompilation of both assem
blies—just as though the parameter were mandatory.
 The default value of an optional parameter must be specified by a constant expres
sion, a parameterless constructor of a value type, or a default expression. Optional
 parameters cannot be marked with ref or out.
 Mandatory parameters must occur before optional parameters in both the method
 declaration and the method call (the exception is with params arguments, which still
 always come last). In the following example, the explicit value of 1 is passed to x,
 and the default value of 0 is passed to y:
 Foo (1);    // 1, 0
 void Foo (int x = 0, int y = 0) { Console.WriteLine (x + ", " + y); }
 You can do the converse (pass a default value to x and an explicit value to y) by
 combining optional parameters with named arguments.
 Named arguments
 Rather than identifying an argument by position, you can identify an argument by
 name:
 Foo (x:1, y:2);  // 1, 2
 void Foo (int x, int y) { Console.WriteLine (x + ", " + y); }
 Named arguments can occur in any order. The following calls to Foo are semanti
cally identical:
 Foo (x:1, y:2);
 Foo (y:2, x:1);

A subtle difference is that argument expressions are evalu
ated in the order in which they appear at the calling site.
 In general, this makes a difference only with interdependent
 side-effecting expressions such as the following, which writes
 0, 1:
 int a = 0;
 Foo (y: ++a, x: --a);  // ++a is evaluated first
 Of course, you would almost certainly avoid writing such code
 in practice!
 You can mix named and positional arguments:
 Foo (1, y:2);
 However, there is a restriction: positional arguments must come before named
 arguments unless they are used in the correct position. So, you could call Foo like
 this:
 Foo (x:1, 2);         // OK. Arguments in the declared positions
 But not like this:
 Foo (y:2, 1);         // Compile-time error. y isn't in the first position
 Named arguments are particularly useful in conjunction with optional parameters.
 For instance, consider the following method:
 void Bar (int a = 0, int b = 0, int c = 0, int d = 0) { ... }
 You can call this supplying only a value for d, as follows:
 Bar (d:3);
 This is particularly useful when calling COM APIs, which we discuss in detail in
 Chapter 24.



## پارامترهای اختیاری (Optional Parameters)

متدها، سازنده‌ها (constructors) و indexerها (فصل 3) می‌توانند پارامترهای اختیاری را تعریف کنند. یک پارامتر زمانی اختیاری است که در تعریف خود یک مقدار پیش‌فرض مشخص کند:
```csharp
void Foo (int x = 23) { Console.WriteLine (x); }
```
می‌توانید پارامترهای اختیاری را هنگام فراخوانی متد حذف کنید:

```csharp
Foo();     // 23
```
آرگومان پیش‌فرض 23 در واقع به پارامتر اختیاری `x` منتقل می‌شود — کامپایلر مقدار 23 را در کد کامپایل‌شده در سمت فراخوانی می‌نویسد (bake می‌کند). فراخوانی قبلی `Foo` از نظر معنایی مشابه این است:

```csharp
Foo (23);
```
زیرا کامپایلر به سادگی مقدار پیش‌فرض پارامتر اختیاری را در هر جایی که استفاده می‌شود جایگزین می‌کند.

> **نکته مهم:** اضافه کردن یک پارامتر اختیاری به یک متد عمومی که از assembly دیگری فراخوانی می‌شود، نیاز به recompile کردن هر دو assembly دارد — درست مثل زمانی که پارامتر اجباری باشد.

مقدار پیش‌فرض یک پارامتر اختیاری باید توسط یک عبارت ثابت (constant expression)، یک سازنده بدون پارامتر از یک value type، یا یک عبارت `default` مشخص شود. پارامترهای اختیاری نمی‌توانند با `ref` یا `out` مشخص شوند.

پارامترهای اجباری باید قبل از پارامترهای اختیاری هم در تعریف متد و هم در فراخوانی متد قرار بگیرند (استثنا در مورد آرگومان‌های `params` است که همیشه در آخر می‌آیند). در مثال زیر، مقدار صریح 1 به `x` و مقدار پیش‌فرض 0 به `y` منتقل می‌شود:

```csharp
Foo (1);    // 1, 0

void Foo (int x = 0, int y = 0) { Console.WriteLine (x + ", " + y); }
```
می‌توانید عکس این را انجام دهید (مقدار پیش‌فرض به `x` و مقدار صریح به `y`) با ترکیب پارامترهای اختیاری با آرگومان‌های نام‌دار (named arguments).

---

### خلاصه نکات کلیدی:

- **تعریف پارامتر اختیاری**: با تعیین مقدار پیش‌فرض در تعریف پارامتر
- **جایگزینی توسط کامپایلر**: کامپایلر مقدار پیش‌فرض را در کد فراخوانی جایگزین می‌کند
- **الزام recompile**: تغییر پارامتر اختیاری در متد عمومی نیاز به recompile کردن assemblies دارد
- **محدودیت‌های مقدار پیش‌فرض**: فقط constant expression، سازنده بدون پارامتر، یا `default`
- **عدم سازگاری با `ref`/`out`**: پارامترهای اختیاری نمی‌توانند `ref` یا `out` باشند
- **ترتیب پارامترها**: اجباری قبل از اختیاری (به جز `params` که آخر است)

## آرگومان‌های نام‌دار (Named Arguments)

به جای شناسایی یک آرگومان با موقعیت، می‌توانید آرگومان را با نام شناسایی کنید:
```csharp
Foo (x:1, y:2);  // 1, 2

void Foo (int x, int y) { Console.WriteLine (x + ", " + y); }
```
آرگومان‌های نام‌دار می‌توانند به هر ترتیبی قرار بگیرند. فراخوانی‌های زیر `Foo` از نظر معنایی یکسان هستند:

```csharp
Foo (x:1, y:2);
Foo (y:2, x:1);
```
> **نکته ظریف:** تفاوت ظریف این است که عبارت‌های آرگومان به ترتیبی که در سایت فراخوانی ظاهر می‌شوند ارزیابی می‌شوند. به طور کلی، این فقط با عبارت‌های وابسته به هم با side-effect تفاوت ایجاد می‌کند مانند مثال زیر که 0، 1 را می‌نویسد:

```csharp
 int a = 0;
 Foo (y: ++a, x: --a);  // ++a ابتدا ارزیابی می‌شود
```

