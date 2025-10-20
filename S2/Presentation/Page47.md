# Numeric Types 

## 📊 جدول کامل انواع عددی از پیش تعریف شده

### Table 2-1: Predefined Numeric Types in C#

```csharp

| C# Type | System Type | Suffix | Size | Range |
|---------|-------------|--------|------|-------|
| **Integral—Signed** |||||
| `sbyte` | `SByte` | - | 8 bits | $-2^7$ to $2^7-1$ (-128 to 127) |
| `short` | `Int16` | - | 16 bits | $-2^{15}$ to $2^{15}-1$ (-32,768 to 32,767) |
| `int` | `Int32` | - | 32 bits | $-2^{31}$ to $2^{31}-1$ (-2,147,483,648 to 2,147,483,647) |
| `long` | `Int64` | `L` | 64 bits | $-2^{63}$ to $2^{63}-1$ |
| `nint` | `IntPtr` | - | 32/64 bits | Platform-dependent |
| **Integral—Unsigned** |||||
| `byte` | `Byte` | - | 8 bits | $0$ to $2^8-1$ (0 to 255) |
| `ushort` | `UInt16` | - | 16 bits | $0$ to $2^{16}-1$ (0 to 65,535) |
| `uint` | `UInt32` | `U` | 32 bits | $0$ to $2^{32}-1$ (0 to 4,294,967,295) |
| `ulong` | `UInt64` | `UL` | 64 bits | $0$ to $2^{64}-1$ |
| `nuint` | `UIntPtr` | - | 32/64 bits | Platform-dependent |
| **Real** |||||
| `float` | `Single` | `F` | 32 bits | $\pm$ (~$10^{-45}$ to $10^{38}$) |
| `double` | `Double` | `D` | 64 bits | $\pm$ (~$10^{-324}$ to $10^{308}$) |
| `decimal` | `Decimal` | `M` | 128 bits | $\pm$ (~$10^{-28}$ to $10^{28}$) |
```
---

##  First-Class Citizens: `int` و `long`

### چرا `int` و `long` ترجیح داده می‌شوند؟

> از میان انواع Integral، **`int` و `long`** شهروندان درجه یک (first-class citizens) هستند و هم توسط **C#** و هم توسط **runtime** مورد علاقه قرار می‌گیرند.

#### دلایل:
1. **پشتیبانی مستقیم پردازنده:** بیشتر CPUها برای 32-bit (`int`) و 64-bit (`long`) بهینه شده‌اند
2. **عملیات سریع‌تر:** دستورالعمل‌های native processor
3. **استاندارد در API:** اکثر متدهای .NET از `int` استفاده می‌کنند
4. **Default choice:** برای اکثر محاسبات عددی
```csharp
// ✅ Preferred:
int count = 100;
long population = 7_800_000_000L;

// ⚠️ کمتر استفاده می‌شود (مگر در موارد خاص):
short age = 25;
byte flags = 0xFF;
```
---

##  کاربردهای Integral Types دیگر

### انواع غیر `int`/`long` معمولاً برای چه استفاده می‌شوند؟

#### 1️⃣ Interoperability (تعامل‌پذیری):
```csharp
// Win32 API (معمولاً از byte/short استفاده می‌کند):
[DllImport("user32.dll")]
static extern short GetAsyncKeyState(int vKey);

// C/C++ struct mapping:
struct NativeHeader
{
public byte Version;    // 1 byte
public ushort Length;   // 2 bytes
public uint Flags;      // 4 bytes
}
```
---

#### 2️⃣ Space Efficiency (بهینه‌سازی حافظه):
```csharp
// مثال: میلیون‌ها رکورد در حافظه
struct CompactData
{
public byte Age;        // 0-255 کافی است
public ushort ZipCode;  // 0-65535
public sbyte Temperature; // -128 تا 127
}
// اشغال حافظه: 4 bytes
// در مقابل int: 12 bytes (3x بیشتر!)

CompactData[] hugeArray = new CompactData[10_000_000];
// صرفه‌جویی: 80 MB
```
---

##  Native-Sized Integers: `nint` و `nuint`

### تعریف:
> **`nint`** و **`nuint`** اعداد صحیح با اندازه بومی (native-sized) هستند که برای کار با **pointerها** بسیار مفید‌اند.

### جزئیات بیشتر:
 **صفحه 266:** "Native-Sized Integers"

### ویژگی‌های کلیدی:
```csharp
// اندازه بسته به معماری:
// 32-bit platform: 4 bytes
// 64-bit platform: 8 bytes

nint pointer;    // Platform-dependent signed
nuint address;   // Platform-dependent unsigned
```
#### کاربرد اصلی:
```csharp
// کار با Pointers:
unsafe
{
int* ptr = stackalloc int[100];
nint offset = (nint)ptr;  // نگهداری آدرس حافظه
}

// Interop با Native Code:
[DllImport("kernel32.dll")]
static extern nint VirtualAlloc(nint lpAddress, nuint dwSize, uint flAllocationType, uint flProtect);
```
---

##  Floating-Point Types: `float` و `double`

### تعریف:
> نکته » **`float`** و **`double`** را **floating-point types** می‌نامند.

### کاربرد معمول:

#### 1️⃣ Scientific Calculations (محاسبات علمی):
```csharp
// فیزیک:
double speedOfLight = 299_792_458.0; // m/s
double gravitationalConstant = 6.67430e-11; // N⋅m²/kg²

// شیمی:
float avogadroNumber = 6.022e23f; // mol⁻¹
```
---

#### 2️⃣ Graphical Calculations (محاسبات گرافیکی):
```csharp
// 3D Graphics:
float positionX = 123.456f;
float positionY = 789.012f;
float rotation = 45.0f;

// Shader calculations:
double[] transformMatrix = new double[16];
```
---

### ⚠️ دقت در Floating-Point:

```csharp
// مشکل دقت:
double x = 0.1 + 0.2;
Console.WriteLine(x);  // 0.30000000000000004 (!)

// برای مقایسه:
const double epsilon = 1e-10;
bool isEqual = Math.Abs(x - 0.3) < epsilon;  // ✅ درست
```
---

##  Decimal Type: محاسبات مالی

### چرا `decimal` برای مالی؟

> نوع **`decimal`** معمولاً برای **محاسبات مالی** استفاده می‌شود که در آن:
> 1. **Base-10 accurate arithmetic** (دقت پایه-۱۰)
> 2. **High precision** (دقت بالا)
> مورد نیاز است.

---

### مقایسه: `double` vs `decimal`

#### ❌ مشکل با `double`:
```csharp
double price = 0.1;
double total = price + price + price;  // 0.1 + 0.1 + 0.1
Console.WriteLine(total);  // 0.30000000000000004 ⚠️ خطا!

// در محاسبات مالی فاجعه است:
double money = 0.1 + 0.2;
if (money == 0.3)  // ❌ False!
Console.WriteLine("Equal");
```
---

#### ✅ راه حل با `decimal`:
```csharp
decimal price = 0.1m;
decimal total = price + price + price;
Console.WriteLine(total);  // 0.3 ✅ دقیق!

// محاسبات بانکی:
decimal accountBalance = 1234.56m;
decimal interest = accountBalance * 0.05m;  // دقیق
decimal newBalance = accountBalance + interest;
```
---

### مثال واقعی مالی:
```csharp
class BankAccount
{
private decimal balance;

public void Deposit(decimal amount)
{
balance += amount;  // دقت کامل
}

public void CalculateInterest(decimal rate)
{
// محاسبه سود:
decimal interest = balance * rate;
balance += interest;
// هیچ خطای گرد کردنی وجود ندارد!
}
}

// استفاده:
var account = new BankAccount();
account.Deposit(100.01m);
account.CalculateInterest(0.05m);  // 5% interest
```
---

##  Specialized Numeric Types (.NET)

### انواع تخصصی اضافی در .NET:

#### 1️⃣ `Int128` و `UInt128` (اعداد 128-bit):
```csharp
using System.Numerics;

Int128 veryLargeNumber = Int128.MaxValue;
// Range: -2^127 to 2^127-1

UInt128 unsignedLarge = UInt128.MaxValue;
// Range: 0 to 2^128-1
```
**کاربرد:** Cryptography، محاسبات علمی با اعداد بسیار بزرگ

---

#### 2️⃣ `BigInteger` (اعداد با اندازه دلخواه):
```csharp
using System.Numerics;

BigInteger factorial = 1;
for (int i = 1; i <= 100; i++)
{
factorial *= i;
}
Console.WriteLine(factorial);  
// 93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864000000000000000000000000

// هیچ محدودیتی در اندازه!
BigInteger huge = BigInteger.Parse("123456789012345678901234567890");
```
**کاربرد:** Cryptography (RSA)، Combinatorics، Symbolic Math

---

#### 3️⃣ `Half` (16-bit floating-point):
```csharp
using System;

Half smallFloat = (Half)3.14;
// Size: 16 bits (2 bytes)
// Range: ±65504 (approximate)
// Precision: ~3-4 decimal digits
```
---

### ⚠️ محدودیت‌های `Half`:

> نکته » **`Half`** عمدتاً برای **تعامل با پردازنده‌های کارت گرافیک** (GPU) طراحی شده و **پشتیبانی بومی (native)** در اکثر CPUها ندارد.

#### نتیجه:
```csharp
// ❌ برای استفاده عمومی:
Half x = (Half)1.5;  // کند (emulated)

// ✅ برای استفاده عمومی:
float x = 1.5f;      // سریع (native CPU support)
double y = 1.5;      // سریع (native CPU support)
```
---

#### کاربرد صحیح `Half`:
```csharp
// GPU Shader Interop:
Half[] vertexData = new Half[1000];  // صرفه‌جویی حافظه GPU

// Machine Learning (Neural Networks):
Half[] weights = LoadWeights();  // کاهش مصرف حافظه
```
---

## 📋 خلاصه انتخاب Type

### راهنمای سریع:

```csharp
//  First Choice (استفاده عمومی):
int count = 42;
long bigCount = 10_000_000_000L;

//  Financial (مالی):
decimal price = 19.99m;

//  Scientific/Graphics (علمی/گرافیکی):
double distance = 384_400.0;  // km to moon
float speed = 343.2f;         // m/s sound speed

//  Space-Critical (بهینه‌سازی حافظه):
byte age = 25;
ushort port = 8080;

//  Interop/Pointers:
nint memoryAddress;

//  Specialized:
BigInteger factorial;     // اعداد خیلی بزرگ
Int128 cryptoKey;        // 128-bit integers
Half gpuData;            // GPU interop
```
---

##  نکات کلیدی

### نکته » 1️⃣ Integral Types:
✅ نکته » `int` و `long` = **first-class citizens**  
✅ انواع دیگر = interop یا space efficiency  
✅ نکته » `nint`/`nuint` = کار با pointers (صفحه 266)

### نکته » 2️⃣ Real Types:
✅ نکته » `float`/`double` = **floating-point** (علمی/گرافیکی)  
✅ نکته » `decimal` = **base-10 accurate** (مالی)  
⚠️ نکته » `double` برای پول استفاده نکنید!

### نکته » 3️⃣ Specialized Types:
✅ نکته » `BigInteger` = اعداد بی‌نهایت بزرگ  
✅ نکته » `Int128`/`UInt128` = 128-bit integers  
⚠️ نکته » `Half` = فقط برای GPU (نه استفاده عمومی)

