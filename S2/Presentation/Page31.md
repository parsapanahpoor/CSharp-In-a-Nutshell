ساختار پایه‌ای برنامه
نکات فنی:

ترجمه :Statement: واحد اجرایی کوچکترین دستور در C#


ترجمه :Semicolon (;): جداکننده اجباری statements


ترجمه :Sequential Execution: اجرای خط به خط از بالا به پایین
```csharp
int x = 12 * 30;                  // Statement 1: Declaration + Assignment + Expression
System.Console.WriteLine(x);      // Statement 2: Method Call
```
سوال متداول : “چرا باید ; بگذاریم؟”

پاسخ: برای جداسازی دستورات - کامپایلر بدون آن نمی‌داند کجا یک statement تمام شده.

----------------------------------------------------------------------------------------------------------------------------------------------------------

```csharp
int myVariable;    //  camelCase (توصیه می‌شود)
int MyVariable;    //  PascalCase
int my_variable;   //  snake_case
int 123variable;   //  نمی‌تواند با عدد شروع شود
int int;           //  کلمه کلیدی است
```
-----------------------------------------------------------------------------------------------------------------------------------------------------------
مفاهیم اولیه شی‌گرای

```csharp
public class Console
{
    // Data Members (فیلدها - داده‌ها)
    
    // Function Members (متدها - رفتارها)
    public static void WriteLine(int value) { ... }
}
```
