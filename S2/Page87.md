Changing the flow of execution with braces
 An else clause always applies to the immediately preceding if statement in the
 statement block:
 if (true)
  if (false)
    Console.WriteLine();
  else
    Console.WriteLine ("executes");
 This is semantically identical to the following:
 if (true)
 {
  if (false)
    Console.WriteLine();
  else
    Console.WriteLine ("executes");
 }
 We can change the execution flow by moving the braces:
 if (true)
 {
  if (false)
    Console.WriteLine();
 }
 else
  Console.WriteLine ("does not execute");
 With braces, you explicitly state your intention. This can improve the readability of
 nested if statements—even when not required by the compiler. A notable exception
 is with the following pattern:
 void TellMeWhatICanDo (int age)
 {
  if (age >= 35)
    Console.WriteLine ("You can be president!");
 else if (age >= 21)
    Console.WriteLine ("You can drink!");
 else if (age >= 18)
    Console.WriteLine ("You can vote!");
  else
    Console.WriteLine ("You can wait!");
 }
 Here, we’ve arranged the if and else statements to mimic the “elseif” construct
 of other languages (and C#’s #elif preprocessor directive). Visual Studio’s auto
formatting recognizes this pattern and preserves the indentation. Semantically,
 though, each if statement following an else statement is functionally nested within
 the else clause


## تغییر جریان اجرا با آکولادها

یک بند `else` همیشه به دستور `if` بلافاصله قبل از خود در بلوک دستور اعمال می‌شود:
```csharp
if (true)
  if (false)
Console.WriteLine();
  else
Console.WriteLine ("executes");
```
این از نظر معنایی یکسان است با موارد زیر:

```csharp
if (true)
{
  if (false)
Console.WriteLine();
  else
Console.WriteLine ("executes");
}
```
ما می‌توانیم جریان اجرا را با جابجایی آکولادها تغییر دهیم:

```csharp
if (true)
{
  if (false)
Console.WriteLine();
}
else
  Console.WriteLine ("does not execute");
```
**نکته مهم:** با استفاده از آکولادها، شما به صراحت قصد خود را بیان می‌کنید. این می‌تواند خوانایی دستورات `if` تو در تو را بهبود بخشد - حتی زمانی که توسط کامپایلر الزامی نیست. یک استثنای قابل توجه با الگوی زیر است:

```csharp
void TellMeWhatICanDo (int age)
{
  if (age >= 35)
Console.WriteLine ("You can be president!");
  else if (age >= 21)
Console.WriteLine ("You can drink!");
  else if (age >= 18)
Console.WriteLine ("You can vote!");
  else
Console.WriteLine ("You can wait!");
}
```
**توضیح:** در اینجا، ما دستورات `if` و `else` را به گونه‌ای ترتیب داده‌ایم که ساختار `elseif` زبان‌های دیگر (و دستور پیش‌پردازنده `#elif` در C#) را تقلید کند. قالب‌بندی خودکار Visual Studio این الگو را تشخیص می‌دهد و تورفتگی (indentation) را حفظ می‌کند. با این حال، از نظر معنایی، هر دستور `if` که به دنبال یک دستور `else` می‌آید، از نظر عملکردی در داخل بند `else` تو در تو قرار دارد.
