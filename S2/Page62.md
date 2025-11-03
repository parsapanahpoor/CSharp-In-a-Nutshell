## Arrays
An array represents a fixed number of variables (called elements) of a particular type. e elements in
an array are always stored in a contiguous block of memory, providing highly efficient access.
An array is denoted with square brackets aer the element type:
char[] vowels = new char[5]; // Declare an array of 5 characters
Square brackets also index the array, accessing a particular element by position:
vowels[0] = 'a';
vowels[1] = 'e';
vowels[2] = 'i';
vowels[3] = 'o';
vowels[4] = 'u';
Console.WriteLine (vowels[1]); // e
is prints “e” because array indexes start at 0. You can use a for loop statement to iterate through
each element in the array. e for loop in this example cycles the integer i from 0 to 4:
for (int i = 0; i < vowels.Length; i++)
Console.Write (vowels[i]); // aeiou
e Length property of an array returns the number of elements in the array. Aer an array has
been created, you cannot change its length. e System.Collection namespace and
subnamespaces provide higher-level data structures, such as dynamically sized arrays and
dictionaries.
An array initialization expression lets you declare and populate an array in a single step:
char[] vowels = new char[] {'a','e','i','o','u'};
Or simply:
char[] vowels = {'a','e','i','o','u'};
All arrays inherit from the System.Array class, providing common services for all arrays. ese
members include methods to get and set elements regardless of the array type. We describe them in
63
“e Array Class”.


## آرایه‌ها

یک آرایه، تعداد ثابتی از متغیرها (که elementsنامیده می‌شوند) از یک نوع خاص را نمایش می‌دهد. elementsها در یک آرایه همیشه در یک بلوک مجاور از حافظه ذخیره می‌شوند که دسترسی بسیار کارآمدی را فراهم می‌کند.

یک آرایه با کروشه‌های مربعی بعد از نوع element مشخص می‌شود:
```csharp
char[] vowels = new char[5]; // یک آرایه از 5 کاراکتر اعلان می‌کند
```
کروشه‌های مربعی همچنین آرایه را index می‌کنند و به یک element خاص بر اساس موقعیت دسترسی می‌دهند:

```csharp
vowels[0] = 'a';
vowels[1] = 'e';
vowels[2] = 'i';
vowels[3] = 'o';
vowels[4] = 'u';
Console.WriteLine (vowels[1]); // e
```
این کد "e" را چاپ می‌کند زیرا indexهای آرایه از 0 شروع می‌شوند. می‌توانید از یک statement حلقه `for` برای پیمایش هر element در آرایه استفاده کنید. حلقه `for` در این مثال، عدد صحیح `i` را از 0 تا 4 چرخه می‌دهد:

```csharp
for (int i = 0; i < vowels.Length; i++)
Console.Write (vowels[i]); // aeiou
```
ترجمه=> property مربوط به `Length` یک آرایه، تعداد elementsها در آرایه را برمی‌گرداند. بعد از اینکه یک آرایه ایجاد شد، نمی‌توانید طول آن را تغییر دهید. namespace مربوط به `System.Collection` و subnamespaceهای آن، ساختارهای داده سطح بالاتری مانند آرایه‌های با اندازه پویا و dictionaryها را فراهم می‌کنند.

یک array initialization expression به شما اجازه می‌دهد که یک آرایه را در یک مرحله اعلان و پُر کنید:

```csharp
char[] vowels = new char[] {'a','e','i','o','u'};
```
یا به سادگی:

```csharp
char[] vowels = {'a','e','i','o','u'};
```
تمام آرایه‌ها از class مربوط به `System.Array` ارث‌بری می‌کنند که سرویس‌های مشترکی را برای همه آرایه‌ها فراهم می‌کند. این memberها شامل متدهایی برای get و set کردن elementsها بدون توجه به نوع آرایه هستند. ما آن‌ها را در بخش "The Array Class" توضیح می‌دهیم.


**خلاصه نکات مهم:**

 ترجمه => 154. **Arrays:** آرایه‌ها تعداد ثابتی از متغیرها (elements) از یک نوع خاص را نمایش می‌دهند که در حافظه مجاور ذخیره می‌شوند.

ترجمه => 155. **Array declaration:** آرایه‌ها با کروشه‌های مربعی بعد از نوع element اعلان می‌شوند (مثل `char[] vowels = new char[5]`).

ترجمه => 156. **Array indexing:** دسترسی به elementsهای آرایه با کروشه‌های مربعی و index که از 0 شروع می‌شود.

ترجمه => 157. **Array iteration:** استفاده از حلقه `for` برای پیمایش elementsهای آرایه.

ترجمه => 158. **Length property:** property مربوط به `Length` تعداد elementsها را برمی‌گرداند و طول آرایه بعد از ایجاد قابل تغییر نیست.

ترجمه => 159. **Dynamic collections:** namespace مربوط به `System.Collection` ساختارهای داده پیشرفته‌تری مانند آرایه‌های پویا و dictionaryها را فراهم می‌کند.

ترجمه => 160. **Array initialization:** امکان اعلان و مقداردهی اولیه آرایه در یک مرحله با استفاده از array initialization expression.

ترجمه => 161. **System.Array inheritance:** تمام آرایه‌ها از `System.Array` ارث‌بری می‌کنند که متدهای مشترک برای get/set کردن elementsها را فراهم می‌کند.

