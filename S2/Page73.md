The params modifier
 The params modifier, if applied to the last parameter of a method, allows the
 method to accept any number of arguments of a particular type. The parameter
 type must be declared as a (single-dimensional) array, as shown in the following
 example:
 int total = Sum (1, 2, 3, 4);
 Console.WriteLine (total);              // 10
 // The call to Sum above is equivalent to:
 int total2 = Sum (new int[] { 1, 2, 3, 4 });
 int Sum (params int[] ints)
 {
  int sum = 0;
  for (int i = 0; i < ints.Length; i++)
    sum += ints [i];                       // Increase sum by ints[i]
  return sum;
 }
 If there are zero arguments in the params position, a zero-length array is created.
 You can also supply a params argument as an ordinary array. The first line in our
 example is semantically equivalent to this:
 int total = Sum (new int[] { 1, 2, 3, 4 } );

 ## Modifier از نوع params

ترجمه=> Modifier از نوع `params`، اگر به آخرین پارامتر یک متد اعمال شود، به متد اجازه می‌دهد که تعداد دلخواهی آرگومان از یک نوع خاص را بپذیرد. نوع پارامتر باید به عنوان یک آرایه (تک‌بعدی) تعریف شود، همانطور که در مثال زیر نشان داده شده است:
```csharp
int total = Sum (1, 2, 3, 4);
Console.WriteLine (total);              // 10

// فراخوانی Sum در بالا معادل این است:
int total2 = Sum (new int[] { 1, 2, 3, 4 });

int Sum (params int[] ints)
{
int sum = 0;
for (int i = 0; i < ints.Length; i++)
sum += ints [i];                       // sum را به اندازه ints[i] افزایش می‌دهد
return sum;
}
```
اگر صفر آرگومان در موقعیت `params` وجود داشته باشد، یک آرایه با طول صفر ایجاد می‌شود.

همچنین می‌توانید یک آرگومان `params` را به عنوان یک آرایه معمولی ارائه دهید. خط اول در مثال ما از نظر معنایی معادل این است:

```csharp
int total = Sum (new int[] { 1, 2, 3, 4 } );
```

**خلاصه نکات مهم:**

277. **تعریف params:** modifier `params` به متد اجازه می‌دهد تعداد دلخواهی آرگومان بپذیرد.

278. **موقعیت params:** `params` فقط می‌تواند به آخرین پارامتر متد اعمال شود.

279. **نوع آرایه:** پارامتر `params` باید به عنوان یک آرایه تک‌بعدی تعریف شود.

280. **سادگی فراخوانی:** با `params` می‌توان آرگومان‌ها را مستقیماً بدون ایجاد آرایه فرستاد.

281. **معادل بودن:** فراخوانی با `params` معادل ارسال یک آرایه صریح است.

282. **آرایه صفر عنصری:** اگر هیچ آرگومانی ارسال نشود، یک آرایه با طول صفر ایجاد می‌شود.

283. **انعطاف‌پذیری:** می‌توان آرگومان `params` را هم به صورت مستقیم و هم به صورت آرایه صریح ارسال کرد.

آماده دریافت بخش بعدی هستم.
