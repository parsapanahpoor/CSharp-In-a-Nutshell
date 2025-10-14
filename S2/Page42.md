## Types and Conversions
 C# can convert between instances of compatible types. A conversion always creates
 a new value from an existing one. Conversions can be either implicit or explicit:
 implicit conversions happen automatically, and explicit conversions require a cast.
 In the following example, we implicitly convert an int to a long type (which has
 twice the bit capacity of an int) and explicitly cast an int to a short type (which
 has half the bit capacity of an int):
 int x = 12345;       // int is a 32-bit integer
 long y = x;          // Implicit conversion to 64-bit integer
 short z = (short)x;  // Explicit conversion to 16-bit integer
 Implicit conversions are allowed when both of the following are true:
 •
 • The compiler can guarantee that they will always succeed.
 •
 • No information is lost in conversion.1
 Conversely, explicit conversions are required when one of the following is true:
 •
 • The compiler cannot guarantee that they will always succeed.
 •
 • Information might be lost during conversion.
 (If the compiler can determine that a conversion will always fail, both kinds of
 conversion are prohibited. Conversions that involve generics can also fail in certain
 conditions—see “Type Parameters and Conversions” on page 166.)


------------------------------------------------------------------------------------------------------------------------------


 The numeric conversions that we just saw are built into the
 language. C# also supports reference conversions and boxing
 conversions (see Chapter 3) as well as custom conversions (see
 “Operator Overloading” on page 256). The compiler doesn’t
 enforce the aforementioned rules with custom conversions, so
 it’s possible for badly designed types to behave otherwise.

 ## Types و Conversions

سی شارپ می‌تواند بین نمونه‌های (instances) typeهای سازگار تبدیل انجام دهد. یک conversion همیشه یک مقدار جدید از یک مقدار موجود ایجاد می‌کند. Conversionها می‌توانند implicit یا explicit باشند: conversionهای implicit به صورت خودکار اتفاق می‌افتند، و conversionهای explicit نیاز به یک cast دارند.

در مثال زیر، به صورت implicit یک `int` را به نوع `long` (که دو برابر ظرفیت bit یک `int` دارد) تبدیل می‌کنیم و به صورت explicit یک `int` را به نوع `short` (که نصف ظرفیت bit یک `int` دارد) cast می‌کنیم:
```csharp
int x = 12345;       // int is a 32-bit integer
long y = x;          // Implicit conversion to 64-bit integer
short z = (short)x;  // Explicit conversion to 16-bit integer
```

تبدیل Conversionهای implicit زمانی مجاز هستند که هر دوی موارد زیر صادق باشند:

• کامپایلر بتواند تضمین کند که آن‌ها همیشه موفق خواهند بود.
• هیچ اطلاعاتی در conversion از دست نمی‌رود.¹

برعکس، conversionهای explicit زمانی مورد نیاز هستند که یکی از موارد زیر صادق باشد:

• کامپایلر نتواند تضمین کند که آن‌ها همیشه موفق خواهند بود.
• ممکن است اطلاعات در طول conversion از دست برود.

(اگر کامپایلر بتواند تشخیص دهد که یک conversion همیشه شکست خواهد خورد، هر دو نوع conversion ممنوع هستند. Conversionهایی که شامل generics هستند نیز می‌توانند در شرایط خاصی شکست بخورند—به "Type Parameters and Conversions" در صفحه 166 مراجعه کنید.)


--------------------------------------------------------------------------------------------------------------------------------------

تبدیل Conversionهای عددی که همین الان دیدیم در زبان تعبیه شده‌اند (built into). C# همچنین از reference conversions و boxing conversions (به فصل 3 مراجعه کنید) و همچنین custom conversions (به "Operator Overloading" در صفحه 256 مراجعه کنید) پشتیبانی می‌کند. کامپایلر قوانین پیش‌گفته را با custom conversions اجرا (enforce) نمی‌کند، بنابراین ممکن است typeهای طراحی شده به صورت نامناسب رفتار متفاوتی داشته باشند.
