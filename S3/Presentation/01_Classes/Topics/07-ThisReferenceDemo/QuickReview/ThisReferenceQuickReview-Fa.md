<div dir="rtl" style="text-align: right;">

# This Reference - بررسی سریع

## تعریف
`this` کلمه کلیدی است که به نمونه فعلی (Current Instance) کلاس اشاره می‌کند و فقط در متدها، propertyها، indexerها و constructorهای instance قابل استفاده است.

## کاربرد
- رفع ابهام بین پارامترهای متد و فیلدهای کلاس
- ارسال نمونه فعلی به متدهای دیگر
- فراخوانی سایر constructorها (Constructor Chaining)
- بازگرداندن نمونه فعلی برای Fluent Interface
- دسترسی به memberهای instance در صورت پنهان شدن

## نکات کلیدی
- **Instance Only**: فقط در instance members قابل استفاده است، نه در static members
- **Implicit**: در اکثر موارد استفاده از this اختیاری است (کامپایلر خودکار آن را اضافه می‌کند)
- **Disambiguation**: برای تمایز بین پارامترها و فیلدها ضروری است
- **Constructor Chaining**: `this(...)` برای فراخوانی constructor دیگر در همان کلاس
- **Extension Methods**: در پارامتر اول extension method برای مشخص کردن نوع مورد توسعه
- **Fluent Interface**: بازگرداندن `this` برای زنجیره‌ای کردن متدها
- **Indexers**: استفاده در تعریف indexer با `this[...]`
- **Anonymous Functions**: دسترسی به this در lambda expressions و anonymous methods
- **Capturing**: در closures، this می‌تواند capture شود
- **Value Types**: در structها، this یک reference متفاوت دارد (readonly در readonly methods)
- **Read-only Context**: در readonly members، this به صورت readonly است
- **Event Handlers**: استفاده برای subscribe/unsubscribe کردن eventها
