<div dir="rtl" style="text-align: right;">

# Finalizers - بررسی سریع

## تعریف
Finalizer (یا Destructor) متد خاصی است که توسط Garbage Collector قبل از آزادسازی حافظه یک object فراخوانی می‌شود. با سینتکس `~ClassName()` تعریف می‌شود و برای cleanup منابع unmanaged استفاده می‌شود.

## کاربرد
- آزادسازی منابع unmanaged (file handles، network connections، native memory)
- cleanup در کلاس‌هایی که IDisposable ندارند
- safety net برای مواردی که Dispose فراخوانی نشده
- نوشتن کد دفاعی برای resource management
- کار با native interop و P/Invoke

## نکات کلیدی
- **Syntax**: `~ClassName() { }` - شبیه C++ destructor
- **Non-Deterministic**: زمان دقیق اجرا مشخص نیست (توسط GC تعیین می‌شود)
- **No Parameters**: نمی‌تواند پارامتر داشته باشد
- **No Access Modifier**: نمی‌تواند access modifier داشته باشد
- **No Overloading**: فقط یک finalizer در هر کلاس
- **Performance Impact**: عملکرد GC را کاهش می‌دهد (نسل بعدی می‌رود)
- **Finalization Queue**: objects با finalizer در صف finalization قرار می‌گیرند
- **Gen2**: باعث ارتقا object به Generation 2 می‌شود
- **IDisposable Pattern**: باید همراه با IDisposable پیاده‌سازی شود
- **SafeHandle**: جایگزین بهتر برای اکثر سناریوها
- **GC.SuppressFinalize**: باید در Dispose فراخوانی شود
- **No Inheritance**: در struct نمی‌توان داشت
- **Exception Handling**: exception در finalizer خطرناک است
- **Resource Cleanup**: فقط برای unmanaged resources
