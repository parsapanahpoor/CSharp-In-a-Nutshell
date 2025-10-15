## Predefined vs Custom Types
Predefined Types (Built-in)

```csharp
// شناسایی شده با keyword C#
int x = 10;
string s = "Text";
bool b = true;
double d = 3.14;
```

```csharp
Types در System Namespace
// مهم ولی پیش‌فرض نیستند
DateTime now = DateTime.Now;
TimeSpan duration = TimeSpan.FromHours(2);
Console.WriteLine(now);
```

## Custom Type Definition: Class

```csharp

public class UnitConverter
{
    int ratio;                              // Field (Data Member)

    public UnitConverter (int unitRatio)    // Constructor
    {
        ratio = unitRatio;
    }

    public int Convert (int unit)           // Method (Function Member)
    {
        return unit * ratio;
    }
}
```

اجزای Class:

- فیلد

```csharp

int ratio;
// مکان ذخیره داده (state)
// خصوصی (private به صورت پیش‌فرض)
```

- سازنده

```csharp

public UnitConverter (int unitRatio)
{
    ratio = unitRatio;
}
// نام آن دقیقاً مثل نام کلاس
// زمان ساخت شی فراخوانی می‌شود
// مقداردهی اولیه را انجام می‌دهد
```

- متد

```csharp

public int Convert (int unit)
{
    return unit * ratio;
}
// رفتار (behavior) کلاس
// عملیاتی که شی انجام می‌دهد
```

-----------------------------------------------------------------------------------------------------------------------------------------------------------

نکته: فیلدها به صورت پیش‌فرض private هستند.

تفاوت کلیدی کاستوم تایپ ها و پریدیفاین تایپ ها : Custom types نیاز به new دارند.


