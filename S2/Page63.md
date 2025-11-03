## Default Element Initialization
Creating an array always preinitializes the elements with default values. e default value for a type is
the result of a bitwise zeroing of memory. For example, consider creating an array of integers.
Because int is a value type, this allocates 1,000 integers in one contiguous block of memory. e
default value for each element will be 0:
int[] a = new int[1000];
Console.Write (a[123]); // 0
## Value types versus reference types
Whether an array element type is a value type or a reference type has important performance
implications. When the element type is a value type, each element value is allocated as part of the
array, as shown here:
Point[] a = new Point[1000];
int x = a[500].X; // 0
public struct Point { public int X, Y; }
Had Point been a class, creating the array would have merely allocated 1,000 null references:
Point[] a = new Point[1000];
int x = a[500].X; // Runtime error, NullReferenceException
public class Point { public int X, Y; }
To avoid this error, we must explicitly instantiate 1,000 Points aer instantiating the array:
Point[] a = new Point[1000];
for (int i = 0; i < a.Length; i++) // Iterate i from 0 to 999
a[i] = new Point(); // Set array element i with new point
An array itself is always a reference type object, regardless of the element type. For instance, the
following is legal:
int[] a = null;


## مقداردهی اولیه پیش‌فرض Element

ایجاد یک آرایه همیشه elementsها را با مقادیر پیش‌فرض از قبل مقداردهی اولیه می‌کند. مقدار پیش‌فرض برای یک نوع، نتیجه صفر کردن بیتی حافظه است. برای مثال، ایجاد یک آرایه از اعداد صحیح را در نظر بگیرید. از آنجا که `int` یک value type است، این کار 1000 عدد صحیح را در یک بلوک مجاور از حافظه اختصاص می‌دهد. مقدار پیش‌فرض برای هر element صفر خواهد بود:
```csharp
int[] a = new int[1000];
Console.Write (a[123]); // 0
```
## value typeها در مقابل reference typeها

اینکه نوع element یک آرایه value type باشد یا reference type، پیامدهای مهم عملکردی دارد. وقتی نوع element یک value type است، هر مقدار element به عنوان بخشی از آرایه اختصاص داده می‌شود، همان‌طور که در اینجا نشان داده شده است:

```csharp
Point[] a = new Point[1000];
int x = a[500].X; // 0

public struct Point { public int X, Y; }
```
اگر `Point` یک class بود، ایجاد آرایه صرفاً 1000 reference مربوط به null را اختصاص می‌داد:

```csharp
Point[] a = new Point[1000];
int x = a[500].X; // خطای زمان اجرا، NullReferenceException

public class Point { public int X, Y; }
```
برای جلوگیری از این خطا، باید به صورت صریح 1000 `Point` را بعد از نمونه‌سازی آرایه نمونه‌سازی کنیم:

```csharp
Point[] a = new Point[1000];
for (int i = 0; i < a.Length; i++) // i را از 0 تا 999 تکرار می‌کند
a[i] = new Point(); // element آرایه i را با point جدید set می‌کند
```
خود یک آرایه همیشه یک شیء reference type است، صرف‌نظر از نوع element. برای مثال، کد زیر قانونی است:

```csharp
int[] a = null;
```

**خلاصه نکات مهم:**

 ترجمه => 162. **Default element initialization:** ایجاد آرایه همیشه elementsها را با مقادیر پیش‌فرض (صفر کردن بیتی حافظه) مقداردهی اولیه می‌کند.

ترجمه => 163. **Default values for value types:** برای value typeها (مثل `int`)، مقدار پیش‌فرض صفر است و تمام elementsها به صورت خودکار صفر می‌شوند.

ترجمه => 164. **Value type arrays:** وقتی نوع element یک value type است (مثل `struct`)، هر مقدار element به عنوان بخشی از آرایه در حافظه اختصاص داده می‌شود.

ترجمه => 165. **Reference type arrays:** وقتی نوع element یک reference type است (مثل `class`)، ایجاد آرایه فقط referenceهای null را اختصاص می‌دهد.

ترجمه => 166. **NullReferenceException risk:** دسترسی به memberهای یک element از نوع reference type بدون نمونه‌سازی آن منجر به `NullReferenceException` می‌شود.

ترجمه => 167. **Explicit instantiation requirement:** برای آرایه‌های reference type، باید هر element را به صورت صریح نمونه‌سازی کرد (معمولاً با حلقه).

ترجمه => 168. **Array is always reference type:** خود آرایه همیشه یک reference type است، حتی اگر نوع element آن value type باشد (مثلاً `int[] a = null` معتبر است).

