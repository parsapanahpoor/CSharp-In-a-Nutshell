# Value Types vs Reference Types 

##  طبقه‌بندی کلی Types در C#

تمام typeهای C# به **4 دسته** تقسیم می‌شوند:
```csharp
// 1. Value Types
int x = 5;
struct Point { }

// 2. Reference Types
string s = "Hello";
class MyClass { }

// 3. Generic Type Parameters
T GenericMethod<T>() { }

// 4. Pointer Types (unsafe context)
unsafe { int* ptr; }

```

##  Value Types (انواع مقداری)

### تعریف اساسی
> **محتوای** یک متغیر value type، **خود مقدار** است، نه مرجع به آن.

###  ذخیره‌سازی در حافظه

```csharp
int x = 32;  // مستقیماً 32 بیت داده در حافظه ذخیره می‌شود
```
**نکته حیاتی:**
- متغیر **خود داده** را نگه می‌دارد
- **نه** آدرس داده را (برخلاف Reference Types)


##  تعریف Custom Value Type با `struct`

### سینتکس کامل:
```csharp
public struct Point 
{ 
public int X; 
public int Y; 
}
```
### سینتکس فشرده (Terse):
```csharp
public struct Point 
{ 
public int X, Y;  // تعریف همزمان چند field
}
```
**⚠️ توجه:**
- هر دو سینتکس معادل هستند
- سینتکس فشرده فقط برای **fieldهای هم‌نوع** کار می‌کند

--------------------------------------

##  رفتار Copy در Value Types

### قانون طلایی:
> معنی = **Assignment** یک value type همیشه **کپی** ایجاد می‌کند، نه مرجع مشترک!

### مثال کامل:
```csharp
Point p1 = new Point();  // ایجاد نمونه اول
p1.X = 7;                // تنظیم مقدار

Point p2 = p1;           // ✅ کپی کامل محتوا (نه مرجع)

Console.WriteLine(p1.X); // خروجی: 7
Console.WriteLine(p2.X); // خروجی: 7

p2.X = 10;               // تغییر p2

Console.WriteLine(p1.X); // خروجی: 7  (تغییر نکرده!)
Console.WriteLine(p2.X); // خروجی: 10

```

## 🧠 تحلیل عمیق Copy Semantics

### مکانیزم حافظه:


قبل از Assignment:
┌─────────┐
│ p1      │
│ X: 7    │
│ Y: 0    │
└─────────┘

بعد از p2 = p1:
┌─────────┐       ┌─────────┐
│ p1      │       │ p2      │
│ X: 7    │  ═══> │ X: 7    │  (کپی مستقل)
│ Y: 0    │       │ Y: 0    │
└─────────┘       └─────────┘
↑                 ↑
 آدرس A           آدرس B (متفاوت!)

**نکات کلیدی:**
1. متغیر های `p1` و `p2` در **آدرس‌های مختلف** حافظه هستند
2. تغییر یکی بر دیگری تأثیر ندارد
3. هر کدام **مالک مستقل** داده‌های خود هستند

---

##  استفاده از `new` با Value Types

### مثال صفحه:
```csharp
Point p1 = new Point();
```
### ⚠️ نکته پیشرفته:
**کلمه ی  `new` برای value types اختیاری است!**

```csharp
// روش 1: با new (صریح)
Point p1 = new Point();  // همه fieldها = 0
// روش 2: بدون new
Point p2;
p2.X = 5;
p2.Y = 10;
```
// ⚠️ باید قبل از استفاده، همه fieldها مقداردهی شوند

**تفاوت:**
- **با `new`**: تمام fieldها خودکار صفر می‌شوند
- **بدون `new`**: باید **دستی** همه fieldها را مقداردهی کنید (وگرنه خطای کامپایل)

---

##  Built-in Value Types

### دسته‌بندی کامل:

#### 1️⃣ Numeric Types
```csharp
// Integral
sbyte, byte          // 8-bit
short, ushort        // 16-bit
int, uint            // 32-bit ✅ (مثال صفحه)
long, ulong          // 64-bit

// Floating-point
float                // 32-bit
double               // 64-bit
decimal              // 128-bit (مالی)
```
#### 2️⃣ Boolean
```csharp
bool flag = true;    // 1 بیت (عملاً 1 بایت)
```
#### 3️⃣ Character
```csharp
char c = 'A';        // 16-bit Unicode
```
#### 4️⃣ Structs
```csharp
DateTime             // تاریخ/زمان
TimeSpan             // بازه زمانی
Guid                 // شناسه یکتا
Nullable<T>          // Nullable value types
```
// ... و بسیاری دیگر

#### 5️⃣ Enums
csharp
enum Color { Red, Green, Blue }

#### 6️⃣ Tuples (C# 7+)
```csharp
(int, string) tuple = (1, "test");
```
---

##  مقایسه مقدماتی با Reference Types

| ویژگی | Value Type | Reference Type |
|-------|-----------|----------------|
| **ذخیره‌سازی** | خود داده | آدرس داده |
| **تعریف** | `struct` | `class` |
| **Copy** | کپی کامل | کپی مرجع |
| **`null`** | ❌ (الا Nullable) | ✅ |
| **Performance** | سریع‌تر (Stack) | کمی کندتر (Heap) |
| **مثال Built-in** | `int` | `string` |

---

##  مثال مقایسه‌ای

### Value Type (Copy):
```csharp
int a = 5;
int b = a;   // کپی مقدار
b = 10;
Console.WriteLine(a);  // 5 (تغییر نکرده)
```
### Reference Type (مثال پیش‌نگر):
```csharp
var arr1 = new int[] { 5 };
var arr2 = arr1;  // کپی مرجع (نه محتوا)
arr2[0] = 10;
Console.WriteLine(arr1[0]);  // 10 (تغییر کرده!)
```
---

##  Performance Implications

### Stack vs Heap (مقدماتی):

**Value Types:**
```csharp
void Method() 
{
int x = 5;      // ✅ Stack allocation (سریع)
Point p;        // ✅ Stack allocation
}
// خودکار پاک می‌شود (scope exit)
```
**نکات:**
- **Allocation**: فوق‌العاده سریع (فقط تغییر Stack Pointer)
- **Deallocation**: خودکار و سریع
- **Garbage Collection**: نیاز ندارد

---

##  محدودیت‌های Value Types

### 1. نمی‌توانند `null` باشند (پیش‌فرض):
```csharp
int x = null;  // ❌ خطای کامپایل
```
**راه حل:** Nullable Value Types (موضوع آینده)
```csharp
int? x = null;  // ✅ Nullable<int>
```
### 2. نمی‌توانند از کلاس ارث ببرند:
```csharp
struct Point : MyClass { }  // ❌ غیرمجاز
```
**اما:**
```csharp
struct Point : IComparable { }  // ✅ Interface مجاز است
```
### 3. نمی‌توانند Abstract/Virtual باشند:
```csharp
abstract struct Point { }  // ❌ غیرمجاز
```
---

##  Custom Value Type - نمونه کامل

```csharp
public struct Point
{
// Fields
public int X, Y;
// Constructor
public Point(int x, int y)
{
X = x;
Y = y;
}

// Method
public double DistanceFromOrigin()
{
return Math.Sqrt(X * X + Y * Y);
}

// Override ToString
public override string ToString()
{
return $"({X}, {Y})";
}
}

// استفاده:
Point p = new Point(3, 4);
Console.WriteLine(p.DistanceFromOrigin());  // 5
Console.WriteLine(p);  // (3, 4)
```
---

##  Size در حافظه

### محاسبه اندازه `Point`:
```csharp
struct Point { public int X, Y; }

// اندازه:
// int = 4 bytes
// int = 4 bytes
// ──────────────
// Total = 8 bytes
```
**بررسی واقعی:**
```csharp
Console.WriteLine(sizeof(Point));  // خروجی: 8
```
**⚠️ نکته:** ممکن است padding برای alignment اضافه شود

---

##  تفاوت‌های ظریف

### `struct` vs `class`:

```csharp
// Value Type
struct PointStruct { public int X, Y; }

// Reference Type  
class PointClass { public int X, Y; }

// تست:
PointStruct s1 = new PointStruct { X = 1 };
PointStruct s2 = s1;  // کپی
s2.X = 2;
Console.WriteLine(s1.X);  // 1

PointClass c1 = new PointClass { X = 1 };
PointClass c2 = c1;  // مرجع
c2.X = 2;
Console.WriteLine(c1.X);  // 2 (تغییر کرده!)
```
---

##  نکات پیشرفته (Footnotesصفحه بعدی)

### 1. Mutable vs Immutable Structs:
**Best Practice:** Value types باید **Immutable** باشند

```csharp
// ❌ بد (Mutable)
public struct BadPoint 
{ 
public int X, Y; 
}

// ✅ خوب (Immutable)
public struct GoodPoint
{
public int X { get; }
public int Y { get; }

public GoodPoint(int x, int y)
{
X = x;
Y = y;
}
}
```
**دلیل:** از رفتار غیرمنتظره در Copyها جلوگیری می‌کند

---

### 2. Boxing (پیش‌نگر):
```csharp
int x = 5;
object obj = x;  // Boxing: value → reference (کپی به Heap)
```
**موضوع:** فصل 3

---

### 3. `readonly struct` (C# 7.2+):
```csharp
public readonly struct ImmutablePoint
{
public int X { get; }
public int Y { get; }

public ImmutablePoint(int x, int y) 
{ 
X = x; 
Y = y; 
}
}
```
**مزیت:** کامپایلر Immutability را اجبار می‌کند

---

##  جدول خلاصه Value Types

| Type | کلمه کلیدی | اندازه | محدوده/توضیح |
|------|------------|--------|---------------|
| **Signed Integer** | `sbyte` | 8-bit | $-128$ تا $127$ |
| | `short` | 16-bit | $-32{,}768$ تا $32{,}767$ |
| | `int` | 32-bit | $-2^{31}$ تا $2^{31}-1$ |
| | `long` | 64-bit | $-2^{63}$ تا $2^{63}-1$ |
| **Unsigned Integer** | `byte` | 8-bit | $0$ تا $255$ |
| | `ushort` | 16-bit | $0$ تا $65{,}535$ |
| | `uint` | 32-bit | $0$ تا $2^{32}-1$ |
| | `ulong` | 64-bit | $0$ تا $2^{64}-1$ |
| **Floating Point** | `float` | 32-bit | ±$1.5 \times 10^{-45}$ تا ±$3.4 \times 10^{38}$ |
| | `double` | 64-bit | ±$5.0 \times 10^{-324}$ تا ±$1.7 \times 10^{308}$ |
| | `decimal` | 128-bit | ±$1.0 \times 10^{-28}$ تا ±$7.9 \times 10^{28}$ |
| **Other** | `bool` | 1 byte | `true` / `false` |
| | `char` | 16-bit | Unicode U+0000 تا U+FFFF |
| **Custom** | `struct` | متغیر | مجموع اندازه fieldها + padding |

---

##  نکات کلیدی برای حفظ

1. ✅ Value type = **محتوا خود داده است**
2. ✅ Assignment = **کپی کامل** (مستقل)
3. ✅ تعریف: `struct` keyword
4. ✅ `new` اختیاری است (اما توصیه می‌شود)
5. ✅ نمی‌توانند `null` باشند (بدون `?`)
6. ✅ معمولاً روی **Stack** ذخیره می‌شوند
7. ✅ Performance بهتر برای دیتای کوچک
8. ⚠️ باید Immutable باشند (Best Practice)

