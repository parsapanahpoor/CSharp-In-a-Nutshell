You can use checked around either an expression or a statement block:
int a = 1000000;
int b = 1000000;
int c = checked (a * b); // Checks just the expression.
checked // Checks all expressions
{ // in statement block.
 ...
 c = a * b;
 ...
}

---------------------------------------------------------------------------

You can make arithmetic overflow checking the default for all expressions in a
program by selecting the “checked” option at the project level (in Visual Studio,
go to Advanced Build Settings). If you then need to disable overflow checking just
for specific expressions or statements, you can do so with the unchecked operator.
For example, the following code will not throw exceptions—even if the project’s
“checked” option is selected:
int x = int.MaxValue;
int y = unchecked (x + 1);
unchecked { int z = x + 1; }

## Overflow checking for constant expressions
Regardless of the “checked” project setting, expressions evaluated at compile time
are always overflow-checked—unless you apply the unchecked operator:
int x = int.MaxValue + 1; // Compile-time error
int y = unchecked (int.MaxValue + 1); // No errors


## Bitwise operators
C# supports the following bitwise operators:
Operator Meaning Sample expression Result
~ Complement ~0xfU 0xfffffff0U
& And 0xf0 & 0x33 0x30
| Or 0xf0 | 0x33 0xf3
^ Exclusive Or 0xff00 ^ 0x0ff0 0xf0f0
<< Shift left 0x20 << 2 0x80
>> Shift right 0x20 >> 1 0x10
>>> Unsigned shift right int.MinValue >>> 1 0x40000000

---------------------------------------------------------------------------------------

The shift-right operator (>>) replicates the high-order bit when operating on signed
integers, whereas the unsigned shift-right operator (>>>) does not.

---------------------------------------------------------------------------------------

Additional bitwise operations are exposed via a class called
BitOperations in the System.Numerics namespace (see
“BitOperations” on page 340).

---------------------------------------------------------------------------------------

می‌توانید از `checked` در اطراف یک expression یا یک statement block استفاده کنید:
```csharp
int a = 1000000;
int b = 1000000;
int c = checked (a * b);  // فقط expression را بررسی می‌کند.

checked                   // تمام expressionها را
{                         // در statement block بررسی می‌کند.
  ...
  c = a * b;
  ...
}
```

---------------------------------------------------------------------------

می‌توانید بررسی سرریز حسابی (arithmetic overflow checking) را به صورت پیش‌فرض برای تمام expressionها در یک برنامه فعال کنید با انتخاب گزینهٔ "checked" در سطح پروژه (در Visual Studio، به Advanced Build Settings بروید). اگر سپس نیاز داشتید که بررسی سرریز را فقط برای expressionها یا statementهای خاصی غیرفعال کنید، می‌توانید این کار را با عملگر `unchecked` انجام دهید. به عنوان مثال، کد زیر exceptionای پرتاب نخواهد کرد—حتی اگر گزینهٔ "checked" پروژه انتخاب شده باشد:
```csharp
int x = int.MaxValue;
int y = unchecked (x + 1);
unchecked { int z = x + 1; }
```

## بررسی سرریز برای expressionهای ثابت

صرف‌نظر از تنظیم "checked" پروژه، expressionهایی که در زمان کامپایل ارزیابی می‌شوند همیشه overflow-checked هستند—مگر اینکه عملگر `unchecked` را اعمال کنید:
```csharp
int x = int.MaxValue + 1;              // خطای زمان کامپایل
int y = unchecked (int.MaxValue + 1);  // بدون خطا
```

## عملگرهای بیتی

زبان C# از عملگرهای بیتی زیر پشتیبانی می‌کند:

| عملگر | معنی | نمونه expression | نتیجه |
|-------|------|------------------|-------|
| `~` | Complement | `~0xfU` | `0xfffffff0U` |
| `&` | And | `0xf0 & 0x33` | `0x30` |
| `|` | Or | `0xf0 | 0x33` | `0xf3` |
| `^` | Exclusive Or | `0xff00 ^ 0x0ff0` | `0xf0f0` |
| `<<` | Shift left | `0x20 << 2` | `0x80` |
| `>>` | Shift right | `0x20 >> 1` | `0x10` |
| `>>>` | Unsigned shift right | `int.MinValue >>> 1` | `0x40000000` |


---------------------------------------------------------------------------------------

عملگر shift-right یعنی `>>` بیت مرتبه بالا (high-order bit) را هنگام عملیات روی اعداد صحیح signed تکرار می‌کند، در حالی که عملگر unsigned shift-right یعنی `>>>` این کار را انجام نمی‌دهد.

---------------------------------------------------------------------------------------

عملیات‌های بیتی اضافی از طریق یک class به نام `BitOperations` در namespace به نام `System.Numerics` در دسترس قرار می‌گیرند (به "BitOperations" در صفحه 340 مراجعه کنید).
