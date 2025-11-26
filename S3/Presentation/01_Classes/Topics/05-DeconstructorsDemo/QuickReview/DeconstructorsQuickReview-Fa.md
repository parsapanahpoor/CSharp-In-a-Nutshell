<div dir="rtl" style="text-align: right;">

# Deconstructors - بررسی سریع

## تعریف
Deconstructor متدی ویژه با نام `Deconstruct` است که به شما امکان می‌دهد یک شیء را به اجزای تشکیل‌دهنده‌اش تجزیه (Deconstruct) کنید و مقادیر آن را در متغیرهای جداگانه قرار دهید.

## کاربرد
- استخراج چندین مقدار از یک شیء به صورت همزمان
- تجزیه Tuples و انواع سفارشی
- ساده‌سازی کد هنگام کار با اشیاء پیچیده
- ایجاد سینتکس خواناتر برای دسترسی به اجزای شیء

## نکات کلیدی
- **نام ثابت**: نام متد باید حتماً `Deconstruct` باشد
- **Return Type**: باید void باشد
- **Out Parameters**: همه پارامترها باید با modifier `out` باشد
- **Overloading**: می‌توان چند Deconstruct با تعداد پارامترهای متفاوت داشت
- **Syntax**: استفاده از `var (x, y, z) = obj` یا `(var x, var y, var z) = obj`
- **Discards**: استفاده از `_` برای نادیده گرفتن مقادیر غیرضروری
- **Extension Methods**: می‌توان Deconstructor را به صورت Extension Method برای انواع موجود اضافه کرد
- **Tuple Deconstruction**: Tuples به صورت پیش‌فرض قابلیت Deconstruct دارند
- **Compiler Support**: کامپایلر به صورت خودکار متد Deconstruct را فراخوانی می‌کند
- **Multiple Values**: می‌توان 2 یا بیشتر مقدار را برگرداند
- **Type Safety**: همه مقادیر strongly-typed هستند
- **Pattern Matching**: قابل استفاده در positional patterns (C# 8+)
