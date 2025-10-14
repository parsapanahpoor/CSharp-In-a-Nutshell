In C#, predefined types (also referred to as built-in types)
 are recognized with a C# keyword. The System namespace
 in .NET contains many important types that are not prede
fined by C# (e.g., DateTime).


## Custom Types
 In C#, predefined types (also referred to as built-in types)
 are recognized with a C# keyword. The System namespace
 in .NET contains many important types that are not prede
fined by C# (e.g., DateTime).
 Just as we can write our own methods, we can write our own types. In this next
 example, we define a custom type named UnitConverter—a class that serves as a
 blueprint for unit conversions:
 UnitConverter feetToInchesConverter = new UnitConverter (12);
 UnitConverter milesToFeetConverter  = new UnitConverter (5280);
 Console.WriteLine (feetToInchesConverter.Convert(30));    // 360
 Console.WriteLine (feetToInchesConverter.Convert(100));   // 1200
 Console.WriteLine (feetToInchesConverter.Convert(
                   milesToFeetConverter.Convert(1)));     // 63360
 public class UnitConverter
 {
 int ratio;                              // Field
 public UnitConverter (int unitRatio)    // Constructor
 {
 ratio = unitRatio;
 } 
public int Convert (int unit)           // Method
{
 return unit * ratio;
 } 
}


---------------------------------------------------------------------------------------------------------------------------------







در C#، type‌های از پیش تعریف شده (که به آن‌ها built-in types نیز گفته می‌شود) با یک keyword از C# شناسایی می‌شوند. namespace به نام System در NET. شامل بسیاری از type‌های مهم است که توسط C# از پیش تعریف نشده‌اند (برای مثال، DateTime).



## Type‌های سفارشی

همان‌طور که می‌توانیم متدهای خودمان را بنویسیم، می‌توانیم type‌های خودمان را نیز بنویسیم. در این مثال بعدی، یک type سفارشی به نام UnitConverter تعریف می‌کنیم—یک class که به عنوان یک blueprint برای تبدیل واحدها عمل می‌کند:
```csharp
UnitConverter feetToInchesConverter = new UnitConverter (12);
UnitConverter milesToFeetConverter  = new UnitConverter (5280);

Console.WriteLine (feetToInchesConverter.Convert(30));    // 360
Console.WriteLine (feetToInchesConverter.Convert(100));   // 1200
Console.WriteLine (feetToInchesConverter.Convert(
milesToFeetConverter.Convert(1)));     // 63360

public class UnitConverter
{
  int ratio;                              // Field

  public UnitConverter (int unitRatio)    // Constructor
  {
ratio = unitRatio;
  }

  public int Convert (int unit)           // Method
  {
return unit * ratio;
  }
}
```
