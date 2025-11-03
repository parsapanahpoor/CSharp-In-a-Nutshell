## String interpolation
A string preceded with the $ character is called an interpolated string. Interpolated strings can
include expressions enclosed in braces:
int x = 4;
Console.Write ($"A square has {x} sides"); // Prints: A square has 4 sides
Any valid C# expression of any type can appear within the braces, and C# will convert the expression
to a string by calling its ToString method or equivalent. You can change the formatting by
appending the expression with a colon and a format string (format strings are described in
“String.Format and composite format strings”):
string s = $"255 in hex is {byte.MaxValue:X2}"; // X2 = 2-digit hexadecimal
// Evaluates to "255 in hex is FF"
Should you need to use a colon for another purpose (such as a ternary conditional operator, which
we’ll cover later), you must wrap the entire expression in parentheses:
bool b = true;
Console.WriteLine ($"The answer in binary is {(b ? 1 : 0)}");
Interpolated strings must complete on a single line, unless you also specify the verbatim string
operator:
int x = 2;
// Note that $ must appear before @ prior to C# 8:
string s = $@"this interpolation spans {
x} lines";
To include a brace literal in an interpolated string, repeat the desired brace character.

## String comparisons
string does not support < and > operators for comparisons. You must use the string’s CompareTo
method, described in Chapter 6.
62

## Constant interpolated strings (C# 10)
From C# 10, interpolated strings can be constants, as long as the interpolated values are constants:
const string greeting = "Hello";
const string message = $"{greeting}, world";

## درون‌یابی String

یک string که با کاراکتر `$` پیشوند خورده، interpolated string نامیده می‌شود. stringهای interpolated می‌توانند عبارت‌هایی را که در داخل آکولاد قرار دارند شامل شوند:
```csharp
int x = 4;
Console.Write ($"A square has {x} sides"); // چاپ می‌کند: A square has 4 sides
```
هر عبارت معتبر #C از هر نوعی می‌تواند در داخل آکولادها ظاهر شود، و #C با فراخوانی متد `ToString` یا معادل آن، عبارت را به string تبدیل می‌کند. می‌توانید قالب‌بندی را با اضافه کردن یک colon و یک format string به عبارت تغییر دهید (format stringها در بخش "String.Format and composite format strings" توضیح داده شده‌اند):

```csharp
string s = $"255 in hex is {byte.MaxValue:X2}"; // X2 = hexadecimal دو رقمی
// به "255 in hex is FF" ارزیابی می‌شود
```
اگر نیاز دارید از colon برای هدف دیگری استفاده کنید (مانند عملگر شرطی سه‌تایی که بعداً پوشش خواهیم داد)، باید کل عبارت را در داخل پرانتز قرار دهید:

```csharp
bool b = true;
Console.WriteLine ($"The answer in binary is {(b ? 1 : 0)}");
```
نکته => stringهای interpolated باید در یک خط کامل شوند، مگر اینکه عملگر verbatim string را نیز مشخص کنید:

```csharp
int x = 2;
// توجه کنید که $ باید قبل از @ ظاهر شود (قبل از C# 8):
string s = $@"this interpolation spans {
x} lines";
```

برای قرار دادن یک آکولاد literal در یک interpolated string، کاراکتر آکولاد مورد نظر را تکرار کنید.

## مقایسه‌های String

ترجمه => `string` از عملگرهای `<` و `>` برای مقایسه‌ها پشتیبانی نمی‌کند. باید از متد `CompareTo` مربوط به string استفاده کنید که در فصل 6 توضیح داده شده است.

## stringهای interpolated ثابت (C# 10)

از #C 10 به بعد، stringهای interpolated می‌توانند ثابت باشند، به شرطی که مقادیر interpolated شده ثابت باشند:

```csharp
const string greeting = "Hello";
const string message = $"{greeting}, world";
```

**خلاصه نکات مهم:**

 ترجمه => 146. **String interpolation:** معرفی interpolated stringها با پیشوند `$` که اجازه می‌دهند عبارت‌ها در داخل آکولاد `{}` قرار گیرند. مثال چاپ تعداد اضلاع مربع.

ترجمه => 147. **Expression evaluation in interpolation:** هر عبارت معتبر #C می‌تواند در آکولادها قرار گیرد و با `ToString` به string تبدیل می‌شود.

ترجمه => 148. **Format strings in interpolation:** امکان تغییر قالب‌بندی با اضافه کردن colon و format string (مثال `{byte.MaxValue:X2}` برای hexadecimal دو رقمی).

ترجمه => 149. **Colon usage and parentheses:** برای استفاده از colon در موارد دیگر (مثل عملگر سه‌تایی)، باید کل عبارت را در پرانتز قرار داد.

ترجمه => 150. **Multi-line interpolated strings:** interpolated stringها باید یک خطی باشند مگر اینکه با `@` ترکیب شوند. نکته مهم: `$` باید قبل از `@` بیاید (قبل از #C 8).

ترجمه => 151. **Brace literals:** برای قرار دادن آکولاد literal، باید آکولاد را تکرار کرد.

ترجمه => 152. **String comparisons:** `string` از عملگرهای `<` و `>` پشتیبانی نمی‌کند و باید از متد `CompareTo` استفاده شود.

ترجمه => 153. **Constant interpolated strings (C# 10):** از #C 10، interpolated stringها می‌توانند ثابت باشند اگر مقادیر درون‌یابی شده نیز ثابت باشند.

آماده دریافت بخش بعدی هستم.
