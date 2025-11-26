<div dir="rtl" style="text-align: right;">


## تعریف
`sealed` از ارث‌بری بیشتر کلاس‌ها یا بازنویسی متدها جلوگیری می‌کند.

## کاربرد
کلاس یا متدهای override را مهر کنید:

<div dir="ltr" style="text-align: left;">

```csharp
public sealed class FinalClass { }  // قابل ارث‌بری نیست

public class Base
{
public virtual void Method() { }
}

public class Derived : Base
{
public sealed override void Method() { }  // دیگر قابل override نیست
}
```

<div dir="rtl" style="text-align: right;">


## نکات کلیدی
- کلاس‌های sealed قابل ارث‌بری نیستند
- متدهای sealed در کلاس‌های مشتق قابل override نیستند
- باید `sealed` را با `override` استفاده کنید
- نمی‌توان متدهای غیر virtual یا غیر override را seal کرد
- مزیت عملکرد - بهینه‌سازی کامپایلر
- `System.String` یک کلاس sealed است
- برای امنیت یا یکپارچگی طراحی استفاده کنید