 The public keyword
 The public keyword exposes members to other classes. In this example, if the Name
 field in Panda was not marked as public, it would be private and could not be
 accessed from outside the class. Marking a member public is how a type communi
cates: “Here is what I want other types to see—everything else is my own private
 implementation details.” In object-oriented terms, we say that the public members
 encapsulate the private members of the class.
 Defining namespaces
 Particularly with larger programs, it makes sense to organize types into namespaces.
 Here’s how to define the Panda class inside a namespace called Animals:
 using System;
 using Animals;
 Panda p = new Panda ("Pan Dee");
 Console.WriteLine (p.Name);

 namespace Animals
 {
  public class Panda
  {
     ...
  }
 }
 In this example, we also imported the Animals namespace so that our top-level
 statements could access its types without qualification. Without that import, we’d
 need to do this:
 Animals.Panda p = new Animals.Panda ("Pan Dee");
 We cover namespaces in detail at the end of this chapter (see “Namespaces” on page
 95).

 ## کلمه کلیدی public

کلمه کلیدی public اعضا را در معرض classهای دیگر قرار می‌دهد. در این مثال، اگر field به نام Name در Panda به عنوان public علامت‌گذاری نشده بود، private بود و نمی‌توانست از خارج class دسترسی پیدا کند. علامت‌گذاری یک member به عنوان public روشی است که یک type ارتباط برقرار می‌کند: "این چیزی است که می‌خواهم typeهای دیگر ببینند—هر چیز دیگری جزئیات پیاده‌سازی خصوصی (private) خودم است." در اصطلاحات شی‌گرا (object-oriented)، می‌گوییم که memberهای public، memberهای private از class را کپسوله‌سازی (encapsulate) می‌کنند.

## تعریف Namespaceها

به ویژه با برنامه‌های بزرگ‌تر، سازماندهی typeها در namespaceها منطقی است. در اینجا نحوهٔ تعریف class به نام Panda در داخل یک namespace به نام Animals آمده است:
```csharp
using System;
using Animals;

Panda p = new Panda ("Pan Dee");
Console.WriteLine (p.Name);

namespace Animals
{
  public class Panda
  {
...
  }
}
```
در این مثال، namespace به نام Animals را نیز import کردیم تا top-level statements ما بتوانند بدون qualification به typeهای آن دسترسی پیدا کنند. بدون آن import، باید این کار را انجام می‌دادیم:

```csharp
Animals.Panda p = new Animals.Panda ("Pan Dee");
```
فضای نام ها را در پایان این فصل به تفصیل پوشش می‌دهیم (به "Namespaces" در صفحه 95 مراجعه کنید).
