# double در مقابل decimal و خطاهای گرد کردن

## 1. مقایسه double و decimal

### جدول مقایسه کامل:
```csharp

| ویژگی | `double` | `decimal` |
|-------|---------|-----------|
| **نمایش داخلی** | Base 2 (باینری) | Base 10 (دهدهی) |
| **دقت اعشاری** | 15-16 رقم معنادار | 28-29 رقم معنادار |
| **محدوده** | $\pm(10^{-324}$ تا $10^{308})$ | $\pm(10^{-28}$ تا $10^{28})$ |
| **مقادیر ویژه** | `+0`, `-0`, `+∞`, `-∞`, `NaN` | ندارد |
| **سرعت** | Native (سخت‌افزاری) | Non-native (~10 برابر کندتر) |
| **اندازه** | 8 bytes | 16 bytes |
| **کاربرد اصلی** | محاسبات علمی | محاسبات مالی |
```

### کد نمایشی:
```csharp
// مقایسه محدوده
Console.WriteLine($"double range: {double.MinValue} to {double.MaxValue}");
Console.WriteLine($"decimal range: {decimal.MinValue} to {decimal.MaxValue}");

// خروجی:
// double range: -1.7976931348623157E+308 to 1.7976931348623157E+308
// decimal range: -79228162514264337593543950335 to 79228162514264337593543950335
```
---

## 2. چه زمان از کدام استفاده کنیم؟

### استفاده از `double`:

✅ **محاسبات علمی و مهندسی:**
```csharp
// محاسبه مختصات فضایی
double latitude = 35.6892;
double longitude = 51.3890;

// فیزیک
double velocity = 299792458.0; // سرعت نور (m/s)
double distance = velocity * time;

// هندسه
double area = Math.PI * radius * radius;
```
✅ **محاسبات گرافیکی و بازی‌سازی:**
```csharp
// موقعیت شخصیت در بازی
double playerX = 125.7;
double playerY = 89.3;
```
### استفاده از `decimal`:

✅ **محاسبات مالی:**
```csharp
decimal price = 19.99m;
decimal tax = 0.09m;
decimal total = price * (1 + tax);
Console.WriteLine($"Total: ${total:F2}"); // Total: $21.79
```
✅ **مقادیر ساخته شده (Manufacturing):**
```csharp
// ابعاد قطعات صنعتی
decimal length = 15.25m;  // cm
decimal width = 10.50m;   // cm
decimal area = length * width; // دقیق
```
✅ **ارزها و حسابداری:**
```csharp
decimal accountBalance = 1000000.00m;
decimal interestRate = 0.05m;
decimal interest = accountBalance * interestRate;
```
---

## 3. خطاهای گرد کردن در اعداد اعشاری (Rounding Errors)

### الف) مشکل نمایش Base 2

**مفهوم کلیدی:** `double` و `float` اعداد را در مبنای 2 (باینری) نمایش می‌دهند، نه مبنای 10.

#### اعدادی که در Base 2 قابل نمایش دقیق هستند:

```csharp
// اعدادی که به صورت دقیق نمایش می‌شوند
float precise1 = 0.5f;   // 1/2 = 2^-1 ✅
float precise2 = 0.25f;  // 1/4 = 2^-2 ✅
float precise3 = 0.125f; // 1/8 = 2^-3 ✅
float precise4 = 0.75f;  // 3/4 = 2^-2 + 2^-1 ✅
```
#### اعدادی که دقیق نیستند:

```csharp
float imprecise1 = 0.1f; // 1/10 نمی‌تواند دقیق در Base 2 نمایش شود ❌
float imprecise2 = 0.3f; // 3/10 ❌
float imprecise3 = 0.7f; // 7/10 ❌

### ب) مثال کلاسیک: 0.1

```csharp
float x = 0.1f; // به جای 0.1 دقیق، مقداری نزدیک به آن ذخیره می‌شود
Console.WriteLine(x + x + x + x + x + x + x + x + x + x);
```
// خروجی: 1.0000001 (به جای 1.0)

**توضیح فنی:**
- $0.1_{10}$ در باینری تبدیل می‌شود به: $0.0001100110011..._2$ (تکرار بی‌نهایت)
- نکته » `float` این مقدار را قطع می‌کند (truncate)
- خطای کوچک در هر عدد، در جمع‌های مکرر انباشته می‌شود

### ج) decimal و دقت در Base 10

```csharp
decimal y = 0.1m;
Console.WriteLine(y + y + y + y + y + y + y + y + y + y);
```
// خروجی: 1.0 (دقیق ✅)

**چرا دقیق است؟**
- نکته `decimal` در Base 10 کار می‌کند
- $0.1_{10}$ به صورت دقیق قابل نمایش است
- همچنین Base 2 و Base 5 (عوامل Base 10) نیز دقیق هستند

---

## 4. اعداد کسری تکرارشونده (Recurring Fractions)

### مشکل مشترک `double` و `decimal`:

```csharp
decimal m = 1M / 6M; // 0.1666666666666666666666666667M
double d = 1.0 / 6.0; // 0.16666666666666666

Console.WriteLine(m); // 28 رقم
Console.WriteLine(d); // 15-16 رقم
```
**نکته:** هر دو نمی‌توانند $\frac{1}{6} = 0.1\overline{6}$ را دقیق نمایش دهند

### تفاوت در دقت:

```csharp
// decimal دقت بیشتری دارد
Console.WriteLine(m.ToString("F28")); 
// 0.1666666666666666666666666667

Console.WriteLine(d.ToString("F28"));
```
// 0.1666666666666666570000000000 (خطا در رقم 17)

---

## 5. خطای انباشته (Accumulated Rounding Errors)

### مثال با decimal:

```csharp
decimal m = 1M / 6M;  // 0.1666666666666666666666666667M
decimal notQuiteWholeM = m + m + m + m + m + m;
Console.WriteLine(notQuiteWholeM); 
// 1.0000000000000000000000000002M

Console.WriteLine(notQuiteWholeM == 1M); // False ❌
```
**تحلیل:**
- تئوری: $6 \times \frac{1}{6} = 1$
- عمل: خطای گرد کردن در هر عملیات جمع
- نتیجه: $1.0000000000000000000000000002$ (تفاوت بسیار کوچک اما موجود)

### مثال با double:

```csharp
double d = 1.0 / 6.0; // 0.16666666666666666
double notQuiteWholeD = d + d + d + d + d + d;
Console.WriteLine(notQuiteWholeD); 
// 0.99999999999999989

Console.WriteLine(notQuiteWholeD < 1.0); // True ❌
```
**خطا بیشتر:** دقت کمتر منجر به خطای بیشتر می‌شود

---

## 6. مشکلات عملیاتی ناشی از خطای گرد کردن

### الف) شکست در عملیات مقایسه:

```csharp
decimal m = 1M / 6M;
decimal sum = m + m + m + m + m + m;

// مقایسه مستقیم شکست می‌خورد
if (sum == 1M)
{
Console.WriteLine("Equal"); // اجرا نمی‌شود!
}
else
{
Console.WriteLine("Not equal"); // اجرا می‌شود
}
```
### ب) مشکل در حلقه‌ها:

```csharp
// خطرناک! ممکن است حلقه بی‌نهایت شود
double value = 0.0;
while (value != 1.0) // ❌ هرگز true نمی‌شود
{
value += 0.1;
if (value > 10.0) break; // محافظ برای جلوگیری از حلقه بی‌نهایت
}
Console.WriteLine(value); // 1.0000000000000009
```
---

## 7. راه‌حل‌ها و Best Practices

### الف) استفاده از Epsilon برای مقایسه:

```csharp
const double EPSILON = 1e-10;

double d = 1.0 / 6.0;
double sum = d + d + d + d + d + d;

// به جای ==
if (Math.Abs(sum - 1.0) < EPSILON)
{
Console.WriteLine("Practically equal"); // اجرا می‌شود ✅
}
```
### ب) متد کمکی برای مقایسه:

```csharp
public static bool AlmostEqual(double a, double b, double epsilon = 1e-10)
{
return Math.Abs(a - b) < epsilon;
}

// استفاده:
double result = 0.1 + 0.2;
Console.WriteLine(AlmostEqual(result, 0.3)); // True
```
### ج) استفاده از decimal برای مالی:

```csharp
// ❌ اشتباه - استفاده از double برای پول
double price = 0.1;
double total = price + price + price; // 0.30000000000000004

// ✅ صحیح - استفاده از decimal
decimal priceM = 0.1m;
decimal totalM = priceM + priceM + priceM; // 0.3 (دقیق)
```
### د) Round کردن نتایج:

```csharp
decimal price = 19.99m;
decimal taxRate = 0.085m;
decimal total = price * (1 + taxRate);

// Round به 2 رقم اعشار برای نمایش پول
decimal rounded = Math.Round(total, 2);
Console.WriteLine($"${rounded:F2}"); // $21.69
```
---

## 8. مثال جامع: سیستم مالی

```csharp
class FinancialCalculator
{
// ❌ اشتباه
public static double CalculateTotalWrong()
{
double[] prices = { 0.1, 0.2, 0.3 };
double total = 0.0;
foreach (var price in prices)
{
total += price;
}
return total; // 0.6000000000000001
}

// ✅ صحیح
public static decimal CalculateTotalCorrect()
{
decimal[] prices = { 0.1m, 0.2m, 0.3m };
decimal total = 0.0m;
foreach (var price in prices)
{
total += price;
}
return total; // 0.6 (دقیق)
}

// مثال کامل
public static void Main()
{
// محاسبه صورت‌حساب
decimal[] items = { 12.99m, 5.49m, 8.75m };
decimal subtotal = 0m;

foreach (var item in items)
{
subtotal += item;
}

decimal taxRate = 0.08m;
decimal tax = subtotal * taxRate;
decimal total = subtotal + tax;

// Round به 2 رقم اعشار
total = Math.Round(total, 2);

Console.WriteLine($"Subtotal: ${subtotal:F2}");
Console.WriteLine($"Tax (8%): ${tax:F2}");
Console.WriteLine($"Total: ${total:F2}");

// Subtotal: $27.23
// Tax (8%): $2.18
// Total: $29.41
}
}
```
---

## 9. مقایسه عملکرد (Performance)

### بنچمارک ساده:

```csharp
using System.Diagnostics;

class PerformanceTest
{
static void Main()
{
const int iterations = 100_000_000;

// تست double
Stopwatch sw1 = Stopwatch.StartNew();
double sumD = 0.0;
for (int i = 0; i < iterations; i++)
{
sumD += 0.1;
}
sw1.Stop();

// تست decimal
Stopwatch sw2 = Stopwatch.StartNew();
decimal sumM = 0.0m;
for (int i = 0; i < iterations; i++)
{
sumM += 0.1m;
}
sw2.Stop();

Console.WriteLine($"double: {sw1.ElapsedMilliseconds}ms");
Console.WriteLine($"decimal: {sw2.ElapsedMilliseconds}ms");
Console.WriteLine($"Ratio: {(double)sw2.ElapsedMilliseconds / sw1.ElapsedMilliseconds:F1}x");

// خروجی تقریبی:
// double: 150ms
// decimal: 1500ms
// Ratio: 10.0x (decimal ~10 برابر کندتر)
}
}
```
---

## 10. نکات پیشرفته

### الف) نمایش داخلی decimal:

```csharp
// decimal در واقع یک struct است با 4 عدد int
// [flags, hi, mid, lo]
decimal d = 123.45m;
int[] bits = decimal.GetBits(d);
Console.WriteLine($"Bits: [{bits[0]}, {bits[1]}, {bits[2]}, {bits[3]}]");
```
### ب) تبدیل بین double و decimal:

```csharp
double d = 0.1;
decimal m = (decimal)d; // تبدیل صریح
Console.WriteLine(m);   // 0.1000000000000000055511151231
```
// خطای double به decimal منتقل می‌شود!

### ج) محدودیت decimal:

```csharp
// decimal نمی‌تواند NaN یا Infinity داشته باشد
try
{
decimal result = 1m / 0m; // DivideByZeroException
}
catch (DivideByZeroException)
{
Console.WriteLine("decimal throws exception on division by zero");
}

// در حالی که double:
double d = 1.0 / 0.0; // Infinity (بدون exception)
```
---

## 11. چک‌لیست تصمیم‌گیری

### استفاده از `double` اگر:
- [ ] محاسبات علمی/مهندسی
- [ ] داده از اندازه‌گیری فیزیکی
- [ ] نیاز به محدوده بسیار بزرگ/کوچک
- [ ] عملکرد بحرانی است
- [ ] نیاز به مقادیر ویژه (NaN, Infinity)

### استفاده از `decimal` اگر:
- [ ] محاسبات مالی
- [ ] ارز، قیمت، مالیات
- [ ] داده ساخته شده (نه اندازه‌گیری)
- [ ] دقت مطلق ضروری
- [ ] مقایسه‌های دقیق لازم

---

## 12. خلاصه برای پایان ارائه

### نکات کلیدی:

1. **Base 2 vs Base 10:**
   - `double`: Base 2 → سریع اما $0.1$ دقیق نیست
   - `decimal`: Base 10 → کند اما $0.1$ دقیق است

2. **خطای گرد کردن:**
   - همیشه وجود دارد (حتی در `decimal` برای کسرهای تکرارشونده)
   - انباشته می‌شود در محاسبات مکرر
   - مقایسه `==` را می‌شکند

3. **راه‌حل‌ها:**
   - استفاده از `decimal` برای مالی
   - مقایسه با Epsilon برای `double`
   - نکته » Round کردن نتایج نهایی

4. **قاعده طلایی:**
```csharp
   // هرگز برای پول از double استفاده نکنید!
   double money = 0.1 + 0.2; // ❌ 0.30000000000000004
   decimal money = 0.1m + 0.2m; // ✅ 0.3
```
