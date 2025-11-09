Assignment Expressions
 An assignment expression uses the = operator to assign the result of another expres
sion to a variable; for example:
 x = x * 5
 An assignment expression is not a void expression—it has a value of whatever
 was assigned, and so can be incorporated into another expression. In the following
 example, the expression assigns 2 to x and 10 to y:
 y = 5 * (x = 2)
 You can use this style of expression to initialize multiple values:
 a = b = c = d = 0
 The compound assignment operators are syntactic shortcuts that combine assign
ment with another operator:
 x *= 2    // equivalent to x = x * 2
 x <<= 1   // equivalent to x = x << 1
 (A subtle exception to this rule is with events, which we describe in Chapter 4: the
 += and -= operators here are treated specially and map to the event’s add and remove
 accessors.

 Operator Precedence and Associativity
 When an expression contains multiple operators, precedence and associativity deter
mine the order of their evaluation. Operators with higher precedence execute before
 operators of lower precedence. If the operators have the same precedence, the
 operator’s associativity determines the order of evaluation.
 Precedence
 The following expression
 1 + 2 * 3
 is evaluated as follows because * has a higher precedence than +:
 1 + (2 * 3)
 Left-associative operators
 Binary operators (except for assignment, lambda, and null-coalescing operators) are
 left-associative; in other words, they are evaluated from left to right. For example,
 the following expression
 8 / 4 / 2
 is evaluated as follows:
 ( 8 / 4 ) / 2    // 1
 you can insert parentheses to change the actual order of evaluation:
 8 / ( 4 / 2 )    // 4


 ## عبارات انتساب (Assignment Expressions)

یک **عبارت انتساب** (Assignment Expression) از عملگر `=` برای انتساب نتیجه یک عبارت دیگر به یک متغیر استفاده می‌کند؛ به عنوان مثال:
```csharp
x = x * 5
```
### ویژگی مهم: عبارت انتساب یک عبارت void نیست

یک عبارت انتساب یک **عبارت void نیست** — بلکه **مقداری برابر با آنچه انتساب داده شده** دارد، و بنابراین می‌تواند در یک عبارت دیگر **گنجانده شود** (Incorporated).

در مثال زیر، عبارت مقدار $2$ را به `x` و مقدار $10$ را به `y` انتساب می‌دهد:

```csharp
y = 5 * (x = 2)
```
**توضیح:**
- ابتدا `x = 2` انجام می‌شود و مقدار $2$ برمی‌گرداند
- سپس $5 \times 2 = 10$ محاسبه می‌شود
- در نهایت $10$ به `y` انتساب داده می‌شود

### مقداردهی اولیه چندگانه (Multiple Initialization)

می‌توانید از این سبک عبارت برای **مقداردهی اولیه چند مقدار** استفاده کنید:

```csharp
a = b = c = d = 0
```
**نحوه اجرا:** از راست به چپ ارزیابی می‌شود:
1. `d = 0` → مقدار $0$ برمی‌گرداند
2. `c = 0` → مقدار $0$ برمی‌گرداند
3. `b = 0` → مقدار $0$ برمی‌گرداند
4. `a = 0` → مقدار $0$ برمی‌گرداند

---

## عملگرهای انتساب ترکیبی (Compound Assignment Operators)

**عملگرهای انتساب ترکیبی** میانبرهای نحوی (Syntactic Shortcuts) هستند که انتساب را با یک عملگر دیگر **ترکیب می‌کنند**:

```csharp
x *= 2    // معادل: x = x * 2
x <<= 1   // معادل: x = x << 1
```
### لیست عملگرهای انتساب ترکیبی رایج:

| عملگر | معادل | توضیح |
|-------|-------|-------|
| `x += y` | `x = x + y` | جمع و انتساب |
| `x -= y` | `x = x - y` | تفریق و انتساب |
| `x *= y` | `x = x * y` | ضرب و انتساب |
| `x /= y` | `x = x / y` | تقسیم و انتساب |
| `x %= y` | `x = x % y` | باقیمانده و انتساب |
| `x &= y` | `x = x & y` | AND بیتی و انتساب |
| `x \|= y` | `x = x \| y` | OR بیتی و انتساب |
| `x ^= y` | `x = x ^ y` | XOR بیتی و انتساب |
| `x <<= y` | `x = x << y` | جابجایی چپ و انتساب |
| `x >>= y` | `x = x >> y` | جابجایی راست و انتساب |

### استثنای ظریف: رویدادها (Events)

یک **استثنای ظریف** برای این قاعده وجود دارد و آن مربوط به **رویدادها** (Events) است (که در **فصل 4** توضیح داده خواهد شد):

عملگرهای `+=` و `-=` در مورد رویدادها به صورت **خاص** رفتار می‌کنند و به **accessorهای add و remove** رویداد map می‌شوند.

```csharp
// برای رویدادها:
button.Click += Button_Click;    // فراخوانی add accessor
button.Click -= Button_Click;    // فراخوانی remove accessor
```
**نکته:** این رفتار متفاوت با عملگرهای `+=` و `-=` معمولی است که صرفاً میانبر نحوی برای `x = x + y` و `x = x - y` هستند.


## اولویت و تجمع‌پذیری عملگرها (Operator Precedence and Associativity)

زمانی که یک عبارت شامل **چندین عملگر** است، **اولویت** (Precedence) و **تجمع‌پذیری** (Associativity) ترتیب ارزیابی آن‌ها را تعیین می‌کنند:

- **عملگرها با اولویت بالاتر** قبل از عملگرهای با اولویت پایین‌تر اجرا می‌شوند
- اگر عملگرها **اولویت یکسان** داشته باشند، **تجمع‌پذیری** عملگر ترتیب ارزیابی را تعیین می‌کند

---

## اولویت (Precedence)

عبارت زیر:
```csharp
1 + 2 * 3
```
به شکل زیر ارزیابی می‌شود، چون `*` **اولویت بالاتری** نسبت به `+` دارد:

```csharp
1 + (2 * 3)    // نتیجه: 7

**توضیح:**
1. ابتدا $2 \times 3 = 6$ محاسبه می‌شود
2. سپس $1 + 6 = 7$
```
---

## عملگرهای چپ-تجمعی (Left-Associative Operators)

**عملگرهای باینری** (به جز عملگرهای **انتساب**، **lambda**، و **null-coalescing**) **چپ-تجمعی** هستند؛ به عبارت دیگر، آن‌ها از **چپ به راست** ارزیابی می‌شوند.

### مثال:

عبارت زیر:

```csharp
8 / 4 / 2
```
به شکل زیر ارزیابی می‌شود:

```csharp
(8 / 4) / 2    // نتیجه: 1

**توضیح:**
1. ابتدا $8 \div 4 = 2$
2. سپس $2 \div 2 = 1$
```
### تغییر ترتیب ارزیابی با پرانتز

می‌توانید **پرانتز** وارد کنید تا ترتیب واقعی ارزیابی را تغییر دهید:

```csharp
8 / (4 / 2)    // نتیجه: 4

**توضیح:**
1. ابتدا $4 \div 2 = 2$ (داخل پرانتز)
2. سپس $8 \div 2 = 4$
```
---

## جدول خلاصه:

| عبارت | ترتیب ارزیابی | نتیجه | دلیل |
|-------|---------------|-------|------|
| `1 + 2 * 3` | `1 + (2 * 3)` | $7$ | اولویت `*` بالاتر از `+` |
| `8 / 4 / 2` | `(8 / 4) / 2` | $1$ | چپ-تجمعی |
| `8 / (4 / 2)` | `8 / (4 / 2)` | $4$ | پرانتز صریح |

---

## نکته کلیدی:

**استثناهای عملگرهای راست-تجمعی:**
- **عملگرهای انتساب** (`=`, `+=`, `-=`, و غیره)
- **عملگر lambda** (`=>`)
- **عملگر null-coalescing** (`??`)

این عملگرها از **راست به چپ** ارزیابی می‌شوند:

```csharp
// انتساب: راست-تجمعی
a = b = c = 5    // معادل: a = (b = (c = 5))

// null-coalescing: راست-تجمعی
x ?? y ?? z      // معادل: x ?? (y ?? z)
```
