
Bounds Checking
 All array indexing is bounds checked by the runtime. An IndexOutOfRange
 Exception is thrown if you use an invalid index:
 int[] arr = new int[3];
 arr[3] = 1;               // IndexOutOfRangeException thrown
 Array bounds checking is necessary for type safety and simplifies debugging.
 66 
| 
Generally, the performance hit from bounds checking is
 minor, and the Just-In-Time (JIT) compiler can perform opti
mizations, such as determining in advance whether all indexes
 will be safe before entering a loop, thus avoiding a check on
 each iteration. In addition, C# provides “unsafe” code that
 can explicitly bypass bounds checking (see “Unsafe Code and
 Pointers” on page 263).

 Variables and Parameters
 A variable represents a storage location that has a modifiable value. A variable can
 be a local variable, parameter (value, ref, or out, or in), field (instance or static), or
 array element.
 The Stack and the Heap
 The stack and the heap are the places where variables reside. Each has very different
 lifetime semantics.
 Stack
 The stack is a block of memory for storing local variables and parameters. The stack
 logically grows and shrinks as a method or function is entered and exited. Consider
 the following method (to avoid distraction, input argument checking is ignored):
 static int Factorial (int x)
 {
  if (x == 0) return 1;
  return x * Factorial (x-1);
 }
 This method is recursive, meaning that it calls itself. Each time the method is
 entered, a new int is allocated on the stack, and each time the method exits, the int
 is deallocated.
 Heap
 The heap is the memory in which objects (i.e., reference-type instances) reside.
 Whenever a new object is created, it is allocated on the heap, and a reference to that
 object is returned. During a program’s execution, the heap begins filling up as new
 objects are created. The runtime has a garbage collector that periodically deallocates
 objects from the heap, so your program does not run out of memory. An object is
 eligible for deallocation as soon as it’s not referenced by anything that’s itself “alive.”
 In the following example, we begin by creating a StringBuilder object referenced
 by the variable ref1 and then write out its content. That StringBuilder object
 is then immediately eligible for garbage collection because nothing subsequently
 uses it.
 C# Language
 Basics
 Variables and Parameters | 67
Then, we create another StringBuilder referenced by variable ref2 and copy
 that reference to ref3. Even though ref2 is not used after that point, ref3 keeps
 the same StringBuilder object alive—ensuring that it doesn’t become eligible for
 collection until we’ve finished using ref3:
 using System;
 using System.Text;
 StringBuilder ref1 = new StringBuilder ("object1");
 Console.WriteLine (ref1);
 // The StringBuilder referenced by ref1 is now eligible for GC.
 StringBuilder ref2 = new StringBuilder ("object2");
 StringBuilder ref3 = ref2;
 // The StringBuilder referenced by ref2 is NOT yet eligible for GC.
 Console.WriteLine (ref3);      // object2
 Value-type instances (and object references) live wherever the variable was declared.
 If the instance was declared as a field within a class type, or as an array element, that
 instance lives on the heap.
 You can’t explicitly delete objects in C#, as you can in C++.
 An unreferenced object is eventually collected by the garbage
 collector.
 The heap also stores static fields. Unlike objects allocated on the heap (which can be
 garbage-collected), these live until the process ends

-----------------------------------------------------------

## بررسی محدوده‌ها

تمام indexing آرایه‌ها توسط runtime بررسی محدوده می‌شوند. اگر از یک index نامعتبر استفاده کنید، یک `IndexOutOfRangeException` پرتاب می‌شود:
```csharp
int[] arr = new int[3];
arr[3] = 1;               // IndexOutOfRangeException پرتاب می‌شود
```
بررسی محدوده‌های آرایه برای امنیت type ضروری است و دیباگ کردن را ساده می‌کند.

## نکته
به طور کلی، افت عملکرد ناشی از بررسی محدوده‌ها جزئی است، و کامپایلر Just-In-Time (JIT) می‌تواند بهینه‌سازی‌هایی انجام دهد، مانند تعیین پیشاپیش اینکه آیا تمام indexها قبل از ورود به یک حلقه امن خواهند بود یا خیر، و در نتیجه از بررسی در هر تکرار جلوگیری کند. علاوه بر این، سی‌شارپ کد "ناامن" (unsafe) را ارائه می‌دهد که می‌تواند به صورت صریح بررسی محدوده‌ها را دور بزند (به بخش "Unsafe Code and Pointers" در صفحه 263 مراجعه کنید).


**خلاصه نکات مهم:**

199. **بررسی محدوده‌های آرایه:** تمام indexing آرایه‌ها توسط runtime بررسی محدوده می‌شوند.

200. **استثنای خارج از محدوده:** استفاده از index نامعتبر منجر به پرتاب `IndexOutOfRangeException` می‌شود.

201. **ضرورت بررسی محدوده:** بررسی محدوده‌های آرایه برای امنیت type ضروری است و دیباگ کردن را ساده می‌کند.

202. **افت عملکرد جزئی:** افت عملکرد ناشی از بررسی محدوده‌ها به طور کلی جزئی است.

203. **بهینه‌سازی JIT:** کامپایلر Just-In-Time می‌تواند بهینه‌سازی‌هایی مانند بررسی پیشاپیش امنیت indexها قبل از ورود به حلقه انجام دهد.

204. **جلوگیری از بررسی تکراری:** بهینه‌سازی JIT می‌تواند از بررسی محدوده در هر تکرار حلقه جلوگیری کند.

205. **کد ناامن:** سی‌شارپ کد unsafe را ارائه می‌دهد که می‌تواند به صورت صریح بررسی محدوده‌ها را دور بزند.



## متغیرها و پارامترها

یک متغیر نشان‌دهنده یک مکان ذخیره‌سازی است که دارای یک مقدار قابل تغییر است. یک متغیر می‌تواند یک متغیر محلی، پارامتر (value، ref، out یا in)، فیلد (instance یا static)، یا عنصر آرایه باشد.

## Stack و Heap

ترجمه => Stack و Heap مکان‌هایی هستند که متغیرها در آن‌ها قرار دارند. هر کدام معناشناسی طول عمر بسیار متفاوتی دارند.

### Stack


ترجمه => Stack یک بلوک حافظه برای ذخیره‌سازی متغیرهای محلی و پارامترها است. Stack به صورت منطقی با ورود و خروج از یک متد یا تابع، رشد و کاهش می‌یابد. کد زیر را در نظر بگیرید (برای جلوگیری از حواس‌پرتی، بررسی آرگومان ورودی نادیده گرفته شده است):
```csharp
static int Factorial (int x)
{
if (x == 0) return 1;
return x * Factorial (x-1);
}
```

این متد بازگشتی است، به این معنی که خودش را فراخوانی می‌کند. هر بار که متد وارد می‌شود، یک `int` جدید روی stack تخصیص داده می‌شود، و هر بار که متد خارج می‌شود، آن `int` آزاد می‌شود.

### Heap


ترجمه => Heap حافظه‌ای است که در آن objectها (یعنی نمونه‌های reference-type) قرار دارند. هر زمان که یک object جدید ایجاد می‌شود، روی heap تخصیص داده می‌شود و یک reference به آن object برگردانده می‌شود. در طول اجرای یک برنامه، heap با ایجاد objectهای جدید شروع به پر شدن می‌کند. runtime دارای یک garbage collector است که به صورت دوره‌ای objectها را از heap آزاد می‌کند، بنابراین برنامه شما از حافظه خارج نمی‌شود. یک object به محض اینکه توسط چیزی که خودش "زنده" است ارجاع داده نشود، برای آزادسازی واجد شرایط می‌شود.

در مثال زیر، با ایجاد یک object از نوع `StringBuilder` که توسط متغیر `ref1` ارجاع داده می‌شود شروع می‌کنیم و سپس محتوای آن را می‌نویسیم. آن object از نوع `StringBuilder` بلافاصله برای garbage collection واجد شرایط می‌شود زیرا پس از آن چیزی از آن استفاده نمی‌کند.

سپس، یک `StringBuilder` دیگر ایجاد می‌کنیم که توسط متغیر `ref2` ارجاع داده می‌شود و آن reference را به `ref3` کپی می‌کنیم. حتی اگر `ref2` پس از آن نقطه استفاده نشود، `ref3` همان object از نوع `StringBuilder` را زنده نگه می‌دارد—و تضمین می‌کند که تا زمانی که استفاده از `ref3` را تمام نکرده‌ایم، برای collection واجد شرایط نمی‌شود:

```csharp
using System;
using System.Text;

StringBuilder ref1 = new StringBuilder ("object1");
Console.WriteLine (ref1);
// StringBuilder که توسط ref1 ارجاع داده می‌شود اکنون برای GC واجد شرایط است.

StringBuilder ref2 = new StringBuilder ("object2");
StringBuilder ref3 = ref2;
// StringBuilder که توسط ref2 ارجاع داده می‌شود هنوز برای GC واجد شرایط نیست.

Console.WriteLine (ref3);      // object2
```

نمونه‌های value-type (و referenceهای object) در هر جایی که متغیر اعلان شده باشد، زندگی می‌کنند. اگر نمونه به عنوان یک فیلد در یک class type یا به عنوان یک عنصر آرایه اعلان شده باشد، آن نمونه روی heap زندگی می‌کند.

## نکته مهم
نمی‌توانید objectها را در سی‌شارپ به صورت صریح حذف کنید، همانطور که در ++C می‌توانید. یک object بدون reference در نهایت توسط garbage collector جمع‌آوری می‌شود.


ترجمه => Heap همچنین فیلدهای static را ذخیره می‌کند. برخلاف objectهایی که روی heap تخصیص داده می‌شوند (که می‌توانند garbage-collected شوند)، این فیلدها تا زمان پایان یافتن فرآیند زنده می‌مانند.


**خلاصه نکات مهم:**

206. **تعریف متغیر:** متغیر نشان‌دهنده یک مکان ذخیره‌سازی با مقدار قابل تغییر است.

207. **انواع متغیرها:** متغیر می‌تواند local variable، parameter، field یا array element باشد.

208. **انواع پارامترها:** پارامترها می‌توانند value، ref، out یا in باشند.


ترجمه => 209. **Stack و Heap:** دو مکان اصلی برای ذخیره‌سازی متغیرها با معناشناسی طول عمر متفاوت.

210. **تعریف Stack:** بلوک حافظه برای ذخیره متغیرهای محلی و پارامترها که با ورود و خروج از متد رشد و کاهش می‌یابد.

211. **رفتار Stack:** با ورود به متد، متغیرها تخصیص داده می‌شوند و با خروج از متد آزاد می‌شوند.

212. **متدهای بازگشتی و Stack:** هر فراخوانی بازگشتی متغیرهای جدیدی روی stack تخصیص می‌دهد.

213. **تعریف Heap:** حافظه‌ای که در آن objectها (نمونه‌های reference-type) قرار دارند.

214. **تخصیص روی Heap:** هر object جدید روی heap تخصیص داده می‌شود و reference به آن برگردانده می‌شود.


ترجمه => 215. **Garbage Collector:** runtime دارای garbage collector است که به صورت دوره‌ای objectها را از heap آزاد می‌کند.

216. **شرایط collection:** object وقتی برای آزادسازی واجد شرایط می‌شود که توسط چیزی که خودش زنده است ارجاع داده نشود.

217. **مثال reference زنده:** اگر یک reference کپی شود، object تا زمانی که آخرین reference زنده است، واجد شرایط collection نمی‌شود.

218. **مکان value-types:** نمونه‌های value-type در جایی که متغیر اعلان شده زندگی می‌کنند.


ترجمه => 219. **value-type روی Heap:** اگر value-type به عنوان فیلد class یا عنصر آرایه اعلان شود، روی heap قرار می‌گیرد.

220. **عدم امکان حذف صریح:** برخلاف ++C، در سی‌شارپ نمی‌توان objectها را به صورت صریح حذف کرد.

221. **فیلدهای static روی Heap:** فیلدهای static روی heap ذخیره می‌شوند اما برخلاف objectهای عادی تا پایان فرآیند زنده می‌مانند.

 
