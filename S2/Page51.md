## Increment and Decrement Operators
The increment and decrement operators (++, --, respectively) increment and decre‐
ment numeric types by 1. The operator can either follow or precede the variable,
depending on whether you want its value before or after the increment/decrement;
for example:
int x = 0, y = 0;
Console.WriteLine (x++); // Outputs 0; x is now 1
Console.WriteLine (++y); // Outputs 1; y is now 1

## Specialized Operations on Integral Types
The integral types are int, uint, long, ulong, short, ushort, byte, and sbyte.

## Division
Division operations on integral types always eliminate the remainder (round toward
zero). Dividing by a variable whose value is zero generates a runtime error (a
DivideByZeroException):
int a = 2 / 3; // 0
int b = 0;
int c = 5 / b; // throws DivideByZeroException
Dividing by the literal or constant 0 generates a compile-time error.

## Overflow
At runtime, arithmetic operations on integral types can overflow. By default, this
happens silently—no exception is thrown, and the result exhibits “wraparound”
behavior, as though the computation were done on a larger integer type and the
extra significant bits discarded. For example, decrementing the minimum possible
int value results in the maximum possible int value:
int a = int.MinValue;
a--;
Console.WriteLine (a == int.MaxValue); // True

## Overflow check operators
The checked operator instructs the runtime to generate an OverflowException
rather than overflowing silently when an integral-type expression or statement
exceeds the arithmetic limits of that type. The checked operator affects expressions
with the ++, −−, +, − (binary and unary), *, /, and explicit conversion operators
between integral types. Overflow checking incurs a small performance cost.

----------------------------------------------------------------------------------

The checked operator has no effect on the double and float
types (which overflow to special “infinite” values, as you’ll see
soon) and no effect on the decimal type (which is always
checked).


## عملگرهای Increment و Decrement

عملگرهای increment و decrement (به ترتیب `++` و `--`) typeهای عددی را به میزان 1 افزایش و کاهش می‌دهند. عملگر می‌تواند بعد یا قبل از متغیر قرار بگیرد، بسته به اینکه مقدار آن را قبل یا بعد از increment/decrement می‌خواهید؛ برای مثال:
```csharp
int x = 0, y = 0;
Console.WriteLine (x++);  // خروجی 0؛ x اکنون 1 است
Console.WriteLine (++y);  // خروجی 1؛ y اکنون 1 است
```

## عملیات‌های تخصصی روی Integral Types

نوع typeهای integral عبارتند از `int`، `uint`، `long`، `ulong`، `short`، `ushort`، `byte` و `sbyte`.

## تقسیم (Division)

عملیات‌های تقسیم روی typeهای integral همیشه باقیمانده را حذف می‌کنند (به سمت صفر رند می‌کنند). تقسیم بر یک متغیر که مقدار آن صفر است، یک خطای زمان اجرا تولید می‌کند (یک `DivideByZeroException`):
```csharp
int a = 2 / 3;      // 0
int b = 0;
int c = 5 / b;      // پرتاب می‌کند DivideByZeroException
```
تقسیم بر literal یا constant به مقدار 0 یک خطای زمان کامپایل تولید می‌کند.

## سرریز (Overflow)

در زمان اجرا، عملیات‌های arithmetic روی typeهای integral می‌توانند سرریز (overflow) شوند. به طور پیش‌فرض، این اتفاق به صورت خاموش (silently) رخ می‌دهد—هیچ exception پرتاب نمی‌شود و نتیجه رفتار "wraparound" را نشان می‌دهد، طوری که انگار محاسبه روی یک integer type بزرگتر انجام شده و بیت‌های معنادار اضافی دور انداخته شده‌اند. برای مثال، کاهش دادن کمترین مقدار ممکن `int` منجر به بیشترین مقدار ممکن `int` می‌شود:

```csharp
int a = int.MinValue;
a--;
Console.WriteLine (a == int.MaxValue);  // True
```

## عملگرهای بررسی Overflow

عملگر `checked` به runtime دستور می‌دهد که به جای سرریز خاموش، یک `OverflowException` تولید کند، زمانی که یک expression یا statement از نوع integral-type از محدوده‌های arithmetic آن type فراتر رود. عملگر `checked` بر expressionهایی که شامل `++`، `--`، `+`، `-` (دودویی و تک‌عملوندی)، `*`، `/` و عملگرهای تبدیل explicit بین typeهای integral هستند، تأثیر می‌گذارد. بررسی overflow هزینه‌ای کوچک در عملکرد (performance) ایجاد می‌کند.


----------------------------------------------------------------------------------

عملگر `checked` هیچ تأثیری بر typeهای `double` و `float` ندارد (که به مقادیر خاص "نامتناهی" (infinite) سرریز می‌شوند، همان‌طور که به زودی خواهید دید) و هیچ تأثیری بر type به نام `decimal` ندارد (که همیشه checked است).

