Namespace Hierarchy

```csharp
System                    // Root namespace
System.Text              // برای مدیریت متن
System.IO                // برای Input/Output
System.Collections       // برای مجموعه‌ها
```
توضیح: Namespace‌ها مثل پوشه‌های تو در تو برای سازماندهی کلاس‌ها هستند.

--------------------------------------------------------------------------------------------------------------------------------------

Using Directive

```csharp
using
System.Console.WriteLine("Hello");

// با using
using System;
Console.WriteLine("Hello");  // ساده‌تر و خواناتر
```
توضیح: using باعث می‌شود نیازی به تکرار namespace در هر خط نباشد.

--------------------------------------------------------------------------------------------------------------------------------------

Parameters vs Arguments

```csharp
int FeetToInches(int feet)  // feet = Parameter (در تعریف)
{
    return feet * 12;
}

Console.WriteLine(FeetToInches(30));  // 30 = Argument (در فراخوانی)
Console.WriteLine(FeetToInches(100)); // 100 = Argument
```
تفاوت:

Parameter: متغیر در تعریف متد
Argument: مقدار واقعی در فراخوانی

--------------------------------------------------------------------------------------------------------------------------------------

Function Types در C#

```csharp
// 1. Method
int Add(int a, int b) { return a + b; }

// 2. Operator
int x = 5 + 3;  // عملگر +

// 3. Constructor (فصل‌های بعد)
// 4. Property (فصل‌های بعد)
// 5. Event (فصل‌های بعد)
// 6. Indexer (فصل‌های بعد)
// 7. Finalizer (فصل‌های بعد)
```

توضیح: Method تنها نوع function نیست، انواع دیگری هم وجود دارند.

--------------------------------------------------------------------------------------------------------------------------------------

















