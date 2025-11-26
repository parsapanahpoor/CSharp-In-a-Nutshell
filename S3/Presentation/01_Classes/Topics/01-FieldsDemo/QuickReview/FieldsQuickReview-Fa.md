<div dir="rtl" style="text-align: right;">

# Fields - بررسی سریع

## تعریف
Field متغیری است که در سطح کلاس یا Struct تعریف می‌شود و داده‌های مرتبط با آن نوع را نگهداری می‌کند.

## کاربرد
- ذخیره‌سازی وضعیت (State) یک شیء
- نگهداری داده‌های مشترک بین اعضای کلاس
- پیاده‌سازی Properties و Encapsulation
- تعریف متغیرهای Static برای اشتراک‌گذاری بین تمام Instanceها

## نکات کلیدی
- **Instance Fields**: هر شیء کپی جداگانه‌ای دارد (در Heap)
- **Static Fields**: یک کپی مشترک برای تمام Instanceها (در Static Memory)
- **Readonly Fields**: فقط در زمان تعریف یا Constructor قابل مقداردهی
- **Access Modifiers**: private, public, protected, internal, protected internal, private protected
- **Initialization Order**: 1Static fields → 2Instance fields → 3Constructor body
- **Memory Layout**: ترتیب تعریف fields بر حافظه تأثیرگذار است
- **Field Padding**: کامپایلر ممکن است byte اضافه کند برای Alignment
- **StructLayout Attribute**: کنترل چیدمان حافظه (Sequential, Explicit, Auto)
- **const vs readonly**: const در compile-time، readonly در runtime
- **Default Values**: Reference types → null، Value types → zero/default
