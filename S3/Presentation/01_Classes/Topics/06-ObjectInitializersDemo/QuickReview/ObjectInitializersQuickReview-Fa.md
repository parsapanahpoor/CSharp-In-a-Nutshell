<div dir="rtl" style="text-align: right;">

# Object Initializers - بررسی سریع

## تعریف
Object Initializer سینتکسی است که به شما امکان می‌دهد بلافاصله بعد از فراخوانی Constructor، مقادیر propertyها یا فیلدهای قابل دسترس یک شیء را مقداردهی کنید، همه در یک عبارت.

## کاربرد
- مقداردهی اولیه propertyها در زمان ایجاد شیء
- کاهش نیاز به constructorهای متعدد با پارامترهای مختلف
- ایجاد کد خواناتر و مختصرتر
- تنظیم چندین property به صورت همزمان

## نکات کلیدی
- **Syntax**: استفاده از `{ Property = value, ... }` بعد از constructor
- **Accessible Members**: فقط propertyها و فیلدهای public و قابل نوشتن (writable) قابل استفاده هستند
- **Constructor Call**: ابتدا constructor اجرا می‌شود، سپس initializer
- **No Parameterless Constructor**: اگر constructor پارامتری داشته باشد، باید آن را فراخوانی کنید
- **Nested Initializers**: می‌توان propertyهای تودرتو را نیز مقداردهی کرد
- **Collection Initializers**: ترکیب با Collection Initializer برای مقداردهی لیست‌ها
- **Anonymous Types**: استفاده در تعریف Anonymous Types
- **Init-only Properties**: با `init` accessor فقط در زمان initialization قابل تنظیم هستند (C# 9+)
- **Required Members**: با `required` keyword باید حتماً مقداردهی شوند (C# 11+)
- **Order Independent**: ترتیب مقداردهی propertyها اهمیتی ندارد
- **Compile-time Check**: کامپایلر وجود property را بررسی می‌کند
- **No Side Effects**: بهتر است propertyها در initializer عوارض جانبی نداشته باشند
