Local variables
 The scope of a local variable or local constant extends throughout the current block.
 You cannot declare another local variable with the same name in the current block
 or in any nested blocks:
 int x;
 {
  int y;
  int x;            // Error - x already defined
 }
 {
  int y;            // OK - y not in scope
 }
 Console.Write (y);  // Error - y is out of scope
 A variable’s scope extends in both directions throughout its
 code block. This means that if we moved the initial declara
tion of x in this example to the bottom of the method, we’d
 get the same error. This is in contrast to C++ and is somewhat
 peculiar, given that it’s not legal to refer to a variable or con
stant before it’s declared.
 Expression Statements
 Expression statements are expressions that are also valid statements. An expression
 statement must either change state or call something that might change state.
 Changing state essentially means changing a variable. Following are the possible
 expression statements:
 •
 • Assignment expressions (including increment and decrement expressions)
 •
 • Method call expressions (both void and nonvoid)
 •
 • Object instantiation expressions
 Here are some examples:
 // Declare variables with declaration statements:
 string s;
 int x, y;
 System.Text.StringBuilder sb;
 // Expression statements
 x = 1 + 2;                 // Assignment expression
 x++;                       // Increment expression
 y = Math.Max (x, 5);       // Assignment expression
 Console.WriteLine (y);     // Method call expression
 sb = new StringBuilder();  // Assignment expression
 new StringBuilder();       // Object instantiation expression
 When you call a constructor or a method that returns a value, you’re not obliged
 to use the result. However, unless the constructor or method changes state, the
 statement is completely useless:
new StringBuilder();     // Legal, but useless
 new string ('c', 3);     // Legal, but useless
 x.Equals (y);            // Legal, but useless


## متغیرهای محلی (Local Variables)

دامنه (scope) یک متغیر محلی یا ثابت محلی در سراسر بلوک فعلی گسترش می‌یابد. شما نمی‌توانید متغیر محلی دیگری با همان نام در بلوک فعلی یا در هر بلوک تو در تو اعلان کنید:
```csharp
int x;
{
  int y;
  int x;            // خطا - x قبلاً تعریف شده است
}
{
  int y;            // OK - y در دامنه (scope) نیست
}
Console.Write (y);  // خطا - y خارج از دامنه است
```
**نکته مهم:** دامنه یک متغیر در هر دو جهت در سراسر بلوک کد آن گسترش می‌یابد. این بدان معناست که اگر اعلان اولیه `x` را در این مثال به انتهای متد منتقل کنیم، همان خطا را دریافت خواهیم کرد. این برخلاف C++ است و تا حدودی عجیب است، با توجه به اینکه قانونی نیست که قبل از اعلان به یک متغیر یا ثابت ارجاع دهیم.

## دستورات عبارتی (Expression Statements)

دستورات عبارتی، عباراتی هستند که همچنین دستورات معتبری نیز هستند. یک دستور عبارتی باید یا حالت را تغییر دهد یا چیزی را فراخوانی کند که ممکن است حالت را تغییر دهد. تغییر حالت اساساً به معنای تغییر یک متغیر است. موارد زیر دستورات عبارتی ممکن هستند:

- **عبارات انتساب** (از جمله عبارات افزایش و کاهش)
- **عبارات فراخوانی متد** (هم `void` و هم غیر `void`)
- **عبارات نمونه‌سازی شیء**

در اینجا چند مثال آورده شده است:

```csharp
// اعلان متغیرها با دستورات اعلان:
string s;
int x, y;
System.Text.StringBuilder sb;

// دستورات عبارتی
x = 1 + 2;                 // عبارت انتساب
x++;                       // عبارت افزایش
y = Math.Max (x, 5);       // عبارت انتساب
Console.WriteLine (y);     // عبارت فراخوانی متد
sb = new StringBuilder();  // عبارت انتساب
new StringBuilder();       // عبارت نمونه‌سازی شیء
```
**نکته:** وقتی یک سازنده (constructor) یا متد که مقدار برمی‌گرداند را فراخوانی می‌کنید، ملزم به استفاده از نتیجه نیستید. با این حال، مگر اینکه سازنده یا متد حالت را تغییر دهد، دستور کاملاً بی‌فایده است:

```csharp
new StringBuilder();     // قانونی، اما بی‌فایده
new string ('c', 3);     // قانونی، اما بی‌فایده
x.Equals (y);            // قانونی، اما بی‌فایده
```
