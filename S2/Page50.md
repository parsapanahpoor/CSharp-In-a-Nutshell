## Converting between floating-point types
A float can be implicitly converted to a double given that a double can represent
every possible value of a float. The reverse conversion must be explicit.

## Converting between floating-point and integral types
All integral types can be implicitly converted to all floating-point types:
  int i = 1;
  float f = i;
The reverse conversion must be explicit:
  int i2 = (int)f;

-----------------------------------------------------------------------------------

When you cast from a floating-point number to an integral
type, any fractional portion is truncated; no rounding is per‐
formed. The static class System.Convert provides methods
that round while converting between various numeric types
(see Chapter 6).

-----------------------------------------------------------------------------------

Implicitly converting a large integral type to a floating-point type preserves magni‐
tude but can occasionally lose precision. This is because floating-point types always
have more magnitude than integral types but can have less precision. Rewriting our
example with a larger number demonstrates this:
  int i1 = 100000001;
  float f = i1; // Magnitude preserved, precision lost
  int i2 = (int)f; // 100000000

## Decimal conversions
All integral types can be implicitly converted to the decimal type given that a
decimal can represent every possible C# integral-type value. All other numeric
conversions to and from a decimal type must be explicit because they introduce the
possibility of either a value being out of range or precision being lost.

## Arithmetic Operators
The arithmetic operators (+, -, *, /, %) are defined for all numeric types except the 8-
and 16-bit integral types:
  + Addition
  - Subtraction
  * Multiplication
  / Division
  % Remainder after division


## Converting between floating-point types

یک `float` می‌تواند به صورت implicit به `double` تبدیل شود، با توجه به اینکه `double` می‌تواند هر مقدار ممکن از `float` را نمایش دهد. تبدیل معکوس باید explicit باشد.

## Converting between floating-point and integral types

تمام typeهای integral می‌توانند به صورت implicit به تمام typeهای floating-point تبدیل شوند:
```csharp
int i = 1;
float f = i;
```
تبدیل معکوس باید explicit باشد:

```csharp
int i2 = (int)f;
```
-----------------------------------------------------------------------------------

هنگامی که از یک عدد floating-point به یک integral type کست می‌کنید، هر بخش کسری حذف می‌شود؛ هیچ رند کردنی انجام نمی‌شود. کلاس static به نام `System.Convert` متدهایی را فراهم می‌کند که هنگام تبدیل بین typeهای عددی مختلف، رند کردن انجام می‌دهند (به فصل 6 مراجعه کنید).

-----------------------------------------------------------------------------------

تبدیل implicit یک integral type بزرگ به یک floating-point type، بزرگی (magnitude) را حفظ می‌کند اما گاهی اوقات ممکن است دقت (precision) را از دست بدهد. این به این دلیل است که typeهای floating-point همیشه بزرگی بیشتری نسبت به typeهای integral دارند اما می‌توانند دقت کمتری داشته باشند. بازنویسی مثال ما با یک عدد بزرگتر این موضوع را نشان می‌دهد:

```csharp
int i1 = 100000001;
float f = i1;      // بزرگی حفظ شد، دقت از دست رفت
int i2 = (int)f;   // 100000000
```

## تبدیل‌های Decimal

تمام typeهای integral می‌توانند به صورت implicit به type به نام `decimal` تبدیل شوند، با توجه به اینکه `decimal` می‌تواند هر مقدار ممکن از integral-typeهای C#‎ را نمایش دهد. تمام تبدیل‌های عددی دیگر به و از type به نام `decimal` باید explicit باشند، زیرا آن‌ها امکان خارج شدن یک مقدار از محدوده یا از دست رفتن دقت را ایجاد می‌کنند.

## عملگرهای Arithmetic

عملگرهای arithmetic به نام‌های (`+`, `-`, `*`, `/`, `%`) برای تمام typeهای عددی به جز typeهای integral با سایز 8 و 16 بیتی تعریف شده‌اند:

- `+` جمع (Addition)
- `-` تفریق (Subtraction)  
- `*` ضرب (Multiplication)
- `/` تقسیم (Division)
- `%` باقیمانده پس از تقسیم (Remainder after division)

















