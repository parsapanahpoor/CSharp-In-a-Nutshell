## Boolean Type and Operators
C#’s bool type (aliasing the System.Boolean type) is a logical value that can be
assigned the literal true or false.
Although a Boolean value requires only one bit of storage, the runtime will use one
byte of memory because this is the minimum chunk that the runtime and processor
can efficiently work with. To avoid space inefficiency in the case of arrays, .NET
provides a BitArray class in the System.Collections namespace that is designed to
use just one bit per Boolean value.

## bool Conversions
No casting conversions can be made from the bool type to numeric types, or vice
versa.

## Equality and Comparison Operators
== and != test for equality and inequality of any type but always return a bool
value.3
 Value types typically have a very simple notion of equality:
int x = 1;
int y = 2;
int z = 1;
Console.WriteLine (x == y); // False
Console.WriteLine (x == z); // True

-------------------------------------------------------------------------------------------------

3 It’s possible to overload these operators (Chapter 4) such that they return a non-bool type, but
this is almost never done in practice.

-------------------------------------------------------------------------------------------------

For reference types, equality, by default, is based on reference, as opposed to the
actual value of the underlying object (more on this in Chapter 6):
Dude d1 = new Dude ("John");
Dude d2 = new Dude ("John");
Console.WriteLine (d1 == d2); // False
Dude d3 = d1;
Console.WriteLine (d1 == d3); // True
public class Dude
{
 public string Name;
 public Dude (string n) { Name = n; }
}

-------------------------------------------------------------------------------------------------

The equality and comparison operators, ==, !=, <, >, >=, and <=, work for all numeric
types, but you should use them with caution with real numbers (as we saw in “Real
Number Rounding Errors” on page 54). The comparison operators also work on
enum type members by comparing their underlying integral-type values. We describe
this in “Enums” on page 154.
We explain the equality and comparison operators in greater detail in “Operator
Overloading” on page 256, and in “Equality Comparison” on page 344 and “Order
Comparison” on page 355.

## نوع Boolean و عملگرها

نوع `bool` در #C (که نوع `System.Boolean` را alias می‌کند) یک مقدار منطقی است که می‌تواند به آن literalهای `true` یا `false` اختصاص داده شود.

اگرچه یک مقدار Boolean تنها به یک بیت حافظه برای ذخیره‌سازی نیاز دارد، runtime از یک بایت حافظه استفاده خواهد کرد زیرا این حداقل بخشی است که runtime و پردازنده می‌توانند به طور کارآمد با آن کار کنند. برای جلوگیری از ناکارآمدی فضا در مورد آرایه‌ها، NET. یک کلاس `BitArray` در namespace `System.Collections` فراهم می‌کند که طراحی شده است تا تنها از یک بیت برای هر مقدار Boolean استفاده کند.


## تبدیل‌های bool

هیچ تبدیل casting نمی‌تواند از نوع `bool` به انواع عددی، یا برعکس، انجام شود.
## عملگرهای برابری و مقایسه

عملگرهای `==` و `!=` برابری و نابرابری را برای هر نوعی آزمایش می‌کنند اما همیشه یک مقدار `bool` برمی‌گردانند.<sup>3</sup>

انواع value معمولاً مفهومی بسیار ساده از برابری دارند:
```csharp
int x = 1;
int y = 2;
int z = 1;
Console.WriteLine (x == y); // False
Console.WriteLine (x == z); // True
```


-------------------------------------------------------------------------------------------------

 امکان overload کردن این عملگرها (فصل 4) به گونه‌ای که یک نوع non-bool برگردانند وجود دارد، اما این کار تقریباً هرگز در عمل انجام نمی‌شود.

-------------------------------------------------------------------------------------------------

برای انواع reference، برابری به طور پیش‌فرض بر اساس reference است، نه مقدار واقعی object زیرین (اطلاعات بیشتر در فصل 6):
```csharp
Dude d1 = new Dude ("John");
Dude d2 = new Dude ("John");
Console.WriteLine (d1 == d2); // False
Dude d3 = d1;
Console.WriteLine (d1 == d3); // True

public class Dude
{
 public string Name;
 public Dude (string n) { Name = n; }
}
```

-------------------------------------------------------------------------------------------------

عملگرهای برابری و مقایسه، `==`، `!=`، `<`، `>`، `>=` و `<=`، برای تمام انواع عددی کار می‌کنند، اما باید با احتیاط از آن‌ها با اعداد real استفاده کنید (همان‌طور که در "خطاهای گرد کردن اعداد Real" در صفحه 54 دیدیم). عملگرهای مقایسه همچنین روی اعضای نوع enum با مقایسه مقادیر integral-type زیربنایی آن‌ها کار می‌کنند. این موضوع را در "Enumها" در صفحه 154 توضیح می‌دهیم.

عملگرهای برابری و مقایسه را با جزئیات بیشتری در "Overload کردن عملگر" در صفحه 256، و در "مقایسه برابری" در صفحه 344 و "مقایسه ترتیب" در صفحه 355 توضیح می‌دهیم.
















