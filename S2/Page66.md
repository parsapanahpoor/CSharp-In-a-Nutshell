## Simplified Array Initialization Expressions
ere are two ways to shorten array initialization expressions. e first is to omit the new operator
and type qualifications:
char[] vowels = {'a','e','i','o','u'};
int[,] rectangularMatrix =
{
{0,1,2},
{3,4,5},
{6,7,8}
};
int[][] jaggedMatrix =
{
new int[] {0,1,2},
new int[] {3,4,5},
new int[] {6,7,8,9}
};
e second approach is to use the var keyword, which instructs the compiler to implicitly type a
local variable:
var i = 3; // i is implicitly of type int
var s = "sausage"; // s is implicitly of type string
// Therefore:
var rectMatrix = new int[,] // rectMatrix is implicitly of type int[,]
{
{0,1,2},
{3,4,5},
{6,7,8}
};
var jaggedMat = new int[][] // jaggedMat is implicitly of type int[][]
{
new int[] {0,1,2},
new int[] {3,4,5},
new int[] {6,7,8,9}
};
Implicit typing can be taken one stage further with arrays: you can omit the type qualifier aer the
new keyword and have the compiler infer the array type:
67
var vowels = new[] {'a','e','i','o','u'}; // Compiler infers char[]
For this to work, the elements must all be implicitly convertible to a single type (and at least one of
the elements must be of that type, and there must be exactly one best type), as in the following
example:
var x = new[] {1,10000000000}; // all convertible to long



## عبارات ساده‌شده مقداردهی اولیه آرایه

دو روش برای کوتاه کردن عبارات مقداردهی اولیه آرایه وجود دارد. اولین روش حذف عملگر `new` و تعیین‌کننده‌های type است:
```csharp
char[] vowels = {'a','e','i','o','u'};

int[,] rectangularMatrix =
{
{0,1,2},
{3,4,5},
{6,7,8}
};

int[][] jaggedMatrix =
{
new int[] {0,1,2},
new int[] {3,4,5},
new int[] {6,7,8,9}
};
```
رویکرد دوم استفاده از کلمه کلیدی `var` است که به کامپایلر دستور می‌دهد یک متغیر محلی را به صورت ضمنی type کند:

```csharp
var i = 3;           // i به صورت ضمنی از نوع int است
var s = "sausage";   // s به صورت ضمنی از نوع string است

// بنابراین:
var rectMatrix = new int[,]  // rectMatrix به صورت ضمنی از نوع int[,] است
{
{0,1,2},
{3,4,5},
{6,7,8}
};

var jaggedMat = new int[][]  // jaggedMat به صورت ضمنی از نوع int[][] است
{
new int[] {0,1,2},
new int[] {3,4,5},
new int[] {6,7,8,9}
};
```
ترجمه =>  type کردن ضمنی را می‌توان یک مرحله بیشتر با آرایه‌ها پیش برد: می‌توانید تعیین‌کننده type را بعد از کلمه کلیدی `new` حذف کنید و اجازه دهید کامپایلر type آرایه را استنتاج کند:

```csharp
var vowels = new[] {'a','e','i','o','u'}; // کامپایلر char[] را استنتاج می‌کند
```
برای اینکه این کار جواب بدهد، تمام elementsها باید به صورت ضمنی به یک type واحد قابل تبدیل باشند (و حداقل یکی از elementsها باید از آن type باشد، و باید دقیقاً یک بهترین type وجود داشته باشد)، همانطور که در مثال زیر نشان داده شده است:

```csharp
var x = new[] {1,10000000000}; // همه قابل تبدیل به long هستند
```

**خلاصه نکات مهم:**


ترجمه =>189. **Simplified array initialization:** دو روش برای کوتاه کردن عبارات مقداردهی اولیه آرایه وجود دارد.


ترجمه =>190. **Omitting new operator:** روش اول حذف عملگر `new` و تعیین‌کننده‌های type است (مثل `char[] vowels = {'a','e','i','o','u'};`).


ترجمه =>191. **Rectangular array shorthand:** امکان حذف `new int[,]` در مقداردهی اولیه آرایه‌های مستطیلی.


ترجمه =>192. **Jagged array partial shorthand:** در آرایه‌های دندانه‌دار، براکت بیرونی را می‌توان حذف کرد اما آرایه‌های داخلی هنوز نیاز به `new int[]` دارند.


ترجمه =>193. **var keyword:** کلمه کلیدی `var` به کامپایلر دستور می‌دهد type متغیر محلی را به صورت ضمنی تعیین کند.


ترجمه =>194. **var with arrays:** استفاده از `var` با آرایه‌ها اجازه می‌دهد کامپایلر type آرایه را از عبارت سمت راست استنتاج کند.


ترجمه =>195. **Implicit array type inference:** می‌توان تعیین‌کننده type را بعد از `new` حذف کرد و اجازه داد کامپایلر type آرایه را استنتاج کند (مثل `var vowels = new[] {'a','e','i','o','u'};`).


ترجمه =>196. **Type inference requirements:** برای استنتاج type آرایه، تمام elementsها باید به صورت ضمنی به یک type واحد قابل تبدیل باشند.


ترجمه =>197. **Best type rule:** حداقل یک element باید از آن type باشد و باید دقیقاً یک بهترین type وجود داشته باشد.


ترجمه =>198. **Common type example:** مثال `var x = new[] {1,10000000000};` که کامپایلر `long` را به عنوان type مشترک استنتاج می‌کند.

آماده دریافت بخش بعدی هستم.
