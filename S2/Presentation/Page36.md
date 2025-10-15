## Comments (کامنت‌ها)
Single-line Comment

```csharp
int x = 3;   // این یک کامنت تک‌خطی است
// کل این خط کامنت است
Multi-line Comment
```

```csharp
int x = 3;   /* این کامنت
                چند خطی است */

/* 
  کامنت بلند
  در چند خط
  برای توضیحات طولانی
*/

```

## Variable vs Constant
Variable (متغیر)

```csharp

int x = 10;
x = 20;        // ✅ می‌تواند تغییر کند
x = 30;        // ✅
Constant (ثابت)
```

```csharp
const int y = 360;
y = 180;       // ❌ خطا: نمی‌تواند تغییر کند

const double PI = 3.14159;
// PI همیشه ثابت است

```

تفاوت کلیدی:

ترجمه Variable: مقدار قابل تغییر
ترجمه Constant: مقدار ثابت (با const)

## int Type

```csharp

int x = 12;
int y = -5;
int z = 2147483647;    // Maximum
int min = -2147483648; // Minimum
```

مشخصات:

حافظه: 32 بیت (4 بایت)
محدوده عددی: -2,147,483,648 تا 2,147,483,647


## ToString()

نکته: ToString() روی تقریباً همه type‌ها کار می‌کند.

قانون: همه مقادیر در C# نمونه‌ای (instance) از یک type هستند.


## Predefined Types (انواع پیش‌فرض)

```csharp

// عددی
int i = 123;
long l = 123L;
double d = 3.14;
float f = 3.14f;
decimal m = 3.14m;

// متنی
string s = "Hello";
char c = 'A';

// منطقی
bool b = true;

// شی
object o = new object();
```
