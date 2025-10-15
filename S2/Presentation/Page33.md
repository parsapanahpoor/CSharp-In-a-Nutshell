## Compilation Process
Source Code (.cs files) → Compiler → Assembly (.dll or .exe)

توضیح: کامپایلر فایل‌های .cs را به assembly تبدیل می‌کند.

## Assembly Types

```csharp
// Application Assembly
// - دارای Entry Point
// - Console یا Windows
// - قابل اجرا

// Library Assembly  
// - بدون Entry Point
// - برای استفاده توسط دیگران
// - غیرقابل اجرا
```

تفاوت:

Application: برنامه مستقل قابل اجرا
Library: مجموعه کدهای قابل استفاده مجدد (مثل .dll)


## Entry Point

```csharp
// روش 1: Top-level statements (جدید - C# 9+)
Console.WriteLine("Hello");  // خود به خود entry point است

// روش 2: Main Method (سنتی)
class Program
{
    static void Main(string[] args)  // Entry point صریح
    {
        Console.WriteLine("Hello");
    }
}
```

توضیح: Entry point نقطه شروع اجرای برنامه است.

## فایل‌های خروجی در .NET 8
MyApp.dll ← Assembly اصلی (همیشه)

MyApp.exe ← Native loader (مخصوص پلتفرم)

نکته مهم: در .NET 8 فایل اصلی .dll است، نه .exe



## Deployment Models

Self-Contained Deployment
MyApp.exe

├── MyApp.dll

├── System.dll

├── … (تمام runtime)

مزیت: نیازی به نصب .NET روی سیستم نیست

AOT (Ahead-of-Time Compilation)
MyApp.exe ← کد native از پیش کامپایل شده

مزایا:

Startup سریع‌تر
مصرف حافظه کمتر

