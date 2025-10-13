In this example, our class definition appears in the same file
 as our top-level statements. This is legal—as long as the top
level statements appear first—and is acceptable when writ
ing small test programs. With larger programs, the standard
 approach is to put the class definition in a separate file such as
 UnitConverter.cs. 

 در این مثال، تعریف class ما در همان فایلی که top-level statements قرار دارند ظاهر می‌شود. این کار مجاز است—تا زمانی که top-level statements ابتدا ظاهر شوند—و هنگام نوشتن برنامه‌های تستی کوچک قابل قبول است. با برنامه‌های بزرگ‌تر، رویکرد استاندارد این است که تعریف class را در یک فایل جداگانه مانند `UnitConverter.cs` قرار دهید.

## Members of a type
 A type contains data members and function members. The data member of
 UnitConverter is the field called ratio. The function members of UnitConverter
 are the Convert method and the UnitConverter’s constructor.
 Symmetry of predefined types and custom types
 A beautiful aspect of C# is that predefined types and custom types have few
 differences. The predefined int type serves as a blueprint for integers. It holds
 data—32 bits—and provides function members that use that data, such as ToString.
 Similarly, our custom UnitConverter type acts as a blueprint for unit conversions. It
 holds data—the ratio—and provides function members to use that data.
 Constructors and instantiation
 Data is created by instantiating a type. Predefined types can be instantiated simply
 by using a literal such as 12 or "Hello world". The new operator creates instances of
 a custom type. We created and declared an instance of the UnitConverter type with
 this statement:
 UnitConverter feetToInchesConverter = new UnitConverter (12);
 Immediately after the new operator instantiates an object, the object’s constructor is
 called to perform initialization. A constructor is defined like a method, except that
 the method name and return type are reduced to the name of the enclosing type:
 public UnitConverter (int unitRatio) { ratio = unitRatio; }
 Instance versus static members
 The data members and function members that operate on the instance of the type
 are called instance members. The UnitConverter’s Convert method and the int’s
 ToString method are examples of instance members. By default, members are
 instance members.
 Data members and function members that don’t operate on the instance of the type
 can be marked as static. To refer to a static member from outside its type, you
 specify its type name rather than an instance. An example is the WriteLine method
 of the Console class. Because this is static, we call Console.WriteLine() and not
 new Console().WriteLine().
 (The Console class is actually declared as a static class, which means that all of its
 members are static and you can never create instances of a Console.)
 In the following code, the instance field Name pertains to an instance of a particular
 Panda, whereas Population pertains to the set of all Panda instances. We create two
 instances of the Panda, print their names, and then print the total population:

  Panda p1 = new Panda ("Pan Dee");
 Panda p2 = new Panda ("Pan Dah");
 Console.WriteLine (p1.Name);      // Pan Dee
 Console.WriteLine (p2.Name);      // Pan Dah
 Console.WriteLine (Panda.Population);   // 2
 public class Panda
 {
  public string Name;             // Instance field
  public static int Population;   // Static field
  public Panda (string n)         // Constructor
  {
    Name = n;                     // Assign the instance field
 Population = Population + 1;  // Increment the static Population field
  }
 }
 
Attempting to evaluate p1.Population or Panda.Name will generate a compile-time
 error.

 ## اعضای یک Type

یک type شامل data members و function members است. data member از UnitConverter یک field به نام ratio است. function members از UnitConverter عبارتند از متد Convert و constructor از UnitConverter.

## تقارن type‌های از پیش تعریف شده و type‌های سفارشی

یک جنبه زیبای C# این است که type‌های از پیش تعریف شده و type‌های سفارشی تفاوت کمی دارند. type از پیش تعریف شدهٔ int به عنوان یک blueprint برای اعداد صحیح عمل می‌کند. این type داده نگه می‌دارد—۳۲ بیت—و function members فراهم می‌کند که از آن داده استفاده می‌کنند، مانند ToString. به طور مشابه، type سفارشی UnitConverter ما به عنوان یک blueprint برای تبدیل واحدها عمل می‌کند. این type داده نگه می‌دارد—ratio—و function members برای استفاده از آن داده فراهم می‌کند.

## Constructorها و Instantiation

داده با instantiate کردن یک type ایجاد می‌شود. type‌های از پیش تعریف شده می‌توانند به سادگی با استفاده از یک literal مانند 12 یا "Hello world" instantiate شوند. عملگر new نمونه‌هایی از یک type سفارشی ایجاد می‌کند. ما یک نمونه از type به نام UnitConverter را با این statement ایجاد و اعلان کردیم:
```csharp
UnitConverter feetToInchesConverter = new UnitConverter (12);
```
بلافاصله پس از اینکه عملگر new یک object را instantiate می‌کند، constructor آن object برای انجام مقداردهی اولیه (initialization) فراخوانی می‌شود. یک constructor مانند یک متد تعریف می‌شود، با این تفاوت که نام متد و return type به نام type محیط‌بر (enclosing type) کاهش می‌یابد:

```csharp
public UnitConverter (int unitRatio) { ratio = unitRatio; }
```

## Instance در مقابل Static Members

اعضای data members و function members که روی نمونهٔ (instance) type عمل می‌کنند، instance members نامیده می‌شوند. متد Convert از UnitConverter و متد ToString از int نمونه‌هایی از instance members هستند. به طور پیش‌فرض، memberها instance members هستند.



اعضایdata members و function members که روی نمونهٔ type عمل نمی‌کنند، می‌توانند به عنوان static علامت‌گذاری شوند. برای ارجاع به یک static member از خارج type آن، نام type را به جای یک نمونه مشخص می‌کنید. یک مثال، متد WriteLine از class به نام Console است. از آنجا که این متد static است، `Console.WriteLine()` را فراخوانی می‌کنیم و نه `new Console().WriteLine()`.

(کلاسی به نام Console در واقع به عنوان یک static class اعلان شده است، که به این معنی است که تمام memberهای آن static هستند و هرگز نمی‌توانید نمونه‌هایی از Console ایجاد کنید.)

در کد زیر، instance field به نام Name به یک نمونه از یک Panda خاص مربوط می‌شود، در حالی که Population به مجموعهٔ تمام نمونه‌های Panda مربوط می‌شود. دو نمونه از Panda ایجاد می‌کنیم، نام آن‌ها را چاپ می‌کنیم، و سپس جمعیت کل را چاپ می‌کنیم:

```csharp
Panda p1 = new Panda ("Pan Dee");
Panda p2 = new Panda ("Pan Dah");

Console.WriteLine (p1.Name);      // Pan Dee
Console.WriteLine (p2.Name);      // Pan Dah
Console.WriteLine (Panda.Population);   // 2

public class Panda
{
  public string Name;             // Instance field
  public static int Population;   // Static field

  public Panda (string n)         // Constructor
  {
Name = n;                     // Assign the instance field
Population = Population + 1;  // Increment the static Population field
  }
}
```
تلاش برای ارزیابی `p1.Population` یا `Panda.Name` یک خطای compile-time ایجاد خواهد کرد.

 
