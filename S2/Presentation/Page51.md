# Increment/Decrement و Specialized Integral Operations 

## 🔢 Increment and Decrement Operators

### تعریف:

> عملگرهای **`++` (increment)** و **`--` (decrement)** مقدار یک متغیر عددی را **1 واحد افزایش یا کاهش می‌دهند**.

---

### دو حالت کاربرد:

| حالت | نام | سینتکس | رفتار |
```csharp
|------|-----|--------|-------|
| **Postfix** | پسوندی | `x++` یا `x--` | ابتدا مقدار **قبلی** برگردانده می‌شود، **سپس** افزایش/کاهش رخ می‌دهد |
| **Prefix** | پیشوندی | `++x` یا `--x` | ابتدا افزایش/کاهش رخ می‌دهد، **سپس** مقدار **جدید** برگردانده می‌شود |
```
---

### مثال 1: Postfix (`x++`)
```csharp
int x = 0;
Console.WriteLine(x++);  // ⚠️ خروجی: 0 (مقدار قبلی)
Console.WriteLine(x);     // 1 (x بعد از print افزایش یافت)
```
**مراحل اجرا:**
1. مقدار فعلی `x` (که `0` است) برای `Console.WriteLine` ارسال می‌شود
2. دوم `x` به `1` افزایش می‌یابد
3. سوم `Console.WriteLine` عدد `0` را چاپ می‌کند

---

### مثال 2: Prefix (`++x`)

```csharp
int y = 0;
Console.WriteLine(++y);  // ✅ خروجی: 1 (مقدار جدید)
Console.WriteLine(y);     // 1 (y همان 1 باقی می‌ماند)
```
**مراحل اجرا:**
1. ابتدا `y` به `1` افزایش می‌یابد
2. مقدار جدید `y` (که `1` است) برای `Console.WriteLine` ارسال می‌شود
3. سوم : `Console.WriteLine` عدد `1` را چاپ می‌کند

---

### مثال 3: مقایسه مستقیم

```csharp
int x = 5, y = 5;

// Postfix
int a = x++;
Console.WriteLine($"a={a}, x={x}");  // a=5, x=6

// Prefix
int b = ++y;
Console.WriteLine($"b={b}, y={y}");  // b=6, y=6
```
---

### مثال 4: در عبارت‌های پیچیده

```csharp
int i = 0;
int result1 = i++ + i++;
Console.WriteLine($"result1={result1}, i={i}");
// result1=1 (0+1), i=2

int j = 0;
int result2 = ++j + ++j;
Console.WriteLine($"result2={result2}, j={j}");
// result2=3 (1+2), j=2
```
**⚠️ هشدار:** استفاده از چند `++`/`--` در یک عبارت می‌تواند **گیج‌کننده** باشد و **رفتار undefined** در برخی زبان‌ها دارد. در C# رفتار مشخص است اما **بهتر است از این الگو اجتناب شود**.

---

### مثال 5: Decrement (`--`)

```csharp
int x = 10, y = 10;

Console.WriteLine(x--);  // 10 (سپس x می‌شود 9)
Console.WriteLine(x);    // 9

Console.WriteLine(--y);  // 9 (y ابتدا کاهش یافت)
Console.WriteLine(y);    // 9
```
---

###  جدول مقایسه:

| عبارت | مقدار برگشتی | مقدار نهایی متغیر |
``` csharp
|-------|--------------|-------------------|
| `x = 5; x++` | `5` | `x = 6` |
| `x = 5; ++x` | `6` | `x = 6` |
| `x = 5; x--` | `5` | `x = 4` |
| `x = 5; --x` | `4` | `x = 4` |
```
---

###  کاربرد معمول:

```csharp
// در حلقه‌ها (معمولاً تفاوتی نمی‌کند)
for (int i = 0; i < 10; i++)   // یا ++i
{
Console.WriteLine(i);
}

// در Array indexing
int[] array = { 10, 20, 30 };
int index = 0;
Console.WriteLine(array[index++]);  // 10، سپس index می‌شود 1
Console.WriteLine(array[index++]);  // 20، سپس index می‌شود 2
```
---

### ✅ Best Practice:

```csharp
// ✅ واضح و خوانا
int x = 5;
int y = x;
x++;

// ❌ گیج‌کننده (اجتناب شود)
int result = x++ + ++x - x--;
```
---

## 🔢 Specialized Operations on Integral Types

### تعریف Integral Types:

> نکته » **Integral types** شامل **8 نوع صحیح** در C# هستند:

| نوع | Signed/Unsigned | بیت | محدوده |
``` csharp
|-----|-----------------|-----|--------|
| `sbyte` | Signed | 8 | $-128$ تا $127$ |
| `byte` | Unsigned | 8 | $0$ تا $255$ |
| `short` | Signed | 16 | $-32,768$ تا $32,767$ |
| `ushort` | Unsigned | 16 | $0$ تا $65,535$ |
| `int` | Signed | 32 | $-2,147,483,648$ تا $2,147,483,647$ |
| `uint` | Unsigned | 32 | $0$ تا $4,294,967,295$ |
| `long` | Signed | 64 | $-2^{63}$ تا $2^{63}-1$ |
| `ulong` | Unsigned | 64 | $0$ تا $2^{64}-1$ |
```
---

##  Division (تقسیم) در Integral Types

### قانون اصلی:

> **تقسیم اعداد صحیح همیشه باقیمانده را حذف می‌کند** (Round toward zero / Truncation).

---

### مثال 1: تقسیم ساده

```csharp
int a = 2 / 3;
Console.WriteLine(a);  // 0 ⚠️ (نه 0.666...)

int b = 5 / 2;
Console.WriteLine(b);  // 2 (نه 2.5)

int c = -5 / 2;
Console.WriteLine(c);  // -2 (نه -2.5، به سمت صفر گرد می‌شود)
```
**توضیح:**
- `2 / 3` = `0.666...` → truncate می‌شود به `0`
- `5 / 2` = `2.5` → truncate می‌شود به `2`
- `-5 / 2` = `-2.5` → truncate می‌شود به `-2` (**نه** `-3`)

---

### مثال 2: گرد شدن به سمت صفر (Round toward zero)

```csharp
Console.WriteLine(7 / 3);    // 2
Console.WriteLine(-7 / 3);   // -2 (نه -3)

Console.WriteLine(10 / 4);   // 2
Console.WriteLine(-10 / 4);  // -2 (نه -3)
```
**قانون:**
- برای اعداد **مثبت**: گرد می‌شود به **پایین** (floor)
- برای اعداد **منفی**: گرد می‌شود به **بالا** (ceiling)
- **هر دو حالت** به سمت **صفر** گرد می‌شوند

---

### ⚠️ Division by Zero (Runtime Error)

```csharp
int b = 0;
int c = 5 / b;  // ❌ Runtime Exception: DivideByZeroException
```
**دلیل:**
- تقسیم بر **متغیری** که مقدارش `0` است در **runtime** بررسی می‌شود
- منجر به **`DivideByZeroException`** می‌شود

---

### ✅ Division by Literal Zero (Compile-Time Error)

```csharp
int d = 5 / 0;  // ❌ Compile-time error: Division by constant zero
```
**دلیل:**
- کامپایلر می‌تواند تقسیم بر **عدد ثابت (literal) `0`** را در **compile-time** تشخیص دهد
- **خطای کامپایل** صادر می‌شود (نه runtime exception)

---

###  مقایسه Integer Division vs Float Division:

```csharp
// Integer division (truncate)
int a = 5 / 2;
Console.WriteLine(a);      // 2

// Float division (دقیق)
double b = 5.0 / 2.0;
Console.WriteLine(b);      // 2.5

// Mixed (ارتقا به double)
double c = 5 / 2.0;
Console.WriteLine(c);      // 2.5

// Cast برای نتیجه float
double d = (double)5 / 2;
Console.WriteLine(d);      // 2.5

// ⚠️ اشتباه متداول
double e = (double)(5 / 2);  // تقسیم ابتدا انجام می‌شود، سپس cast
Console.WriteLine(e);         // 2.0 (نه 2.5!)
```
---

###  راه حل: دریافت نتیجه اعشاری

```csharp
int numerator = 5;
int denominator = 2;

// روش 1: Cast کردن یکی از operandها
double result1 = (double)numerator / denominator;
Console.WriteLine(result1);  // 2.5 ✅

// روش 2: ضرب در 1.0
double result2 = numerator * 1.0 / denominator;
Console.WriteLine(result2);  // 2.5 ✅

// روش 3: استفاده از decimal
decimal result3 = (decimal)numerator / denominator;
Console.WriteLine(result3);  // 2.5 ✅
```
---

##  Overflow (سرریز) در Integral Types

### قانون پیش‌فرض:

> **در runtime، عملیات‌های حسابی روی integral types می‌توانند سرریز (overflow) شوند.**  
> **به طور پیش‌فرض، این اتفاق به صورت "خاموش" (silently) می‌افتد**:
> - ❌ هیچ exception پرتاب نمی‌شود
> - ⚠️ رفتار **wraparound** رخ می‌دهد

---

### مثال 1: Wraparound در Decrement

```csharp
int a = int.MinValue;    // -2,147,483,648
a--;                      // کاهش 1 واحد

Console.WriteLine(a);                     // 2147483647 ⚠️
Console.WriteLine(a == int.MaxValue);     // True
```
**توضیح:**

int.MinValue = -2,147,483,648 (32-bit signed)
در Binary:  10000000 00000000 00000000 00000000

کاهش 1 واحد:
01111111 11111111 11111111 11111111
= 2,147,483,647 (int.MaxValue)

---

### مثال 2: Wraparound در Increment

```csharp
int b = int.MaxValue;    // 2,147,483,647
b++;                      // افزایش 1 واحد

Console.WriteLine(b);                     // -2147483648 ⚠️
Console.WriteLine(b == int.MinValue);     // True
```
---

### مثال 3: Overflow در ضرب

```csharp
int x = 1000000;
int y = 1000000;
int z = x * y;

Console.WriteLine(z);  // -727379968 ⚠️ (نه 1,000,000,000,000)
```

**دلیل:**
- $1,000,000 \times 1,000,000 = 1,000,000,000,000$
- این عدد از محدوده `int` ($\approx 2.1$ میلیارد) خارج است
- بیت‌های اضافی **دور انداخته می‌شوند** و نتیجه **wraparound** می‌شود

---

### 🔬 تحلیل Wraparound:


محدوده int: -2,147,483,648 تا 2,147,483,647

فرض کنید عملیات روی یک "ساعت دایره‌ای" انجام می‌شود:

int.MaxValue (2,147,483,647)
↓ +1
int.MinValue (-2,147,483,648)

int.MinValue (-2,147,483,648)
↓ -1
int.MaxValue (2,147,483,647)

---

### مثال 4: Unsigned Overflow

```csharp
byte b = 255;     // حداکثر byte
b++;

Console.WriteLine(b);  // 0 ⚠️ (wraparound به حداقل)

byte c = 0;       // حداقل byte
c--;

Console.WriteLine(c);  // 255 ⚠️ (wraparound به حداکثر)
```
---

## ✅ Overflow Check Operators

### `checked` Operator

> **عملگر `checked` به runtime دستور می‌دهد که به جای overflow خاموش، یک `OverflowException` پرتاب کند.**

---

### سینتکس:

```csharp
// روش 1: برای یک expression
checked(expression)

// روش 2: برای یک بلوک کد
checked
{
// statements
}
```
---

### مثال 1: `checked` برای Expression

```csharp
int a = int.MaxValue;

// بدون checked (پیش‌فرض)
int b = a + 1;
Console.WriteLine(b);  // -2147483648 ⚠️ (wraparound)

// با checked
try
{
int c = checked(a + 1);  // ❌ Exception
}
catch (OverflowException ex)
{
Console.WriteLine("Overflow detected!"); ✅
}
```
---

### مثال 2: `checked` برای بلوک

```csharp
int x = int.MaxValue;

checked
{
try
{
x++;              // ❌ OverflowException
int y = x * 2;    // این خط اجرا نمی‌شود
}
catch (OverflowException)
{
Console.WriteLine("Overflow in checked block"); ✅
}
}
```
---

### عملگرهای تحت تأثیر `checked`:

> `checked` فقط بر عملگرهای زیر تأثیر می‌گذارد:

| عملگر | نام | مثال |
```csharp
|-------|-----|------|
| `++` | Increment | `x++` |
| `--` | Decrement | `x--` |
| `-` (unary) | Negation | `-x` |
| `+` | Addition | `x + y` |
| `-` | Subtraction | `x - y` |
| `*` | Multiplication | `x * y` |
| `/` | Division | `x / y` |
| **Explicit casts** | تبدیل صریح | `(int)longValue` |
```
---

### مثال 3: `checked` در Cast

```csharp
long bigNumber = long.MaxValue;

// بدون checked
int a = (int)bigNumber;
Console.WriteLine(a);  // -1 ⚠️ (wraparound)

// با checked
try
{
int b = checked((int)bigNumber);  // ❌ OverflowException
}
catch (OverflowException)
{
Console.WriteLine("Cast overflow!"); ✅
}
```
---

### عملکرد (Performance):

> **استفاده از `checked` یک هزینه عملکردی کوچک دارد.**

```csharp
// اندازه‌گیری تقریبی:
// Unchecked: ~0.5 ns per operation
// Checked:   ~0.7 ns per operation

// تفاوت معمولاً قابل صرف‌نظر است مگر در حلقه‌های بسیار تکراری
```
**توصیه:**
- برای کد معمولی: از `checked` استفاده کنید (امنیت > سرعت)
- برای کد بحرانی از نظر عملکرد: `unchecked` (اما با دقت)

---

### `unchecked` Operator (عکس `checked`)

```csharp
// فعال‌سازی مجدد wraparound (اگر checked به صورت پیش‌فرض فعال باشد)
unchecked
{
int a = int.MaxValue + 1;
Console.WriteLine(a);  // -2147483648 (wraparound)
}
```
---

## ⚠️ محدودیت‌های `checked`

### 1. تأثیر ندارد بر `float` و `double`

```csharp
checked
{
float f = float.MaxValue;
f = f * 2;
Console.WriteLine(f);  // Infinity ⚠️ (نه exception)
}
```
**دلیل:**
- `float` و `double` به جای overflow، به **مقادیر خاص "infinite"** سرریز می‌شوند
- `checked` هیچ تأثیری ندارد

---

### 2. تأثیر ندارد بر `decimal`

```csharp
// decimal همیشه checked است
decimal d = decimal.MaxValue;
// d++;  // ❌ همیشه OverflowException (حتی بدون کلمه کلیدی checked)
```
**دلیل:**
- نکته » `decimal` **به صورت پیش‌فرض و همیشه checked** است
- نمی‌توان `unchecked` را برای `decimal` اعمال کرد

---

###  جدول خلاصه Overflow Behavior:

| نوع | رفتار پیش‌فرض | تأثیر `checked` |
```csharp
|-----|--------------|----------------|
| Integral types (`int`, `long`, ...) | Wraparound | ✅ OverflowException |
| `float`, `double` | `Infinity` / `NaN` | ❌ بدون تأثیر |
| `decimal` | OverflowException | N/A (همیشه checked) |
```
---

## ✅ خلاصه نکات کلیدی

### Increment/Decrement (`++`, `--`):
1. نکته » **Postfix (`x++`):** مقدار قبل از افزایش برگردانده می‌شود
2. نکته » **Prefix (`++x`):** مقدار بعد از افزایش برگردانده می‌شود
3. در حلقه‌ها معمولاً تفاوتی ندارد

### Division در Integral Types:
1. **همیشه Truncate می‌شود** (Round toward zero)
2. `5 / 2` = `2` (نه `2.5`)
3. تقسیم بر متغیر `0`: **Runtime Exception** (`DivideByZeroException`)
4. تقسیم بر literal `0`: **Compile-time Error**

### Overflow:
1. **پیش‌فرض:** Silent wraparound (بدون exception)
2. نکته » `int.MaxValue + 1` = `int.MinValue`
3. نکته » **`checked`:** OverflowException به جای wraparound
4. **هزینه عملکرد:** کوچک اما موجود
5. **محدودیت‌ها:**
   - بر `float`/`double` تأثیر ندارد (به `Infinity` سرریز می‌شوند)
   - نکته » `decimal` همیشه checked است

