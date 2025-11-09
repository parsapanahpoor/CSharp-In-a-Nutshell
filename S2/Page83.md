Null-Conditional Operator
 The ?. operator is the null-conditional or “Elvis” operator (after the Elvis emoticon).
 It allows you to call methods and access members just like the standard dot operator
 except that if the operand on the left is null, the expression evaluates to null instead
 of throwing a NullReferenceException:
 System.Text.StringBuilder sb = null;
 string s = sb?.ToString();  // No error; s instead evaluates to null
 The last line is equivalent to the following:
 string s = (sb == null ? null : sb.ToString());
 Null-conditional expressions also work with indexers:
 string[] words = null;
 string word = words?[1];   // word is null
 Upon encountering a null, the Elvis operator short-circuits the remainder of the
 expression. In the following example, s evaluates to null, even with a standard dot
 operator between ToString() and ToUpper():
 System.Text.StringBuilder sb = null;
 string s = sb?.ToString().ToUpper();   // s evaluates to null without error
Repeated use of Elvis is necessary only if the operand immediately to its left might
 be null. The following expression is robust to both x being null and x.y being null:
 x?.y?.z
 It is equivalent to the following (except that x.y is evaluated only once):
 x == null ? null 
          : (x.y == null ? null : x.y.z)
 The final expression must be capable of accepting a null. The following is illegal:
 System.Text.StringBuilder sb = null;
 int length = sb?.ToString().Length;   // Illegal : int cannot be null
 We can fix this with the use of nullable value types (see “Nullable Value Types” on
 page 210). If you’re already familiar with nullable value types, here’s a preview:
 int? length = sb?.ToString().Length;   // OK: int? can be null
 You can also use the null-conditional operator to call a void method:
 someObject?.SomeVoidMethod();
 If someObject is null, this becomes a “no-operation” rather than throwing a NullRe
 ferenceException.
 You can use the null-conditional operator with the commonly used type members
 that we describe in Chapter 3, including methods, fields, properties, and indexers. It
 also combines well with the null-coalescing operator:
 System.Text.StringBuilder sb = null;
 string s = sb?.ToString() ?? "nothing";   // s evaluates to "nothing"


 ## عملگر Null-Conditional

عملگر `?.` عملگر null-conditional یا عملگر "Elvis" است (به خاطر شکلک Elvis). این عملگر به شما اجازه می‌دهد که متدها را فراخوانی کنید و به اعضا دسترسی پیدا کنید دقیقاً مانند عملگر نقطه استاندارد، با این تفاوت که اگر عملوند سمت چپ null باشد، عبارت به null ارزیابی می‌شود به جای اینکه یک `NullReferenceException` پرتاب کند:
```csharp
System.Text.StringBuilder sb = null;
string s = sb?.ToString();  // بدون خطا؛ s به جای آن به null ارزیابی می‌شود
```
خط آخر معادل است با:

```csharp
string s = (sb == null ? null : sb.ToString());
```
عبارات null-conditional همچنین با indexerها نیز کار می‌کنند:

```csharp
string[] words = null;
string word = words?[1];   // word برابر null است
```
با برخورد به null، عملگر Elvis باقی‌مانده عبارت را کوتاه می‌کند (short-circuit). در مثال زیر، `s` به null ارزیابی می‌شود، حتی با وجود یک عملگر نقطه استاندارد بین `ToString()` و `ToUpper()`:

```csharp
System.Text.StringBuilder sb = null;
string s = sb?.ToString().ToUpper();   // s بدون خطا به null ارزیابی می‌شود
```
استفاده مکرر از Elvis فقط در صورتی ضروری است که عملوندی که بلافاصله در سمت چپ آن قرار داردممکن است null باشد. عبارت زیر نسبت به null بودن هم `x` و هم `x.y` مقاوم است:

```csharp
x?.y?.z
```
این معادل است با (با این تفاوت که `x.y` فقط یک بار ارزیابی می‌شود):

```csharp
x == null ? null 
: (x.y == null ? null : x.y.z)
```
عبارت نهایی باید قادر به پذیرش null باشد. موارد زیر غیرمجاز است:

```csharp
System.Text.StringBuilder sb = null;
int length = sb?.ToString().Length;   // غیرمجاز: int نمی‌تواند null باشد
```
ما می‌توانیم این مورد را با استفاده از انواع مقداری nullable اصلاح کنیم (به "Nullable Value Types" در صفحه 210 مراجعه کنید). اگر قبلاً با انواع مقداری nullable آشنا هستید، در اینجا یک پیش‌نمایش است:

```csharp
int? length = sb?.ToString().Length;   // OK: int? می‌تواند null باشد
```
شما همچنین می‌توانید از عملگر null-conditional برای فراخوانی یک متد void استفاده کنید:

```csharp
someObject?.SomeVoidMethod();
```
اگر `someObject` برابر null باشد، این به یک "no-operation" تبدیل می‌شود به جای اینکه یک `NullReferenceException` پرتاب کند.

شما می‌توانید از عملگر null-conditional با اعضای رایج نوعی که ما در فصل 3 توضیح می‌دهیم استفاده کنید، از جمله متدها، فیلدها، خصوصیات، و indexerها. این عملگر همچنین به خوبی با عملگر null-coalescing ترکیب می‌شود:

```csharp
System.Text.StringBuilder sb = null;
string s = sb?.ToString() ?? "nothing";   // s به "nothing" ارزیابی می‌شود
```
