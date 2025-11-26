<div dir="rtl" style="text-align: right;">

# Indexers - بررسی سریع

## تعریف
Indexer نوع خاصی از property است که به یک شیء امکان می‌دهد مانند آرایه با استفاده از نماد `[]` قابل دسترسی باشد و به آن Array-like Access می‌گویند.

## کاربرد
- دسترسی به عناصر داخلی کلاس با سینتکس آرایه‌ای
- پیاده‌سازی collection-like behavior
- کپسولاسیون دسترسی به ساختارهای داده داخلی
- ارائه interface شهودی برای دسترسی به داده‌ها
- پیاده‌سازی matrix، dictionary یا ساختارهای سفارشی

## نکات کلیدی
- **Syntax**: تعریف با `this[type index]` به جای نام property
- **Parameters**: می‌تواند چندین پارامتر با انواع مختلف داشته باشد
- **Get/Set Accessors**: مشابه property دارای get و set است
- **Overloading**: امکان overload با تعداد یا نوع پارامترهای متفاوت
- **Read-only Indexer**: فقط با get accessor
- **Write-only Indexer**: فقط با set accessor (نادر)
- **Multiple Parameters**: `this[int x, int y]` برای ماتریس‌ها
- **Different Types**: پارامتر می‌تواند string، int یا هر نوع دیگری باشد
- **Expression-bodied**: سینتکس کوتاه با `=>` برای read-only
- **Range/Index Support**: پشتیبانی از `Range` و `Index` (C# 8+)
- **Null Handling**: بررسی null در setter/getter
- **Performance**: در نظر گرفتن هزینه lookup برای دسترسی
- **Interface Implementation**: می‌تواند در interface تعریف شود
- **Inheritance**: قابل virtual، override و abstract بودن است
