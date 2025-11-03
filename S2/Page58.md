## Conditional Operators
e && and || operators test for and and or conditions. ey are frequently used in conjunction with
the ! operator, which expresses not. In the following example, the UseUmbrella method returns
3
58
true if it’s rainy or sunny (to protect us from the rain or the sun), as long as it’s not also windy
(umbrellas are useless in the wind):
static bool UseUmbrella (bool rainy, bool sunny, bool windy)
{
return !windy && (rainy || sunny);
}
e && and || operators short-circuit evaluation when possible. In the preceding example, if it is
windy, the expression (rainy || sunny) is not even evaluated. Short-circuiting is essential in
allowing expressions such as the following to run without throwing a NullReferenceException:
if (sb != null && sb.Length > 0) ...
e & and | operators also test for and and or conditions:
return !windy & (rainy | sunny);
e difference is that they do not short-circuit. For this reason, they are rarely used in place of
conditional operators.

## Note
Unlike in C and C++, the & and | operators perform (non-short-circuiting) Boolean comparisons when applied to
bool expressions. e & and | operators perform bitwise operations only when applied to numbers.

##Conditional operator (ternary operator)
e conditional operator (more commonly called the ternary operator because it’s the only operator
that takes three operands) has the form q ? a : b; thus, if condition q is true, a is evaluated,
otherwise b is evaluated:
static int Max (int a, int b)
{
return (a > b) ? a : b;
}
e conditional operator is particularly useful in LINQ expressions (Chapter 8).

### عملگرهای شرطی

عملگرهای `&&` و `||` برای شرایط and و or تست می‌کنند. آن‌ها اغلب همراه با عملگر `!` استفاده می‌شوند که not را بیان می‌کند. در مثال زیر، متد `UseUmbrella` مقدار `true` را برمی‌گرداند اگر بارانی یا آفتابی باشد (برای محافظت از ما در برابر باران یا آفتاب)، به شرطی که بادی هم نباشد (چترها در باد بی‌فایده هستند):
```csharp
static bool UseUmbrella (bool rainy, bool sunny, bool windy)
{
return !windy && (rainy || sunny);
}
```

عملگرهای `&&` و `||` در صورت امکان، ارزیابی را short-circuit می‌کنند. در مثال قبلی، اگر بادی باشد، عبارت `(rainy || sunny)` حتی ارزیابی نمی‌شود. Short-circuit کردن در اجازه دادن به عبارت‌هایی مانند موارد زیر برای اجرا بدون پرتاب کردن `NullReferenceException` ضروری است:

```csharp
if (sb != null && sb.Length > 0) ...
```
عملگرهای `&` و `|` نیز برای شرایط and و or تست می‌کنند:

```csharp
return !windy & (rainy | sunny);
```
تفاوت این است که آن‌ها short-circuit نمی‌کنند. به همین دلیل، به ندرت به جای عملگرهای شرطی استفاده می‌شوند.



---

نکته => <sup>3</sup> امکان overload کردن این عملگرها (فصل 4) به گونه‌ای که یک نوع non-bool برگردانند وجود دارد، اما این کار تقریباً هرگز در عمل انجام نمی‌شود.


### عملگرهای شرطی

عملگرهای `&&` و `||` برای شرایط and و or تست می‌کنند. آن‌ها اغلب همراه با عملگر `!` استفاده می‌شوند که not را بیان می‌کند. در مثال زیر، متد `UseUmbrella` مقدار `true` را برمی‌گرداند اگر بارانی یا آفتابی باشد (برای محافظت از ما در برابر باران یا آفتاب)، به شرطی که بادی هم نباشد (چترها در باد بی‌فایده هستند):
```csharp
static bool UseUmbrella (bool rainy, bool sunny, bool windy)
{
return !windy && (rainy || sunny);
}
```

عملگرهای `&&` و `||` در صورت امکان، ارزیابی را short-circuit می‌کنند. در مثال قبلی، اگر بادی باشد، عبارت `(rainy || sunny)` حتی ارزیابی نمی‌شود. Short-circuit کردن در اجازه دادن به عبارت‌هایی مانند موارد زیر برای اجرا بدون پرتاب کردن `NullReferenceException` ضروری است:

```csharp
if (sb != null && sb.Length > 0) ...
```
عملگرهای `&` و `|` نیز برای شرایط and و or تست می‌کنند:

```csharp
return !windy & (rainy | sunny);
```
تفاوت این است که آن‌ها short-circuit نمی‌کنند. به همین دلیل، به ندرت به جای عملگرهای شرطی استفاده می‌شوند.<sup>3</sup>

---

برخلاف C و C++، عملگرهای `&` و `|` مقایسه‌های Boolean (بدون short-circuit) را هنگام اعمال بر عبارت‌های `bool` انجام می‌دهند. عملگرهای `&` و `|` تنها هنگام اعمال بر اعداد، عملیات bitwise را انجام می‌دهند.

---

نکته => <sup>3</sup> امکان overload کردن این عملگرها (فصل 4) به گونه‌ای که یک نوع non-bool برگردانند وجود دارد، اما این کار تقریباً هرگز در عمل انجام نمی‌شود.


**خلاصه نکات مهم در ترجمه این بخش:**

نکته => 131. **Conditional Operators (تکمیل):** توضیح کامل عملگرهای شرطی `&&`، `||` و `!` با مثال `UseUmbrella`. تأکید بر short-circuit evaluation و اهمیت آن در جلوگیری از `NullReferenceException`. مقایسه با عملگرهای `&` و `|` که short-circuit نمی‌کنند.

132. **تفاوت با C/C++:** نکته مهم درباره رفتار متفاوت عملگرهای `&` و `|` در #C نسبت به C و C++: در #C این عملگرها روی عبارت‌های `bool` مقایسه Boolean (بدون short-circuit) انجام می‌دهند، در حالی که عملیات bitwise را فقط روی اعداد اعمال می‌کنند.




### عملگر شرطی (عملگر سه‌تایی)

عملگر شرطی (که معمولاً عملگر سه‌تایی نامیده می‌شود چون تنها عملگری است که سه operand می‌گیرد) به شکل `q ? a : b` است؛ بنابراین، اگر شرط `q` درست باشد، `a` ارزیابی می‌شود، در غیر این صورت `b` ارزیابی می‌شود:
```csharp
static int Max (int a, int b)
{
return (a > b) ? a : b;
}
```
عملگر شرطی به ویژه در عبارت‌های LINQ (فصل 8) مفید است.


**خلاصه:**

نکته => 133. **Conditional operator (ternary operator):** معرفی عملگر سه‌تایی با فرمت `q ? a : b` و توضیح منطق ارزیابی آن. مثال متد `Max` برای نمایش کاربرد. اشاره به مفید بودن آن در عبارت‌های LINQ.

