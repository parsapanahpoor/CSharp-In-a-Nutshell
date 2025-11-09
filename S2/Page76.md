Ref Returns
 The Span<T> and ReadOnlySpan<T> types that we describe
 in Chapter 23 use ref returns to implement a highly effi
cient indexer. Outside such scenarios, ref returns are not com
monly used, and you can consider them a micro-optimization
 feature.
 You can return a ref local from a method. This is called a ref return:
 class Program
 {
  static string x = "Old Value";
  static ref string GetX() => ref x;    // This method returns a ref
  static void Main()
  {
 ref string xRef = ref GetX();       // Assign result to a ref local
    xRef = "New Value";
    Console.WriteLine (x);              // New Value
  }
 }
 If you omit the ref modifier on the calling side, it reverts to returning an ordinary
 value:
 string localX = GetX();  // Legal: localX is an ordinary non-ref variable.
 You also can use ref returns when defining a property or indexer:
 static ref string Prop => ref x;
 Such a property is implicitly writable, despite there being no set accessor:
 Prop = "New Value";
 You can prevent such modification by using ref readonly:
 static ref readonly string Prop => ref x;
  The ref readonly modifier prevents modification while still enabling the perfor
mance gain of returning by reference. The gain would be very small in this case,
 because x is of type string (a reference type): no matter how long the string, the
 only inefficiency that you can hope to avoid is the copying of a single 32- or 64-bit
 reference. Real gains can occur with custom value types (see “Structs” on page 142),
 but only if the struct is marked as readonly (otherwise, the compiler will perform a
 defensive copy).
 Attempting to define an explicit set accessor on a ref return property or indexer is
 illegal.

 ## مقادیر برگشتی مرجعی (Ref Returns)

انواع `Span<T>` و `ReadOnlySpan<T>` که در فصل 23 توضیح می‌دهیم، از **ref returns** برای پیاده‌سازی یک **indexer** بسیار کارآمد استفاده می‌کنند. خارج از چنین سناریوهایی، **ref returns** معمولاً استفاده نمی‌شوند و می‌توانید آن‌ها را یک ویژگی بهینه‌سازی میکرو در نظر بگیرید.

شما می‌توانید یک **ref local** را از یک متد برگردانید. به این کار **ref return** گفته می‌شود:
```csharp
class Program
{
static string x = "Old Value";
static ref string GetX() => ref x;    // این متد یک ref برمی‌گرداند

static void Main()
{
ref string xRef = ref GetX();       // نتیجه را به یک ref local اختصاص دهید
xRef = "New Value";
Console.WriteLine(x);              // New Value
}
}
```
اگر modifier `ref` را در سمت فراخوانی حذف کنید، به برگرداندن یک مقدار معمولی تبدیل می‌شود:

```csharp
string localX = GetX();  // قانونی: localX یک متغیر معمولی non-ref است
```
همچنین می‌توانید از **ref returns** هنگام تعریف یک **property** یا **indexer** استفاده کنید:

```csharp
static ref string Prop => ref x;
```
چنین property‌ای به صورت ضمنی قابل نوشتن است، با وجود اینکه **set accessor** ندارد:

```csharp
Prop = "New Value";
```
می‌توانید با استفاده از `ref readonly` از چنین تغییری جلوگیری کنید:

```csharp
static ref readonly string Prop => ref x;
```

## مانع از تغییر با ref readonly

ترجمه => modifier `ref readonly` از تغییر جلوگیری می‌کند در حالی که همچنان امکان بهبود عملکرد از طریق برگرداندن به صورت مرجع را فراهم می‌کند. در این مورد، سود حاصله بسیار کوچک خواهد بود، زیرا `x` از نوع `string` است (یک **reference type**): مهم نیست رشته چقدر طولانی باشد، تنها ناکارآمدی که می‌توانید امیدوار باشید از آن اجتناب کنید، کپی کردن یک مرجع 32 یا 64 بیتی است. سودهای واقعی می‌توانند با **custom value types** رخ دهند (بخش "Structs" در صفحه 142 را ببینید)، اما فقط در صورتی که **struct** به عنوان `readonly` علامت‌گذاری شده باشد (در غیر این صورت، کامپایلر یک کپی دفاعی انجام خواهد داد).

تلاش برای تعریف یک **set accessor** صریح روی یک **ref return property** یا **indexer** غیرقانونی است.
