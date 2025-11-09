 Ref Locals
 A somewhat esoteric feature of C# is that you can define a local variable that
 references an element in an array or field in an object (from C# 7):
 int[] numbers = { 0, 1, 2, 3, 4 };
 ref int numRef = ref numbers [2];
 In this example, numRef is a reference to numbers[2]. When we modify numRef, we
 modify the array element:
 numRef *= 10;
 Console.WriteLine (numRef);        // 20
 Console.WriteLine (numbers [2]);   // 20
 The target for a ref local must be an array element, field, or local variable; it cannot
 be a property (Chapter 3). Ref locals are intended for specialized micro-optimization
 scenarios and are typically used in conjunction with ref returns

 ## متغیرهای محلی مرجعی (Ref Locals)

یکی از ویژگی‌های نسبتاً تخصصی **C#** این است که می‌توانید یک متغیر محلی تعریف کنید که به یک عنصر در آرایه یا فیلد در یک **object** ارجاع دهد (از **C# 7**):
```csharp
int[] numbers = { 0, 1, 2, 3, 4 };
ref int numRef = ref numbers[2];
```
در این مثال، `numRef` یک مرجع به `numbers[2]` است. وقتی `numRef` را تغییر می‌دهیم، عنصر آرایه را تغییر می‌دهیم:

```csharp
numRef *= 10;
Console.WriteLine(numRef);        // 20
Console.WriteLine(numbers[2]);   // 20
```
هدف برای یک **ref local** باید یک عنصر آرایه، فیلد، یا متغیر محلی باشد؛ نمی‌تواند یک **property** باشد (فصل 3). **Ref locals** برای سناریوهای بهینه‌سازی میکرو تخصصی در نظر گرفته شده‌اند و معمولاً همراه با **ref returns** استفاده می‌شوند.
