## Predefined Type Taxonomy
The predefined types in C# are as follows:
Value types
• Numeric
— Signed integer (sbyte, short, int, long)
— Unsigned integer (byte, ushort, uint, ulong)
— Real number (float, double, decimal)
• Logical (bool)
• Character (char)
Reference types
• String (string)
• Object (object)
Predefined types in C# alias .NET types in the System namespace. There is only a
syntactic difference between these two statements:
int i = 5;
System.Int32 i = 5;
The set of predefined value types excluding decimal are known as primitive types
in the CLR. Primitive types are so called because they are supported directly via
instructions in compiled code, and this usually translates to direct support on the
underlying processor; for example:
// Underlying hexadecimal representation
int i = 7; // 0x7
bool b = true; // 0x1
char c = 'A'; // 0x41
float f = 0.5f; // uses IEEE floating-point encoding
The System.IntPtr and System.UIntPtr types are also primitive (see Chapter 24).

### Predefined Type Taxonomy

نوعtypeهای از پیش تعریف شده در C# به شرح زیر هستند:

**Value types**

• عددی (Numeric)
  — اعداد صحیح علامت‌دار (sbyte, short, int, long)
  — اعداد صحیح بدون علامت (byte, ushort, uint, ulong)
  — اعداد حقیقی (float, double, decimal)
• منطقی (bool)
• کاراکتر (char)

**Reference types**

• رشته (string)
• شیء (object)

نوعtypeهای از پیش تعریف شده در C# نام مستعار (alias) typeهای .NET در namespace به نام `System` هستند. تنها یک تفاوت نحوی (syntactic) بین این دو statement وجود دارد:
```csharp
int i = 5;
System.Int32 i = 5;
```

مجموعه value typeهای از پیش تعریف شده به استثنای `decimal` به عنوان primitive types در CLR شناخته می‌شوند. primitive types به این دلیل چنین نامیده می‌شوند که مستقیماً از طریق دستورالعمل‌ها (instructions) در کد کامپایل شده پشتیبانی می‌شوند، و این معمولاً به پشتیبانی مستقیم در پردازنده زیرین ترجمه می‌شود؛ به عنوان مثال:


 نمایش هگزادسیمال زیرین
```csharp
int i = 7;        // 0x7
bool b = true;    // 0x1
char c = 'A';     // 0x41
float f = 0.5f;   // از کدگذاری floating-point استاندارد IEEE استفاده می‌کند
```
نوعtypeهای `System.IntPtr` و `System.UIntPtr` نیز primitive هستند (به فصل 24 مراجعه کنید).

