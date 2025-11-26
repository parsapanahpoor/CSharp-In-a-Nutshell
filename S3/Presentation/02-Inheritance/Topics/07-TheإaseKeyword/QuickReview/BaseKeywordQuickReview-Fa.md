<div dir="rtl" style="text-align: right;">


## تعریف
کلیدواژه `base` به اعضای کلاس پایه از داخل کلاس مشتق دسترسی می‌دهد.

## کاربرد
سازنده، متد یا property کلاس پایه را فراخوانی کنید:

<div dir="ltr" style="text-align: left;">


```csharp
public class Base
{
public Base(int x) { }
public virtual void Method() { }
}

public class Derived : Base
{
public Derived(int x) : base(x) { }  // فراخوانی سازنده پایه

public override void Method()
{
base.Method();  // فراخوانی متد پایه
}
}
```

<div dir="rtl" style="text-align: right;">

## نکات کلیدی
- دسترسی به اعضای کلاس پایه از کلاس مشتق
- از `: base()` برای فراخوانی سازنده پایه استفاده کنید
- از `base.Method()` برای فراخوانی متدهای پایه استفاده کنید
- ضروری است وقتی پایه سازنده بدون پارامتر ندارد
- در متدهای static قابل استفاده نیست
- برای توسعه قابلیت‌های پایه مفید است
- در متدهای override رایج است

