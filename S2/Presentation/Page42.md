
# Types و Conversions

## 📌 مفهوم Conversion

**Conversion** = تبدیل بین نمونه‌های (instances) typeهای سازگار

### ✨ نکته کلیدی
> یک conversion همیشه یک **مقدار جدید** ایجاد می‌کند، نه تغییر مقدار موجود!
```csharp
int x = 100;
long y = x;  // یک مقدار long جدید ساخته می‌شود
x = 200;
Console.WriteLine(y);  // هنوز 100 است
```


## 🔀 انواع Conversion

### 1️⃣ Implicit Conversion (تبدیل ضمنی)
**تعریف:** خودکار و بدون نیاز به دخالت برنامه‌نویس

#### 📋 شرایط (هر دو باید برقرار باشند):
✅ کامپایلر تضمین کند همیشه موفق است  
✅ هیچ اطلاعاتی از دست نمی‌رود

#### 💡 مثال:
```csharp
int x = 12345;       // 32-bit integer
long y = x;          // ✅ Implicit: int → long (ایمن است)

**چرا ایمن است؟**
- `int`: $-2^{31}$ تا $2^{31}-1$ (4 bytes)
- `long`: $-2^{63}$ تا $2^{63}-1$ (8 bytes)
- هر `int` می‌تواند در `long` جای بگیرد ✅

```
### 2️⃣ Explicit Conversion (تبدیل صریح)
**تعریف:** نیاز به **Cast** دارد: `(TargetType)value`

#### 📋 شرایط (یکی کافی است):
⚠️ کامپایلر نمی‌تواند موفقیت را تضمین کند  
⚠️ ممکن است اطلاعات از دست برود

#### 💡 مثال:
```csharp
int x = 12345;
short z = (short)x;  // ⚠️ Explicit: int → short (ممکن است overflow شود)

**چرا Explicit است؟**
- `int`: $-2^{31}$ تا $2^{31}-1$ (4 bytes)
- `short`: $-2^{15}$ تا $2^{15}-1$ (2 bytes)
- همه `int`ها در `short` جا نمی‌شوند ⚠️

```

## 🎯 مقایسه Implicit vs Explicit

| ویژگی | Implicit | Explicit |
|-------|----------|----------|
| **سینتکس** | `long y = x;` | `short z = (short)x;` |
| **امنیت** | ✅ همیشه ایمن | ⚠️ ممکن است خطا رخ دهد |
| **از دست رفتن داده** | ❌ خیر | ⚠️ ممکن است |
| **کنترل کامپایلر** | ✅ کامل | ⚠️ محدود |

---

## ⚠️ Overflow در Explicit Conversion

### مثال 1: Overflow ساکت
```csharp
int large = 300;
byte small = (byte)large;  // محدوده byte: 0-255
Console.WriteLine(small);  // خروجی: 44 (300 % 256)

**چرا 44؟**
$$300 \mod 256 = 44$$

### مثال 2: تشخیص Overflow با `checked`
csharp
checked {
int max = int.MaxValue;
int overflow = max + 1;  // 💥 OverflowException
}

```

## 📊 انواع Conversion در C#

### 1. Numeric Conversions (عددی)
**Built-in:** در زبان تعبیه شده

```csharp
// Implicit (Widening)
int i = 100;
long l = i;          // ✅ 32-bit → 64-bit
float f = i;         // ✅ int → float

// Explicit (Narrowing)
long big = 100L;
int small = (int)big;     // ⚠️ 64-bit → 32-bit
double d = 9.99;
int truncated = (int)d;   // ⚠️ 9 (اعشار حذف می‌شود)
```
### 2. Reference Conversions
**موضوع:** فصل 3 (پیشرفته)

```csharp
// مثال مقدماتی
string s = "Hello";
object o = s;  // ✅ Implicit: string → object
```
### 3. Boxing Conversions
**موضوع:** فصل 3 (پیشرفته)

```csharp
// مثال مقدماتی
int value = 123;
object boxed = value;  // Boxing: value type → reference type
```
### 4. Custom Conversions
**موضوع:** صفحه 256 (Operator Overloading)

⚠️ **نکته مهم:**
> کامپایلر قوانین ایمنی را با custom conversions اجرا **نمی‌کند**!

```csharp
// مثال (پیشرفته)
public static implicit operator int(MyClass obj) {
return obj.Value;  // برنامه‌نویس مسئول ایمنی است
}

```

## ❌ Conversionهای غیرمجاز

### حالت 1: همیشه شکست می‌خورد
```csharp
int i = 5;
string s = (string)i;  // ❌ خطای کامپایل - هیچ مسیری وجود ندارد
```
**راه حل:**
```csharp
string s = i.ToString();  // ✅ استفاده از متد

### حالت 2: Generics (پیشرفته)
**موضوع:** صفحه 166 - شرایط خاص

```
