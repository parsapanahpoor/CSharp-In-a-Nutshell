
<div dir="rtl" style="text-align: right;">

## تعریف
کلاس‌های abstract قابل نمونه‌سازی نیستند و ممکن است شامل اعضای abstract باشند که باید توسط کلاس‌های مشتق پیاده‌سازی شوند.

## کاربرد
از کلیدواژه `abstract` برای کلاس و اعضا استفاده کنید:

<div dir="ltr" style="text-align: left;">


```csharp
public abstract class Animal
{
public abstract void MakeSound();  // بدون پیاده‌سازی
public void Eat() { }              // می‌تواند متد معمولی داشته باشد
}

public class Dog : Animal
{
public override void MakeSound() => Console.WriteLine("Woof");
}
```

<div dir="rtl" style="text-align: right;">

## نکات کلیدی
- کلاس‌های abstract مستقیماً قابل نمونه‌سازی نیستند
- اعضای abstract پیاده‌سازی ندارند
- کلاس‌های مشتق باید تمام اعضای abstract را پیاده‌سازی کنند
- می‌تواند هم abstract و هم معمولی داشته باشد
- متدهای abstract به صورت ضمنی virtual هستند
- نمی‌تواند sealed باشد
- می‌تواند سازنده برای کلاس‌های مشتق داشته باشد
- زمانی استفاده کنید که کد با پیاده‌سازی ناقص مشترک است
