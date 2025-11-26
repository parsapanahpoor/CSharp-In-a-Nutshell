<div dir="rtl" style="text-align: right;">

# Static Constructors - بررسی سریع

## تعریف
Static Constructor نوع خاصی از constructor است که برای مقداردهی اولیه static members یک کلاس استفاده می‌شود و فقط یک‌بار قبل از اولین استفاده از کلاس (ایجاد نمونه یا دسترسی به static member) توسط CLR فراخوانی می‌شود.

## کاربرد
- مقداردهی اولیه static fields
- بارگذاری تنظیمات یا configuration
- ثبت نام (registration) کلاس در سیستم
- اجرای منطق initialization یکبار برای کل کلاس
- مقداردهی پیچیده static readonly fields

## نکات کلیدی
- **Syntax**: بدون access modifier و بدون پارامتر: `static ClassName() { }`
- **Parameterless**: نمی‌تواند پارامتر داشته باشد
- **No Access Modifier**: نمی‌تواند access modifier داشته باشد
- **Single Execution**: فقط یک‌بار در طول عمر AppDomain اجرا می‌شود
- **Thread-Safe**: CLR تضمین می‌کند که thread-safe است
- **Timing**: قبل از اولین instance constructor یا دسترسی به static member اجرا می‌شود
- **Order**: ترتیب اجرا در کلاس‌های مختلف غیرقابل پیش‌بینی است
- **Exception Handling**: اگر exception بیفتد، کلاس غیرقابل استفاده می‌شود (TypeInitializationException)
- **Static Fields**: برای مقداردهی static readonly fields ایده‌آل است
- **Performance**: هزینه اولیه دارد اما فقط یک‌بار
- **Debugging**: دشوار است چون timing دقیق مشخص نیست
