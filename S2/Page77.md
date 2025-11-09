var—Implicitly Typed Local Variables
 It is often the case that you declare and initialize a variable in one step. If the
 compiler is able to infer the type from the initialization expression, you can use the
 keyword var in place of the type declaration; for example:
 var x = "hello";
 var y = new System.Text.StringBuilder();
 var z = (float)Math.PI;
 This is precisely equivalent to the following:
 string x = "hello";
 System.Text.StringBuilder y = new System.Text.StringBuilder();
 float z = (float)Math.PI;
 Because of this direct equivalence, implicitly typed variables are statically typed. For
 example, the following generates a compile-time error:
 var x = 5;
 x = "hello";    // Compile-time error; x is of type int
 var can decrease code readability when you can’t deduce the
 type purely by looking at the variable declaration. For exam
ple:
 Random r = new Random();
 var x = r.Next();
 What type is x?
 In “Anonymous Types” on page 220, we will describe a scenario in which the use of
 var is mandatory

 Target-Typed new Expressions
 Another way to reduce lexical repetition is with target-typed new expressions (from
 C# 9):
 System.Text.StringBuilder sb1 = new();
 System.Text.StringBuilder sb2 = new ("Test");
 This is precisely equivalent to:
 System.Text.StringBuilder sb1 = new System.Text.StringBuilder();
 System.Text.StringBuilder sb2 = new System.Text.StringBuilder ("Test");
 The principle is that you can call new without specifying a type name if the compiler
 is able to unambiguously infer it. Target-typed new expressions are particularly
 useful when the variable declaration and initialization are in different parts of your
 code. A common example is when you want to initialize a field in a constructor:
 class Foo
 {
 System.Text.StringBuilder sb;
  public Foo (string initialValue)


  ## var — متغیرهای محلی با نوع ضمنی (Implicitly Typed Local Variables)

اغلب پیش می‌آید که یک متغیر را در یک مرحله اعلان و مقداردهی اولیه می‌کنید. اگر کامپایلر بتواند نوع را از عبارت مقداردهی اولیه استنباط کند، می‌توانید از کلمه کلیدی `var` به جای اعلان نوع استفاده کنید؛ به عنوان مثال:
```csharp
var x = "hello";
var y = new System.Text.StringBuilder();
var z = (float)Math.PI;
```
این دقیقاً معادل موارد زیر است:

```csharp
string x = "hello";
System.Text.StringBuilder y = new System.Text.StringBuilder();
float z = (float)Math.PI;
```
به دلیل این هم‌ارزی مستقیم، متغیرهای با نوع ضمنی به صورت استاتیک نوع‌دهی می‌شوند. به عنوان مثال، کد زیر یک خطای زمان کامپایل ایجاد می‌کند:

```csharp
var x = 5;
x = "hello";    // خطای زمان کامپایل؛ x از نوع int است
```
استفاده از `var` می‌تواند خوانایی کد را کاهش دهد زمانی که نمی‌توانید نوع را صرفاً با نگاه کردن به اعلان متغیر استنباط کنید. به عنوان مثال:

```csharp
Random r = new Random();
var x = r.Next();
```
ترجمه => `x` چه نوعی است؟

در بخش "Anonymous Types" در صفحه 220، سناریویی را توصیف خواهیم کرد که در آن استفاده از `var` اجباری است.


## عبارات new با نوع هدف (Target-Typed new Expressions)

راه دیگر برای کاهش تکرار واژگانی، استفاده از **target-typed new expressions** است (از **C# 9**):
```csharp
System.Text.StringBuilder sb1 = new();
System.Text.StringBuilder sb2 = new("Test");
```
این دقیقاً معادل موارد زیر است:

```csharp
System.Text.StringBuilder sb1 = new System.Text.StringBuilder();
System.Text.StringBuilder sb2 = new System.Text.StringBuilder("Test");
```
اصل این است که می‌توانید `new` را بدون مشخص کردن نام نوع فراخوانی کنید، اگر کامپایلر بتواند آن را به صورت غیرمبهم استنباط کند. **Target-typed new expressions** به ویژه زمانی مفید هستند که اعلان متغیر و مقداردهی اولیه در بخش‌های مختلف کد شما قرار دارند. یک مثال رایج زمانی است که می‌خواهید یک فیلد را در یک **constructor** مقداردهی اولیه کنید:


