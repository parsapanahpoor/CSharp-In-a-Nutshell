Passing arguments by value
 By default, arguments in C# are passed by value, which is by far the most common
 case. This means that a copy of the value is created when passed to the method:
 int x = 8;
 Foo (x);                    // Make a copy of x
 Console.WriteLine (x);      // x will still be 8
 static void Foo (int p)
 {
  p = p + 1;                // Increment p by 1
  Console.WriteLine (p);    // Write p to screen
 }
 Assigning p a new value does not change the contents of x, because p and x reside in
 different memory locations.
 Passing a reference-type argument by value copies the reference but not the object.
 In the following example, Foo sees the same StringBuilder object we instantiated
 (sb) but has an independent reference to it. In other words, sb and fooSB are
 separate variables that reference the same StringBuilder object:
 StringBuilder sb = new StringBuilder();
 Foo (sb);
 Console.WriteLine (sb.ToString());    // test
 static void Foo (StringBuilder fooSB)
 {
  fooSB.Append ("test");
  fooSB = null;
 }
 Because fooSB is a copy of a reference, setting it to null doesn’t make sb null. (If,
 however, fooSB was declared and called with the ref modifier, sb would become
 null.)
 The ref modifier
 To pass by reference, C# provides the ref parameter modifier. In the following
 example, p and x refer to the same memory locations:
 int x = 8;
 Foo (ref  x);              // Ask Foo to deal directly with x
 Console.WriteLine (x);     // x is now 9
 static void Foo (ref int p)
 {
  p = p + 1;               // Increment p by 1
  Console.WriteLine (p);   // Write p to screen
 }

 Now assigning p a new value changes the contents of x. Notice how the ref modifier
 is required both when writing and when calling the method.4 This makes it very
 clear what’s going on.
 The ref modifier is essential in implementing a swap method (in “Generics” on
 page 159, we show how to write a swap method that works with any type):
 string x = "Penn";
 string y = "Teller";
 Swap (ref x, ref y);
 Console.WriteLine (x);   // Teller
 Console.WriteLine (y);   // Penn
 static void Swap (ref string a, ref string b)
 {
  string temp = a;
  a = b;
  b = temp;
 }
 The out modifier
 A parameter can be passed by reference or by value, regardless
 of whether the parameter type is a reference type or a value
 type.


 ## انتقال آرگومان‌ها by value

به طور پیش‌فرض، آرگومان‌ها در سی‌شارپ by value منتقل می‌شوند که بسیار رایج است. این بدان معنی است که هنگام انتقال به متد، یک کپی از مقدار ایجاد می‌شود:
```csharp
int x = 8;
Foo (x);                    // یک کپی از x ایجاد می‌شود
Console.WriteLine (x);      // x هنوز 8 است

static void Foo (int p)
{
p = p + 1;                // p را 1 واحد افزایش می‌دهد
Console.WriteLine (p);    // p را روی صفحه می‌نویسد
}
```
اختصاص دادن یک مقدار جدید به `p` محتویات `x` را تغییر نمی‌دهد، زیرا `p` و `x` در مکان‌های حافظه متفاوتی قرار دارند.

انتقال یک آرگومان از نوع reference by value، reference را کپی می‌کند اما object را خیر. در مثال زیر، `Foo` همان object از نوع `StringBuilder` را که ما نمونه‌سازی کردیم (`sb`) می‌بیند اما یک reference مستقل به آن دارد. به عبارت دیگر، `sb` و `fooSB` متغیرهای جداگانه‌ای هستند که به همان object از نوع `StringBuilder` ارجاع می‌دهند:

```csharp
StringBuilder sb = new StringBuilder();
Foo (sb);
Console.WriteLine (sb.ToString());    // test

static void Foo (StringBuilder fooSB)
{
fooSB.Append ("test");
fooSB = null;
}
```
از آنجایی که `fooSB` یک کپی از یک reference است، تنظیم آن به `null`، `sb` را `null` نمی‌کند. (اگر، با این حال، `fooSB` با modifier از نوع `ref` اعلان و فراخوانی می‌شد، `sb` به `null` تبدیل می‌شد.)

## ترجمه => Modifier از نوع ref

برای انتقال by reference، سی‌شارپ modifier پارامتر `ref` را فراهم می‌کند. در مثال زیر، `p` و `x` به همان مکان‌های حافظه ارجاع می‌دهند:

```csharp
int x = 8;
Foo (ref x);              // از Foo می‌خواهیم که مستقیماً با x کار کند
Console.WriteLine (x);     // x اکنون 9 است

static void Foo (ref int p)
{
p = p + 1;               // p را 1 واحد افزایش می‌دهد
Console.WriteLine (p);   // p را روی صفحه می‌نویسد
}
```
اکنون اختصاص دادن یک مقدار جدید به `p` محتویات `x` را تغییر می‌دهد. توجه کنید که چگونه modifier از نوع `ref` هم هنگام نوشتن و هم هنگام فراخوانی متد مورد نیاز است. این موضوع را بسیار واضح می‌کند که چه اتفاقی در حال رخ دادن است.

 ترجمه =>Modifier از نوع `ref` برای پیاده‌سازی یک متد swap (جابه‌جایی) ضروری است:

```csharp
string x = "Penn";
string y = "Teller";
Swap (ref x, ref y);
Console.WriteLine (x);   // Teller
Console.WriteLine (y);   // Penn

static void Swap (ref string a, ref string b)
{
string temp = a;
a = b;
b = temp;
}
```
##  ترجمه => Modifier از نوع out

یک پارامتر می‌تواند by reference یا by value منتقل شود، صرف نظر از اینکه نوع پارامتر یک reference type است یا value type.


**خلاصه نکات مهم:**

244. **پیش‌فرض: by value:** به طور پیش‌فرض، آرگومان‌ها در سی‌شارپ by value منتقل می‌شوند.

245. **کپی مقدار:** انتقال by value یعنی ایجاد یک کپی از مقدار هنگام انتقال به متد.

246. **استقلال متغیرها:** تغییر پارامتر در متد تأثیری بر آرگومان اصلی ندارد زیرا در مکان‌های حافظه متفاوتی قرار دارند.

247.  ترجمه => **reference-type by value:** انتقال reference-type by value، reference را کپی می‌کند نه خود object را.

248. **مثال StringBuilder:** دو متغیر می‌توانند referenceهای مستقل به یک object واحد داشته باشند.

249. **تغییر reference کپی شده:** تنظیم reference کپی شده به `null` بر reference اصلی تأثیر نمی‌گذارد.

250.  ترجمه => **modifier از نوع ref:** برای انتقال by reference از `ref` استفاده می‌شود.

251. **اشتراک مکان حافظه:** با `ref`، پارامتر و آرگومان به همان مکان حافظه ارجاع می‌دهند.

252. **تأثیر تغییرات:** با `ref`، تغییر پارامتر مستقیماً آرگومان اصلی را تغییر می‌دهد.

253. **الزام استفاده دوطرفه:** `ref` باید هم در تعریف متد و هم در فراخوانی آن استفاده شود.

254. **وضوح کد:** استفاده دوطرفه `ref` رفتار کد را کاملاً واضح می‌کند.

255. **کاربرد swap:** `ref` برای پیاده‌سازی متد swap (جابه‌جایی) ضروری است.

256. **استقلال از نوع:** پارامتر می‌تواند by reference یا by value منتقل شود، صرف نظر از اینکه reference-type یا value-type است.

آماده دریافت بخش بعدی (ادامه modifier از نوع `out`) هستم.
