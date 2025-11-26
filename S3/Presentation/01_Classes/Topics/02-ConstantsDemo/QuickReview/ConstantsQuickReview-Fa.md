<div dir="rtl" style="text-align: right;">

# Constants - بررسی سریع

## تعریف
Constant مقداری ثابت است که در زمان Compile-time مشخص می‌شود و در طول اجرای برنامه قابل تغییر نیست.

## کاربرد
- تعریف مقادیر ثابت و غیرقابل تغییر (مثل PI، MaxValue)
- جلوگیری از استفاده مستقیم از اعداد جادویی (Magic Numbers)
- بهبود خوانایی و نگهداری کد
- بهینه‌سازی عملکرد (Inline شدن در Compile-time)

## نکات کلیدی
- **Compile-time Constant**: مقدار در زمان کامپایل مشخص می‌شود
- **Implicitly Static**: همیشه Static هستند (نیازی به کلیدواژه static نیست)
- **Supported Types**: فقط انواع Built-in (int, string, bool, double, ...) و enum - در نسخه ی جدید برای تمام value تایپ ها - با شرط مثال زیر 
- **const vs readonly**: const در compile-time، readonly در runtime
- **Inlining**: کامپایلر مقدار را مستقیماً جایگزین می‌کند
- **No Reference**: نمی‌توان reference به constant گرفت - از کیبورد های ref - out  نمیتوان استفاده کرد
- **Versioning Issue**: تغییر const در یک assembly نیاز به recompile سایر assemblies دارد
- **Local Constants**: می‌توان در متدها نیز تعریف کرد
- **Expression Constants**: می‌توان از عبارات ثابت استفاده کرد (const int x = 5 + 3;)
- **Access Modifiers**: می‌توانند public, private, internal, ... باشند

<div dir="ltr" style="text-align: left;">

```csharp
// ✅ مجاز - اگر value در compile-time محاسبه شود:
const DateTime Date1 = new DateTime(2024, 1, 1);
const TimeSpan Duration = TimeSpan.FromHours(2);

// ❌ غیرمجاز - اگر runtime value باشد:
const DateTime Date2 = DateTime.Now;        // خطا!
const TimeSpan Duration2 = GetDuration();   // خطا!

// ✅ مجاز - default value:
const Guid EmptyGuid = default;
const DateTime MinDate = default;

```