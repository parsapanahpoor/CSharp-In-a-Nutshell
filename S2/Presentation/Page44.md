# Reference Types 

##  ساختار Reference Types

### تعریف اساسی:
> یک **Reference Type** دو بخش دارد:
> 1. آبجکت - **Object** (شیء واقعی در Heap)
> 2. رفرتس - **Reference** (مرجع/اشاره‌گر به آن شیء)

###  مفهوم کلیدی:
**محتوای** یک متغیر reference type، **آدرس object** است، نه خود داده!

---

##  تبدیل Point از `struct` به `class`

### نسخه قبلی (Value Type):
```csharp
public struct Point { public int X, Y; }  // Value Type
```

### نسخه جدید (Reference Type):
```csharp
public class Point { public int X, Y; }   // Reference Type
```

** تنها تفاوت:** تغییر `struct` → `class`  
**تأثیر:** تغییر کامل رفتار در حافظه و assignment!

---

##  ساختار حافظه Reference Type

### Figure 2-3: نمایش در حافظه

```csharp

Stack (متغیر)              Heap (Object واقعی)
┌──────────────┐           ┌──────────────┐
│ Point p1     │           │   Object     │
│              │  ───────> │   X: 7       │
│ Reference    │           │   Y: 0       │
│ (Address)    │           │              │
└──────────────┘           └──────────────┘
   0x1000                     0x2A4F8C
```
**نکات:**
1. متغیر `p1` روی **Stack** ذخیره می‌شود (فقط آدرس)
2. شی Object واقعی روی **Heap** قرار دارد
3. مقدار `p1` = آدرس object (مثلاً `0x2A4F8C`)
4. دسترسی به `X` و `Y` از طریق این آدرس انجام می‌شود

---

##  Copy Semantics در Reference Types

### قانون طلایی:
> نکته : **Assignment** یک reference type، **فقط reference** را کپی می‌کند، نه object!

### مثال کامل:
```csharp
Point p1 = new Point();
p1.X = 7;

Point p2 = p1;  // ⚠️ کپی reference (نه object)

Console.WriteLine(p1.X);  // 7
Console.WriteLine(p2.X);  // 7

p2.X = 9;  // تغییر از طریق p2

Console.WriteLine(p1.X);  // 9 (تغییر کرده!)
Console.WriteLine(p2.X);  // 9

```
## 🧠 تحلیل عمیق: چرا `p1` تغییر کرد؟

### گام به گام در حافظه:

#### مرحله 1: ایجاد p1
```csharp
Stack                      Heap
┌──────────┐              ┌──────────┐
│ p1       │  ─────────>  │ Object   │
│ 0x2000   │              │ X: 7     │
└──────────┘              │ Y: 0     │
└──────────┘
Address: 0x2000
```
#### مرحله 2: بعد از `p2 = p1`
```csharp
Stack                      Heap
┌──────────┐              ┌──────────┐
│ p1       │  ─────────>  │ Object   │  <───┐
│ 0x2000   │              │ X: 7     │      │
└──────────┘              │ Y: 0     │      │
└──────────┘      │
┌──────────┐               Address: 0x2000  │
│ p2       │  ──────────────────────────────┘
│ 0x2000   │  (همان آدرس!)
└──────────┘
```
**نکته کلیدی:** هر دو به **یک object** اشاره دارند!

#### مرحله 3: بعد از `p2.X = 9`
```csharp
Stack                      Heap
┌──────────┐              ┌──────────┐
│ p1       │  ─────────>  │ Object   │  <───┐
│ 0x2000   │              │ X: 9  ✏️ │      │
└──────────┘              │ Y: 0     │      │
└──────────┘      │
┌──────────┐                                │
│ p2       │  ──────────────────────────────┘
│ 0x2000   │
└──────────┘
```

**نتیجه:** تغییر از طریق `p2` روی **همان object** اثر می‌گذارد که `p1` هم به آن اشاره دارد.

---

## مقایسه دقیق Value Type vs Reference Type

### سناریو یکسان با رفتار متفاوت:

#### Value Type (`struct`):
```csharp
struct PointStruct { public int X, Y; }

PointStruct p1 = new PointStruct();
p1.X = 7;

PointStruct p2 = p1;  // کپی object
p2.X = 9;

Console.WriteLine(p1.X);  // 7 (تغییر نکرده)
Console.WriteLine(p2.X);  // 9
```
**حافظه:**
```csharp
Stack
┌──────────┐  ┌──────────┐
│ p1       │  │ p2       │
│ X: 7     │  │ X: 9     │  دو object مستقل
│ Y: 0     │  │ Y: 0     │
└──────────┘  └──────────┘
```
#### Reference Type (`class`):
```csharp
class PointClass { public int X, Y; }

PointClass p1 = new PointClass();
p1.X = 7;

PointClass p2 = p1;  // کپی reference
p2.X = 9;

Console.WriteLine(p1.X);  // 9 (تغییر کرده!)
Console.WriteLine(p2.X);  // 9
```
**حافظه:**
```csharp
Stack              Heap
┌──────┐          ┌──────────┐
│ p1   │ ──────>  │ Object   │  <──┐
└──────┘          │ X: 9     │     │
┌──────┐          │ Y: 0     │     │  یک object مشترک
│ p2   │ ─────────────────────────┘
└──────┘
```
---

##  جدول مقایسه کامل

| ویژگی | Value Type (`struct`) | Reference Type (`class`) |
|-------|----------------------|--------------------------|
| **محل ذخیره متغیر** | Stack | Stack (reference) |
| **محل ذخیره داده** | Stack¹ | Heap |
| **محتوای متغیر** | خود داده | آدرس object |
| **Assignment** | کپی کامل داده | کپی reference |
| **استقلال بعد از copy** | ✅ کاملاً مستقل | ❌ به یک object اشاره دارند |
| **`null` پذیری** | ❌ (الا `Nullable<T>`) | ✅ بله |
| **Inheritance** | ❌ خیر (فقط Interface) | ✅ بله |
| **`new` keyword** | اختیاری | **الزامی** |
| **Performance** | سریع‌تر (کوچک) | کندتر (نیاز به GC) |
| **Default value** | صفر/`false` | `null` |

¹ *به جز زمانی که member یک class باشند یا boxed شوند*

---

##  عملیات `p1` روی `p2` تأثیر می‌گذارد

### مثال کامل از صفحه:
```csharp
public class Point { public int X, Y; }

Point p1 = new Point();
p1.X = 7;

Point p2 = p1;  // هر دو به یک object اشاره دارند

Console.WriteLine(p1.X);  // 7
Console.WriteLine(p2.X);  // 7

p1.X = 9;  //  تغییر از طریق p1

Console.WriteLine(p1.X);  // 9
Console.WriteLine(p2.X);  // 9 (p2 هم تغییر کرد!)
```

### چرا `p2` تغییر کرد؟

p1 ───┐
├──> [همان Object]
p2 ───┘

تغییر از طریق p1 = تغییر object
تغییر object = p2 هم آن را می‌بیند

---

##  پیامدهای عملی

### 1️⃣ Shared State (وضعیت مشترک):
```csharp
class BankAccount 
{ 
public decimal Balance; 
}

BankAccount account1 = new BankAccount { Balance = 1000 };
BankAccount account2 = account1;  // اشتراک!

account2.Balance -= 100;  // برداشت از account2
Console.WriteLine(account1.Balance);  // 900 (کاهش یافت!)
```
**کاربرد:** زمانی که می‌خواهید چند متغیر یک object را به اشتراک بگذارند.

---

### 2️⃣ مشکل Unintended Mutation:
```csharp
void ProcessPoint(Point p)
{
p.X = 0;  // ⚠️ object اصلی تغییر می‌کند!
}

Point original = new Point { X = 5, Y = 10 };
ProcessPoint(original);
Console.WriteLine(original.X);  // 0 (تغییر کرده!)
```
**راه حل:** کپی دستی یا Immutable Design

---

### 3️⃣ Collections و Reference Types:
```csharp
List<Point> points = new List<Point>();
Point p = new Point { X = 1, Y = 2 };
points.Add(p);

p.X = 999;  // تغییر p
Console.WriteLine(points[0].X);  // 999 (لیست هم تغییر کرد!)
```
**دلیل:** `List` reference را ذخیره می‌کند، نه کپی از object.

---

##  ایجاد کپی مستقل (Clone)

### مشکل:
```csharp
Point p1 = new Point { X = 5, Y = 10 };
Point p2 = p1;  // reference مشترک
p2.X = 99;
Console.WriteLine(p1.X);  // 99 (ناخواسته تغییر کرد!)
```
### راه حل 1: کپی دستی
```csharp
Point p1 = new Point { X = 5, Y = 10 };
Point p2 = new Point { X = p1.X, Y = p1.Y };  // ✅ کپی واقعی
p2.X = 99;
Console.WriteLine(p1.X);  // 5 (تغییر نکرده)
```
### راه حل 2: Clone Method
```csharp
public class Point
{
public int X, Y;

public Point Clone()
{
return new Point { X = this.X, Y = this.Y };
}
}

Point p1 = new Point { X = 5, Y = 10 };
Point p2 = p1.Clone();  // ✅ object جدید
p2.X = 99;
Console.WriteLine(p1.X);  // 5
```
### راه حل 3: `ICloneable` (قدیمی، توصیه نمی‌شود)
```csharp
public class Point : ICloneable
{
public int X, Y;

public object Clone()
{
return new Point { X = this.X, Y = this.Y };
}
}
```
** نکته:** `ICloneable` مشکلاتی دارد (Deep vs Shallow copy ابهام دارد).

---

##  Built-in Reference Types

### دسته‌بندی:

#### 1️⃣ String (ویژه):
```csharp
string s1 = "Hello";
string s2 = s1;  // reference type اما...
s2 = "World";
Console.WriteLine(s1);  // "Hello" (تغییر نکرد!)
```
** استثنا:** `string` **immutable** است (رفتار شبیه value type)!

#### 2️⃣ Arrays:
```csharp
int[] arr1 = { 1, 2, 3 };
int[] arr2 = arr1;  // reference مشترک
arr2[0] = 999;
Console.WriteLine(arr1[0]);  // 999
```
#### 3️⃣ Classes:
```csharp
class MyClass { public int Value; }

MyClass obj1 = new MyClass { Value = 10 };
MyClass obj2 = obj1;  // reference
```
#### 4️⃣ Delegates:
```csharp
delegate void MyDelegate();
```
#### 5️⃣ Interfaces (خودشان reference نیستند، اما type را محدود می‌کنند):
```csharp
interface IMyInterface { }
```
#### 6️⃣ Object (پایه همه):
```csharp
object obj = new Point();  // هر چیزی می‌تواند object باشد
```
---

##  عملگر `new` در Reference Types

### الزامی است!
```csharp
Point p1;  // ❌ فقط اعلام (هنوز null است)
p1.X = 5;  // 💥 NullReferenceException

Point p2 = new Point();  // ✅ ایجاد object
p2.X = 5;  // ✅ کار می‌کند
```
### بدون `new`:
```csharp
Point p = null;  // ✅ مجاز (اما خطرناک)
Console.WriteLine(p.X);  // 💥 NullReferenceException
```
---

##  تفاوت‌های ظریف

### `new` در Value Type vs Reference Type:

#### Value Type:
```csharp
struct PointStruct { public int X; }

PointStruct p1;      // اعلام (uninitialized)
PointStruct p2 = new PointStruct();  // همه fieldها = 0

// p1 و p2 هر دو روی Stack هستند
```
#### Reference Type:
```csharp
class PointClass { public int X; }

PointClass p1;       // null
PointClass p2 = new PointClass();  // object روی Heap

// p1 = null روی Stack
// p2 = آدرس object روی Stack, object روی Heap
```
---

##  نمونه پیشرفته: Linked List

```csharp
public class Node
{
public int Value;
public Node Next;  // ✅ reference به خودش (امکان‌پذیر)
}

Node n1 = new Node { Value = 1 };
Node n2 = new Node { Value = 2 };
Node n3 = new Node { Value = 3 };

n1.Next = n2;  // اتصال
n2.Next = n3;

// حالا n1 به n2 اشاره دارد که به n3 اشاره دارد
Console.WriteLine(n1.Next.Next.Value);  // 3
```
**نکته:** این ساختار با value type امکان‌پذیر نیست!

---

##  خطاهای رایج

### 1. فراموشی `new`:
```csharp
Point p;
p.X = 5;  // 💥 خطا: p نمونه‌سازی نشده
```
### 2. فکر کردن Assignment = کپی object:
```csharp
Point p1 = new Point { X = 5 };
Point p2 = p1;  // ❌ فکر: کپی, ✅ واقعیت: reference
```
### 3. تغییر ناخواسته:
```csharp
void ResetPoint(Point p)
{
p.X = 0;  // ⚠️ object اصلی تغییر می‌کند!
}
```
---

##  نکات کلیدی برای حفظ

1. ✅ رفرنس تایپ ها Reference type = **دو بخش:** object (Heap) + reference (Stack)
2. ✅ محتوای متغیر = **آدرس object**، نه داده
3. ✅ نکته » Assignment = **کپی reference**، نه object
4. ✅ چند متغیر می‌توانند به **یک object** اشاره کنند
5. ✅ تغییر از طریق هر reference روی **همان object** اثر می‌گذارد
6. ✅ نکته » `new` **الزامی** است (بدون آن = `null`)
7. ✅ تعریف: `class` keyword
8. ⚠️ نکته » Default value = `null`
9. ⚠️ نیاز به **Garbage Collection**
