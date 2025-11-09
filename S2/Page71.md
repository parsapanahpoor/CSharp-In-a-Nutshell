The out modifier
 A parameter can be passed by reference or by value, regardless
 of whether the parameter type is a reference type or a value
 type.
 An out argument is like a ref argument except for the following:
 •
 • It need not be assigned before going into the function.
 •
 • It must be assigned before it comes out of the function.
 The out modifier is most commonly used to get multiple return values back from a
 method; for example:
 string a, b;
 Split ("Stevie Ray Vaughn", out a, out b);
 Console.WriteLine (a);                      // Stevie Ray
 Console.WriteLine (b);                      // Vaughn
 void Split (string name, out string firstNames, out string lastName)
 {
  int i = name.LastIndexOf (' ');
  firstNames = name.Substring (0, i);
  lastName = name.Substring (i + 1);
 }
 Like a ref parameter, an out parameter is passed by reference

 ## ترجمه => Modifier از نوع out

یک پارامتر می‌تواند by reference یا by value منتقل شود، صرف نظر از اینکه نوع پارامتر یک reference type است یا value type.

یک آرگومان `out` مانند یک آرگومان `ref` است به جز موارد زیر:

- نیازی نیست قبل از ورود به تابع مقداردهی شود.
- باید قبل از خروج از تابع مقداردهی شود.

ترجمه =>Modifier از نوع `out` بیشتر برای دریافت چندین مقدار بازگشتی از یک متد استفاده می‌شود؛ برای مثال:
```csharp
string a, b;
Split ("Stevie Ray Vaughn", out a, out b);
Console.WriteLine (a);                      // Stevie Ray
Console.WriteLine (b);                      // Vaughn

void Split (string name, out string firstNames, out string lastName)
{
int i = name.LastIndexOf (' ');
firstNames = name.Substring (0, i);
lastName = name.Substring (i + 1);
}
```

مانند یک پارامتر `ref`، یک پارامتر `out` به صورت by reference منتقل می‌شود.


**خلاصه نکات مهم:**

257. **مشابهت با ref:** پارامتر `out` مانند `ref` به صورت by reference منتقل می‌شود.

258. **عدم نیاز به مقداردهی ورودی:** پارامتر `out` نیازی به مقداردهی قبل از ورود به تابع ندارد.

259. **الزام مقداردهی خروجی:** پارامتر `out` باید حتماً قبل از خروج از تابع مقداردهی شود.

260. **کاربرد اصلی out:** `out` بیشتر برای برگرداندن چندین مقدار از یک متد استفاده می‌شود.

261. **مثال Split:** متد `Split` نمونه‌ای از استفاده `out` برای برگرداندن چند مقدار است.

262. **انتقال by reference:** `out` نیز مانند `ref` پارامتر را by reference منتقل می‌کند.

263. **تفاوت اصلی ref و out:** تفاوت اصلی در زمان مقداردهی است؛ `ref` در ورود و `out` در خروج.

آماده دریافت بخش بعدی هستم.
