## Numeric suffixes
Numeric suffixes explicitly define the type of a literal. Suffixes can be either lower‐
case or uppercase, and are as follows:

F float float f = 1.0F;
D double double d = 1D;
M decimal decimal d = 1.0M;
U uint uint i = 1U;
L long long i = 1L;
UL ulong ulong i = 1UL;

The suffixes U and L are rarely necessary because the uint, long, and ulong types
can nearly always be either inferred or implicitly converted from int:
long i = 5; // Implicit lossless conversion from int literal to long
The D suffix is technically redundant in that all literals with a decimal point are
inferred to be double. And you can always add a decimal point to a numeric literal:
double x = 4.0;
The F and M suffixes are the most useful and should always be applied when
specifying float or decimal literals. Without the F suffix, the following line would
not compile, because 4.5 would be inferred to be of type double, which has no
implicit conversion to float:
float f = 4.5F;
The same principle is true for a decimal literal:
decimal d = -1.23M; // Will not compile without the M suffix.
We describe the semantics of numeric conversions in detail in the following section.

## Numeric Conversions
## Converting between integral types
Integral type conversions are implicit when the destination type can represent every
possible value of the source type. Otherwise, an explicit conversion is required; for
example:

int x = 12345; // int is a 32-bit integer
long y = x; // Implicit conversion to 64-bit integral type
short z = (short)x; // Explicit conversion to 16-bit integral type


## Numeric suffixes

پسوند (suffix)های عددی به صورت صریح type یک literal را تعریف می‌کنند. suffixها می‌توانند کوچک یا بزرگ باشند و به شرح زیر هستند:

| Suffix | Type | مثال |
|--------|------|------|
| F | float | `float f = 1.0F;` |
| D | double | `double d = 1D;` |
| M | decimal | `decimal d = 1.0M;` |
| U | uint | `uint i = 1U;` |
| L | long | `long i = 1L;` |
| UL | ulong | `ulong i = 1UL;` |

پسوند (suffix) های U و L به ندرت ضروری هستند زیرا typeهای `uint`، `long` و `ulong` تقریباً همیشه می‌توانند یا از `int` استنتاج شوند یا به صورت ضمنی (implicit) تبدیل شوند:
```csharp
long i = 5; // تبدیل ضمنی بدون از دست دادن اطلاعات از int literal به long
```
پسوند (suffix) D از نظر فنی زاید است چرا که تمام literalهایی که دارای نقطه اعشار هستند به صورت `double` استنتاج می‌شوند. و همیشه می‌توانید یک نقطه اعشار به یک literal عددی اضافه کنید:

```csharp
double x = 4.0;
```
پسوند (suffix)های F و M بیشترین کاربرد را دارند و همیشه باید هنگام مشخص کردن literalهای `float` یا `decimal` به کار روند. بدون suffix F، خط زیر کامپایل نمی‌شود، زیرا `4.5` به عنوان type `double` استنتاج می‌شود، که هیچ تبدیل ضمنی به `float` ندارد:

```csharp
float f = 4.5F;
```
همین اصل برای یک literal از نوع `decimal` نیز صادق است:

```csharp
decimal d = -1.23M; // بدون suffix M کامپایل نخواهد شد.
```
معناشناسی (semantics) تبدیل‌های عددی را در بخش بعدی به تفصیل شرح می‌دهیم.

## Numeric Conversions

## Converting between integral types

تبدیل‌های integral type زمانی implicit هستند که type مقصد بتواند هر مقدار ممکن از type مبدأ را نمایش دهد. در غیر این صورت، یک تبدیل explicit مورد نیاز است؛ به عنوان مثال:
```csharp
int x = 12345;       // int یک integer 32 بیتی است
long y = x;          // تبدیل implicit به integral type 64 بیتی
short z = (short)x;  // تبدیل explicit به integral type 16 بیتی
```

