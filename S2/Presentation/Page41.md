## مقایسه Top-Level Statements vs متد Main
روش مدرن: Top-Level Statements (C# 9+)

```csharp
using System;

// مستقیماً شروع می‌کنیم - بدون class و Main
int x = 12 * 30;
Console.WriteLine(x);  // 360
```
ویژگی‌ها:
 کد کوتاه‌تر و ساده‌تر
 مناسب برای برنامه‌های کوچک و اسکریپت‌ها
 کامپایلر به صورت خودکار Main می‌سازد
روش سنتی: متد Main
```csharp
using System;

class Program
{
    static void Main()   // نقطه ورود برنامه
    {
        int x = 12 * 30;
        Console.WriteLine(x);  // 360
    }
}
```
ویژگی‌ها:

 کنترل بیشتر
 استاندارد در پروژه‌های بزرگ
 سازگاری با نسخه‌های قدیمی C#
-----------------------------------------------------------------------------------------------------------------

چرا متد Main استاتیک است ؟ 
توضیح:

دات نت CLR قبل از ایجاد هر شی، باید entry point را پیدا کند
متد static بدون نیاز به شی قابل فراخوانی است
پس Main باید static باشد

 -----------------------------------------------------------------------------------------------------------------

 ## قوانین تعریف Main
قانون 1: محل تعریف
// ✅ می‌تواند در هر class باشد
```csharp
class Program
{
    static void Main() { }
}

// یا
class Application
{
    static void Main() { }
}

// یا
namespace MyApp
{
    class Startup
    {
        static void Main() { }
    }
}
```
قانون 2: فقط یک Main

// ❌ خطا: دو entry point
```csharp

class Program
{
    static void Main() { }
}

class Application
{
    static void Main() { }  // خطای کامپایل
}
```
خطای کامپایل:

error CS0017: Program has more than one entry point defined

راه‌حل: مشخص کردن entry point در فایل پروژه
```csharp

<PropertyGroup>
    <StartupObject>MyNamespace.Program</StartupObject>
</PropertyGroup>

```

## امضاهای مختلف Main
امضا 1: بدون پارامتر، بدون بازگشت

```csharp

static void Main()
{
    Console.WriteLine("Simple Main");
}
```

استفاده: برنامه‌های ساده که به command-line arguments نیاز ندارند.

امضا 2: با پارامتر args

```csharp

static void Main(string[] args)
{
    Console.WriteLine($"Arguments count: {args.Length}");
    
    foreach (string arg in args)
    {
        Console.WriteLine($"Argument: {arg}");
    }
}
```

استفاده: دریافت ورودی از command line

مثال اجرا:


```csharp
dotnet run arg1 arg2 arg3
خروجی:

Arguments count: 3

Argument: arg1

Argument: arg2

Argument: arg3
```

امضا 3: با Return Type (int)

```csharp

static int Main()
{
    try
    {
        // منطق برنامه
        Console.WriteLine("Success");
        return 0;  // موفقیت
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
        return 1;  // خطا
    }
}
```
استفاده: برگرداندن Exit Code به سیستم‌عامل

قرارداد:

0 = موفقیت
غیر 0 = خطا (معمولاً 1, 2, …)
امضا 4: کامل (با پارامتر و Return)

```csharp
static int Main(string[] args)
{
    if (args.Length == 0)
    {
        Console.WriteLine("No arguments provided");
        return 1;  // خطا
    }
    
    Console.WriteLine($"Processing {args.Length} arguments");
    // منطق پردازش...
    
    return 0;  // موفقیت
}
```

نکته: کامپایلر در پشت‌صحنه Top-Level Statements را به یک متد Main تبدیل می‌کند.


## مثال پیشرفته: برنامه Calculator

```csharp

using System;

class Calculator
{
    static int Main(string[] args)
    {
        // بررسی تعداد آرگومان‌ها
        if (args.Length != 3)
        {
            Console.WriteLine("Usage: Calculator <number1> <operator> <number2>");
            Console.WriteLine("Example: Calculator 10 + 5");
            return 1;
        }
        
        try
        {
            // پارس کردن ورودی‌ها
            double num1 = double.Parse(args[0]);
            string op = args[1];
            double num2 = double.Parse(args[2]);
            
            // محاسبه
            double result = Calculate(num1, op, num2);
            
            // نمایش نتیجه
            Console.WriteLine($"{num1} {op} {num2} = {result}");
            return 0;
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid number format");
            return 2;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero");
            return 3;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return 99;
        }
    }
    
    static double Calculate(double a, string op, double b)
    {
        return op switch
        {
            "+" => a + b,
            "-" => a - b,
            "*" => a * b,
            "/" => a / b,
            _ => throw new ArgumentException($"Unknown operator: {op}")
        };
    }
}

```

نحوه اجرا:


```csharp
# جمع
dotnet run 10 + 5
# خروجی: 10 + 5 = 15
# Exit Code: 0

# تقسیم بر صفر
dotnet run 10 / 0
# خروجی: Error: Division by zero
# Exit Code: 3

# فرمت نادرست
dotnet run abc + 5
# خروجی: Error: Invalid number format
# Exit Code: 2

# آرگومان کم
dotnet run 10 +
# خروجی: Usage: Calculator <number1> <operator> <number2>
# Exit Code: 1
```


<img width="913" height="303" alt="image" src="https://github.com/user-attachments/assets/54d5c50a-072b-4504-b72f-b90f5e2f57af" />


  ## نکات مهم
1. استفاده از static اجباری است

```csharp

// ❌ خطا
class Program
{
    void Main() { }  // باید static باشد
}
```

2. نام باید Main باشد (حساس به حروف بزرگ/کوچک)

```csharp

// ❌ خطا
class Program
{
    static void main() { }   // 'm' کوچک
    static void MAIN() { }   // همه بزرگ
}
```

3. فقط یک Main مجاز است

```csharp

// ❌ خطا: دو Main در یک برنامه
```

4.استفاده از async Main نیز مجاز است (C# 7.1+)

```csharp

using System;
using System.Threading.Tasks;

class Program
{
    static async Task<int> Main(string[] args)
    {
        await Task.Delay(1000);
        Console.WriteLine("Done");
        return 0;
    }
}
```

## خلاصه نهایی

```csharp

// ===== Top-Level Statements (C# 9+) =====
using System;
Console.WriteLine("Modern way");


// ===== Traditional Main Method =====
using System;

class Program
{
    // امضاهای مختلف:
    static void Main()                    // ساده
    static void Main(string[] args)       // با آرگومان
    static int Main()                     // با Exit Code
    static int Main(string[] args)        // کامل
    {
        // Entry point برنامه
        // فقط یک Main در کل برنامه
        // باید static باشد
    }
}


// ===== مثال کاربردی =====
static int Main(string[] args)
{
    if (args.Length == 0)
    {
        Console.WriteLine("Usage: app [args]");
        return 1;  // خطا
    }
    
    Console.WriteLine($"Processing {args.Length} arguments");
    return 0;  // موفقیت
}

```

