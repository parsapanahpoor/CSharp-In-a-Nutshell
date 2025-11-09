Out variables and discards
 You can declare variables on the fly when calling methods with out parameters. We
 can replace the first two lines in our preceding example with this:
 Split ("Stevie Ray Vaughan", out string a, out string b);
 When calling methods with multiple out parameters, sometimes you’re not interes
ted in receiving values from all the parameters. In such cases, you can “discard” the
 ones in which you’re uninterested by using an underscore:
 Split ("Stevie Ray Vaughan", out string a, out _);   // Discard 2nd param
 Console.WriteLine (a);
 In this case, the compiler treats the underscore as a special symbol, called a discard.
 You can include multiple discards in a single call. Assuming SomeBigMethod has
 been defined with seven out parameters, we can ignore all but the fourth, as follows:
 SomeBigMethod (out _, out _, out _, out int x, out _, out _, out _);
 For backward compatibility, this language feature will not take effect if a real
 underscore variable is in scope:
 string _;
 Split ("Stevie Ray Vaughan", out string a, out _);
 Console.WriteLine (_);     // Vaughan
 Implications of passing by reference
 When you pass an argument by reference, you alias the storage location of an
 existing variable rather than create a new storage location. In the following example,
 the variables x and y represent the same instance:
 class Test
 {
  static int x;
  static void Main() { Foo (out x); }
  static void Foo (out int y)
  {
    Console.WriteLine (x);                // x is 0
    y = 1;                                // Mutate y
    Console.WriteLine (x);                // x is 1
  }
 }
 The in modifier
 An in parameter is similar to a ref parameter except that the argument’s value
 cannot be modified by the method (doing so generates a compile-time error). This
 modifier is most useful when passing a large value type to the method because it
 allows the compiler to avoid the overhead of copying the argument prior to passing
 it in while still protecting the original value from modification.
 Overloading solely on the presence of in is permitted:
 void Foo (   SomeBigStruct a) { ... }
 void Foo (in SomeBigStruct a) { ... }
 To call the second overload, the caller must use the in modifier:
 SomeBigStruct x = ...;
 Foo (x);      // Calls the first overload
 Foo (in x);   // Calls the second overload
 When there’s no ambiguity
 void Bar (in SomeBigStruct a) { ... }
 use of the in modifier is optional for the caller:
 Bar (x);     // OK (calls the 'in' overload)
 Bar (in x);  // OK (calls the 'in' overload)
 To make this example meaningful, SomeBigStruct would be defined as a struct (see
 “Structs” on page 142).


 ## متغیرهای Out و Discards

می‌توانید متغیرها را به صورت on-the-fly (همان لحظه) هنگام فراخوانی متدهایی با پارامترهای `out` تعریف کنید. می‌توانیم دو خط اول در مثال قبلی را با این جایگزین کنیم:
```csharp
Split ("Stevie Ray Vaughan", out string a, out string b);
```
هنگام فراخوانی متدهایی با چندین پارامتر `out`، گاهی اوقات به دریافت مقادیر از همه پارامترها علاقه‌ای ندارید. در چنین مواردی، می‌توانید آن‌هایی که به آنها علاقه ندارید را با استفاده از یک آندراسکور "discard" کنید:

```csharp
Split ("Stevie Ray Vaughan", out string a, out _);   // پارامتر دوم را نادیده می‌گیرد
Console.WriteLine (a);
```
در این حالت، کامپایلر آندراسکور را به عنوان یک نماد خاص به نام **discard** در نظر می‌گیرد.

می‌توانید چندین discard را در یک فراخوانی واحد قرار دهید. با فرض اینکه `SomeBigMethod` با هفت پارامتر `out` تعریف شده باشد، می‌توانیم همه را به جز پارامتر چهارم نادیده بگیریم:

```csharp
SomeBigMethod (out _, out _, out _, out int x, out _, out _, out _);
```
برای سازگاری با نسخه‌های قبلی، این ویژگی زبان اعمال نمی‌شود اگر یک متغیر واقعی با نام آندراسکور در scope باشد:

```csharp
string _;
Split ("Stevie Ray Vaughan", out string a, out _);
Console.WriteLine (_);     // Vaughan
```
## پیامدهای انتقال by reference

هنگامی که یک آرگومان را by reference منتقل می‌کنید، به مکان ذخیره‌سازی یک متغیر موجود **alias** می‌دهید به جای اینکه یک مکان ذخیره‌سازی جدید ایجاد کنید. در مثال زیر، متغیرهای `x` و `y` همان instance را نمایش می‌دهند:

```csharp
class Test
{
static int x;
static void Main() { Foo (out x); }
static void Foo (out int y)
{
Console.WriteLine (x);                // x برابر 0 است
y = 1;                                // y را تغییر می‌دهد
Console.WriteLine (x);                // x برابر 1 است
}
}
```
## ترجمه => Modifier از نوع in

یک پارامتر `in` شبیه به یک پارامتر `ref` است به جز اینکه مقدار آرگومان نمی‌تواند توسط متد تغییر کند (انجام این کار یک خطای زمان کامپایل تولید می‌کند). این modifier بیشتر زمانی مفید است که یک value type بزرگ را به متد منتقل می‌کنید، زیرا به کامپایلر اجازه می‌دهد از overhead کپی کردن آرگومان قبل از انتقال آن اجتناب کند، در حالی که همچنان مقدار اصلی را از تغییر محافظت می‌کند.

 ترجمه =>Overloading صرفاً بر اساس وجود `in` مجاز است:

```csharp
void Foo (   SomeBigStruct a) { ... }
void Foo (in SomeBigStruct a) { ... }
```
برای فراخوانی overload دوم، caller باید از modifier `in` استفاده کند:

```csharp
SomeBigStruct x = ...;
Foo (x);      // overload اول را فراخوانی می‌کند
Foo (in x);   // overload دوم را فراخوانی می‌کند
```
زمانی که ابهامی وجود ندارد:

```csharp
void Bar (in SomeBigStruct a) { ... }
```
استفاده از modifier `in` برای caller اختیاری است:

```csharp
Bar (x);     // OK (overload 'in' را فراخوانی می‌کند)
Bar (in x);  // OK (overload 'in' را فراخوانی می‌کند)
```
برای معنادار شدن این مثال، `SomeBigStruct` باید به عنوان یک `struct` تعریف شود (به بخش "Structs" در صفحه 142 مراجعه کنید).


**خلاصه نکات مهم:**

264. **تعریف on-the-fly:** می‌توان متغیرهای `out` را همان لحظه فراخوانی متد تعریف کرد.

265. ترجمه => **Discard با آندراسکور:** از `_` برای نادیده گرفتن پارامترهای `out` که به آنها نیازی نیست استفاده می‌شود.

266. **نماد خاص discard:** کامپایلر `_` را به عنوان یک نماد خاص discard تشخیص می‌دهد.

267. **چندین discard:** می‌توان چندین `_` در یک فراخوانی استفاده کرد.

268. **سازگاری با گذشته:** اگر متغیر واقعی `_` در scope باشد، discard کار نمی‌کند.

269. ترجمه => **Aliasing در by reference:** انتقال by reference به مکان ذخیره‌سازی موجود alias می‌دهد.

270. **اشتراک instance:** متغیرهایی که by reference منتقل می‌شوند، به همان instance ارجاع می‌دهند.

271. ترجمه => **modifier از نوع in:** `in` شبیه `ref` است اما مقدار را فقط خواندنی می‌کند.

272. **جلوگیری از تغییر:** با `in` نمی‌توان مقدار آرگومان را در متد تغییر داد (خطای کامپایل).

273. **کاربرد in:** `in` برای انتقال value typeهای بزرگ مفید است تا از overhead کپی جلوگیری شود.

274. ترجمه => **Overloading با in:** می‌توان متدها را فقط بر اساس وجود `in` overload کرد.

275. **الزام in در فراخوانی overload:** برای فراخوانی overload با `in`، باید صریحاً `in` را در فراخوانی بنویسیم.

276. **اختیاری بودن in:** زمانی که ابهامی نیست، استفاده از `in` در فراخوانی اختیاری است.

آماده دریافت بخش بعدی هستم.
