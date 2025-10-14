 ## Null
 A reference can be assigned the literal null, indicating that the reference points to
 no object:
 Point p = null;
 Console.WriteLine (p == null);   // True
 // The following line generates a runtime error
 // (a NullReferenceException is thrown):
 Console.WriteLine (p.X);
 class Point {...}
------------------------------------------------------------------------------------------------------
  In “Nullable Reference Types” on page 215, we describe a
 feature of C# that helps to reduce accidental NullReference
 Exception errors.

------------------------------------------------------------------------------------------------------
 In contrast, a value type cannot ordinarily have a null value:
 Point p = null;  // Compile-time error
 int x = null;    // Compile-time error
 struct Point {...}


------------------------------------------------------------------------------------------------------

 C# also has a construct called nullable value types for repre
senting value-type nulls. For more information, see “Nullable
 Value Types” on page 210.


## Storage overhead
 Value-type instances occupy precisely the memory required to store their fields. In
 this example, Point takes 8 bytes of memory:
 struct Point
 {
  int x;  // 4 bytes
  int y;  // 4 bytes
 }

------------------------------------------------------------------------------------------------------

Technically, the CLR positions fields within the type at an
 address that’s a multiple of the fields’ size (up to a maximum
 of 8 bytes). Thus, the following actually consumes 16 bytes of
 memory (with the 7 bytes following the first field “wasted”):
 struct A { byte b; long l; }
 You can override this behavior by applying the StructLayout
 attribute (see “Mapping a Struct to Unmanaged Memory” on
 page 997).

 ------------------------------------------------------------------------------------------------------

 Reference types require separate allocations of memory for the reference and object.
 The object consumes as many bytes as its fields, plus additional administrative
 overhead. The precise overhead is intrinsically private to the implementation of
 the .NET runtime, but at minimum, the overhead is 8 bytes, used to store a key
 to the object’s type as well as temporary information such as its lock state for
 multithreading and a flag to indicate whether it has been fixed from movement by
 the garbage collector. Each reference to an object requires an extra 4 or 8 bytes,
 depending on whether the .NET runtime is running on a 32- or 64-bit platform. 


 
### Null

یک reference می‌تواند به literal مقدار `null` اختصاص یابد که نشان می‌دهد reference به هیچ object اشاره نمی‌کند:
```csharp
Point p = null;
Console.WriteLine (p == null);   // True
// خط زیر یک خطای زمان اجرا تولید می‌کند
// (یک NullReferenceException پرتاب می‌شود):
Console.WriteLine (p.X);
class Point {...}
```

-------------------------------------------------------------------------------------------------

 در بخش "Nullable Reference Types" در صفحه 215، ویژگی‌ای از C# را توصیف می‌کنیم که به کاهش خطاهای تصادفی `NullReferenceException` کمک می‌کند.

-----------------------------------------------------------------------------------------------------------

 در مقابل، یک value type به طور معمول نمی‌تواند مقدار `null` داشته باشد:
```csharp
Point p = null;  // خطای زمان کامپایل
int x = null;    // خطای زمان کامپایل
struct Point {...}
```

--------------------------------------------------------------------------------------------------------------

سی شارپ C# همچنین یک ساختار به نام nullable value types برای نمایش null در value-typeها دارد. برای اطلاعات بیشتر، به بخش "Nullable Value Types" در صفحه 210 مراجعه کنید.



 ### Storage overhead

نمونه‌های value-type دقیقاً به اندازه‌ای حافظه اشغال می‌کنند که برای ذخیره fieldهای آن‌ها نیاز است. در این مثال، `Point` هشت بایت حافظه اشغال می‌کند:
```csharp
struct Point
{
 int x;  // 4 بایت
 int y;  // 4 بایت
}
```
------------------------------------------------------------------------------------------------------



 از نظر فنی، CLR فیلدها را در آدرسی قرار می‌دهد که مضربی از اندازه فیلدها است (حداکثر تا 8 بایت). بنابراین، کد زیر در واقع 16 بایت حافظه مصرف می‌کند (با 7 بایت "هدر رفته" بعد از فیلد اول):
```csharp
struct A { byte b; long l; }
```
می‌توانید این رفتار را با اعمال attribute به نام `StructLayout` تغییر دهید (به بخش "Mapping a Struct to Unmanaged Memory" در صفحه 997 مراجعه کنید).

 ------------------------------------------------------------------------------------------------------

 
متغیرهای reference typeها نیاز به تخصیص جداگانه حافظه برای reference و object دارند. object به اندازه فیلدهای خود به علاوه overhead اداری اضافی حافظه مصرف می‌کند. overhead دقیق به طور ذاتی خصوصی پیاده‌سازی .NET runtime است، اما حداقل، این overhead برابر 8 بایت است که برای ذخیره کلیدی به type آن object و همچنین اطلاعات موقتی مانند وضعیت lock آن برای multithreading و یک flag برای نشان دادن اینکه آیا توسط garbage collector از جابجایی ثابت شده است یا خیر، استفاده می‌شود. هر reference به یک object به 4 یا 8 بایت اضافی نیاز دارد که بستگی به این دارد که .NET runtime روی پلتفرم 32 بیتی یا 64 بیتی در حال اجرا باشد.

