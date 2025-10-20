# Numeric Literals

## 🔢 Integral-Type Literals

### انواع نمایش (Notations)

> لیترال‌های نوع Integral می‌توانند از **نمایش دهدهی (decimal)** یا **نمایش شانزده‌دهی (hexadecimal)** استفاده کنند.

---

### 1️⃣ Decimal Notation (پایه 10):
```csharp
int x = 127;        // دهدهی معمولی
long y = 1000;      // دهدهی
```
---

### 2️⃣ Hexadecimal Notation (پایه 16):

> نکته » **Hexadecimal** با پیشوند **`0x`** مشخص می‌شود.

```csharp
int x = 127;        // Decimal: 127
long y = 0x7F;      // Hexadecimal: 127 (معادل)

// مثال‌های بیشتر:
int color = 0xFF00FF;      // RGB: Magenta
byte flags = 0xA5;         // 10100101 (binary)
uint address = 0xDEADBEEF; // آدرس حافظه معروف!
```
---

### 3️⃣ Binary Notation (پایه 2):

> با پیشوند **`0b`** می‌توانید اعداد را به صورت **باینری** مشخص کنید.

```csharp
var b = 0b1010_1011_1100_1101_1110_1111;

// مثال‌های واقعی:
byte permissions = 0b0000_0111;  // rwx (read, write, execute)
int mask = 0b1111_0000;          // Bit masking
ushort flags = 0b0001_0010_0100_1000;
```
#### کاربرد Binary:
```csharp
// Bit flags:
enum FileAccess
{
Read    = 0b0001,  // 1
Write   = 0b0010,  // 2
Execute = 0b0100,  // 4
Delete  = 0b1000   // 8
}

FileAccess access = FileAccess.Read | FileAccess.Write;
// 0b0001 | 0b0010 = 0b0011
```
---

### 4️⃣ Underscore Separator (خوانایی):

> می‌توانید **underscore (`_`)** را در **هر جایی** داخل یک لیترال عددی قرار دهید تا آن را **خواناتر** کنید.

```csharp
int million = 1_000_000;           // خواناتر از 1000000
long trillion = 1_000_000_000_000L;

// با Hexadecimal:
uint color = 0xFF_00_FF;           // RGB format
int memAddr = 0xDEAD_BEEF;

// با Binary:
byte b = 0b1010_1011;              // گروه‌بندی 4-bit
int mask = 0b1111_0000_1111_0000;  // pattern واضح‌تر
```
#### ⚠️ نکات مهم:
```csharp
// ✅ معتبر:
int x = 1_000;
int y = 0x_FF;
int z = 0b_1010;
int w = 1_2_3_4;

// ❌ نامعتبر:
// int a = _1000;      // خطا: نمی‌توان از ابتدا شروع کرد
// int b = 1000_;      // خطا: نمی‌توان در انتها قرار داد
// int c = 0_x1F;      // خطا: بین 0 و x
```
---

##  Real Literals (اعداد حقیقی)

### انواع نمایش:

> لیترال‌های Real می‌توانند از **نمایش دهدهی** و/یا **نمایش نمایی (exponential)** استفاده کنند.

---

### 1️⃣ Decimal Notation:

```csharp
double d = 1.5;
double pi = 3.14159;
double precise = 0.0001;
```
---

### 2️⃣ Exponential Notation (علمی):

> از **`E`** یا **`e`** برای نمایش نمایی استفاده می‌شود.

**فرمت:** $\text{coefficient} \times 10^{\text{exponent}}$

```csharp
double million = 1E06;    // 1 × 10^6 = 1,000,000
double million2 = 1e6;    // کوچک یا بزرگ بودن 'e' مهم نیست

// مثال‌های بیشتر:
double speedOfLight = 2.998E8;        // 299,800,000 m/s
double electronMass = 9.109E-31;      // 0.0000...0009109 kg
double avogadro = 6.022E23;           // 602,200,000,000,000,000,000,000
double planck = 6.626E-34;            // 0.0000...0006626
```
---

### 3️⃣ ترکیب Decimal و Exponential:

```csharp
double d1 = 1.5E3;        // 1.5 × 10^3 = 1500
double d2 = 3.14E-2;      // 3.14 × 10^-2 = 0.0314
double d3 = 2.5E+5;       // 2.5 × 10^5 = 250,000
```
---

##  Numeric Literal Type Inference (استنباط نوع)

### قوانین پیش‌فرض کامپایلر

> به طور پیش‌فرض، کامپایلر یک لیترال عددی را **یا `double` یا یک نوع Integral** استنباط می‌کند.

---

### قانون 1️⃣: اگر Decimal Point یا `E` داشته باشد → `double`

**شرط:** لیترال شامل **نقطه اعشاری (`.`)** یا **نماد نمایی (`E`)** باشد.

```csharp
Console.WriteLine(1.0.GetType());     // Double (double) ✅
Console.WriteLine(1E06.GetType());    // Double (double) ✅
Console.WriteLine(3.14.GetType());    // Double (double)
Console.WriteLine(2E-5.GetType());    // Double (double)
```
---

### قانون 2️⃣: در غیر این صورت → اولین نوع مناسب از لیست

**لیست به ترتیب:**
1. `int`
2. `uint`
3. `long`
4. `ulong`

**اولین نوعی که مقدار لیترال در آن جا می‌شود، انتخاب می‌شود.**

---

### مثال‌های Type Inference:

```csharp
Console.WriteLine(1.GetType());              // Int32 (int) ✅
Console.WriteLine(0xF0000000.GetType());     // UInt32 (uint) ✅
Console.WriteLine(0x100000000.GetType());    // Int64 (long) ✅
```
---

###  تحلیل دقیق هر مثال:

#### مثال 1: `1`
```csharp
Console.WriteLine(1.GetType());  // Int32 (int)
```
- مقدار: `1`
- بررسی:
  - آیا در `int` جا می‌شود؟ **بله** ($-2^{31}$ تا $2^{31}-1$)
- **نتیجه:** `int`

---

#### مثال 2: `0xF0000000`
```csharp
Console.WriteLine(0xF0000000.GetType());  // UInt32 (uint)
```
- مقدار Hexadecimal: `0xF0000000`
- مقدار Decimal: `4,026,531,840`
- بررسی:
  - آیا در `int` جا می‌شود? **خیر** (بیشتر از $2^{31}-1 = 2,147,483,647$)
  - آیا در `uint` جا می‌شود? **بله** ($0$ تا $2^{32}-1 = 4,294,967,295$)
- **نتیجه:** `uint`

---

#### مثال 3: `0x100000000`
```csharp
Console.WriteLine(0x100000000.GetType());  // Int64 (long)
```
- مقدار Hexadecimal: `0x100000000`
- مقدار Decimal: `4,294,967,296`
- بررسی:
  - آیا در `int` جا می‌شود? **خیر**
  - آیا در `uint` جا می‌شود? **خیر** (بیشتر از $2^{32}-1 = 4,294,967,295$)
  - آیا در `long` جا می‌شود? **بله** ($-2^{63}$ تا $2^{63}-1$)
- **نتیجه:** `long`

---

##  جدول کامل Type Inference

| لیترال | مقدار (Decimal) | Type استنباط شده | دلیل |
```charp
|--------|-----------------|-------------------|------|
| `1` | 1 | `int` | جا می‌شود در `int` |
| `1.0` | 1.0 | `double` | دارای `.` است |
| `1E06` | 1,000,000 | `double` | دارای `E` است |
| `0x7F` | 127 | `int` | جا می‌شود در `int` |
| `0xF0000000` | 4,026,531,840 | `uint` | خارج از `int`، داخل `uint` |
| `0x100000000` | 4,294,967,296 | `long` | خارج از `uint`، داخل `long` |
| `0x10000000000000000` | خیلی بزرگ | `ulong` | خارج از `long`، داخل `ulong` |
```
---

##  Literal Suffixes (پسوندها)

### اجبار کامپایلر برای نوع خاص:

```csharp
// Long:
long x = 127L;           // صریحاً long
long y = 0x7FL;

// Unsigned:
uint a = 100U;
ulong b = 100UL;         // یا LU

// Float:
float f = 1.5F;
float g = 1E6F;

// Decimal:
decimal d = 1.5M;
decimal price = 19.99m;
```
---

### جدول کامل Suffixes:
```csharp
| Suffix | نوع | مثال |
|--------|-----|------|
| `L` یا `l` | `long` | `100L` |
| `U` یا `u` | `uint` | `100U` |
| `UL` یا `ul` یا `LU` یا `lu` | `ulong` | `100UL` |
| `F` یا `f` | `float` | `1.5F` |
| `D` یا `d` | `double` | `1.5D` (اختیاری) |
| `M` یا `m` | `decimal` | `1.5M` |
```
---

##  مثال‌های عملی

### مثال 1: Binary Flags
```csharp
[Flags]
enum Permissions
{
None    = 0b0000_0000,  // 0
Read    = 0b0000_0001,  // 1
Write   = 0b0000_0010,  // 2
Execute = 0b0000_0100,  // 4
Delete  = 0b0000_1000,  // 8
All     = 0b0000_1111   // 15
}

Permissions userPerms = Permissions.Read | Permissions.Write;
// 0b0000_0011 = 3
```
---

### مثال 2: Color Values
```csharp
uint red   = 0xFF_00_00;  // RGB: (255, 0, 0)
uint green = 0x00_FF_00;  // RGB: (0, 255, 0)
uint blue  = 0x00_00_FF;  // RGB: (0, 0, 255)
uint white = 0xFF_FF_FF;  // RGB: (255, 255, 255)

// با alpha channel:
uint semiTransparent = 0x80_FF_00_00;  // ARGB
```
---

### مثال 3: Scientific Constants
```csharp
const double SpeedOfLight = 2.998E8;        // m/s
const double GravityEarth = 9.81;           // m/s²
const double PlanckConstant = 6.626E-34;    // J⋅s
const double AvogadroNumber = 6.022E23;     // mol⁻¹

// محاسبه انرژی:
double mass = 1.0;  // kg
double energy = mass * SpeedOfLight * SpeedOfLight;
// E = mc²
```
---

### مثال 4: Financial Data
```csharp
decimal accountBalance = 1_234_567.89M;
decimal interestRate = 0.05M;              // 5%
decimal monthlyPayment = 1_500.00M;

decimal interest = accountBalance * interestRate;
decimal newBalance = accountBalance + interest - monthlyPayment;
```
---

##  نکات پیشرفته

### 1️⃣ پیاده‌سازی داخلی (Compiler Implementation):

```csharp
// این دو یکسان هستند:
int x = 0xFF;
int y = 255;

// در IL (Intermediate Language) هر دو به:
ldc.i4 255  // Load Constant Int32
```
---

### 2️⃣ حواس‌پرتی‌های رایج:

```csharp
// ❌ خطا: نمی‌تواند double را بدون cast به int تبدیل کند
// int x = 1.0;  // Compilation Error

// ✅ درست:
int x = (int)1.0;
double d = 1.0;
```
---

### 3️⃣ Overflow در Literals:

```csharp
// ⚠️ خطا در Compile Time:
// int x = 999999999999;  // خارج از محدوده int

// ✅ راه حل:
long x = 999999999999L;
```
---

##  یادداشت فوت‌نوت (Footnote)

> **یادداشت فنی شماره 2:**  
> از نظر فنی، **`decimal`** نیز یک نوع floating-point است، اگرچه در **C# Language Specification** به این نام اشاره نمی‌شود.

### توضیح:
- نکته » **`float`** و **`double`**: IEEE 754 Binary Floating-Point
- نکته » **`decimal`**: IEEE 754-2008 Decimal Floating-Point (128-bit)

```csharp
// هر سه "floating-point" هستند اما متفاوت:
float f = 1.5F;      // Binary, 32-bit
double d = 1.5;      // Binary, 64-bit
decimal m = 1.5M;    // Decimal, 128-bit
```
---

##  خلاصه نکات کلیدی

### نکته » ✅ Integral Literals:
- نکته » **Decimal:** `127`
- نکته » **Hexadecimal:** `0x7F` (پیشوند `0x`)
- نکته » **Binary:** `0b1010` (پیشوند `0b`)
- نکته » **Separator:** `1_000_000` (underscore برای خوانایی)

### نکته » ✅ Real Literals:
- نکته » **Decimal:** `1.5`
- نکته » **Exponential:** `1E06` ($1 \times 10^6$)

### نکته » ✅ Type Inference:
1. **دارای `.` یا `E`** → `double`
2. **بدون `.` یا `E`** → اولین نوع مناسب: `int` → `uint` → `long` → `ulong`

### نکته » ✅ Suffixes (اجباری کردن نوع):
- نکته » `L`: `long`
- نکته » `U`: `uint`
- نکته » `UL`: `ulong`
- نکته » `F`: `float`
- نکته » `M`: `decimal`

