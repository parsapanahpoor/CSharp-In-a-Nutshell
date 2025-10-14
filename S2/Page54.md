## double Versus decimal
double is useful for scientific computations (such as computing spatial coordinates).
decimal is useful for financial computations and values that are manufactured
rather than the result of real-world measurements. Here’s a summary of the
differences.
Category double decimal
Internal representation Base 2 Base 10
Decimal precision 15–16 significant figures 28–29 significant figures
Range ±(~10−324 to ~10308) ±(~10−28 to ~1028)
Special values +0, −0, +∞, −∞, and NaN None
Speed Native to processor Non-native to processor (about 10 times slower than
double)

## Real Number Rounding Errors
float and double internally represent numbers in base 2. For this reason, only
numbers expressible in base 2 are represented precisely. Practically, this means most
literals with a fractional component (which are in base 10) will not be represented
precisely; for example:
float x = 0.1f; // Not quite 0.1
Console.WriteLine (x + x + x + x + x + x + x + x + x + x); // 1.0000001

------------------------------------------------------------------------------------------------------------

This is why float and double are bad for financial calculations. In contrast, deci
mal works in base 10 and so can precisely represent numbers expressible in base
10 (as well as its factors, base 2 and base 5). Because real literals are in base 10,
decimal can precisely represent numbers such as 0.1. However, neither double nor
decimal can precisely represent a fractional number whose base 10 representation is
recurring:
decimal m = 1M / 6M; // 0.1666666666666666666666666667M
double d = 1.0 / 6.0; // 0.16666666666666666
This leads to accumulated rounding errors:
decimal notQuiteWholeM = m+m+m+m+m+m; // 1.0000000000000000000000000002M
double notQuiteWholeD = d+d+d+d+d+d; // 0.99999999999999989
which break equality and comparison operations:
Console.WriteLine (notQuiteWholeM == 1M); // False
Console.WriteLine (notQuiteWholeD < 1.0); // True

## double در مقابل decimal

نوعtype `double` برای محاسبات علمی (مانند محاسبه مختصات فضایی) مفید است. type `decimal` برای محاسبات مالی و مقادیری که ساخته شده‌اند به جای اینکه نتیجه اندازه‌گیری‌های دنیای واقعی باشند، مفید است. خلاصه‌ای از تفاوت‌ها به شرح زیر است:

| دسته‌بندی | double | decimal |
|-----------|--------|---------|
| نمایش داخلی | Base 2 | Base 10 |
| دقت اعشاری | 15–16 رقم معنادار | 28–29 رقم معنادار |
| محدوده | $\pm(\sim10^{-324}$ تا $\sim10^{308})$ | $\pm(\sim10^{-28}$ تا $\sim10^{28})$ |
| مقادیر ویژه | $+0$، $-0$، $+\infty$، $-\infty$ و NaN | هیچ‌کدام |
| سرعت | Native به پردازنده | Non-native به پردازنده (تقریباً 10 برابر کندتر از double) |

## خطاهای گرد کردن اعداد حقیقی

نوعtypeهای `float` و `double` به صورت داخلی اعداد را در base 2 نمایش می‌دهند. به همین دلیل، فقط اعدادی که در base 2 قابل بیان هستند به طور دقیق نمایش داده می‌شوند. از نظر عملی، این بدان معناست که اکثر literalهایی که دارای جزء کسری هستند (که در base 10 هستند) به طور دقیق نمایش داده نخواهند شد؛ به عنوان مثال:

```csharp
float x = 0.1f; // دقیقاً 0.1 نیست
Console.WriteLine (x + x + x + x + x + x + x + x + x + x); // 1.0000001
```
------------------------------------------------------------------------------------------------------------

به همین دلیل است که typeهای `float` و `double` برای محاسبات مالی مناسب نیستند. در مقابل، `decimal` در base 10 کار می‌کند و بنابراین می‌تواند اعدادی که در base 10 قابل بیان هستند (و همچنین عامل‌های آن، base 2 و base 5) را به طور دقیق نمایش دهد. به دلیل اینکه literalهای real در base 10 هستند، `decimal` می‌تواند اعدادی مانند 0.1 را به طور دقیق نمایش دهد. با این حال، هیچ‌کدام از `double` و `decimal` نمی‌توانند عدد کسری که نمایش base 10 آن تکرار شونده است را به طور دقیق نمایش دهند:
```csharp
decimal m = 1M / 6M; // 0.1666666666666666666666666667M
double d = 1.0 / 6.0; // 0.16666666666666666
```
این امر منجر به خطاهای گرد کردن انباشته شده می‌شود:

```csharp
decimal notQuiteWholeM = m+m+m+m+m+m; // 1.0000000000000000000000000002M
double notQuiteWholeD = d+d+d+d+d+d; // 0.99999999999999989
```
که عملیات‌های برابری و مقایسه را خراب می‌کند:

```csharp
Console.WriteLine (notQuiteWholeM == 1M); // False
Console.WriteLine (notQuiteWholeD < 1.0); // True
```





























