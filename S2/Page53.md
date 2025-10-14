## 8- and 16-Bit Integral Types
The 8- and 16-bit integral types are byte, sbyte, short, and ushort. These types
lack their own arithmetic operators, so C# implicitly converts them to larger types
as required. This can cause a compile-time error when trying to assign the result
back to a small integral type:
short x = 1, y = 1;
short z = x + y; // Compile-time error
In this case, x and y are implicitly converted to int so that the addition can be
performed. This means that the result is also an int, which cannot be implicitly cast
back to a short (because it could cause loss of data). To make this compile, you
must add an explicit cast:
short z = (short) (x + y); // OK

## Special Float and Double Values
Unlike integral types, floating-point types have values that certain operations treat
specially. These special values are NaN (Not a Number), +∞, −∞, and −0. The float
and double classes have constants for NaN, +∞, and −∞, as well as other values
(MaxValue, MinValue, and Epsilon); for example:
Console.WriteLine (double.NegativeInfinity); // -Infinity
The constants that represent special values for double and float are as follows:
Special value Double constant Float constant
NaN double.NaN float.NaN
+∞ double.PositiveInfinity float.PositiveInfinity
−∞ double.NegativeInfinity float.NegativeInfinity
−0 −0.0 −0.0f

--------------------------------------------------------------------------------------------------------

Dividing a nonzero number by zero results in an infinite value:
Console.WriteLine ( 1.0 / 0.0); // Infinity
Console.WriteLine (−1.0 / 0.0); // -Infinity
Console.WriteLine ( 1.0 / −0.0); // -Infinity
Console.WriteLine (−1.0 / −0.0); // Infinity
Dividing zero by zero, or subtracting infinity from infinity, results in a NaN:
Console.WriteLine ( 0.0 / 0.0); // NaN
Console.WriteLine ((1.0 / 0.0) − (1.0 / 0.0)); // NaN

--------------------------------------------------------------------------------------------------------

When using ==, a NaN value is never equal to another value, even another NaN
value:
Console.WriteLine (0.0 / 0.0 == double.NaN); // False
To test whether a value is NaN, you must use the float.IsNaN or double.IsNaN
method:
Console.WriteLine (double.IsNaN (0.0 / 0.0)); // True
When using object.Equals, however, two NaN values are equal:
Console.WriteLine (object.Equals (0.0 / 0.0, double.NaN)); // True

--------------------------------------------------------------------------------------------------------

NaNs are sometimes useful in representing special values. In
Windows Presentation Foundation (WPF), double.NaN repre‐
sents a measurement whose value is “Automatic.” Another way
to represent such a value is with a nullable type (Chapter 4);
another is with a custom struct that wraps a numeric type and
adds an additional field (Chapter 3).

--------------------------------------------------------------------------------------------------------

float and double follow the specification of the IEEE 754 format types, supported
natively by almost all processors. You can find detailed information on the behavior
of these types at http://www.ieee.org.

## typeهای integral تک‌بایتی و دوبایتی

نوع typeهای integral تک‌بایتی و دوبایتی عبارتند از `byte`، `sbyte`، `short` و `ushort`. این typeها عملگرهای حسابی مخصوص به خود را ندارند، بنابراین C# به صورت ضمنی آن‌ها را به typeهای بزرگ‌تر تبدیل می‌کند در صورت نیاز. این امر می‌تواند باعث خطای زمان کامپایل شود هنگامی که سعی می‌کنید نتیجه را دوباره به یک type integral کوچک اختصاص دهید:
```csharp
short x = 1, y = 1;
short z = x + y;        // خطای زمان کامپایل
```
در این حالت، `x` و `y` به صورت ضمنی به `int` تبدیل می‌شوند تا عملیات جمع انجام شود. این بدان معناست که نتیجه نیز یک `int` است، که نمی‌تواند به صورت ضمنی به `short` تبدیل شود (چون ممکن است باعث از دست رفتن داده شود). برای کامپایل شدن این کد، باید یک cast صریح اضافه کنید:

```csharp
short z = (short) (x + y);  // OK
```

## مقادیر ویژه Float و Double

برخلاف typeهای integral، typeهای floating-point دارای مقادیری هستند که عملیات‌های خاصی با آن‌ها به صورت ویژه رفتار می‌کنند. این مقادیر ویژه عبارتند از NaN (Not a Number)، $+\infty$، $-\infty$ و $-0$. classهای `float` و `double` دارای ثابت‌هایی برای NaN، $+\infty$ و $-\infty$ و همچنین مقادیر دیگری (`MaxValue`، `MinValue` و `Epsilon`) هستند؛ به عنوان مثال:
```csharp
Console.WriteLine (double.NegativeInfinity);  // -Infinity
```
ثابت‌هایی که مقادیر ویژه برای `double` و `float` را نشان می‌دهند به شرح زیر هستند:

| مقدار ویژه | ثابت Double | ثابت Float |
|------------|--------------|------------|
| NaN | `double.NaN` | `float.NaN` |
| $+\infty$ | `double.PositiveInfinity` | `float.PositiveInfinity` |
| $-\infty$ | `double.NegativeInfinity` | `float.NegativeInfinity` |
| $-0$ | `-0.0` | `-0.0f` |


--------------------------------------------------------------------------------------------------------

تقسیم یک عدد غیرصفر بر صفر منجر به یک مقدار نامتناهی (infinite) می‌شود:
```csharp
Console.WriteLine ( 1.0 /  0.0);  //  Infinity
Console.WriteLine (−1.0 /  0.0);  // -Infinity
Console.WriteLine ( 1.0 / −0.0);  // -Infinity
Console.WriteLine (−1.0 / −0.0);  //  Infinity
```
تقسیم صفر بر صفر، یا تفریق نامتناهی از نامتناهی، منجر به NaN می‌شود:

```csharp
Console.WriteLine ( 0.0 / 0.0);                //  NaN
Console.WriteLine ((1.0 / 0.0) − (1.0 / 0.0)); //  NaN
```
--------------------------------------------------------------------------------------------------------

هنگام استفاده از `==`، یک مقدار NaN هرگز با مقدار دیگری برابر نیست، حتی با مقدار NaN دیگری:
```csharp
Console.WriteLine (0.0 / 0.0 == double.NaN);  // False
```
برای تست اینکه آیا یک مقدار NaN است، باید از متد `float.IsNaN` یا `double.IsNaN` استفاده کنید:

```csharp
Console.WriteLine (double.IsNaN (0.0 / 0.0));  // True
```
با این حال، هنگام استفاده از `object.Equals`، دو مقدار NaN برابر هستند:

```csharp
Console.WriteLine (object.Equals (0.0 / 0.0, double.NaN));  // True
```
--------------------------------------------------------------------------------------------------------

مقادیر NaN گاهی اوقات برای نشان دادن مقادیر ویژه مفید هستند. در Windows Presentation Foundation (WPF)، `double.NaN` نشان‌دهندهٔ یک اندازه‌گیری است که مقدار آن "Automatic" است. راه دیگر برای نشان دادن چنین مقداری، استفاده از nullable type است (فصل 4)؛ راه دیگر استفاده از یک struct سفارشی است که یک numeric type را wrap می‌کند و یک field اضافی به آن اضافه می‌کند (فصل 3).

--------------------------------------------------------------------------------------------------------

نوع typeهای `float` و `double` از مشخصات format typeهای IEEE 754 پیروی می‌کنند که به صورت native توسط تقریباً تمام پردازنده‌ها پشتیبانی می‌شوند. می‌توانید اطلاعات دقیق درباره رفتار این typeها را در http://www.ieee.org پیدا کنید.

