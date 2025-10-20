# Predefined Type Taxonomy (C# in a Nutshell - صفحه 16)

##  طبقه‌بندی کامل انواع از پیش تعریف شده

### انواع مقداری - Value Types 

#### 1️⃣ Numeric Types (اعداد)

##### الف) Signed Integer (اعداد صحیح علامت‌دار):
```csharp
sbyte   // System.SByte   (-128 to 127)
short   // System.Int16   (-32,768 to 32,767)
int     // System.Int32   (-2,147,483,648 to 2,147,483,647)
long    // System.Int64   (-9,223,372,036,854,775,808 to ...)
```
##### ب) Unsigned Integer (اعداد صحیح بدون علامت):
```csharp
byte    // System.Byte    (0 to 255)
ushort  // System.UInt16  (0 to 65,535)
uint    // System.UInt32  (0 to 4,294,967,295)
ulong   // System.UInt64  (0 to 18,446,744,073,709,551,615)
```
##### ج) Real Number (اعداد حقیقی):
```csharp
float   // System.Single   (±1.5 × 10^−45 to ±3.4 × 10^38)
double  // System.Double   (±5.0 × 10^−324 to ±1.7 × 10^308)
decimal // System.Decimal  (±1.0 × 10^−28 to ±7.9 × 10^28)
```
---

#### 2️⃣ Logical Type (منطقی):
```csharp
bool    // System.Boolean (true or false)
```
---

#### 3️⃣ Character Type (کاراکتر):
```csharp
char    // System.Char (U+0000 to U+FFFF)
```
---

### 🔶 Reference Types (انواع مرجع)

#### 1️⃣ String (رشته):
```csharp
string  // System.String
```
#### 2️⃣ Object (شیء):
```csharp
object  // System.Object
```
---

##  ارتباط با .NET Framework

### قانون Aliasing:
> **تمام** انواع از پیش تعریف شده در C# فقط **alias** (نام مستعار) برای typeهای .NET در namespace `System` هستند.

### مثال معادل‌سازی:

```csharp
// این دو خط کاملاً یکسان هستند:
int i = 5;
System.Int32 i = 5;

// تفاوت فقط سینتکسی است، نه معنایی!
```
---

##  جدول کامل Aliases
```csharp
| C# Keyword | .NET Type | دسته |
|------------|-----------|------|
| `sbyte` | `System.SByte` | Signed Integer |
| `byte` | `System.Byte` | Unsigned Integer |
| `short` | `System.Int16` | Signed Integer |
| `ushort` | `System.UInt16` | Unsigned Integer |
| `int` | `System.Int32` | Signed Integer |
| `uint` | `System.UInt32` | Unsigned Integer |
| `long` | `System.Int64` | Signed Integer |
| `ulong` | `System.UInt64` | Unsigned Integer |
| `float` | `System.Single` | Real Number |
| `double` | `System.Double` | Real Number |
| `decimal` | `System.Decimal` | Real Number |
| `bool` | `System.Boolean` | Logical |
| `char` | `System.Char` | Character |
| `string` | `System.String` | Reference |
| `object` | `System.Object` | Reference |
```
---

##  Primitive Types در CLR

### تعریف:
> تایپ های  **Primitive types** شامل همه value types از پیش تعریف شده **به جز `decimal`** هستند.

### لیست Primitive Types:
```csharp
// ✅ Primitive:
sbyte, byte, short, ushort, int, uint, long, ulong
float, double
bool
char

// ❌ NOT Primitive:
decimal
```
---

### 🔍 چرا Primitive؟

> **دلیل:** این typeها **مستقیماً** توسط دستورالعمل‌های (instructions) کد کامپایل شده پشتیبانی می‌شوند.

#### معنی:
1. **کامپایلر** کد بهینه تولید می‌کند
2. **پردازنده** معمولاً پشتیبانی سخت‌افزاری دارد
3. **عملیات** بسیار سریع هستند

---

## 💻 نمایش داخلی (Hexadecimal Representation)

### مثال‌های Primitive Encoding:

```csharp
// Integer (ذخیره مستقیم):
int i = 7;
// نمایش داخلی: 0x00000007

// Boolean (1 بیت منطقی، 1 بایت واقعی):
bool b = true;
// نمایش داخلی: 0x01

// Character (Unicode UTF-16):
char c = 'A';
// نمایش داخلی: 0x0041

// Float (IEEE 754 single-precision):
float f = 0.5f;
// نمایش داخلی: 0x3F000000
// (استفاده از IEEE floating-point encoding)

```
---

###  جزئیات Encoding

#### 1️⃣ Integer Types:
```csharp
int x = 255;
// Binary:      11111111
// Hex:         0xFF
// Memory:      FF 00 00 00 (little-endian)
```
---

#### 2️⃣ Boolean:
```csharp
bool flag = true;
// Internal:    0x01 (1 byte)
// false:       0x00
```
**نکته:** منطقاً فقط 1 بیت کافی است، اما CLR 1 بایت اختصاص می‌دهد (به دلیل Memory Alignment).

---

#### 3️⃣ Character (Unicode):
```csharp
char letter = 'A';
// Unicode:     U+0041
// Hex:         0x0041
// Memory:      41 00 (little-endian UTF-16)
```
```csharp
char persian = 'س';
// Unicode:     U+0633
// Hex:         0x0633
// Memory:      33 06
```
---

#### 4️⃣ Float (IEEE 754):
```csharp
float half = 0.5f;
// IEEE Format: Sign (1 bit) | Exponent (8 bits) | Mantissa (23 bits)
//              0              01111110            00000000000000000000000
// Hex:         0x3F000000
```
**فرمول IEEE 754:**
$$ \text{value} = (-1)^{\text{sign}} \times 2^{(\text{exponent} - 127)} \times (1 + \text{mantissa}) $$

**محاسبه برای 0.5:**
$$ 0.5 = (-1)^0 \times 2^{(126-127)} \times (1 + 0) = 1 \times 2^{-1} \times 1 = 0.5 $$

---

##  مثال‌های کامل

### مثال 1: Integer Encoding
```csharp
int num = 42;
// Decimal:     42
// Binary:      00101010
// Hex:         0x0000002A
// Memory (LE): 2A 00 00 00
```
---

### مثال 2: Multi-byte Character
```csharp
char emoji = '😀';  // ⚠️ خطا! char فقط 16-bit است
// برای emoji از string استفاده کنید:
string emoji = "😀";  // ✅
```
---

### مثال 3: Float vs Double
```csharp
float f = 1.23f;
// Hex: 0x3F9D70A4 (4 bytes)

double d = 1.23;
// Hex: 0x3FF3AE147AE147AE (8 bytes)
```
---

##  Primitive Types 

### System.IntPtr و System.UIntPtr:

> **فصل 24:** این دو نوع نیز **Primitive** هستند.

```csharp
IntPtr ptr;   // اندازه بسته به معماری (4 یا 8 بایت)
UIntPtr uptr; // مشابه اما بدون علامت
```
#### کاربرد:
- **Interop:** ارتباط با کدهای Native (C/C++)
- **Unsafe Code:** کار با pointerها
- **Platform-specific:** اندازه بسته به 32-bit یا 64-bit

```csharp
// در 32-bit:
IntPtr p;  // 4 bytes (مانند int)

// در 64-bit:
IntPtr p;  // 8 bytes (مانند long)
```
---

##  طبقه‌بندی نهایی

```csharp
C# Predefined Types
│
├── Value Types
│   ├── Numeric
│   │   ├── Signed Integer (sbyte, short, int, long) ✅ Primitive
│   │   ├── Unsigned Integer (byte, ushort, uint, ulong) ✅ Primitive
│   │   └── Real Number (float, double, decimal)
│   │       ├── float ✅ Primitive
│   │       ├── double ✅ Primitive
│   │       └── decimal ❌ NOT Primitive
│   ├── Logical (bool) ✅ Primitive
│   └── Character (char) ✅ Primitive
│
└── Reference Types
├── string (System.String) ❌ NOT Primitive
└── object (System.Object) ❌ NOT Primitive
```
---

##  نکات کلیدی

### 1️⃣ Alias:
✅ کلمات کلیدی سی شارپ C# keywords فقط **نام مستعار** برای `System.XXX` هستند  
✅ هیچ تفاوت عملکردی ندارند  
✅ می‌توانید از هر دو استفاده کنید (اما C# keyword معمول‌تر است)

### 2️⃣ Primitive:
✅ همه value types **جز `decimal`**  
✅ پشتیبانی مستقیم پردازنده  
✅ عملیات سریع‌تر  
✅ نکته » `IntPtr` و `UIntPtr` نیز Primitive هستند (فصل 24)

### 3️⃣ Encoding:
✅ نکته »  Integer: نمایش مستقیم Hexadecimal  
✅ نکته » Boolean: `0x01` (true) یا `0x00` (false)  
✅ نکته »  Char: UTF-16 Unicode  
✅ نکته »  Float/Double: IEEE 754 floating-point

##  مثال جامع

```csharp
using System;

class TypeDemo
{
static void Main()
{
// Aliases (معادل):
int x = 10;
Int32 y = 10;
Console.WriteLine(x == y);  // True

// Primitive Encoding:
int i = 7;       // 0x00000007
bool b = true;   // 0x01
char c = 'A';    // 0x0041
float f = 0.5f;  // 0x3F000000

// NOT Primitive:
decimal m = 1.5m;  // استفاده از software encoding

// Reference Types:
string s = "Hello";
object o = new object();
}
}
```
