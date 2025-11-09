 Expressions and Operators
 An expression essentially denotes a value. The simplest kinds of expressions are
 constants and variables. Expressions can be transformed and combined using oper
ators. An operator takes one or more input operands to output a new expression.
 Here is an example of a constant expression:
 12
 We can use the * operator to combine two operands (the literal expressions 12 and
 30), as follows:
 12 * 30
 We can build complex expressions because an operand can itself be an expression,
 such as the operand (12 * 30) in the following example:
 1 + (12 * 30)
 Operators in C# can be classed as unary, binary, or ternary, depending on the
 number of operands they work on (one, two, or three). The binary operators always
 use infix notation in which the operator is placed between the two operands

  Primary Expressions
 Primary expressions include expressions composed of operators that are intrinsic to
 the basic plumbing of the language. Here is an example:
 Math.Log (1)
 This expression is composed of two primary expressions. The first expression per
forms a member lookup (with the . operator), and the second expression performs
 a method call (with the () operator).
 Void Expressions
 A void expression is an expression that has no value, such as this:
 Console.WriteLine (1)
 Because it has no value, you cannot use a void expression as an operand to build
 more complex expressions:
 1 + Console.WriteLine (1)


 ## عبارات و عملگرها (Expressions and Operators)

یک **عبارت** (Expression) اساساً نشان‌دهنده یک مقدار است. ساده‌ترین انواع عبارات، **ثابت‌ها** (Constants) و **متغیرها** (Variables) هستند. عبارات می‌توانند با استفاده از **عملگرها** (Operators) تبدیل و ترکیب شوند. یک عملگر یک یا چند **عملوند** (Operand) ورودی می‌گیرد تا یک عبارت جدید خروجی دهد.

در اینجا مثالی از یک عبارت ثابت آورده شده است:
```csharp
12
```
می‌توانیم از عملگر `*` برای ترکیب دو عملوند (عبارات literal یعنی $12$ و $30$) به شکل زیر استفاده کنیم:

```csharp
12 * 30
```
می‌توانیم عبارات پیچیده بسازیم زیرا یک عملوند خود می‌تواند یک عبارت باشد، مانند عملوند `(12 * 30)` در مثال زیر:

```csharp
1 + (12 * 30)
```
### طبقه‌بندی عملگرها بر اساس تعداد عملوندها

عملگرها در C# بسته به تعداد عملوندهایی که روی آن‌ها کار می‌کنند، می‌توانند به سه دسته تقسیم شوند:

- ترحمه => **Unary** (یک‌عملوندی): یک عملوند
-  ترحمه => **Binary** (دوعملوندی): دو عملوند  
-  ترحمه => **Ternary** (سه‌عملوندی): سه عملوند

**عملگرهای باینری** (Binary operators) همیشه از **نماد infix** استفاده می‌کنند که در آن عملگر **بین دو عملوند** قرار می‌گیرد.

### مثال‌ها:

```csharp
// عملگر Unary (منفی کردن)
-5

// عملگر Binary (جمع)
10 + 20

// عملگر Ternary (شرطی)
x > 0 ? "positive" : "non-positive"
```
**نکته:** در عبارات پیچیده، **اولویت عملگرها** (Operator Precedence) تعیین می‌کند که کدام عملیات اول انجام شود. در مثال `1 + (12 * 30)`:
- اگر پرانتز نبود، `*` به دلیل اولویت بالاتر، قبل از `+` اجرا می‌شد
- پرانتز به ما اجازه می‌دهد ترتیب ارزیابی را کنترل کنیم

## عبارات اولیه (Primary Expressions)

**عبارات اولیه** (Primary Expressions) شامل عباراتی هستند که از عملگرهایی تشکیل شده‌اند که **ذاتی** (intrinsic) برای لوله‌کشی پایه (plumbing) زبان هستند. در اینجا یک مثال آورده شده است:
```csharp
Math.Log(1)
```
این عبارت از **دو عبارت اولیه** تشکیل شده است:
1. **عبارت اول** یک **جستجوی عضو** (Member Lookup) با عملگر `.` انجام می‌دهد
2. **عبارت دوم** یک **فراخوانی متد** (Method Call) با عملگر `()` انجام می‌دهد

### ساختار تجزیه:
```csharp
Math.Log(1)
  ↓
Math.Log  →  member lookup با عملگر '.'
(1)  →  method call با عملگر '()'
```
---

## عبارات Void

یک **عبارت void** (Void Expression) عبارتی است که **هیچ مقداری ندارد**، مانند:

```csharp
Console.WriteLine(1)
```
### محدودیت عبارات Void

از آنجا که عبارت void هیچ مقداری ندارد، **نمی‌توانید** از آن به عنوان یک عملوند برای ساختن عبارات پیچیده‌تر استفاده کنید:

```csharp
1 + Console.WriteLine(1)  // ❌ خطای کامپایل
```
**دلیل خطا:** `Console.WriteLine(1)` هیچ مقداری برنمی‌گرداند (نوع بازگشتی `void` دارد)، بنابراین نمی‌توان آن را با عملگر `+` با عدد $1$ ترکیب کرد.

### مثال‌های صحیح و غلط:

```csharp
// ✅ صحیح - استفاده مستقل از void expression
Console.WriteLine("Hello");

// ✅ صحیح - متدی که مقدار برمی‌گرداند
int result = 1 + Math.Abs(-5);

// ❌ غلط - استفاده از void expression به عنوان عملوند
string text = "Result: " + Console.WriteLine(42);

// ❌ غلط - انتساب void expression
int x = Console.WriteLine(10);
```
**نکته کلیدی:** متدهایی که `void` برمی‌گردانند فقط برای **اثرات جانبی** (Side Effects) خود فراخوانی می‌شوند (مانند نوشتن در کنسول، تغییر وضعیت، و غیره)، نه برای تولید مقدار.

