The switch statement
 switch statements let you branch program execution based on a selection of possi
ble values that a variable might have. switch statements can result in cleaner code
 than multiple if statements because switch statements require an expression to be
 evaluated only once:
 void ShowCard (int cardNumber)
 {
  switch (cardNumber)
  {
    case 13:
      Console.WriteLine ("King");
      break;
    case 12:
      Console.WriteLine ("Queen");
      break;
    case 11:
      Console.WriteLine ("Jack");
      break;
    case -1:                         // Joker is -1
      goto case 12;                  // In this game joker counts as queen
    default:                         // Executes for any other cardNumber
      Console.WriteLine (cardNumber);
      break;
  }
 }
 This example demonstrates the most common scenario, which is switching on
 constants. When you specify a constant, you’re restricted to the built-in numeric
 types and the bool, char, string, and enum types.
 At the end of each case clause, you must specify explicitly where execution is to go
 next, with some kind of jump statement (unless your code ends in an infinite loop).
 Here are the options:
 •
 • break (jumps to the end of the switch statement)
 •
 • goto case x (jumps to another case clause)
 •
 • goto default (jumps to the default clause)
 •
 • Any other jump statement—namely, return, throw, continue, or goto label
 When more than one value should execute the same code, you can list the common
 cases sequentially:
 switch (cardNumber)
 {
 case 13:
 case 12:
 case 11:
    Console.WriteLine ("Face card");
    break;
  default:
   Console.WriteLine ("Plain card");
    break;
 }
 This feature of a switch statement can be pivotal in terms of producing cleaner code
 than multiple if-else statements



 ## دستور switch

دستورات `switch` به شما اجازه می‌دهند اجرای برنامه را بر اساس انتخاب مقادیر ممکنی که یک متغیر ممکن است داشته باشد، شاخه‌بندی کنید. دستورات `switch` می‌توانند منجر به کد تمیزتری نسبت به چندین دستور `if` شوند زیرا دستورات `switch` نیاز دارند که یک عبارت فقط یک بار ارزیابی شود:
```csharp
void ShowCard (int cardNumber)
{
  switch (cardNumber)
  {
case 13:
Console.WriteLine ("King");
break;
case 12:
Console.WriteLine ("Queen");
break;
case 11:
Console.WriteLine ("Jack");
break;
case -1:                         // Joker is -1
goto case 12;                  // In this game joker counts as queen
default:                         // Executes for any other cardNumber
Console.WriteLine (cardNumber);
break;
  }
}
```
این مثال رایج‌ترین سناریو را نشان می‌دهد که switch کردن روی ثابت‌ها است. وقتی یک ثابت را مشخص می‌کنید، محدود به انواع عددی داخلی (built-in) و انواع `bool`، `char`، `string` و `enum` هستید.

### دستورات پرش در پایان هر case

در پایان هر بند `case`، باید به صراحت مشخص کنید که اجرا بعد از آن به کجا برود، با نوعی دستور پرش (مگر اینکه کد شما در یک حلقه بی‌نهایت به پایان برسد). گزینه‌ها عبارتند از:

- **`break`** (به انتهای دستور switch می‌پرد)
- **`goto case x`** (به بند case دیگری می‌پرد)
- **`goto default`** (به بند default می‌پرد)
- **هر دستور پرش دیگری** - یعنی `return`, `throw`, `continue`, یا `goto label`

### چندین case با کد مشترک

زمانی که بیش از یک مقدار باید کد یکسانی را اجرا کند، می‌توانید case های مشترک را به صورت پشت سر هم فهرست کنید:

```csharp
switch (cardNumber)
{
  case 13:
  case 12:
  case 11:
Console.WriteLine ("Face card");
break;
  default:
Console.WriteLine ("Plain card");
break;
}
```
**نکته:** این ویژگی دستور `switch` می‌تواند از نظر تولید کد تمیزتر نسبت به چندین دستور `if-else` محوری باشد.
