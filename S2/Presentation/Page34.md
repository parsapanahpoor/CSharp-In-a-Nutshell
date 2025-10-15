## Reserved Keywords

```csharp
int int = 5;        // ❌ خطا: 'int' keyword است

int @int = 5;       // ✅ با @ می‌توان از keyword استفاده کرد
Console.WriteLine(@int);  // 5
```

نکته: با @ می‌توان keywords را به عنوان identifier استفاد کرد (توصیه نمی‌شود!)

## Unicode Support

```csharp
int نام = 10;           // ✅ فارسی
int 名前 = 20;          // ✅ ژاپنی
int имя = 30;          // ✅ روسی

Console.WriteLine(نام);  // 10
```
توضیح: C# از کاراکترهای Unicode در identifiers پشتیبانی می‌کند.


##  Contextual Keywords

```csharp
var x = 10;      // 'var' فقط در context خاص keyword است
get, set, value, where, select, from, async, await
```
توضیح: این keywords فقط در بافت خاصی معنا دارند و در جاهای دیگر می‌توان از آن‌ها به عنوان identifier استفاده کرد.
