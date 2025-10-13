## Reference types
 A reference type is more complex than a value type, having two parts: an object and
 the reference to that object. The content of a reference-type variable or constant is
 a reference to an object that contains the value. Here is the Point type from our
 previous example rewritten as a class rather than a struct (shown in Figure 2-3):
 public class Point { public int X, Y; }

 ### Reference types

یک reference type پیچیده‌تر از یک value type است و دو بخش دارد: یک object و reference به آن object. محتوای یک متغیر یا ثابت reference-type یک reference به یک object است که مقدار را در خود دارد. در اینجا نوع `Point` از مثال قبلی ما به عنوان یک `class` به جای `struct` بازنویسی شده است (در شکل 2-3 نشان داده شده):
```csharp
public class Point { public int X, Y; }
```

<img width="712" height="169" alt="image" src="https://github.com/user-attachments/assets/786a9da9-d320-4ab2-9ecd-9734dcc8a981" />
**شکل 2-3. یک نمونهٔ reference-type در حافظه**

 Assigning a reference-type variable copies the reference, not the object instance.
 This allows multiple variables to refer to the same object—something not ordinarily
 possible with value types. If we repeat the previous example, but with Point now a
 class, an operation to p1 affects p2:

 انتساب یک متغیر reference-type، reference را کپی می‌کند، نه نمونهٔ object را. این امر اجازه می‌دهد که چندین متغیر به یک object واحد ارجاع دهند—چیزی که به طور معمول با value typeها ممکن نیست. اگر مثال قبلی را تکرار کنیم، اما این بار `Point` یک `class` باشد، یک عملیات روی `p1` بر `p2` تأثیر می‌گذارد:
```csharp
Point p1 = new Point();
p1.X = 7;
Point p2 = p1;             // reference مربوط به p1 را کپی می‌کند
Console.WriteLine (p1.X);  // 7
Console.WriteLine (p2.X);  // 7
p1.X = 9;                  // p1.X را تغییر می‌دهد
Console.WriteLine (p1.X);  // 9
Console.WriteLine (p2.X);  // 9
```

<img width="663" height="168" alt="image" src="https://github.com/user-attachments/assets/e13a74b9-54f5-4812-9d13-685e530a28bb" />
شکل 2-4 نشان می‌دهد که `p1` و `p2` دو reference هستند که به یک object واحد اشاره می‌کنند.

**شکل 2-4. Assignment یک reference را کپی می‌کند**


