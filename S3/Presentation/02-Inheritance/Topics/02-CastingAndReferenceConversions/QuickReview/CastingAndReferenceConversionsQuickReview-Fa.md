<div dir="rtl" style="text-align: right;">

# تبدیل و کست رفرنس‌ها 

## تعریف
**Casting** تبدیل رفرنس از یک نوع به نوع دیگر در سلسله‌مراتب وراثت است. تبدیل‌های رفرنسی نحوه دسترسی به شی را تغییر می‌دهند، نه خود شی را.

## دو جهت

### 1. Upcasting (مشتق → پایه)
- تبدیل **ضمنی** (نیاز به کست ندارد)
- همیشه **ایمن** - هر شی مشتق یک شی پایه هست
- دسترسی به اعضای ویژه مشتق از دست می‌رود

<div dir="ltr" style="text-align: left;">

```csharp
Dog dog = new Dog();
Animal animal = dog;  // Upcast ضمنی ✅
```

<div dir="rtl" style="text-align: right;">


### 2. Downcasting (پایه → مشتق)
- تبدیل **صریح** (نیاز به کست دارد)
- نیاز به **بررسی زمان اجرا** - ممکن است شکست بخورد
- دسترسی به اعضای ویژه مشتق پیدا می‌کند


<div dir="ltr" style="text-align: left;">

 
```csharp
Animal animal = new Dog();
Dog dog = (Dog)animal;  // Downcast صریح - اگر واقعاً Dog باشد OK
```

<div dir="rtl" style="text-align: right;">


## الگوهای کست ایمن

### استفاده از عملگر `as`
- در صورت شکست `null` برمی‌گرداند (بدون exception)
- فقط با reference type کار می‌کند

<div dir="ltr" style="text-align: left;">


```csharp
Dog? dog = animal as Dog;
if (dog != null)
{
dog.Bark();  // ایمن
}
```

<div dir="rtl" style="text-align: right;">


### استفاده از عملگر `is` با pattern matching
- بررسی نوع + کست در یک مرحله
- رویکرد مدرن C#

<div dir="ltr" style="text-align: left;">


```csharp
if (animal is Dog d)
{
d.Bark();  // d از قبل نوع Dog است
}
```

<div dir="rtl" style="text-align: right;">


### کست مستقیم
- در صورت شکست `InvalidCastException` پرتاب می‌کند
- زمانی استفاده کنید که از نوع مطمئن هستید

<div dir="ltr" style="text-align: left;">


```csharp
Dog dog = (Dog)animal;  // ❌ Exception اگر Dog نباشد
```

<div dir="rtl" style="text-align: right;">

## نکات کلیدی
- **Upcasting**: ضمنی، ایمن، محدود کننده رابط
- **Downcasting**: صریح، پرخطر، توسعه‌دهنده رابط
- **عملگر as**: ایمن، در شکست null برمی‌گرداند
- **عملگر is**: بررسی نوع قبل از دسترسی
- تبدیل‌های رفرنسی شی را تغییر نمی‌دهند، فقط نحوه دسترسی را

## اشتباهات رایج
- Downcast بدون بررسی می‌تواند exception پرتاب کند
- نمی‌توان بین انواع نامرتبط در سلسله‌مراتب کست کرد
- کست کردن شی را تبدیل نمی‌کند، فقط نوع رفرنس را
