# Numeric Suffixes و Numeric Conversions 

## پسوندهای عددی  Numeric Suffixes )

### تعریف:
> نکته » **Numeric Suffixes** به صورت **صریح (explicit)** نوع یک لیترال را مشخص می‌کنند.  
> پسوندها می‌توانند **lowercase** یا **UPPERCASE** باشند.

---

##  جدول کامل Suffixes
```csharp

| Suffix | نوع | مثال | توضیح |
|--------|-----|------|-------|
| `F` یا `f` | `float` | `float f = 1.0F;` | **ضروری** برای `float` |
| `D` یا `d` | `double` | `double d = 1D;` | اختیاری (پیش‌فرض) |
| `M` یا `m` | `decimal` | `decimal d = 1.0M;` | **ضروری** برای `decimal` |
| `U` یا `u` | `uint` | `uint i = 1U;` | معمولاً غیرضروری |
| `L` یا `l` | `long` | `long i = 1L;` | معمولاً غیرضروری |
| `UL` یا `ul` یا `LU` یا `lu` | `ulong` | `ulong i = 1UL;` | معمولاً غیرضروری |
```

---

## 🔍 تحلیل دقیق هر Suffix

### 1️⃣ Suffixes **U** و **L** (معمولاً غیرضروری)

> **پسوندهای `U` و `L` به ندرت ضروری هستند** زیرا انواع `uint`، `long` و `ulong` تقریباً همیشه می‌توانند:
> - از لیترال `int` **استنباط شوند (inferred)**
> - یا به صورت **ضمنی (implicit)** از `int` تبدیل شوند

---

#### مثال 1: Implicit Conversion به `long`
```csharp
long i = 5;  // ✅ Implicit lossless conversion از int literal به long
```
**تحلیل:**
- لیترال `5` به صورت پیش‌فرض `int` است
- `int` → `long` یک **Implicit Conversion** است
- **هیچ اطلاعاتی از دست نمی‌رود** (32-bit → 64-bit)
- پس نیازی به suffix `L` نیست:

```csharp
// این دو یکسان هستند:
long i = 5;
long i = 5L;  // suffix اضافی است
```
---

#### مثال 2: Implicit Conversion به `uint`

```csharp
uint x = 100;   // ✅ معمولاً کار می‌کند (اگر مقدار مثبت باشد)
uint y = 100U;  // ✅ صریح‌تر اما معمولاً غیرضروری
```
**⚠️ نکته:** اگر لیترال بزرگ‌تر از `int.MaxValue` باشد، suffix `U` لازم است:

```csharp
// ❌ خطا: خارج از محدوده int
// uint x = 3000000000;

// ✅ درست:
uint x = 3000000000U;
```
---

#### مثال 3: چه زمانی `L` ضروری است؟

```csharp
// ✅ معمولاً کافی است:
long x = 5000000000;  // کامپایلر خودش تشخیص می‌دهد

// اما در برخی موارد نیاز است:
var y = 5000000000;   // ❌ خطا: خارج از محدوده int
var y = 5000000000L;  // ✅ درست: صریحاً long
```
---

### 2️⃣ Suffix **D** (تکنیکاً زائد)

> **پسوند `D` از نظر فنی زائد (redundant) است** زیرا تمام لیترال‌هایی که **decimal point** دارند، به صورت خودکار `double` استنباط می‌شوند.

---

#### مثال:

```csharp
double x1 = 1.5;    // ✅ پیش‌فرض double
double x2 = 1.5D;   // ✅ صریحاً double (زائد)
double x3 = 1D;     // ✅ اجبار integer به double
```
---

#### نکته: همیشه می‌توانید decimal point اضافه کنید

> **همیشه می‌توانید یک decimal point به یک لیترال عددی اضافه کنید:**

```csharp
double x = 4.0;  // ✅ صریحاً double با decimal point
double y = 4;    // ✅ implicit conversion از int
```
**تفاوت:**
- `4.0` → مستقیماً `double` است
- `4` → ابتدا `int` است، سپس implicit conversion به `double`

---

### 3️⃣ Suffixes **F** و **M** (مفیدترین و ضروری)

> **پسوندهای `F` و `M` مفیدترین هستند و باید همیشه** هنگام تعیین لیترال‌های `float` یا `decimal` به کار روند.

---

#### چرا `F` ضروری است؟

**بدون پسوند `F`، کد زیر کامپایل نمی‌شود:**

```csharp
// ❌ خطای کامپایل:
// float f = 4.5;
// Error CS0664: Literal of type double cannot be implicitly converted to type 'float'
```
**دلیل:**
1. لیترال `4.5` به صورت پیش‌فرض **`double`** استنباط می‌شود
2. **`double` هیچ Implicit Conversion به `float` ندارد** (چون ممکن است دقت از دست برود)
3. باید صریحاً نوع را با `F` مشخص کنید:

```csharp
// ✅ درست:
float f = 4.5F;
```
---

#### مثال‌های `float`:

```csharp
// ✅ روش‌های صحیح:
float f1 = 4.5F;
float f2 = 1.0f;      // lowercase هم مجاز است
float f3 = 3.14F;
float f4 = 1E6F;      // با exponential

// ❌ خطا:
// float f5 = 4.5;    // double به float implicit نمی‌شود

// ✅ راه حل جایگزین (explicit cast):
float f6 = (float)4.5;  // اما استفاده از F بهتر است
```
---

#### چرا `M` ضروری است؟

**همان قاعده برای `decimal` اعمال می‌شود:**

```csharp
// ❌ خطای کامپایل:
// decimal d = -1.23;
// Error CS0664: Literal of type double cannot be implicitly converted to type 'decimal'
```
**باید با پسوند `M` صریح باشید:**

```csharp
// ✅ درست:
decimal d = -1.23M;
```
---

#### مثال‌های `decimal`:

```csharp
// ✅ روش‌های صحیح:
decimal price = 19.99M;
decimal tax = 0.15m;        // lowercase
decimal total = 1234.56M;
decimal rate = 0.0001M;

// ❌ خطا:
// decimal d = 1.5;         // double به decimal implicit نمی‌شود

// ✅ راه حل جایگزین:
decimal d = (decimal)1.5;   // اما M بهتر است
```
---

## 📊 مقایسه Implicit Conversions

| از → به | Implicit؟ | دلیل |
```csharp
|---------|-----------|------|
| `int` → `long` | ✅ بله | هیچ اطلاعاتی از دست نمی‌رود |
| `int` → `double` | ✅ بله | Lossless (تا 53-bit precision) |
| `double` → `float` | ❌ خیر | ممکن است دقت از دست برود |
| `double` → `decimal` | ❌ خیر | نوع متفاوت (binary vs decimal) |
| `int` → `decimal` | ✅ بله | Lossless |
| `float` → `decimal` | ❌ خیر | نوع متفاوت |
```
---

##  مثال‌های عملی

### مثال 1: محاسبات مالی با `decimal`

```csharp
decimal accountBalance = 1000.00M;
decimal interestRate = 0.05M;          // 5%
decimal interest = accountBalance * interestRate;
decimal newBalance = accountBalance + interest;

Console.WriteLine($"Interest: ${interest}");        // $50.00
Console.WriteLine($"New Balance: ${newBalance}");   // $1050.00
```
---

### مثال 2: محاسبات علمی با `float`

```csharp
float gravity = 9.81F;              // m/s²
float mass = 10.5F;                 // kg
float force = mass * gravity;       // F = m × g

Console.WriteLine($"Force: {force} N");  // 103.005 N
```
---

### مثال 3: ترکیب انواع مختلف

```csharp
// ❌ خطا: نمی‌توان مستقیماً ترکیب کرد
// decimal price = 100.0M;
// double discount = 0.1;
// decimal finalPrice = price * discount;  // خطا!

// ✅ درست: باید تبدیل صریح انجام شود
decimal price = 100.0M;
decimal discount = 0.1M;  // یا (decimal)0.1
decimal finalPrice = price * discount;
```
---

##  Numeric Conversions (تبدیلات عددی)

> در این بخش، **semantics (معناشناسی) تبدیلات عددی** به تفصیل توضیح داده می‌شود.

---

## 🔄 Converting Between Integral Types (تبدیل بین انواع Integral)

### قانون کلی:

> تبدیلات Integral Type **زمانی implicit هستند که** نوع مقصد بتواند **هر مقدار ممکن** از نوع مبدأ را نمایش دهد.  
> در غیر این صورت، یک **explicit conversion** مورد نیاز است.

---

### مثال کلاسیک:

```csharp
int x = 12345;       // int یک integer 32-bit است
long y = x;          // ✅ Implicit conversion به integer 64-bit
short z = (short)x;  // ⚠️ Explicit conversion به integer 16-bit
```
---

### تحلیل دقیق:

#### 1️⃣ `int` → `long` (Implicit ✅)

```csharp
int x = 12345;
long y = x;  // ✅ Implicit
```

**چرا Implicit؟**
- `int`: $-2^{31}$ تا $2^{31}-1$ (32-bit)
- `long`: $-2^{63}$ تا $2^{63}-1$ (64-bit)
- **هر مقدار `int` در `long` جا می‌شود** → Lossless
- **نیازی به cast نیست**

**دیاگرام:**

int (32-bit):  [═══════════════════]
↓ همیشه جا می‌شود
long (64-bit): [══════════════════════════════════════════]

---

#### 2️⃣ `int` → `short` (Explicit )

```csharp
int x = 12345;
short z = (short)x;  // ⚠️ Explicit conversion با cast
```
**چرا Explicit؟**
- `int`: $-2^{31}$ تا $2^{31}-1$ (32-bit)
- `short`: $-2^{15}$ تا $2^{15}-1$ = $-32,768$ تا $32,767$ (16-bit)
- **نمی‌توان تضمین کرد که هر `int` در `short` جا می‌شود**
- **خطر Data Loss**

**دیاگرام:**

int (32-bit):  [══════════════════════════════]
↓ ممکن است سرریز شود
short (16-bit): [═════]

---

### ⚠️ خطر Overflow:

```csharp
int x = 100000;           // خارج از محدوده short
short z = (short)x;       // ⚠️ سرریز (overflow)!

Console.WriteLine(z);     // -31072 (مقدار اشتباه!)
```
**چرا `-31072`؟**
- `100000` در Binary: `0001 1000 0110 1010 0000` (32-bit)
- فقط 16 بیت پایین حفظ می‌شود: `1000 0110 1010 0000`
- در `short` (signed)، این `1000...` یعنی عدد منفی
- نتیجه: Wrap-around به `-31072`

---

##  جدول Implicit Conversions (Integral Types)

| از → به | Implicit؟ | دلیل |
```csharp
|---------|-----------|------|
| `sbyte` → `short`, `int`, `long` | ✅ | Lossless (8→16/32/64 bit) |
| `byte` → `short`, `ushort`, `int`, `uint`, `long`, `ulong` | ✅ | Lossless |
| `short` → `int`, `long` | ✅ | Lossless (16→32/64 bit) |
| `ushort` → `int`, `uint`, `long`, `ulong` | ✅ | Lossless |
| `int` → `long` | ✅ | Lossless (32→64 bit) |
| `uint` → `long`, `ulong` | ✅ | Lossless |
| `long` → `int` | ❌ | ممکن است Data Loss |
| `int` → `short` | ❌ | ممکن است Data Loss |
| `int` → `byte` | ❌ | ممکن است Data Loss |
```
---

##  مثال‌های بیشتر

### مثال 1: Implicit Conversions (موفق)

csharp
byte b = 100;
short s = b;        // ✅ byte → short (8→16 bit)
int i = s;          // ✅ short → int (16→32 bit)
long l = i;         // ✅ int → long (32→64 bit)

Console.WriteLine($"byte: {b}, short: {s}, int: {i}, long: {l}");
// byte: 100, short: 100, int: 100, long: 100

---

### مثال 2: Explicit Conversions (نیاز به Cast)

```csharp
long l = 1000;
int i = (int)l;     // ⚠️ long → int
short s = (short)i; // ⚠️ int → short
byte b = (byte)s;   // ⚠️ short → byte

Console.WriteLine($"long: {l}, int: {i}, short: {s}, byte: {b}");
// long: 1000, int: 1000, short: 1000, byte: 232 (overflow!)
```
**توضیح `byte: 232`:**
- `1000` در Binary: `0011 1110 1000`
- فقط 8 بیت پایین: `1110 1000` = `232`

---

### مثال 3: Checked Context (جلوگیری از Overflow)

```csharp
try
{
int x = 100000;
short z = checked((short)x);  // ✅ پرتاب Exception
}
catcowException ex)
{
Console.WriteLine("Overflow detected!");
}
```
---

##  ارتباط با مباحث دیگر

- نکته » **Numeric Types (صفحه 1):** جدول کامل انواع عددی
- نکته » **Numeric Literals (صفحه 18):** Type Inference
- نکته » **Overflow & Checked Contexts (صفحه 12):** مدیریت Overflow
- نکته » **Real Number Conversions:** ادامه در صفحات بعدی
- نکته » **Custom Conversions (صفحه 256):** Operator overloading

---

## ✅ خلاصه نکات کلیدی

### نکته » Numeric Suffixes:
1. نکته » **`F`**: ضروری برای `float` (مثل `4.5F`)
2. نکته » **`M`**: ضروری برای `decimal` (مثل `1.23M`)
3. نکته » **`D`**: اختیاری برای `double` (پیش‌فرض)
4. نکته » **`L
