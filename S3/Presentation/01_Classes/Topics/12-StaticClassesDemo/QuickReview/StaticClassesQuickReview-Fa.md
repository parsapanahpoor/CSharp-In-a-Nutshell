<div dir="rtl" style="text-align: right;">

# Static Classes - بررسی سریع

## تعریف
Static Class نوع خاصی از کلاس است که فقط شامل static members است، نمی‌توان از آن نمونه (instance) ساخت و نمی‌تواند به عنوان کلاس پایه استفاده شود. با کلیدواژه `static` قبل از `class` تعریف می‌شود.

## کاربرد
- ایجاد utility و helper methods
- ساخت extension methods (باید static class باشد)
- گروه‌بندی متدهای مرتبط بدون نیاز به state
- ایجاد factory methods
- کتابخانه‌های mathematical یا conversion functions

## نکات کلیدی
- **Definition**: با `static class` تعریف می‌شود
- **No Instantiation**: نمی‌توان با `new` از آن نمونه ساخت
- **Only Static Members**: فقط می‌تواند static members داشته باشد
- **Sealed**: به صورت implicit sealed است (نمی‌توان از آن ارث برد)
- **No Inheritance**: نمی‌تواند از کلاس دیگری ارث ببرد (جز Object)
- **No Instance Constructor**: نمی‌تواند instance constructor داشته باشد
- **Static Constructor**: می‌تواند static constructor داشته باشد
- **Extension Methods**: باید در static class تعریف شوند
- **Thread-Safety**: باید برای thread-safety مراقب shared state بود
- **Namespaces**: معمولاً برای سازماندهی در namespace‌ها استفاده می‌شود
- **Examples**: `Math`, `Console`, `File`, `Path`, `Convert`
- **Design Pattern**: جایگزین Singleton در برخی سناریوها
- **Testing**: testing دشوارتر است (نمی‌توان mock کرد)
- **Dependency Injection**: با DI سازگار نیست
- **Performance**: overhead کمتری نسبت به instance methods دارد
