<div dir="rtl" style="text-align: right;">

## تعریف
**Polymorphism** یعنی "اشکال متعدد" - توانایی اشیا برای گرفتن فرم‌های مختلف. یک رابط واحد می‌تواند انواع زیرین مختلف را نمایش دهد.

## دو نوع

### 1. چندریختی ایستا (زمان کامپایل)
- **Overloading متد**: نام یکسان، پارامترهای متفاوت
- **Overloading عملگر**: رفتار سفارشی برای عملگرها
- در **زمان کامپایل** تعیین می‌شود


<div dir="ltr" style="text-align: left;">

```csharp
class Math
{
public int Add(int a, int b) => a + b;
public double Add(double a, double b) => a + b;  // Overload شده
}
```

<div dir="rtl" style="text-align: right;">

### 2. چندریختی پویا (زمان اجرا)
- **Override متد**: `virtual` در پایه، `override` در مشتق
- در **زمان اجرا** بر اساس نوع واقعی شی تعیین می‌شود
- چندریختی واقعی از طریق رفرنس پایه


<div dir="ltr" style="text-align: left;">

```csharp
class Animal
{
public virtual void Speak() => Console.WriteLine("صدای حیوان");
}

class Dog : Animal
{
public override void Speak() => Console.WriteLine("پارس!");
}

Animal a = new Dog();
a.Speak();  // خروجی: "پارس!" (تصمیم زمان اجرا)

```

<div dir="rtl" style="text-align: right;">

## نکات کلیدی
- **متدهای virtual** چندریختی زمان اجرا را فعال می‌کنند
- **رفرنس پایه** می‌تواند شی مشتق نگه دارد
- **نوع واقعی** تعیین‌کننده متد اجرایی است
- برای کد توسعه‌پذیر و قابل نگهداری قدرتمند است

## مزایا
- کد نویسی بر اساس رابط‌ها، نه پیاده‌سازی‌ها
- توسعه آسان با انواع جدید
- کاهش وابستگی، افزایش انعطاف