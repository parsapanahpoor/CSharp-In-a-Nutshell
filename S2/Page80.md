 Right-associative operators
 The assignment operators as well as the lambda, null-coalescing, and conditional
 operators are right-associative; in other words, they are evaluated from right to left.
 Right associativity allows multiple assignments such as the following to compile:
 x = y = 3;
 This first assigns 3 to y and then assigns the result of that expression (3) to x.
 Operator Table
 Table 2-3 lists C#’s operators in order of precedence. Operators in the same category
 have the same precedence.
 We explain user-overloadable operators in “Operator Overloading” on page 256.
 Table 2-3. C# operators (categories in order of precedence)
 Category Operator
 symbol
 Operator name Example User
overloadable
 Primary . Member access x.y No
 ?. and ?[] Null-conditional x?.y or x?[0] No
 ! (postfix) Null-forgiving x!.y or x![0] No-> (unsafe) Pointer to struct x->y No
 () Function call x() No
 [] Array/index a[x] Via indexer
 ++ Post-increment x++ Yes
 −− Post-decrement x−− Yes
 new Create instance new Foo() No
 stackalloc Stack allocation stackalloc(10) No
 typeof Get type from
 identifier
 typeof(int) No
 nameof Get name of
 identifier
 nameof(x) No
 checked Integral overflow
 check on
 checked(x) No
 unchecked Integral overflow
 check off
 unchecked(x) No
 default Default value default(char) No


 ## عملگرهای راست-تجمعی (Right-Associative Operators)

**عملگرهای انتساب** (Assignment) و همچنین عملگرهای **lambda**، **null-coalescing**، و **conditional** (شرطی) **راست-تجمعی** هستند؛ به عبارت دیگر، آن‌ها از **راست به چپ** ارزیابی می‌شوند.

### مثال: انتساب چندگانه

تجمع‌پذیری راست به چپ این امکان را می‌دهد که **انتساب‌های چندگانه** مانند زیر کامپایل شوند:
```csharp
x = y = 3;
```
**نحوه اجرا:**
1. ابتدا مقدار $3$ به `y` انتساب داده می‌شود
2. سپس نتیجه آن عبارت (که $3$ است) به `x` انتساب داده می‌شود

**معادل با پرانتز:**
```csharp
x = (y = 3);
```
---

## جدول عملگرها (Operator Table)

**جدول 2-3** عملگرهای C# را به ترتیب **اولویت** (Precedence) لیست می‌کند. عملگرها در **یک دسته** دارای **اولویت یکسان** هستند.

### جدول 2-3: عملگرهای C# (دسته‌ها به ترتیب اولویت)

| دسته | نماد عملگر | نام عملگر | مثال | قابلیت overload توسط کاربر |
|------|-----------|-----------|------|--------------------------|
| **Primary** | `.` | دسترسی به عضو (Member access) | `x.y` | خیر |
| | `?.` و `?[]` | شرطی null (Null-conditional) | `x?.y` یا `x?[0]` | خیر |
| | `!` (postfix) | بخشش null (Null-forgiving) | `x!.y` یا `x![0]` | خیر |
| | `->` (unsafe) | اشاره‌گر به struct | `x->y` | خیر |
| | `()` | فراخوانی تابع (Function call) | `x()` | خیر |
| | `[]` | آرایه/ایندکس (Array/index) | `a[x]` | بله (از طریق indexer) |
| | `++` | افزایش پسوندی (Post-increment) | `x++` | بله |
| | `--` | کاهش پسوندی (Post-decrement) | `x--` | بله |
| | `new` | ایجاد نمونه (Create instance) | `new Foo()` | خیر |
| | `stackalloc` | تخصیص استک (Stack allocation) | `stackalloc(10)` | خیر |
| | `typeof` | گرفتن نوع از شناسه | `typeof(int)` | خیر |
| | `nameof` | گرفتن نام شناسه | `nameof(x)` | خیر |
| | `checked` | بررسی سرریز اعداد صحیح (روشن) | `checked(x)` | خیر |
| | `unchecked` | بررسی سرریز اعداد صحیح (خاموش) | `unchecked(x)` | خیر |
| | `default` | مقدار پیش‌فرض | `default(char)` | خیر |

---

## نکات کلیدی:

### 1. عملگرهای راست-تجمعی شامل:
- **عملگرهای انتساب**: `=`, `+=`, `-=`, `*=`, `/=`, و غیره
- **عملگر lambda**: `=>`
- **عملگر null-coalescing**: `??`
- **عملگر شرطی**: `? :`

### 2. مثال‌های راست-تجمعی:

```csharp
// انتساب چندگانه
a = b = c = 5;    // معادل: a = (b = (c = 5))

// null-coalescing
x ?? y ?? z;      // معادل: x ?? (y ?? z)

// شرطی (ternary)
a ? b : c ? d : e;    // معادل: a ? b : (c ? d : e)
```
### 3. عملگرهای قابل Overload:

برخی عملگرها مانند `++`, `--`, و `[]` (از طریق indexer) می‌توانند توسط کاربر **overload** شوند. این موضوع در **صفحه 256** ("Operator Overloading") توضیح داده خواهد شد.

---

## مقایسه چپ-تجمعی و راست-تجمعی:

| نوع | عملگرها | جهت ارزیابی | مثال |
|-----|---------|--------------|------|
| **چپ-تجمعی** | اکثر عملگرهای باینری | چپ → راست | `8 / 4 / 2` → `(8 / 4) / 2` |
| **راست-تجمعی** | انتساب، lambda، `??`, `? :` | راست → چپ | `x = y = 3` → `x = (y = 3)` |
