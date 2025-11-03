## Strings and Characters
C#’s char type (aliasing the System.Char type) represents a Unicode character and occupies 2
bytes (UTF-16). A char literal is specified within single quotes:
59
char c = 'A'; // Simple character
Escape sequences express characters that cannot be expressed or interpreted literally. An escape
sequence is a backslash followed by a character with a special meaning; for example:
char newLine = '\n';
char backSlash = '\\';
Table 2-2 shows the escape sequence characters.
Table 2-2. Escape sequence
characters
Char Meaning Value
\' Single quote 0x0027
\" Double quote 0x0022
\\ Backslash 0x005C
\0 Null 0x0000
\a Alert 0x0007
\b Backspace 0x0008
\f Form feed 0x000C
\n New line 0x000A
\r Carriage return 0x000D
\t Horizontal tab 0x0009
\v Vertical tab 0x000B
e \u (or \x) escape sequence lets you specify any Unicode character via its four-digit hexadecimal
code:
char copyrightSymbol = '\u00A9';
char omegaSymbol = '\u03A9';
char newLine = '\u000A';


## Char Conversions
An implicit conversion from a char to a numeric type works for the numeric types that can
accommodate an unsigned short. For other numeric types, an explicit conversion is required.


## رشته‌ها و کاراکترها

نوع `char` در #C (که نوع `System.Char` را alias می‌کند) یک کاراکتر Unicode را نمایش می‌دهد و 2 بایت (UTF-16) اشغال می‌کند. یک literal از نوع `char` در داخل تک‌کوتیشن مشخص می‌شود:
```csharp
char c = 'A'; // کاراکتر ساده
```
توالی‌های escape کاراکترهایی را بیان می‌کنند که نمی‌توانند به صورت literal بیان یا تفسیر شوند. یک توالی escape یک backslash است که به دنبال آن یک کاراکتر با معنای خاص می‌آید؛ به عنوان مثال:

```csharp
char newLine = '\n';
char backSlash = '\\';
```
جدول 2-2 کاراکترهای توالی escape را نشان می‌دهد.

**جدول 2-2. کاراکترهای توالی escape**

| Char | معنا | مقدار |
|------|------|-------|
| `\'` | Single quote | 0x0027 |
| `\"` | Double quote | 0x0022 |
| `\\` | Backslash | 0x005C |
| `\0` | Null | 0x0000 |
| `\a` | Alert | 0x0007 |
| `\b` | Backspace | 0x0008 |
| `\f` | Form feed | 0x000C |
| `\n` | New line | 0x000A |
| `\r` | Carriage return | 0x000D |
| `\t` | Horizontal tab | 0x0009 |
| `\v` | Vertical tab | 0x000B |

توالی escape با `\u` (یا `\x`) به شما اجازه می‌دهد هر کاراکتر Unicode را از طریق کد hexadecimal چهار رقمی آن مشخص کنید:

```csharp
char copyrightSymbol = '\u00A9';
char omegaSymbol = '\u03A9';
char newLine = '\u000A';
```
## تبدیل‌های Char

یک تبدیل implicit از `char` به یک نوع عددی برای انواع عددی که می‌توانند یک unsigned short را جای دهند کار می‌کند. برای سایر انواع عددی، یک تبدیل explicit مورد نیاز است.


**خلاصه نکات مهم:**

نکته=> 134. **Strings and Characters:** معرفی نوع `char` که کاراکتر Unicode را نمایش می‌دهد و 2 بایت (UTF-16) است. نحوه تعریف char literal با تک‌کوتیشن.

نکته=> 135. **Escape sequences:** توضیح توالی‌های escape برای بیان کاراکترهایی که به صورت literal نمایش داده نمی‌شوند. مثال‌هایی مانند `'\n'` و `'\\'`.

نکته=> 136. **جدول 2-2:** ارائه جدول کامل کاراکترهای escape sequence با معنا و مقدار hexadecimal هر یک.

نکته=> 137. **Unicode escape sequences:** توضیح استفاده از `\u` یا `\x` برای مشخص کردن کاراکترهای Unicode با کد hexadecimal چهار رقمی. مثال‌هایی برای نمایش copyright، omega و newline.

نکته=> 138. **Char Conversions:** توضیح تبدیل implicit از `char` به انواع عددی که unsigned short را می‌پذیرند و نیاز به تبدیل explicit برای سایر انواع.

