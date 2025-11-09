 The order of the case clauses can matter when switching on type (unlike when
 switching on constants). This example would give a different result if we reversed
 the two cases (in fact, it would not even compile, because the compiler would
 determine that the second case is unreachable). An exception to this rule is the
 default clause, which is always executed last, regardless of where it appears.
 You can stack multiple case clauses. The Console.WriteLine in the following code
 will execute for any floating-point type greater than 1,000:
 switch (x)
 {
 case float f when f > 1000:
 case double d when d > 1000:
 case decimal m when m > 1000:
    Console.WriteLine ("We can refer to x here but not f or d or m");
    break;
 }
 In this example, the compiler lets us consume the pattern variables f, d, and m, only
 in the when clauses. When we call Console.WriteLine, it’s unknown which one of
 those three variables will be assigned, so the compiler puts all of them out of scope.
 You can mix and match constants and patterns in the same switch statement. And
 you can also switch on the null value:
 case null:
  Console.WriteLine ("Nothing here");
  break;
 Switch expressions
 From C# 8, you can use switch in the context of an expression. Assuming that
 cardNumber is of type int, the following illustrates its use:
 string cardName = cardNumber switch
 {
  13 => "King",
  12 => "Queen",
  11 => "Jack",
 _ => "Pip card"   // equivalent to 'default'
 };
 Notice that the switch keyword appears after the variable name, and that the case
 clauses are expressions (terminated by commas) rather than statements. Switch
 expressions are more compact than their switch statement counterparts, and you
 can use them in LINQ queries (Chapter 8).
 If you omit the default expression (_) and the switch fails to match, an exception is
 thrown.
You can also switch on multiple values (the tuple pattern):
 int cardNumber = 12;
 string suite = "spades";
 string cardName = (cardNumber, suite) switch
 {
 (13, "spades") => "King of spades",
 (13, "clubs") => "King of clubs",
  ...
 };
 Many more options are possible through the use of patterns (see “Patterns” on page
 238).

## ترتیب بندهای case در switch بر اساس نوع

ترتیب بندهای `case` می‌تواند هنگام switch کردن بر اساس نوع اهمیت داشته باشد (برخلاف switch کردن بر اساس ثابت‌ها). این مثال نتیجه متفاوتی می‌دهد اگر ترتیب دو `case` را معکوس کنیم (در واقع، حتی کامپایل نمی‌شود، زیرا کامپایلر تشخیص می‌دهد که `case` دوم غیرقابل دسترس است). یک استثنا برای این قاعده بند `default` است، که همیشه در آخر اجرا می‌شود، صرف نظر از اینکه کجا ظاهر شود.

### چیدن چندین بند case

می‌توانید چندین بند `case` را روی هم بچینید. `Console.WriteLine` در کد زیر برای هر نوع اعشاری (floating-point) بزرگتر از $1000$ اجرا می‌شود:
```csharp
switch (x)
{
  case float f when f > 1000:
  case double d when d > 1000:
  case decimal m when m > 1000:
Console.WriteLine ("We can refer to x here but not f or d or m");
break;
}
```
**توضیح:** در این مثال، کامپایلر به ما اجازه می‌دهد متغیرهای الگو `f`، `d` و `m` را فقط در بندهای `when` مصرف کنیم. وقتی `Console.WriteLine` را فراخانی می‌کنیم، مشخص نیست کدام یک از این سه متغیر مقداردهی شده است، بنابراین کامپایلر همه آن‌ها را خارج از دامنه (scope) قرار می‌دهد.

### ترکیب ثابت‌ها و الگوها

می‌توانید ثابت‌ها و الگوها را در یک دستور `switch` ترکیب کنید. و همچنین می‌توانید بر اساس مقدار `null` switch کنید:

```csharp
case null:
  Console.WriteLine ("Nothing here");
  break;
```
## عبارات Switch (Switch Expressions)

از C# 8، می‌توانید `switch` را در زمینه یک عبارت استفاده کنید. با فرض اینکه `cardNumber` از نوع `int` است، موارد زیر استفاده از آن را نشان می‌دهد:

```csharp
string cardName = cardNumber switch
{
  13 => "King",
  12 => "Queen",
  11 => "Jack",
  _ => "Pip card"   // equivalent to 'default'
};
```
**نکته:** توجه کنید که کلمه کلیدی `switch` بعد از نام متغیر ظاهر می‌شود، و بندهای `case` عبارت هستند (با کاما خاتمه می‌یابند) نه دستور. عبارات `switch` فشرده‌تر از همتایان دستوری خود هستند، و می‌توانید آن‌ها را در query های LINQ استفاده کنید (فصل ۸).

**هشدار:** اگر عبارت `default` (`_`) را حذف کنید و `switch` نتواند مطابقت پیدا کند، یک استثنا پرتاب می‌شود.

### Switch بر اساس چندین مقدار (الگوی Tuple)

می‌توانید بر اساس چندین مقدار نیز switch کنید (الگوی tuple):

```csharp
int cardNumber = 12;
string suite = "spades";

string cardName = (cardNumber, suite) switch
{
  (13, "spades") => "King of spades",
  (13, "clubs") => "King of clubs",
  ...
};
```
```**توضیح:** گزینه‌های بسیار بیشتری از طریق استفاده از الگوها (patterns) امکان‌پذیر است (به بخش "Patterns" در صفحه ۲۳۸ مراجعه کنید).
