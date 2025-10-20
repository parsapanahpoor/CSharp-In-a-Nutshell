#  انواع عددی 8 و 16 بیتی و مقادیر ویژه Float/Double

## 1. انواع عددی صحیح 8 و 16 بیتی (8-bit and 16-bit Integral Types)

### انواع:
- `byte` (8-bit، بدون علامت: $0$ تا $255$)
- `sbyte` (8-bit، با علامت: $-128$ تا $127$)
- `short` (16-bit، با علامت: $-32768$ تا $32767$)
- `ushort` (16-bit، بدون علامت: $0$ تا $65535$)

### نکته کلیدی: عدم وجود عملگرهای مستقل ریاضی
```csharp
short x = 1, y = 1;
short z = x + y; // خطای کامپایل!
```
**چرا خطا می‌دهد؟**

1.سی شارپ C# به صورت خودکار `x` و `y` را به `int` تبدیل می‌کند (implicit conversion)
2. نتیجه `x + y` از نوع `int` است
3. نمی‌توان `int` را به صورت implicit به `short` تبدیل کرد (احتمال از دست رفتن داده)

### راه حل: استفاده از Cast صریح

```csharp
short z = (short)(x + y); // OK
```
⚠️ **نکته مهم برای ارائه:**
- پرانتز دور `(x + y)` ضروری است
- اگر بنویسیم `(short)x + y` فقط `x` cast می‌شود و مشکل حل نمی‌شود

### مثال عملی:

```csharp
byte a = 100;
byte b = 150;
// byte c = a + b; // خطا! نتیجه int است
byte c = (byte)(a + b); // OK، اما نتیجه: 250 (اگر checked نباشد ممکن است overflow شود)

// با checked:
checked
{
// byte d = (byte)(a + b); // OverflowException (چون 250 > byte.MaxValue=255)
}
```
---

## 2. مقادیر ویژه Float و Double

### انواع مقادیر خاص:
```chsarp
| مقدار ویژه | ثابت Double | ثابت Float |
|-----------|-------------|-----------|
| NaN (Not a Number) | `double.NaN` | `float.NaN` |
| بی‌نهایت مثبت | `double.PositiveInfinity` | `float.PositiveInfinity` |
| بی‌نهایت منفی | `double.NegativeInfinity` | `float.NegativeInfinity` |
| صفر منفی | `-0.0` | `-0.0f` |
```
### سایر ثابت‌های مفید:

```csharp
Console.WriteLine(double.MaxValue);    // 1.7976931348623157E+308
Console.WriteLine(double.MinValue);    // -1.7976931348623157E+308
Console.WriteLine(double.Epsilon);     // 4.94065645841247E-324 (کوچکترین مقدار مثبت)
Console.WriteLine(double.NegativeInfinity); // -Infinity
```
---

## 3. عملیات تقسیم و مقادیر ویژه

### الف) تقسیم بر صفر با اعداد غیرصفر:

```csharp
Console.WriteLine( 1.0 / 0.0);   // Infinity
Console.WriteLine(-1.0 / 0.0);   // -Infinity
Console.WriteLine( 1.0 / -0.0);  // -Infinity
Console.WriteLine(-1.0 / -0.0);  // Infinity
```
**نکته:** علامت نتیجه بستگی به علامت صورت و مخرج دارد

### ب) تقسیم صفر بر صفر:

```csharp
Console.WriteLine(0.0 / 0.0);  // NaN
```
### ج) عملیات نامعتبر با بی‌نهایت:

```csharp
Console.WriteLine((1.0 / 0.0) - (1.0 / 0.0));  // NaN
```
// یعنی: ∞ - ∞ = NaN

**قاعده کلی:** عملیاتی که ریاضیاً نامعین است (indeterminate) منجر به `NaN` می‌شود

---

## 4. کار با NaN - نکات مهم

### الف) مقایسه با عملگر ==

```csharp
Console.WriteLine(0.0 / 0.0 == double.NaN);  // False
Console.WriteLine(double.NaN == double.NaN); // False ⚠️
```
**نکته کلیدی:** `NaN` با هیچ چیز برابر نیست، حتی با خودش!

### ب) استفاده از متد IsNaN (روش صحیح)

```csharp
Console.WriteLine(double.IsNaN(0.0 / 0.0));  // True
Console.WriteLine(float.IsNaN(0.0f / 0.0f)); // True
```
### ج) مقایسه با object.Equals

```csharp
Console.WriteLine(object.Equals(0.0 / 0.0, double.NaN));  // True
Console.WriteLine(object.Equals(double.NaN, double.NaN)); // True
```
**تفاوت رفتار:**
```csharp
| روش مقایسه | `NaN == NaN` | `object.Equals(NaN, NaN)` |
|------------|-------------|---------------------------|
| نتیجه | `false` | `true` |
| استاندارد | IEEE 754 | سمنتیک .NET |
```
### مثال عملی برای کلاس:

```csharp
double result = 0.0 / 0.0;

// روش اشتباه ❌
if (result == double.NaN)
{
Console.WriteLine("This will NEVER execute!");
}

// روش صحیح ✅
if (double.IsNaN(result))
{
Console.WriteLine("Result is NaN!");
}

// یا:
if (object.Equals(result, double.NaN))
{
Console.WriteLine("Result is NaN using Equals!");
}
```
---

## 5. کاربردهای عملی NaN

### الف) WPF (Windows Presentation Foundation):

```csharp
// در WPF برای نمایش اندازه "خودکار":
myControl.Width = double.NaN;  // یعنی "Automatic"
myControl.Height = double.NaN;
```
### ب) جایگزین‌های دیگر برای نمایش مقادیر خاص:

**1. Nullable Types (فصل 4):**
```csharp
double? measurement = null; // به جای NaN
```
**2. Custom Struct (فصل 3):**
```csharp
struct Measurement
{
public double Value;
public bool IsAutomatic;

public static Measurement Automatic => new() { IsAutomatic = true };
}
```
**مقایسه رویکردها:**
```csharp

| رویکرد | مزایا | معایب |
|--------|-------|-------|
| `NaN` | استاندارد IEEE، کارآمد | مقایسه پیچیده، احتمال باگ |
| `Nullable<T>` | واضح، type-safe | overhead حافظه |
| `Custom Struct` | انعطاف‌پذیر، واضح | کد بیشتر |
```
---

## 6. استاندارد IEEE 754

### نکات کلیدی:

- جنس های `float` و `double` از مشخصات **IEEE 754** پیروی می‌کنند
- تقریباً تمام پردازنده‌ها به صورت سخت‌افزاری از این استاندارد پشتیبانی می‌کنند
- جزئیات بیشتر: [IEEE.org](http://www.ieee.org)

**ویژگی‌های مهم IEEE 754:**

1. **تمثیل یکسان:** در تمام سیستم‌ها یکسان عمل می‌کند
2. نکته » **Rounding modes:** حالت‌های مختلف گرد کردن
3. نکته » **Exception handling:** مدیریت استاندارد overflow/underflow
4. **مقادیر ویژه:** NaN، Infinity، -0

### نمایش باینری (اختیاری برای ارائه پیشرفته):

**Float (32-bit):**

[Sign: 1 bit] [Exponent: 8 bits] [Mantissa: 23 bits]

**Double (64-bit):**

[Sign: 1 bit] [Exponent: 11 bits] [Mantissa: 52 bits]

---

## 7. مثال جامع برای کلاس

```csharp
class FloatingPointDemo
{
static void Main()
{
// 1. تبدیل خودکار short به int
short a = 10, b = 20;
// short c = a + b; // خطا!
short c = (short)(a + b); // صحیح
Console.WriteLine($"c = {c}");

// 2. تقسیم بر صفر
double infinity = 1.0 / 0.0;
Console.WriteLine($"1/0 = {infinity}");

// 3. NaN
double nan = 0.0 / 0.0;
Console.WriteLine($"0/0 = {nan}");
Console.WriteLine($"NaN == NaN: {nan == double.NaN}");  // False!
Console.WriteLine($"IsNaN: {double.IsNaN(nan)}");       // True

// 4. کاربرد عملی
double? temperature = GetTemperature();
if (temperature == null)
{
Console.WriteLine("Sensor error");
}
else if (double.IsNaN(temperature.Value))
{
Console.WriteLine("Invalid reading");
}
else
{
Console.WriteLine($"Temperature: {temperature}°C");
}
}

static double? GetTemperature()
{
// شبیه‌سازی خواندن از سنسور
return 25.5; // یا null، یا double.NaN
}
}
```
---

## 8. سوالات متداول

### سوال 1: چرا short + short نتیجه int می‌دهد؟

نکته »  **A:** به دلایل تاریخی و عملکردی:
- پردازنده‌ها معمولاً عملیات 32-bit را سریع‌تر انجام می‌دهند
- جلوگیری از overflow در محاسبات میانی
- سازگاری با زبان‌های قدیمی‌تر (C/C++)

### سوال 2: چه زمانی باید از NaN استفاده کنیم؟

نکته »  **A:**
- وقتی API با float/double کار می‌کند و null مجاز نیست
- در کتابخانه‌های ریاضی برای نتایج نامعتبر
- برای سازگاری با استانداردهای IEEE 754

### سوال 3: آیا می‌توان NaN را در شرط‌ها استفاده کرد؟

 بله، اما با دقت:**A:**
```csharp
double x = double.NaN;
if (double.IsNaN(x))  // ✅ صحیح
{
// ...
}

if (x == double.NaN)  // ❌ اشتباه - همیشه false
{
// هرگز اجرا نمی‌شود!
}
```
---

## خلاصه برای پایان ارائه

### بخش 8 و 16 بیتی:
1.نکته »  ✅ `byte`, `sbyte`, `short`, `ushort` عملگر مستقل ندارند
2. ✅ تبدیل خودکار به `int` در محاسبات
3. ✅ نیاز به cast صریح برای انتساب نتیجه

### بخش Float/Double:
4. ✅ مقادیر ویژه: `NaN`, `±Infinity`, `-0`
5. ✅ نکته » `NaN == NaN` همیشه `false` است
6. ✅ استفاده از `IsNaN()` برای بررسی
7. ✅ پیروی از استاندارد IEEE 754

### نکته امنیتی:
⚠️ **همیشه از `double.IsNaN()` برای بررسی NaN استفاده کنید، نه از `==`**
