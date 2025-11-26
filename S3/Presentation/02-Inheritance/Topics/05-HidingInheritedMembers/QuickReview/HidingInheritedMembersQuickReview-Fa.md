
<div dir="rtl" style="text-align: right;">

## تعریف
مخفی‌سازی به کلاس مشتق اجازه می‌دهد عضوی با همان نام عضو کلاس پایه تعریف کند، با استفاده از کلیدواژه `new`.

## کاربرد
از `new` برای مخفی کردن عضو پایه استفاده کنید:

<div dir="ltr" style="text-align: left;">

```csharp
public class Base
{
public void Method() => Console.WriteLine("Base");
}

public class Derived : Base
{
public new void Method() => Console.WriteLine("Derived");
}
```

<div dir="rtl" style="text-align: right;">

## نکات کلیدی
- از کلیدواژه `new` برای مخفی کردن اعضا استفاده کنید
- چندریختی ندارد - متد فراخوانی شده به نوع رفرنس بستگی دارد
- اگر `new` حذف شود هشدار کامپایلر تولید می‌شود
- می‌توان متد، property، فیلد، event را مخفی کرد
- عضو پایه همچنان از طریق رفرنس کلاس پایه قابل دسترسی است
- با override متفاوت است - چندریختی زمان اجرا ندارد
- تا جایممکن از virtual/override استفاده کنید