# Null و Storage Overhead 

## 📌 بخش اول: Null در C#

### نال Null در Reference Types

#### تعریف:
> یک **reference** می‌تواند مقدار literal `null` بگیرد که نشان می‌دهد **به هیچ object‌ای اشاره نمی‌کند**.

#### مثال:
```csharp
class Point { /* ... */ }

Point p = null;  // ✅ قانونی
Console.WriteLine(p == null);  // True

```
###  خطای Runtime: NullReferenceException

#### کد خطا:
```csharp
Point p = null;
Console.WriteLine(p.X);  // 💥 Runtime Error
```
#### نتیجه:

System.NullReferenceException: Object reference not set to an instance of an object.

**دلیل:** تلاش برای دسترسی به عضو (`X`) یک object که وجود ندارد!

---

###  Nullable Reference Types (NRTs)

> **صفحه 215:** C# دارای ویژگی‌ای برای **کاهش خطاهای تصادفی** `NullReferenceException` است.

#### پیش‌نمایش (جزئیات در صفحه 215):
```csharp
#nullable enable  // فعال‌سازی

string? name = null;  // ✅ صریحاً nullable
string address = null;  // ⚠️ هشدار کامپایلر!
```
**هدف:** کامپایلر به شما هشدار می‌دهد قبل از اینکه Runtime Error بگیرید.

---

##  Null در Value Types

### قانون پایه:
> یک **value type** به طور معمول **نمی‌تواند** مقدار `null` داشته باشد.

### مثال‌های خطا:
```csharp
struct Point { /* ... */ }

Point p = null;  // ❌ Compile-time error
int x = null;    // ❌ Compile-time error
```
#### پیام خطا:

Cannot convert null to 'Point' because it is a non-nullable value type
Cannot convert null to 'int' because it is a non-nullable value type

---

### ✅ راه حل: Nullable Value Types

> **صفحه 210:** C# سازوکاری به نام **Nullable Value Types** دارد برای نمایش `null` در value types.

#### Syntax:
```csharp
int? x = null;     // ✅ کار می‌کند
Point? p = null;   // ✅ کار می‌کند

Console.WriteLine(x == null);  // True
Console.WriteLine(p == null);  // True
```
#### معادل کامل:
```csharp
Nullable<int> x = null;
Nullable<Point> p = null;
```
**نکته:** `?` یک shorthand برای `Nullable<T>` است.

---

##  جدول مقایسه Null

| نوع | Nullability پیش‌فرض | Syntax برای Nullable | مثال |
```زساشقح
|-----|---------------------|---------------------|------|
| **Reference Type** | ✅ بله | - | `string s = null;` |
| **Value Type** | ❌ خیر | `T?` یا `Nullable<T>` | `int? x = null;` |
| **String** | ✅ بله (reference است) | - | `string? s = null;` (با NRT) |
| **Array** | ✅ بله (reference است) | - | `int[] arr = null;` |
```


##  بخش دوم: Storage Overhead (سربار حافظه)

###  Value Types: اندازه دقیق

#### قانون:
> نکته » Value-type instances دقیقاً به اندازه **مجموع فیلدهایشان** حافظه اشغال می‌کنند.

#### مثال ساده:
```csharp
struct Point 
{ 
int x;  // 4 bytes
int y;  // 4 bytes
}
```
// کل فضا: 8 bytes

**محاسبه:**
$$ \text{Size} = \text{sizeof}(x) + \text{sizeof}(y) = 4 + 4 = 8 \text{ bytes} $$

---

###  Field Alignment (تراز فیلدها)

#### قانون CLR:
> نکته » **CLR** فیلدها را در آدرسی قرار می‌دهد که **مضربی از اندازه فیلد** باشد (حداکثر 8 بایت).

#### مثال با Padding:
```csharp
struct A 
{ 
byte b;   // 1 byte
long l;   // 8 bytes
}
```
#### تحلیل حافظه:
```csharp
Memory Layout:
┌─────────────────────────────────┬───────────────────────────┐
│ byte b (1 byte) + Padding (7)   │ long l (8 bytes)          │
└─────────────────────────────────┴───────────────────────────┘
  0        1  2  3  4  5  6  7      8  9  10 11 12 13 14 15

Total: 16 bytes (not 9!)
```
**توضیح:**
1. نکته » `byte b` در آدرس `0` قرار می‌گیرد (1 بایت)
2. نکته » CLR 7 بایت **padding** اضافه می‌کند تا `long` در آدرس مضرب 8 قرار گیرد
3. نکته » `long l` در آدرس `8` شروع می‌شود (8 بایت)

**فرمول:**
$$ \text{Total Size} = 1 + 7_{\text{padding}} + 8 = 16 \text{ bytes} $$

---

### 🎯 چرا Alignment؟

**دلیل:** کارایی CPU - دسترسی به داده‌های تراز شده **سریع‌تر** است.

```csharp
// Bad Alignment (کند):
0: [byte]
1: [long starts here] ❌ آدرس فرد!

// Good Alignment (سریع):
0: [byte][padding...]
8: [long starts here] ✅ آدرس مضرب 8
```

###  Override کردن Alignment

> **صفحه 997:** می‌توانید با `StructLayout` این رفتار را تغییر دهید.

```csharp
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
struct A 
{ 
byte b;  // 1 byte
long l;  // 8 bytes
}

// حالا فضا: 9 bytes (بدون padding)
```
**هشدار:** این کار ممکن است **performance** را کاهش دهد!


###  مثال‌های بیشتر Alignment

#### مثال 1: Optimal Order
```csharp
struct Optimized 
{ 
long a;   // 8 bytes (offset 0)
int b;    // 4 bytes (offset 8)
short c;  // 2 bytes (offset 12)
byte d;   // 1 byte  (offset 14)
byte e;   // 1 byte  (offset 15)
}

// Total: 16 bytes (no waste!)
```

#### مثال 2: Bad Order
```csharp
struct BadOrder 
{ 
byte a;   // 1 byte  (offset 0)
long b;   // 8 bytes (offset 8) → 7 bytes padding!
byte c;   // 1 byte  (offset 16)
}

// Total: 24 bytes (11 bytes wasted!)
```
**درس:** **ترتیب فیلدها مهم است!**

---

##  Reference Types: سربار مضاعف

### دو تخصیص حافظه:

#### 1️⃣ Reference (مرجع):
- **محل:** Stack
- **اندازه:** 4 یا 8 بایت (بسته به معماری)

#### 2️⃣ Object (شیء):
- **محل:** Heap
- **اندازه:** فیلدها + سربار مدیریتی

---

### 📦 ساختار Object در Heap

```csharp
┌─────────────────────────────────┐
│ Object Header (حداقل 8 bytes)  │  ← سربار CLR
├─────────────────────────────────┤
│ Type Key (کلید نوع)             │
│ Lock State (وضعیت قفل)          │
│ GC Flags (پرچم‌های GC)          │
├─────────────────────────────────┤
│ Field 1                         │  ← داده‌های شما
│ Field 2                         │
│ ...                             │
└─────────────────────────────────┘
```


### جزئیات سربار (Overhead)

#### الف) Object Header (حداقل 8 بایت):

> **نکته:** اندازه دقیق private است (implementation detail)، اما **حداقل 8 بایت**.

**محتویات:**
1. نکته » **Type Key:** شناسه نوع object (برای reflection و casting)
2. **Lock State:** اطلاعات قفل برای multithreading (`lock` statement)
3. **GC Flag:** نشان می‌دهد object ثابت شده (fixed) یا خیر

```csharp
// مثال:
class Point { int X, Y; }

Point p = new Point();

// Heap:
// [8 bytes header] [4 bytes X] [4 bytes Y]
// Total: 16 bytes
```
---

#### ب) Reference Size (4 یا 8 بایت):

> هر **reference** به object یک **pointer** اضافی است.

| معماری | اندازه Pointer |
```chsarp
|---------|----------------|
| **32-bit** | 4 bytes |
| **64-bit** | 8 bytes |

csharp
class Point { int X, Y; }

Point p1 = new Point();  // 1 reference (4 or 8 bytes)
Point p2 = p1;           // 2 references (8 or 16 bytes total)
Point p3 = p1;           // 3 references (12 or 24 bytes total)

// اما فقط 1 object روی Heap!
```
---

###  محاسبه کل فضا

#### مثال:
```csharp
class Point 
{ 
int X;  // 4 bytes
int Y;  // 4 bytes
}

Point p = new Point();
```
#### محاسبه در 64-bit:

| بخش | اندازه | محل |
```csharp
|-----|--------|-----|
| **Reference `p`** | 8 bytes | Stack |
| **Object Header** | 8 bytes | Heap |
| **Field `X`** | 4 bytes | Heap |
| **Field `Y`** | 4 bytes | Heap |
| **کل** | **24 bytes** | - |


```
**فرمول:**
$$ \text{Total} = \underbrace{8}_{\text{ref}} + \underbrace{8}_{\text{header}} + \underbrace{4 + 4}_{\text{fields}} = 24 \text{ bytes} $$

---

###  چند Reference، یک Object

```csharp
Point p1 = new Point();
Point p2 = p1;
Point p3 = p1;
```
**فضا (64-bit):**
- **References:** $3 \times 8 = 24$ bytes (Stack)
- **Object:** $8 + 4 + 4 = 16$ bytes (Heap)
- **کل:** $24 + 16 = 40$ bytes

**نکته:** object فقط **یک بار** ایجاد می‌شود!

---

##  جدول مقایسه کامل Storage
```csharp
| feature | Value Type | Reference Type |
|-------|-----------|---------------|
| **place** | Stack | Heap (+ ref در Stack) |
| **size** | فیلدها (+ padding) | فیلدها + header (≥8) + ref (4/8) |
| **overhead** | فقط padding | header + pointer |
| **varriables** | هر کدام یک کپی مستقل | همه به یک object اشاره می‌کنند |
| **GC** | ❌ خیر | ✅ بله |
| **Alignment** | ✅ بله (CLR) | ✅ بله (CLR) |
| **Override Alignment** | `StructLayout` | `StructLayout` |

```
---

##  نکات عملی Storage

### 1️⃣ بهینه‌سازی Struct:
```csharp
// ❌ Bad (24 bytes):
struct Bad 
{
byte a;   // +7 padding
long b;
byte c;   // +7 padding
}

// ✅ Good (16 bytes):
struct Good 
{
long b;   // 8 bytes
byte a;   // 1 byte
byte c;   // 1 byte
// +6 padding at end
}
```
**قانون:** **بزرگ‌ترین فیلدها را اول** بگذارید.

---

### 2️⃣ Reference Type بزرگ:
```csharp
class HugeClass 
{
byte[] data = new byte[1000000];  // 1 MB
}

HugeClass h1 = new HugeClass();
HugeClass h2 = h1;  // فقط 8 بایت کپی می‌شود (ref)!
```
**مزیت:** کپی reference ارزان است، حتی برای object‌های بزرگ.

---

### 3️⃣ Value Type کوچک:
```csharp
struct TinyStruct 
{
byte a, b;
}

void Process(TinyStruct t) { /* ... */ }

TinyStruct s = new TinyStruct();
Process(s);  // کل struct کپی می‌شود (2 bytes)
```
**مزیت:** برای struct‌های کوچک (<16 bytes) ارزان است.

---

##  Value Type vs Reference Type: انتخاب

### استفاده از `struct` (Value Type):
✅ اندازه کوچک (<16 bytes)  
✅ تغییرناپذیر immutable 
✅ کوتاه lifetime   
✅ نیاز به کپی مستقل  

**مثال:** `Point`, `DateTime`, `TimeSpan`

---

### استفاده از `class` (Reference Type):
✅ اندازه بزرگ  
✅ تغییرپذیر mutable   
✅ طولانی lifetime   
✅ نیاز به اشتراک‌گذاری  
✅ نیاز به inheritance  

**مثال:** `List<T>`, `StreamReader`, `DbConnection`

---

## 🔬 مثال پیشرفته: محاسبه دقیق

```csharp
struct Complex 
{
double real;      // 8 bytes (offset 0)
double imaginary; // 8 bytes (offset 8)
}

// Total: 16 bytes (no padding)

class ComplexRef 
{
double real;      // 8 bytes
double imaginary; // 8 bytes
}

// Heap: 8 (header) + 8 + 8 = 24 bytes
// Stack (ref): 8 bytes (64-bit)
// Total: 32 bytes
```
**نتیجه:** `struct` در این مورد **2 برابر کارآمدتر** است!

---

##  خلاصه نکات کلیدی

### نکته » Null:
1. ✅ نکته » Reference types **می‌توانند** `null` باشند
2. ✅ نکته » Value types **نمی‌توانند** `null` باشند (الا با `?`)
3. ✅ نکته » `NullReferenceException` = خطای Runtime
4. ✅ نکته » **NRTs** (صفحه 215) کمک می‌کند
5. ✅ نکته » `Nullable<T>` (صفحه 210) برای value types

### نکته » Storage:
1. ✅ نکته » Value type = **فقط فیلدها** (+ padding)
2. ✅ نکته » Reference type = **فیلدها + header + pointer**
3. ✅ نکته » **Alignment:** فیلدها در مضرب اندازه خودشان (≤8)
4. ✅ نکته » **Padding** ممکن است فضا را افزایش دهد
5. ✅ **ترتیب فیلدها** مهم است!
6. ✅ نکته » **Object header** حداقل 8 بایت
7. ✅ نکته » **Reference** = 4 (32-bit) یا 8 (64-bit) بایت
8.  نکته » `StructLayout` برای override (صفحه 997)


