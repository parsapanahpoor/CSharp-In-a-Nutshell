# Numeric Conversions و Arithmetic Operators 

## 🔄 Converting Between Floating-Point Types

### قانون اصلی:

> نکته » **`float` می‌تواند به صورت implicit به `double` تبدیل شود**، اما **عکس آن باید explicit باشد**.

---

### مثال:
```csharp
// ✅ Implicit: float → double
float f = 1.5F;
double d = f;        // همیشه موفقیت‌آمیز

// ⚠️ Explicit: double → float
double d2 = 1.5;
float f2 = (float)d2; // نیاز به cast
```
---

###  تحلیل دقیق:

#### چرا `float` → `double` Implicit است؟

**دلیل 1: محدوده (Range)**
- `float` (32-bit): تقریباً $±1.5 \times 10^{-45}$ تا $±3.4 \times 10^{38}$
- `double` (64-bit): تقریباً $±5.0 \times 10^{-324}$ تا $±1.7 \times 10^{308}$
- **هر مقدار `float` در `double` جا می‌شود**

**دلیل 2: دقت (Precision)**
- `float`: 7-8 رقم دقت (23-bit mantissa)
- `double`: 15-16 رقم دقت (52-bit mantissa)
- **هیچ دقتی از دست نمی‌رود**

```csharp
float f = 123.456789F;
double d = f;  // ✅ همه بیت‌های f حفظ می‌شوند
Console.WriteLine(d);  // 123.456787109375 (دقیقاً همان نمایش float)
```
---

#### چرا `double` → `float` Explicit است؟

**خطر 1: از دست رفتن دقت**

```csharp
double d = 0.123456789012345;  // 15 رقم دقت
float f = (float)d;             // ⚠️ فقط ~7 رقم حفظ می‌شود
Console.WriteLine(f);           // 0.12345679 (کمتر دقیق)
```
**خطر 2: Overflow**

```csharp
double d = 1E308;      // نزدیک به حداکثر double
float f = (float)d;    // ⚠️ Infinity!
Console.WriteLine(f);  // ∞
```
---

###  جدول خلاصه:

| تبدیل | نوع | دلیل |
```csharp
|-------|-----|------|
| `float` → `double` | ✅ Implicit | Lossless (محدوده و دقت حفظ می‌شود) |
| `double` → `float` | ⚠️ Explicit | خطر از دست رفتن دقت یا overflow |
| `float` → `decimal` | ⚠️ Explicit | سیستم نمایش متفاوت (binary vs decimal) |
| `double` → `decimal` | ⚠️ Explicit | سیستم نمایش متفاوت |
| `decimal` → `float` | ⚠️ Explicit | سیستم نمایش متفاوت |
| `decimal` → `double` | ⚠️ Explicit | سیستم نمایش متفاوت |
```
---

## 🔢 Converting Between Floating-Point and Integral Types

### قانون اصلی:

> **تمام integral types می‌توانند به صورت implicit به تمام floating-point types تبدیل شوند.**  
> **عکس آن (floating → integral) همیشه explicit است.**

---

### مثال 1: Integral → Floating (Implicit ✅)

```csharp
int i = 1;
float f = i;      // ✅ Implicit
double d = i;     // ✅ Implicit
decimal m = i;    // ✅ Implicit

Console.WriteLine($"float: {f}, double: {d}, decimal: {m}");
// float: 1, double: 1, decimal: 1
```
---

### مثال 2: Floating → Integral (Explicit ⚠️)

```csharp
float f = 3.7F;
int i = (int)f;   // ⚠️ نیاز به explicit cast

Console.WriteLine(i);  // 3 (fractional part حذف شد)
```
---

##  Truncation (برش کسری) vs Rounding (گرد کردن)

### ⚠️ قانون مهم: Cast همیشه Truncate می‌کند (گرد نمی‌کند)

```csharp
float f1 = 3.2F;
float f2 = 3.7F;
float f3 = -3.7F;

int i1 = (int)f1;  // 3  (not 3)
int i2 = (int)f2;  // 3  (not 4!) ⚠️
int i3 = (int)f3;  // -3 (not -4)

Console.WriteLine($"{i1}, {i2}, {i3}");  // 3, 3, -3
```
**توضیح:**
- نکته » Casting همیشه **به سمت صفر (toward zero) truncate می‌کند**
- `3.7` → `3` (نه `4`)
- `-3.7` → `-3` (نه `-4`)

---

### ✅ راه حل: استفاده از `System.Convert` برای Rounding

```csharp
float f = 3.7F;

// روش 1: Casting (truncate)
int i1 = (int)f;                    // 3 ⚠️

// روش 2: Convert (رند می‌کند)
int i2 = Convert.ToInt32(f);        // 4 ✅

// روش 3: Math.Round (کنترل بیشتر)
int i3 = (int)Math.Round(f);        // 4 ✅
int i4 = (int)Math.Floor(f);        // 3 (همیشه به پایین)
int i5 = (int)Math.Ceiling(f);      // 4 (همیشه به بالا)

Console.WriteLine($"Cast: {i1}, Convert: {i2}, Round: {i3}");
// Cast: 3, Convert: 4, Round: 4
```
---

### نکته: `System.Convert` در فصل 6

> **کلاس `System.Convert` متدهایی را فراهم می‌کند که** در هنگام تبدیل بین انواع عددی، **رند (round) می‌کنند**.  
> (جزئیات کامل در **فصل 6** توضیح داده خواهد شد)

---

## Precision Loss (از دست رفتن دقت) در Integral → Float

### قانون مهم:

> تبدیل ضمنی یک **large integral type** به **floating-point type**:  
> - نکته » **Magnitude (اندازه) را حفظ می‌کند**  
> -  اما **گاهی اوقات ممکن است دقت (precision) از دست برود**

---

### دلیل:

- نکته » **Floating-point types** همیشه **magnitude (اندازه) بیشتری** از integral types دارند
- اما می‌توانند **precision (دقت) کمتری** داشته باشند
- این به دلیل **نحوه ذخیره‌سازی binary** در `float` و `double` است

---

### مثال: از دست رفتن دقت

```csharp
int i1 = 100000001;      // عدد دقیق
float f = i1;            // ⚠️ Magnitude حفظ شد، اما Precision از دست رفت
int i2 = (int)f;         // برگشت به int

Console.WriteLine(i1);   // 100000001 (اصلی)
Console.WriteLine(f);    // 1E+08 (نمایش علمی)
Console.WriteLine(i2);   // 100000000 ⚠️ (1 واحد از دست رفت!)
```
---

###  تحلیل دقیق:

#### چرا `100000001` به `100000000` تبدیل شد؟

**ساختار `float` (IEEE 754, 32-bit):**

[Sign: 1 bit] [Exponent: 8 bits] [Mantissa: 23 bits]

**مشکل:**
- `100000001` نیاز به **27 بیت** برای نمایش دقیق دارد
- نکته » `float` فقط **23 بیت برای mantissa** دارد
- بنابراین، **4 بیت کم‌اهمیت‌ترین (LSB) حذف می‌شوند**

**محاسبه:**


100000001 در Binary:
0101 1111 0101 1110 0000 0001
↑
23 بیت mantissa
↓ 4 بیت آخر حذف می‌شوند

نتیجه در float:
0101 1111 0101 1110 0000 0000 = 100000000

---

### مثال‌های بیشتر:

```csharp
// مثال 1: اعداد کوچک - بدون مشکل
int small = 12345;
float f1 = small;
int back1 = (int)f1;
Console.WriteLine(back1);  // 12345 ✅ دقیق

// مثال 2: اعداد بزرگ - از دست رفتن دقت
int large = 123456789;
float f2 = large;
int back2 = (int)f2;
Console.WriteLine(back2);  // 123456792 ⚠️ (3 واحد خطا!)

// مثال 3: با double - دقیق‌تر
int large2 = 123456789;
double d = large2;
int back3 = (int)d;
Console.WriteLine(back3);  // 123456789 ✅ (double دقت بیشتری دارد)
```
---

###  جدول دقت (Precision):

| نوع | بیت‌های Mantissa | رقم دقت | حداکثر integer دقیق |
```csharp
|-----|------------------|---------|---------------------|
| `float` | 23 | ~7 | $2^{24}$ = 16,777,216 |
| `double` | 52 | ~15-16 | $2^{53}$ = 9,007,199,254,740,992 |
| `decimal` | 96 | 28-29 | $2^{96}$ (خیلی بزرگ) |
```
**نتیجه:**
- برای `int` (32-bit): `double` یا `decimal` بهتر است
- برای `long` (64-bit): فقط `decimal` کاملاً دقیق است

---

##  Decimal Conversions (تبدیلات Decimal)

### قانون اصلی:

> 1. **تمام integral types می‌توانند به صورت implicit به `decimal` تبدیل شوند**  
> 2. **تمام تبدیلات دیگر به/از `decimal` باید explicit باشند**

---

### دلیل Implicit برای Integral → Decimal:

**`decimal` می‌تواند هر مقدار ممکن از هر integral type در C# را نمایش دهد:**

```csharp
byte b = 100;
int i = 123456;
long l = 9876543210L;

decimal d1 = b;  // ✅ Implicit
decimal d2 = i;  // ✅ Implicit
decimal d3 = l;  // ✅ Implicit

Console.WriteLine($"{d1}, {d2}, {d3}");
// 100, 123456, 9876543210
```

**چرا؟**
- `decimal`: 128-bit با 28-29 رقم دقت
- `long`: 64-bit (حداکثر ~19 رقم)
- **هیچ مقدار `long` از محدوده `decimal` خارج نیست**

---

### چرا سایر تبدیلات Explicit هستند؟

**دو دلیل:**
1. **خطر خارج بودن از محدوده (out of range)**
2. **خطر از دست رفتن دقت (precision loss)**

---

#### مثال 1: Decimal → Integral (خطر Overflow)

```csharp
decimal d = 1234567890.123M;
int i = (int)d;  // ⚠️ Explicit (fractional part حذف می‌شود)

Console.WriteLine(i);  // 1234567890

// خطر overflow:
decimal tooBig = decimal.MaxValue;
// int i2 = (int)tooBig;  // ❌ Runtime Exception: OverflowException
```
---

#### مثال 2: Float/Double ↔ Decimal (سیستم نمایش متفاوت)

```csharp
// ⚠️ float/double → decimal: Explicit
float f = 1.23F;
decimal d1 = (decimal)f;  // نیاز به cast

double dbl = 4.56;
decimal d2 = (decimal)dbl;  // نیاز به cast

// ⚠️ decimal → float/double: Explicit
decimal d3 = 7.89M;
float f2 = (float)d3;       // نیاز به cast
double dbl2 = (double)d3;   // نیاز به cast
```
**دلیل:**
- `float`/`double`: نمایش **binary (base-2)**
- `decimal`: نمایش **decimal (base-10)**
- تبدیل بین این دو می‌تواند منجر به **خطاهای رند شدن** شود

---

#### مثال 3: خطای دقت در Float → Decimal

```csharp
float f = 0.1F;
decimal d = (decimal)f;
Console.WriteLine(d);  
// 0.100000001490116119384765625 ⚠️
// (نه 0.1 دقیق!)
```
**تحلیل:**
- `0.1` در binary یک **اعشار تکرارشونده** است
- `float` آن را تقریب می‌زند
- تبدیل به `decimal` این تقریب را نشان می‌دهد

---

###  جدول کامل Decimal Conversions:

| تبدیل | نوع | دلیل |
```csharp
|-------|-----|------|
| `int` → `decimal` | ✅ Implicit | Lossless |
| `long` → `decimal` | ✅ Implicit | Lossless |
| `decimal` → `int` | ⚠️ Explicit | خطر Overflow + Truncation |
| `decimal` → `long` | ⚠️ Explicit | Truncation |
| `float` → `decimal` | ⚠️ Explicit | سیستم نمایش متفاوت |
| `double` → `decimal` | ⚠️ Explicit | سیستم نمایش متفاوت |
| `decimal` → `float` | ⚠️ Explicit | از دست رفتن دقت |
| `decimal` → `double` | ⚠️ Explicit | از دست رفتن دقت |
```
---

##  Arithmetic Operators (عملگرهای حسابی)

### تعریف:

> عملگرهای حسابی (`+`, `-`, `*`, `/`, `%`) برای **تمام numeric types تعریف شده‌اند**  
> **به جز** integral types **8-bit و 16-bit**.

---

### 🔢 پنج عملگر اصلی:

| عملگر | نام | مثال | توضیح |
```csharp
|-------|-----|------|-------|
| `+` | Addition (جمع) | `5 + 3` → `8` | جمع دو عدد |
| `-` | Subtraction (تفریق) | `5 - 3` → `2` | تفریق دو عدد |
| `*` | Multiplication (ضرب) | `5 * 3` → `15` | ضرب دو عدد |
| `/` | Division (تقسیم) | `10 / 3` → `3` (int) | تقسیم (رفتار متفاوت) |
| `%` | Remainder/Modulo | `10 % 3` → `1` | باقیمانده تقسیم |
```
---

###  استثنا: 8-bit و 16-bit Integral Types

**انواع خارج شده:**
- `byte`, `sbyte` (8-bit)
- `short`, `ushort` (16-bit)

**دلیل:**
این انواع **قبل از عملیات** به `int` ارتقا می‌یابند (Integer Promotion).  
(جزئیات در صفحات بعدی)

---

### مثال‌های ساده:

```csharp
// ✅ کار می‌کند با int, long, float, double, decimal
int a = 10, b = 3;
Console.WriteLine(a + b);   // 13
Console.WriteLine(a - b);   // 7
Console.WriteLine(a * b);   // 30
Console.WriteLine(a / b);   // 3 (integer division)
Console.WriteLine(a % b);   // 1 (remainder)

// ✅ با float
float f1 = 10.0F, f2 = 3.0F;
Console.WriteLine(f1 / f2); // 3.3333333

// ✅ با decimal
decimal d1 = 10.0M, d2 = 3.0M;
Console.WriteLine(d1 / d2); // 3.3333333333333333333333333333
```
---


## ✅ خلاصه نکات کلیدی

### نکته » Floating-Point Conversions:
1. نکته » `float` → `double`: ✅ Implicit (Lossless)
2. نکته » `double` → `float`: ⚠️ Explicit (خطر از دست رفتن دقت)

### نکته » Floating ↔ Integral:
1. نکته » **Integral → Floating**: ✅ Implicit (اما خطر از دست رفتن دقت برای اعداد بزرگ)
2. نکته » **Floating → Integral**: ⚠️ Explicit + **Truncation (نه Rounding)**
3. برای Rounding: استفاده از `Convert.ToInt32()` یا `Math.Round()`

### نکته » Decimal Conversions:
1. نکته » **Integral → Decimal**: ✅ Implicit (Lossless)
2. **سایر تبدیلات**: ⚠️ Explicit (خطر Overflow یا Precision Loss)
3. نکته » **Float/Double ↔ Decimal**: همیشه Explicit (سیستم نمایش متفاوت)

### نکته » Arithmetic Operators:
1. `+`, `-`, `*`, `/`, `%` برای تمام numeric types
2. **استثنا**: 8-bit و 16-bit integrals (Integer Promotion)
3. نکته » **Division**: رفتار متفاوت برای integral (truncate) vs floating-point
