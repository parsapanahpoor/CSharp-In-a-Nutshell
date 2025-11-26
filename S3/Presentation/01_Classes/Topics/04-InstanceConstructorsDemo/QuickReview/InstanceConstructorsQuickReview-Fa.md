<div dir="rtl" style="text-align: right;">

# Instance Constructors - بررسی سریع

## تعریف
Constructor متدی ویژه است که هنگام ایجاد یک نمونه (Instance) از کلاس فراخوانی می‌شود و برای مقداردهی اولیه شیء استفاده می‌شود.

## کاربرد
- مقداردهی اولیه فیلدها و propertyها
- اجرای منطق لازم هنگام ایجاد شیء
- اعتبارسنجی پارامترهای ورودی
- تنظیم وضعیت اولیه (Initial State) شیء

## نکات کلیدی
- **نام یکسان با کلاس**: نام constructor باید دقیقاً مثل نام کلاس باشد
- **بدون Return Type**: حتی void هم ندارند
- **Default Constructor**: اگر هیچ constructor تعریف نشود، کامپایلر یک parameterless constructor ایجاد می‌کند
- **Constructor Overloading**: می‌توان چند constructor با پارامترهای متفاوت داشت
- **Constructor Chaining**: استفاده از this() برای فراخوانی constructor دیگر
- **Base Class Constructor**: استفاده از base() برای فراخوانی constructor کلاس پایه
- **Execution Order**: Base constructor → Field initializers → Constructor body
- **Access Modifiers**: public, private, protected, internal, ...
- **Private Constructor**: برای Singleton Pattern یا Static-only classes
- **Expression-bodied Constructor**: سینتکس کوتاه‌تر با => (C# 7+)
- **Object Initializers**: مقداردهی propertyها بعد از constructor با { }
- **Required Members**: استفاده از required keyword (C# 11+)
