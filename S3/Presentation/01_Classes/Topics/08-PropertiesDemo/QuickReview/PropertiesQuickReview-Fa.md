<div dir="rtl" style="text-align: right;">

# Properties - بررسی سریع

## تعریف
Property مکانیزمی است برای دسترسی به داده‌های یک کلاس با استفاده از Accessors (`get` و `set`) که کپسولاسیون و کنترل دسترسی را فراهم می‌کند.

## کاربرد
- کپسولاسیون فیلدهای private
- اعتبارسنجی مقادیر قبل از تنظیم
- اجرای منطق custom هنگام دسترسی یا تنظیم
- ارائه Interface عمومی ایمن برای داده‌ها
- تبدیل مقادیر یا محاسبات on-demand

## نکات کلیدی
- **Auto Properties**: سینتکس کوتاه `{ get; set; }` بدون backing field
- **Backing Field**: فیلد private پشت property برای ذخیره مقدار
- **Get Accessor**: مسئول بازگرداندن مقدار property
- **Set Accessor**: مسئول تنظیم مقدار property
- **Access Modifiers**: می‌توان برای get و set access modifiers متفاوتی داشت
- **Read-only Property**: فقط getter بدون setter
- **Write-only Property**: فقط setter بدون getter (نادر)
- **Expression-bodied Property**: سینتکس کوتاه با `=>` (C# 6+)
- **Init-only Property**: `{ get; init; }` برای تنظیم فقط در initialization (C# 9+)
- **Required Properties**: با `required` keyword باید حتماً مقداردهی شوند (C# 11+)
- **Property Validation**: اعتبارسنجی در setter
- **Lazy Initialization**: محاسبه مقدار به صورت تنبل (on-demand)
- **Computed Properties**: محاسبه مقدار بر اساس دیگر فیلدها
- **Indexed Properties**: indexer برای دسترسی به عناصر collection
