## Indices and Ranges
Indices and ranges (introduced in C# 8) simplify working with elements or portions of an array.
64
## NOTE
Indices and ranges also work with the CLR types Span<T> and ReadOnlySpan<T> (see Chapter 23).
You can also make your own types work with indices and ranges, by defining an indexer of type Index or Range (see
“Indexers”).

## Indices
Indices let you refer to elements relative to the end of an array, with the ^ operator. ^1 refers to the
last element, ^2 refers to the second-to-last element, and so on:
char[] vowels = new char[] {'a','e','i','o','u'};
char lastElement = vowels [^1]; // 'u'
char secondToLast = vowels [^2]; // 'o'
(^0 equals the length of the array, so vowels[^0] generates an error.)
C# implements indices with the help of the Index type, so you can also do the following:
Index first = 0;
Index last = ^1;
char firstElement = vowels [first]; // 'a'
char lastElement = vowels [last]; // 'u'

## Ranges
Ranges let you “slice” an array by using the .. operator:
char[] firstTwo = vowels [..2]; // 'a', 'e'
char[] lastThree = vowels [2..]; // 'i', 'o', 'u'
char[] middleOne = vowels [2..3]; // 'i'
e second number in the range is exclusive, so ..2 returns the elements before vowels[2].
You can also use the ^ symbol in ranges. e following returns the last two characters:
char[] lastTwo = vowels [^2..]; // 'o', 'u'
C# implements ranges with the help of the Range type, so you can also do the following:
Range firstTwoRange = 0..2;
char[] firstTwo = vowels [firstTwoRange]; // 'a', 'e'



## Indexها و Rangeها

 ترجمه  => Indexها و rangeها (معرفی شده در C# 8) کار با elementsها یا بخش‌هایی از یک آرایه را ساده می‌کنند.

## نکته
ترجمه  => Indexها و rangeها همچنین با typeهای CLR مربوط به `Span<T>` و `ReadOnlySpan<T>` کار می‌کنند (فصل 23 را ببینید). همچنین می‌توانید typeهای خود را با indexها و rangeها کار کنید، با تعریف یک indexer از نوع `Index` یا `Range` (به بخش "Indexers" مراجعه کنید).

## Indexها

ترجمه  => Indexها به شما اجازه می‌دهند به elementsها نسبت به انتهای آرایه با استفاده از عملگر `^` اشاره کنید. `^1` به آخرین element اشاره می‌کند، `^2` به element قبل از آخر اشاره می‌کند، و به همین ترتیب:
```csharp
char[] vowels = new char[] {'a','e','i','o','u'};
char lastElement = vowels [^1]; // 'u'
char secondToLast = vowels [^2]; // 'o'
```
(`^0` برابر با طول آرایه است، بنابراین `vowels[^0]` خطا ایجاد می‌کند.)

ترجمه  => C# indexها را با کمک نوع `Index` پیاده‌سازی می‌کند، بنابراین می‌توانید کار زیر را هم انجام دهید:

```csharp
Index first = 0;
Index last = ^1;
char firstElement = vowels [first]; // 'a'
char lastElement = vowels [last]; // 'u'
```
## Rangeها

ترجمه  => Rangeها به شما اجازه می‌دهند یک آرایه را با استفاده از عملگر `..` "slice" کنید:

```csharp
char[] firstTwo = vowels [..2]; // 'a', 'e'
char[] lastThree = vowels [2..]; // 'i', 'o', 'u'
char[] middleOne = vowels [2..3]; // 'i'
```
عدد دوم در range exclusive است، بنابراین `..2` elementsهای قبل از `vowels[2]` را برمی‌گرداند.

همچنین می‌توانید از نماد `^` در rangeها استفاده کنید. کد زیر دو کاراکتر آخر را برمی‌گرداند:

```csharp
char[] lastTwo = vowels [^2..]; // 'o', 'u'
```
ترجمه  => C# rangeها را با کمک نوع `Range` پیاده‌سازی می‌کند، بنابراین می‌توانید کار زیر را هم انجام دهید:

```csharp
Range firstTwoRange = 0..2;
char[] firstTwo = vowels [firstTwoRange]; // 'a', 'e'
```

**خلاصه نکات مهم:**

ترجمه  => 169. **Indices and Ranges (C# 8):** قابلیتی برای ساده کردن کار با elementsها یا بخش‌های آرایه.

ترجمه  => 170. **Compatibility:** Indexها و rangeها با `Span<T>` و `ReadOnlySpan<T>` نیز کار می‌کنند و قابل پیاده‌سازی برای typeهای سفارشی هستند.

ترجمه  => 171. **Index operator (`^`):** برای اشاره به elementsها نسبت به انتهای آرایه؛ `^1` آخرین element، `^2` قبل از آخر و غیره.

ترجمه  => 172. **`^0` restriction:** `^0` برابر با طول آرایه است و استفاده از آن خطا ایجاد می‌کند.

ترجمه  => 173. **Index type:** C# از نوع `Index` برای پیاده‌سازی indexها استفاده می‌کند که امکان ذخیره و استفاده مجدد را فراهم می‌کند.

ترجمه  => 174. **Range operator (`..`):** برای "slice" کردن آرایه و استخراج بخشی از آن (مثل `vowels[..2]` یا `vowels[2..]`).

ترجمه  => 175. **Exclusive end:** عدد دوم در range exclusive است (مثلاً `..2` elementsهای قبل از index 2 را برمی‌گرداند).

ترجمه  => 176. **Range with `^`:** امکان استفاده از `^` در rangeها برای slice کردن نسبت به انتهای آرایه (مثل `vowels[^2..]`).

ترجمه  => 177. **Range type:** C# از نوع `Range` برای پیاده‌سازی rangeها استفاده می‌کند که امکان ذخیره و استفاده مجدد را فراهم می‌کند.
