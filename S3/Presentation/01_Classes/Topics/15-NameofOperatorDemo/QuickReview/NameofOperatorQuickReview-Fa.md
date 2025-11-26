<div dir="rtl" style="text-align: right;">

# nameof Operator - بررسی سریع

## تعریف
Operator `nameof` یک اپراتور compile-time است که نام یک متغیر، type، یا member را به صورت string برمی‌گرداند. این کار refactoring-safe است و از hard-coded strings جلوگیری می‌کند.

## کاربرد
- اعتبارسنجی پارامترها (argument validation)
- پیاده‌سازی INotifyPropertyChanged
- logging و exception messages
- attribute arguments
- MVC action names
- dependency injection registration
- serialization property names
- raising events با نام property

## نکات کلیدی
- **Syntax**: `nameof(variable)` یا `nameof(Type.Member)`
- **Compile-Time**: در زمان compile به string تبدیل می‌شود
- **Refactoring-Safe**: با rename در IDE به‌روز می‌شود
- **No Runtime Cost**: هیچ overhead در runtime ندارد
- **Simple Name**: فقط نام ساده را برمی‌گرداند (نه fully qualified)
- **Generic Types**: با generic types کار می‌کند
- **Members**: می‌تواند نام method، property، field و ... را برگرداند
- **Parameters**: می‌تواند نام پارامترها را برگرداند
- **Local Variables**: با متغیرهای local کار می‌کند
- **Expression Body**: در expression-bodied members مفید است
- **ArgumentNullException**: ایده‌آل برای throw کردن با نام پارامتر
- **CallerArgumentExpression**: در C# 10+ گزینه جدید برای validation
- **INotifyPropertyChanged**: جایگزین magic strings
- **No Type Checking**: فقط نام را برمی‌گرداند، type safety ندارد
- **Case Sensitive**: حساس به حروف بزرگ و کوچک است
