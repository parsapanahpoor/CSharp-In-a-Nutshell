<div dir="rtl" style="text-align: right;">

## تعریف
اعضای virtual به کلاس‌های مشتق اجازه بازنویسی رفتار کلاس پایه را می‌دهند و چندریختی زمان اجرا را فعال می‌کنند.

## کاربرد
متد/property را در کلاس پایه با `virtual` مشخص کنید، در مشتق از `override` استفاده کنید:

<div dir="ltr" style="text-align: left;">

```csharp
public class Shape
{
public virtual double Area => 0;
}

public class Circle : Shape
{
public double Radius { get; set; }
public override double Area => Math.PI * Radius * Radius;
}
```

<div dir="rtl" style="text-align: right;">

## نکات کلیدی
- اعضای virtual پیاده‌سازی پیش‌فرض دارند
- Override رفتار را برای انواع مشتق تغییر می‌دهد
- از `base.Method()` برای فراخوانی پیاده‌سازی والد استفاده کنید
- نمی‌توان اعضای غیر virtual را override کرد
- باید امضا دقیقاً یکسان باشد
- متدهای static نمی‌توانند virtual باشند
- سربار جزئی عملکرد به دلیل جستجوی زمان اجرا
