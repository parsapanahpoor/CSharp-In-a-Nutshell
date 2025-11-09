Switching on types
 Switching on a type is a special case of switching on a pattern.
 A number of other patterns have been introduced in recent
 versions of C#; see “Patterns” on page 238 for a full discussion.
 You can also switch on types (from C# 7):
 TellMeTheType (12);
 TellMeTheType ("hello");
 TellMeTheType (true);
 void TellMeTheType (object x)   // object allows any type.
 {
  switch (x)
  {
    case int i:
      Console.WriteLine ("It's an int!");
      Console.WriteLine ($"The square of {i} is {i * i}");
      break;
    case string s:
      Console.WriteLine ("It's a string");
      Console.WriteLine ($"The length of {s} is {s.Length}");
      break;
    case DateTime:
      Console.WriteLine ("It's a DateTime");
      break;
    default:
      Console.WriteLine ("I don't know what x is");
      break;
  }
 }
 (The object type allows for a variable of any type; we discuss this fully in “Inheri
tance” on page 126 and “The object Type” on page 138.)
 Each case clause specifies a type upon which to match, and a variable upon which
 to assign the typed value if the match succeeds (the “pattern” variable). Unlike with
 constants, there’s no restriction on what types you can use.
 You can predicate a case with the when keyword:
 switch (x)
 {
  case bool b when b == true:
    Console.WriteLine ("True!");
    break;
  case bool b:
 Console.WriteLine ("False!");
    break;
 }


## Switch کردن بر اساس انواع (Types)

ترجمه Switch کردن بر اساس یک نوع، حالت خاصی از switch کردن بر اساس الگو (pattern) است.

**نکته:** تعدادی الگوی دیگر در نسخه‌های اخیر C# معرفی شده‌اند؛ برای بحث کامل به بخش "Patterns" در صفحه ۲۳۸ مراجعه کنید.

شما همچنین می‌توانید بر اساس انواع switch کنید (از C# 7):
```csharp
TellMeTheType (12);
TellMeTheType ("hello");
TellMeTheType (true);

void TellMeTheType (object x)   // object allows any type.
{
  switch (x)
  {
case int i:
Console.WriteLine ("It's an int!");
Console.WriteLine ($"The square of {i} is {i * i}");
break;
case string s:
Console.WriteLine ("It's a string");
Console.WriteLine ($"The length of {s} is {s.Length}");
break;
case DateTime:
Console.WriteLine ("It's a DateTime");
break;
default:
Console.WriteLine ("I don't know what x is");
break;
  }
}
```
**(نوع `object` اجازه می‌دهد متغیری از هر نوعی داشته باشیم؛ ما این موضوع را به طور کامل در بخش "Inheritance" صفحه ۱۲۶ و "The object Type" صفحه ۱۳۸ بحث می‌کنیم.)**

### متغیر الگو (Pattern Variable)

هر بند `case` یک نوع را مشخص می‌کند که باید با آن مطابقت داشته باشد، و یک متغیر که مقدار نوع‌دار (typed) را در صورت موفقیت مطابقت به آن اختصاص می‌دهد (متغیر "الگو"). برخلاف ثابت‌ها، هیچ محدودیتی در مورد انواعی که می‌توانید استفاده کنید وجود ندارد.

### استفاده از when برای شرط‌گذاری

می‌توانید یک `case` را با کلمه کلیدی `when` شرطی کنید:

```csharp
switch (x)
{
  case bool b when b == true:
Console.WriteLine ("True!");
break;
  case bool b:
Console.WriteLine ("False!");
break;
}
```
**توضیح:** در این مثال، اولین `case` فقط زمانی اجرا می‌شود که `x` از نوع `bool` باشد **و** مقدار آن `true` باشد. در غیر این صورت، `case` دوم برای هر مقدار `bool` دیگری (یعنی `false`) اجرا می‌شود.
