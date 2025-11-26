<div dir="rtl" style="text-align: right;">

# Primary Constructors - بررسی سریع

## تعریف
Primary Constructor ویژگی C# 12 است که اجازه می‌دهد پارامترهای constructor را مستقیماً در تعریف کلاس یا struct بنویسیم و به جای نوشتن constructor جداگانه، از سینتکس مختصرتری استفاده کنیم.

## کاربرد
- کاهش boilerplate code در تعریف کلاس‌ها
- دسترسی مستقیم به پارامترهای constructor در همه members
- ساده‌سازی dependency injection
- جایگزینی برای auto-properties در سناریوهای ساده
- کاهش تعداد خطوط کد در کلاس‌های ساده

## نکات کلیدی
- **Syntax**: پارامترها بعد از نام کلاس: `class MyClass(int x, string y)`
- **Scope**: پارامترها در scope تمام members کلاس قابل دسترسی هستند
- **No Backing Fields**: پارامترها به صورت خودکار backing field ندارند
- **Capture**: پارامترها در صورت استفاده در members، capture می‌شوند
- **Records**: در record types از C# 9 قبلاً وجود داشت
- **Classes/Structs**: از C# 12 برای class و struct نیز قابل استفاده است
- **Additional Constructors**: می‌توان constructor‌های اضافی با `this()` داشت
- **Field Initialization**: می‌توان از پارامترها برای مقداردهی فیلدها استفاده کرد
- **Property Initialization**: می‌توان در object initializer یا property از آنها استفاده کرد
- **Validation**: می‌توان از field initializer یا property برای اعتبارسنجی استفاده کرد
- **Performance**: پارامترهای استفاده نشده ممکن است overhead ایجاد کنند
- **Readability**: برای کلاس‌های ساده خوانایی را افزایش می‌دهد
- **Base Constructor**: با `base(...)` می‌توان constructor کلاس پایه را فراخواند
