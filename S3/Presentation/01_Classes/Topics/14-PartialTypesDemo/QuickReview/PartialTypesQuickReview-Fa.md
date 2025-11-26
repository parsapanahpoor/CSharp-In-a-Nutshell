<div dir="rtl" style="text-align: right;">

# Partial Types and Methods - بررسی سریع

## تعریف
Partial Types امکان تقسیم تعریف یک کلاس، struct، interface یا record به چند فایل مختلف را فراهم می‌کند. Partial Methods نیز امکان تعریف یک متد در یک بخش و پیاده‌سازی آن در بخش دیگر را می‌دهند. با کلیدواژه `partial` تعریف می‌شوند.

## کاربرد
- جداسازی generated code از user code
- کار تیمی روی یک کلاس بزرگ
- سازماندهی کد در فایل‌های منطقی
- designer-generated code (Windows Forms، WPF)
- separation of concerns در کلاس‌های پیچیده
- code generation scenarios

## نکات کلیدی
- **Syntax**: `partial class ClassName { }`
- **Multiple Files**: می‌توان در چند فایل مختلف تعریف کرد
- **Same Assembly**: همه بخش‌ها باید در یک assembly باشند
- **Merge at Compile**: در زمان compile به هم متصل می‌شوند
- **Access Modifiers**: باید در همه بخش‌ها یکسان باشد
- **Base Class**: فقط در یک بخش می‌توان base class را مشخص کرد (یا در همه یکسان باشد)
- **Interfaces**: می‌توان در بخش‌های مختلف interface‌های متفاوت پیاده‌سازی کرد
- **Attributes**: attributes از همه بخش‌ها ترکیب می‌شوند
- **Generic Types**: می‌توان partial generic types داشت
- **Partial Methods**: متدی که در یک بخش تعریف و در بخش دیگر پیاده‌سازی می‌شود
- **Optional Implementation**: پیاده‌سازی partial method اختیاری است (pre-C# 9)
- **C# 9 Changes**: partial methods می‌توانند return type و access modifier داشته باشند
- **Code Generation**: ایده‌آل برای source generators
- **Designer Support**: استفاده در Visual Studio designers
- **Nested Types**: می‌توان nested partial types داشت
