# نوع Boolean و عملگرهای آن

## 1. معرفی نوع `bool`

### تعریف پایه:
```csharp
// bool نام مستعار (alias) برای System.Boolean است
bool isTrue = true;
bool isFalse = false;

// تأیید aliasing
Console.WriteLine(typeof(bool) == typeof(System.Boolean)); // True
```
### ویژگی‌های کلیدی:

```csharp
| ویژگی | مقدار |
|-------|-------|
| **نام کامل** | `System.Boolean` |
| **نام مستعار** | `bool` |
| **مقادیر مجاز** | `true`, `false` |
| **فضای منطقی** | 1 bit |
| **فضای واقعی (Runtime)** | 1 byte (8 bits) |
| **دلیل 1 byte** | کوچک‌ترین واحد قابل دسترسی برای CPU و Runtime |
```
---

## 2. چرا 1 byte به جای 1 bit؟

### توضیح فنی:

```csharp
// bool فقط 1 bit نیاز دارد (0 یا 1)
// اما Runtime از 1 byte استفاده می‌کند

bool flag = true; // 1 byte در حافظه

// دلایل:
// 1. CPU نمی‌تواند مستقیماً با bits تکی کار کند
// 2. آدرس‌دهی حافظه به صورت byte-addressable است
// 3. کارایی: دسترسی به byte سریع‌تر از bit manipulation است
```

### مقایسه اندازه:

```csharp
using System;
using System.Runtime.InteropServices;

class SizeDemo
{
static void Main()
{
Console.WriteLine($"bool size: {sizeof(bool)} byte(s)");
Console.WriteLine($"byte size: {sizeof(byte)} byte(s)");
Console.WriteLine($"int size: {sizeof(int)} byte(s)");

// خروجی:
// bool size: 1 byte(s)
// byte size: 1 byte(s)
// int size: 4 byte(s)
}
}
```
---

## 3. مشکل فضای هدررفته در آرایه‌ها

### مثال مشکل:

```csharp
// آرایه 1000 bool
bool[] flags = new bool[1000];

// فضای مورد نیاز منطقی: 1000 bits = 125 bytes
// فضای واقعی: 1000 bytes (8 برابر بیشتر!) ❌
Console.WriteLine($"Array size: {flags.Length * sizeof(bool)} bytes");
// Array size: 1000 bytes
```
### راه‌حل: `BitArray`

```csharp
using System.Collections;

class BitArrayDemo
{
static void Main()
{
// ایجاد BitArray با 1000 عنصر
BitArray bits = new BitArray(1000);

// تنظیم مقادیر
bits[0] = true;
bits[999] = false;

// BitArray از 1 bit برای هر مقدار استفاده می‌کند
// فضای واقعی: ~125 bytes (به جای 1000 bytes)

Console.WriteLine($"BitArray Length: {bits.Length}");
Console.WriteLine($"First element: {bits[0]}");
Console.WriteLine($"Last element: {bits[999]}");
}
}
```
### مقایسه کامل `bool[]` و `BitArray`:

```csharp
using System;
using System.Collections;

class ComparisonDemo
{
static void Main()
{
const int size = 10_000_000;

// bool[] - هدر فضا
bool[] boolArray = new bool[size];
long boolArrayBytes = size * sizeof(bool);
Console.WriteLine($"bool[]: {boolArrayBytes:N0} bytes");
// bool[]: 10,000,000 bytes

// BitArray - بهینه
BitArray bitArray = new BitArray(size);
long bitArrayBytes = (size + 7) / 8; // تقریباً
Console.WriteLine($"BitArray: ~{bitArrayBytes:N0} bytes");
// BitArray: ~1,250,000 bytes

double savings = (1 - (double)bitArrayBytes / boolArrayBytes) * 100;
Console.WriteLine($"Space saving: {savings:F1}%");
// Space saving: 87.5%
}
}
```

### چه زمانی از `BitArray` استفاده کنیم:

✅ **استفاده کنید:**
- آرایه‌های بزرگ Boolean (1000+ عنصر)
- محدودیت حافظه
- پردازش bitmap یا flag sets

❌ **استفاده نکنید:**
- آرایه‌های کوچک (< 100 عنصر)
- نیاز به LINQ operations
- نیاز به عملکرد بالای دسترسی تصادفی

---

## 4. تبدیل‌های bool (Conversions)

### قانون اصلی:

**هیچ تبدیل casting بین `bool` و انواع عددی وجود ندارد**

### مثال‌های غلط:

```csharp
// ❌ تبدیل از bool به int
bool flag = true;
// int number = (int)flag; // Compile Error!

// ❌ تبدیل از int به bool
int zero = 0;
// bool isZero = (bool)zero; // Compile Error!

// ❌ تبدیل ضمنی
// if (1) { } // Compile Error! (برخلاف C/C++)
```
### راه‌حل‌های صحیح:

```csharp
// ✅ تبدیل صریح با شرط
bool flag = true;
int number = flag ? 1 : 0; // استفاده از ternary operator
Console.WriteLine(number); // 1

// ✅ استفاده از Convert
int num2 = Convert.ToInt32(flag);
Console.WriteLine(num2); // 1

// ✅ تبدیل از int به bool
int value = 0;
bool isNonZero = value != 0;
Console.WriteLine(isNonZero); // False
```
### مقایسه با C/C++:

```csharp
// در C/C++: (اشتباه در C#)
// if (1) { } // قابل اجرا در C/C++
// while (count--) { } // قابل اجرا در C/C++

// در C#: (صحیح)
if (true) { } // ✅
while (count > 0) { count--; } // ✅
```
---

## 5. عملگرهای برابری (Equality Operators)

### `==` و `!=`

**امضا:**
```csharp
// برای هر نوع کار می‌کند اما همیشه bool برمی‌گرداند
bool operator==(T left, T right);
bool operator!=(T left, T right);
```
### الف) با Value Types:

```csharp
// برابری بر اساس مقدار (value)
int x = 1;
int y = 2;
int z = 1;

Console.WriteLine(x == y); // False
Console.WriteLine(x == z); // True
Console.WriteLine(x != y); // True

// با انواع مختلف value type
double d = 3.14;
int i = 3;
Console.WriteLine(d == i); // False

decimal m = 1.0m;
Console.WriteLine(m == 1m); // True
```
### ب) با Reference Types:

**قانون پیش‌فرض:** برابری بر اساس **مرجع (reference)**، نه **مقدار**

```csharp
public class Dude
{
public string Name;
public Dude(string n) { Name = n; }
}

class ReferenceEqualityDemo
{
static void Main()
{
// دو شیء مختلف با محتوای یکسان
Dude d1 = new Dude("John");
Dude d2 = new Dude("John");

Console.WriteLine(d1 == d2); // False ❌
// چرا؟ d1 و d2 به دو شیء مختلف در حافظه اشاره می‌کنند

// مرجع یکسان
Dude d3 = d1;
Console.WriteLine(d1 == d3); // True ✅
// چرا؟ d1 و d3 به همان شیء اشاره می‌کنند

// تأیید:
Console.WriteLine(Object.ReferenceEquals(d1, d2)); // False
Console.WriteLine(Object.ReferenceEquals(d1, d3)); // True
}
}
```
### نمایش گرافیکی حافظه:

```csharp
┌──────────────────────────────────┐
│ Stack                             │
├──────────────────────────────────┤
│ d1 ──────┐                       │
│          │                       │
│ d2 ──────┼─────┐                │
│          │     │                │
│ d3 ──────┘     │                │
└──────────┬─────┴────────────────┘
│     │
▼     ▼
┌──────────────────────────────────┐
│ Heap                              │
├──────────────────────────────────┤
│ Object1: { Name = "John" } ◄─ d1, d3
│                                   │
│ Object2: { Name = "John" } ◄─ d2 │
└──────────────────────────────────┘
```
### مثال پیشرفته:

```csharp
class Person
{
public string Name { get; set; }
public int Age { get; set; }

public Person(string name, int age)
{
Name = name;
Age = age;
}
}

class Demo
{
static void Main()
{
Person p1 = new Person("Alice", 30);
Person p2 = new Person("Alice", 30);
Person p3 = p1;

// Reference equality
Console.WriteLine(p1 == p2); // False (مراجع متفاوت)
Console.WriteLine(p1 == p3); // True (مرجع یکسان)

// تغییر از طریق یک مرجع
p3.Age = 31;
Console.WriteLine(p1.Age); // 31 (همان شیء)
Console.WriteLine(p2.Age); // 30 (شیء متفاوت)
}
}
```
---

## 6. برابری `string` (استثنا)

### رفتار خاص `string`:

```csharp
// string یک reference type است اما == را overload کرده
string s1 = "Hello";
string s2 = "Hello";
string s3 = new string(new char[] { 'H', 'e', 'l', 'l', 'o' });

Console.WriteLine(s1 == s2); // True ✅ (مقایسه محتوا)
Console.WriteLine(s1 == s3); // True ✅ (مقایسه محتوا)

// اما:
Console.WriteLine(Object.ReferenceEquals(s1, s2)); // True (interning)
Console.WriteLine(Object.ReferenceEquals(s1, s3)); // False
```
**نکته:** `string` رفتار خاصی دارد که در فصل‌های بعدی (Chapter 6) توضیح داده می‌شود.

---

## 7. عملگرهای مقایسه (Comparison Operators)

### عملگرها:

```csharp
// <, >, <=, >=
// فقط برای انواع قابل مقایسه (numeric types, enums)
```
### الف) با انواع عددی:

```csharp
int a = 5;
int b = 10;

Console.WriteLine(a < b);  // True
Console.WriteLine(a > b);  // False
Console.WriteLine(a <= 5); // True
Console.WriteLine(a >= 5); // True

// با انواع مختلف (implicit conversion)
double d = 5.5;
Console.WriteLine(a < d); // True (5 < 5.5)
```

### ب) هشدار با اعداد اعشاری:

```csharp
// یادآوری از صفحه قبل
double x = 0.1 + 0.2; // 0.30000000000000004
Console.WriteLine(x == 0.3); // False ❌

// راه حل:
const double EPSILON = 1e-10;
Console.WriteLine(Math.Abs(x - 0.3) < EPSILON); // True ✅

// مقایسه نیز می‌تواند مشکل داشته باشد:
double y = 1.0 / 3.0 * 3.0; // 0.9999999999999999
Console.WriteLine(y < 1.0);  // True (انتظار False)
Console.WriteLine(y >= 1.0); // False
```
### ج) با Enums:

```csharp
enum Priority
{
Low = 1,
Medium = 2,
High = 3
}

Priority p1 = Priority.Low;
Priority p2 = Priority.High;

Console.WriteLine(p1 < p2);  // True (1 < 3)
Console.WriteLine(p2 >= Priority.Medium); // True (3 >= 2)

// مقایسه بر اساس مقدار زیرین (underlying integral value)
Console.WriteLine((int)Priority.High); // 3
```
---

## 8. جدول خلاصه عملگرهای برابری و مقایسه
```csharp
| عملگر | نام | انواع قابل استفاده | مثال | نتیجه |
|-------|-----|-------------------|------|-------|
| `==` | برابری | همه | `5 == 5` | `true` |
| `!=` | نابرابری | همه | `5 != 3` | `true` |
| `<` | کوچک‌تر | عددی، enum | `3 < 5` | `true` |
| `>` | بزرگ‌تر | عددی، enum | `5 > 3` | `true` |
| `<=` | کوچک‌تر مساوی | عددی، enum | `3 <= 3` | `true` |
| `>=` | بزرگ‌تر مساوی | عددی، enum | `5 >= 5` | `true` |
```
---

## 9. نکته پیشرفته: Overloading عملگرها

### اشاره در کتاب:

>  "It's possible to overload these operators (Chapter 4) such that they return a non-bool type, but this is almost never done in practice."

### مثال تئوری (غیر عملی):

```csharp
class WeirdNumber
{
public int Value { get; set; }

// Overload نامتعارف که int برمی‌گرداند (نه bool)
public static int operator==(WeirdNumber a, WeirdNumber b)
{
return a.Value + b.Value; // برمی‌گرداند int!
}

public static int operator!=(WeirdNumber a, WeirdNumber b)
{
return a.Value - b.Value;
}
}

// استفاده (در عمل توصیه نمی‌شود):
WeirdNumber w1 = new WeirdNumber { Value = 5 };
WeirdNumber w2 = new WeirdNumber { Value = 3 };
int result = w1 == w2; // 8 (نه true/false!)
```
**چرا این کار نمی‌شود؟**
- نقض انتظارات برنامه‌نویس
- مشکل در استفاده در شرط‌ها
- کد گیج‌کننده و غیرقابل نگهداری

---

## 10. مثال‌های عملی

### الف) سیستم احراز هویت:

```csharp
class User
{
public string Username { get; set; }
public string Password { get; set; }
}

class AuthenticationSystem
{
static bool Authenticate(User input, User stored)
{
// مقایسه string (محتوا)
bool usernameMatch = input.Username == stored.Username;
bool passwordMatch = input.Password == stored.Password;

return usernameMatch && passwordMatch;
}

static void Main()
{
User stored = new User 
{ 
Username = "admin", 
Password = "pass123" 
};

User input1 = new User 
{ 
Username = "admin", 
Password = "pass123" 
};

Console.WriteLine(Authenticate(input1, stored)); // True

// توجه: input1 == stored -> False (مراجع متفاوت)
// اما Authenticate -> True (محتوا یکسان)
}
}
```
### ب) مقایسه محدوده:

```csharp
class Range
{
static bool IsInRange(int value, int min, int max)
{
return value >= min && value <= max;
}

static void Main()
{
int score = 85;

if (IsInRange(score, 0, 100))
{
Console.WriteLine("Valid score");
}

// استفاده از pattern matching (C# 9+)
string grade = score switch
{
>= 90 => "A",
>= 80 => "B",
>= 70 => "C",
>= 60 => "D",
_ => "F"
};

Console.WriteLine($"Grade: {grade}"); // Grade: B
}
}
```

### ج) مقایسه تاریخ:

```csharp
using System;

class DateComparison
{
static void Main()
{
DateTime now = DateTime.Now;
DateTime tomorrow = now.AddDays(1);
DateTime yesterday = now.AddDays(-1);

Console.WriteLine(now < tomorrow);  // True
Console.WriteLine(now > yesterday); // True
Console.WriteLine(now == now);      // True

// DateTime یک struct است (value type)
DateTime copy = now;
Console.WriteLine(now == copy); // True (مقایسه مقدار)
}
}
```
---

## 11. خطاهای رایج و اشتباهات

### خطا 1: فرض تبدیل خودکار از int به bool

```csharp
int count = 5;

// ❌ اشتباه
// if (count) { } // Compile Error!

// ✅ صحیح
if (count > 0) { }
if (count != 0) { }
```

### خطا 2: مقایسه اشتباه reference types

```csharp
class Product
{
public string Name { get; set; }
public decimal Price { get; set; }
}

Product p1 = new Product { Name = "Book", Price = 10m };
Product p2 = new Product { Name = "Book", Price = 10m };

// ❌ اشتباه (مقایسه مرجع)
if (p1 == p2) 
{
Console.WriteLine("Same product"); // اجرا نمی‌شود!
}

// ✅ صحیح (مقایسه property ها)
if (p1.Name == p2.Name && p1.Price == p2.Price)
{
Console.WriteLine("Same product"); // اجرا می‌شود
}
```

### خطا 3: مقایسه مستقیم double

```csharp
double calculated = 0.1 + 0.2;

// ❌ اشتباه
if (calculated == 0.3) // False!
{
Console.WriteLine("Equal");
}

// ✅ صحیح
const double EPSILON = 1e-10;
if (Math.Abs(calculated - 0.3) < EPSILON)
{
Console.WriteLine("Equal"); // اجرا می‌شود
}
```

---

## 13. خلاصه نهایی برای ارائه

### نکات کلیدی:

1. **`bool` Type:**
   - 1 bit منطقی، 1 byte فیزیکی
   - فقط `true` یا `false`
   - برای آرایه‌های بزرگ از `BitArray` استفاده کنید

2. **تبدیل‌ها:**
   - هیچ casting مستقیم به/از انواع عددی
   - باید صریح با `? :` یا `!= 0` تبدیل کنید

3. **عملگرهای برابری (`==`, `!=`):**
   -  مقدار Value types: مقایسه مقدار
   - مقدار Reference types: مقایسه مرجع (مگر overload شده باشد)
   - همیشه `bool` برمی‌گردانند

4. **عملگرهای مقایسه (`<`, `>`, `<=`, `>=`):**
   - فقط برای انواع عددی و enum
   - مراقب خطای گرد کردن در اعداد اعشاری باشید

### کد خلاصه:

```csharp
// bool basics
bool flag = true; // 1 byte in memory

// No implicit conversion
int x = flag ? 1 : 0; // ✅

// Value type equality
int a = 5, b = 5;
Console.WriteLine(a == b); // True (value)

// Reference type equality
var obj1 = new object();
var obj2 = new object();
Console.WriteLine(obj1 == obj2); // False (reference)

// Comparison with caution
double d = 0.1 + 0.2;
Console.WriteLine(Math.Abs(d - 0.3) < 1e-10); // True ✅
```


