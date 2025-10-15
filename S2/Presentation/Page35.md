 ## استفاده از @ با Keywords

```csharp


// ❌ خطا
int using = 123;
int class = 456;
int void = 789;

// ✅ صحیح (ولی توصیه نمی‌شود!)
int @using = 123;
int @class = 456;
int @void = 789;

Console.WriteLine(@using);  // 123
```
نکته مهم: @ بخشی از نام نیست!


```csharp
int @myVar = 10;
int myVar = 20;      // ❌ خطا: تکراری است!

// @myVar === myVar

```

## Contextual Keywords

```csharp

// این کلمات فقط در context خاص keyword هستند

// مثال 1: 'var'
var x = 10;          // اینجا keyword است
int var = 20;        // اینجا identifier است! ✅

// مثال 2: 'value' در property
public int Age
{
    set { _age = value; }  // 'value' اینجا keyword است
}
int value = 100;     // اینجا identifier است! ✅

// مثال 3: 'where' در LINQ و Generics
var result = list.Where(x => x > 5);  // keyword در LINQ
int where = 10;      // identifier ✅

```


## Punctuators (علائم نگارشی)

```csharp

;    // Semicolon - پایان statement
{ }  // Braces - بلوک کد
( )  // Parentheses - فراخوانی متد، گروه‌بندی
[ ]  // Brackets - آرایه، indexer
,    // Comma - جداکننده
.    // Dot - دسترسی به member
:    // Colon - inheritance، case
```


