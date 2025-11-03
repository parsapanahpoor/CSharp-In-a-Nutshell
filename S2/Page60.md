## String Type
C#’s string type (aliasing the System.String type, covered in depth in Chapter 6) represents an
immutable (unmodifiable) sequence of Unicode characters. A string literal is specified within double
quotes:
60
string a = "Heat";
NOTE
string is a reference type rather than a value type. Its equality operators, however, follow value-type semantics:
string a = "test";
string b = "test";
Console.Write (a == b); // True
e escape sequences that are valid for char literals also work inside strings:
string a = "Here's a tab:\t";
e cost of this is that whenever you need a literal backslash, you must write it twice:
string a1 = "\\\\server\\fileshare\\helloworld.cs";
To avoid this problem, C# allows verbatim string literals. A verbatim string literal is prefixed with @
and does not support escape sequences. e following verbatim string is identical to the preceding
one:
string a2 = @"\\server\fileshare\helloworld.cs";
A verbatim string literal can also span multiple lines:
string escaped = "First Line\r\nSecond Line";
string verbatim = @"First Line
Second Line";
// True if your text editor uses CR-LF line separators:
Console.WriteLine (escaped == verbatim);
You can include the double-quote character in a verbatim literal by writing it twice:
string xml = @"<customer id=""123""></customer>";

## String concatenation
e + operator concatenates two strings:
61
string s = "a" + "b";
One of the operands might be a nonstring value, in which case ToString is called on that value:
string s = "a" + 5; // a5
Using the + operator repeatedly to build up a string is inefficient: a better solution is to use the
System.Text.StringBuilder type (described in Chapter 6).




## نوع String

نوع `string` در #C (که نوع `System.String` را alias می‌کند و در فصل 6 به طور کامل پوشش داده می‌شود) یک دنباله immutable (غیرقابل تغییر) از کاراکترهای Unicode را نمایش می‌دهد. یک literal از نوع `string` در داخل دابل‌کوتیشن مشخص می‌شود:
```csharp
string a = "Heat";
```
> **نکته**

 `string` یک reference type است نه value type. با این حال، عملگرهای equality آن از معناشناسی value-type پیروی می‌کنند:


```csharp
 string a = "test";
 string b = "test";
 Console.Write (a == b); // True

```
توالی‌های escape که برای char literalها معتبر هستند در داخل stringها نیز کار می‌کنند:

```csharp

string a = “Here’s a tab:\t”;
```
هزینه این کار این است که هر زمان که به یک backslash به صورت literal نیاز دارید، باید آن را دو بار بنویسید:

```csharp

string a1 = “\\server\fileshare\helloworld.cs”;
```
برای جلوگیری از این مشکل، #C اجازه می‌دهد از verbatim string literalها استفاده کنید. یک verbatim string literal با @ پیشوند می‌خورد و از توالی‌های escape پشتیبانی نمی‌کند. verbatim string زیر با string قبلی یکسان است:

```csharp

string a2 = @“\server\fileshare\helloworld.cs”;
```
یک verbatim string literal همچنین می‌تواند چندین خط را شامل شود:

```csharp

string escaped = “First Line\r\nSecond Line”;

string verbatim = @"First Line

Second Line";

// اگر ویرایشگر متنی شما از جداکننده‌های خط CR-LF استفاده کند، True می‌شود:

Console.WriteLine (escaped == verbatim);
```

می‌توانید کاراکتر دابل‌کوتیشن را در یک verbatim literal با نوشتن دو بار آن قرار دهید:

```csharp

string xml = @“<customer id=”“123"”></customer>";
```
الحاق String
عملگر + دو string را به هم الحاق می‌کند:

```csharp

string s = “a” + “b”;
```
یکی از operandها می‌تواند یک مقدار غیر-string باشد، که در این صورت ToString روی آن مقدار فراخوانی می‌شود:

```csharp

string s = “a” + 5; // a5
```
استفاده تکراری از عملگر + برای ساختن یک string ناکارآمد است: یک راه‌حل بهتر استفاده از نوع System.Text.StringBuilder است (که در فصل 6 توضیح داده شده است).

خلاصه نکات مهم:

نکته => String Type: معرفی نوع string که alias برای System.String است و یک دنباله immutable از کاراکترهای Unicode را نمایش می‌دهد.

نکته مهم: string یک reference type است اما عملگرهای equality آن از معناشناسی value-type پیروی می‌کنند.

نکته => Escape sequences in strings: توالی‌های escape در stringها کار می‌کنند اما نیاز به نوشتن دو بار backslash وجود دارد.

کته => Verbatim string literals: معرفی verbatim stringها با پیشوند @ که escape sequenceها را پشتیبانی نمی‌کنند.

کته => Multi-line verbatim strings: verbatim stringها می‌توانند چند خطی باشند.

کته => Double-quotes in verbatim strings: نحوه قرار دادن دابل‌کوتیشن با نوشتن دو بار آن.

کته => String concatenation: استفاده از عملگر + برای الحاق stringها و هشدار درباره ناکارآمدی استفاده تکراری.
