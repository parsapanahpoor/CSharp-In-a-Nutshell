<div dir="rtl" style="text-align: right;">

# 📝 آزمون Casting و Reference Conversions در C#

## 📊 اطلاعات آزمون
- **تعداد سوالات**: 20 سوال
- **نوع**: چهار گزینه‌ای
- **سطح دشواری**: 6 آسان | 9 متوسط | 5 سخت
- **زمان پیشنهادی**: 60 دقیقه

---

## 🟢 بخش اول: سوالات آسان (6 سوال)

### سوال 1️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Animal { }
class Dog : Animal { }

Dog dog = new Dog();
Animal animal = dog;  // Upcast
Console.WriteLine(animal.GetType().Name);
```

<div dir="rtl" style="text-align: right;">

**الف)** Animal  
**ب)** Dog  
**ج)** خطای کامپایل  
**د)** خطای زمان اجرا  

<details>
<summary>✅ پاسخ صحیح: ب</summary>

**تحلیل:**

این سوال مفهوم پایه **Upcasting** و **Type Information** را بررسی می‌کند.

1. `Dog dog = new Dog();` یک شی `Dog` ایجاد می‌کند.
2. `Animal animal = dog;` یک **Upcast** انجام می‌دهد (Implicit Casting).
3. `animal.GetType().Name` نوع **واقعی** شی را برمی‌گرداند، نه نوع رفرنس.
4. حتی اگر رفرنس از نوع `Animal` باشد، شی هنوز یک `Dog` است.
5. خروجی: **"Dog"**

**نکات کلیدی:**
- Upcasting فقط **نوع رفرنس** را تغییر می‌دهد، نه نوع واقعی شی.
- `GetType()` همیشه نوع واقعی را برمی‌گرداند.
- Upcasting **همیشه ایمن** است و نیاز به کست صریح ندارد.

</details>

---

### سوال 2️⃣

کدام گزینه تعریف صحیح **Casting** است؟

**الف)** تبدیل یک شی به شی دیگر  
**ب)** تبدیل رفرنس از یک نوع به نوع دیگر در سلسله‌مراتب Inheritance  
**ج)** تغییر نوع واقعی یک شی  
**د)** تبدیل Value Type به Reference Type  

<details>
<summary>✅ پاسخ صحیح: ب</summary>

**تحلیل:**

**Casting** به معنای تبدیل رفرنس از یک نوع به نوع دیگر در سلسله‌مراتب Inheritance است.

**مثال:**
```csharp
class Animal { }
class Dog : Animal { }

Dog dog = new Dog();
Animal animal = dog;  // ✅ Casting (Upcast)
```

**گزینه‌های نادرست:**
- **الف**: Casting شی را تغییر نمی‌دهد، فقط رفرنس را تغییر می‌دهد.
- **ج**: نوع واقعی شی تغییر نمی‌کند.
- **د**: این تعریف **Boxing** است، نه Casting.

**نکات کلیدی:**
- Casting فقط **نوع رفرنس** را تغییر می‌دهد.
- شی **همان شی** باقی می‌ماند.
- نوع واقعی شی در Runtime حفظ می‌شود.

</details>

---

### سوال 3️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Animal { }
class Dog : Animal { }

Animal animal = new Dog();
Dog dog = (Dog)animal;  // Downcast
Console.WriteLine("Success");
```

<div dir="rtl" style="text-align: right;">

**الف)** Success  
**ب)** خطای کامپایل  
**ج)** InvalidCastException  
**د)** NullReferenceException  

<details>
<summary>✅ پاسخ صحیح: الف</summary>

**تحلیل:**

این سوال **Downcasting** را بررسی می‌کند.

1. `Animal animal = new Dog();` یک رفرنس `Animal` به یک شی `Dog` ایجاد می‌کند.
2. `Dog dog = (Dog)animal;` یک **Downcast** انجام می‌دهد.
3. در Runtime، نوع واقعی شی (`Dog`) بررسی می‌شود.
4. چون `animal` واقعاً به یک `Dog` اشاره می‌کند، Downcast **موفق** می‌شود.
5. خروجی: **"Success"**

**نکات کلیدی:**
- Downcasting **صریح** است (نیاز به `()` دارد).
- Downcasting فقط زمانی موفق می‌شود که نوع واقعی با نوع مورد نظر سازگار باشد.
- اگر نوع واقعی سازگار نباشد، `InvalidCastException` رخ می‌دهد.

</details>

---

### سوال 4️⃣

کدام عملگر برای **بررسی نوع** قبل از Casting استفاده می‌شود؟

**الف)** `as`  
**ب)** `is`  
**ج)** `typeof`  
**د)** `GetType`  

<details>
<summary>✅ پاسخ صحیح: ب</summary>

**تحلیل:**

عملگر `is` برای **بررسی نوع** قبل از Casting استفاده می‌شود.

**مثال:**
```csharp
class Animal { }
class Dog : Animal { }

Animal animal = new Dog();

if (animal is Dog) {  // ✅ بررسی نوع
    Dog dog = (Dog)animal;  // ✅ Casting ایمن
    // ...
}
```

**گزینه‌های نادرست:**
- **الف**: `as` برای **Casting** استفاده می‌شود (نه بررسی).
- **ج**: `typeof` برای گرفتن `Type` در Compile-time استفاده می‌شود.
- **د**: `GetType()` برای گرفتن نوع واقعی در Runtime استفاده می‌شود.

**نکات کلیدی:**
- `is` یک **Boolean** برمی‌گرداند (true/false).
- `is` با Pattern Matching ترکیب می‌شود: `if (animal is Dog d) { }`

</details>

---

### سوال 5️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Animal { }
class Dog : Animal { }
class Cat : Animal { }

Animal animal = new Cat();
Dog dog = (Dog)animal;
```

<div dir="rtl" style="text-align: right;">

**الف)** کد بدون خطا اجرا می‌شود  
**ب)** خطای کامپایل  
**ج)** InvalidCastException  
**د)** NullReferenceException  

<details>
<summary>✅ پاسخ صحیح: ج</summary>

**تحلیل:**

این سوال **InvalidCastException** در Downcasting را بررسی می‌کند.

1. `Animal animal = new Cat();` یک رفرنس `Animal` به یک شی `Cat` ایجاد می‌کند.
2. `Dog dog = (Dog)animal;` تلاش می‌کند `Cat` را به `Dog` تبدیل کند.
3. در Runtime، نوع واقعی (`Cat`) بررسی می‌شود.
4. چون `Cat` نمی‌تواند به `Dog` تبدیل شود، **InvalidCastException** رخ می‌دهد.

**خطای Runtime:**
```
System.InvalidCastException: Unable to cast object of type 'Cat' to type 'Dog'.
```

**راه حل ایمن:**
```csharp
if (animal is Dog d) {
    // Safe to use d
}
```

**نکات کلیدی:**
- Downcasting **خطرناک** است و ممکن است شکست بخورد.
- همیشه قبل از Downcasting نوع را با `is` بررسی کنید.
- یا از `as` استفاده کنید که `null` برمی‌گرداند در صورت شکست.

</details>

---

### سوال 6️⃣

کدام نوع Casting **خودکار** و **همیشه ایمن** است؟

**الف)** Upcasting  
**ب)** Downcasting  
**ج)** Explicit Casting  
**د)** Boxing  

<details>
<summary>✅ پاسخ صحیح: الف</summary>

**تحلیل:**

**Upcasting** (تبدیل از Derived به Base) **خودکار** و **همیشه ایمن** است.

**مثال:**
```csharp
class Animal { }
class Dog : Animal { }

Dog dog = new Dog();
Animal animal = dog;  // ✅ Upcast (Implicit - خودکار)
```

**چرا ایمن است؟**
- هر `Dog` یک `Animal` است.
- کامپایلر می‌تواند این تبدیل را تضمین کند.
- نیاز به کست صریح ندارد.

**گزینه‌های نادرست:**
- **ب**: Downcasting **صریح** است و ممکن است شکست بخورد.
- **ج**: Explicit Casting نیاز به کست صریح دارد.
- **د**: Boxing تبدیل Value Type به Reference Type است.

**نکات کلیدی:**
- Upcasting = Derived → Base (خودکار)
- Downcasting = Base → Derived (صریح، خطرناک)

</details>

---

## 🟡 بخش دوم: سوالات متوسط (9 سوال)

### سوال 7️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Animal {
    public void Eat() => Console.WriteLine("Eating");
}

class Dog : Animal {
    public void Bark() => Console.WriteLine("Woof!");
}

Dog dog = new Dog();
Animal animal = dog;  // Upcast

animal.Eat();
animal.Bark();
```

<div dir="rtl" style="text-align: right;">

**الف)** Eating, Woof!  
**ب)** خطای کامپایل در خط آخر  
**ج)** خطای زمان اجرا  
**د)** Eating, خطای کامپایل  

<details>
<summary>✅ پاسخ صحیح: ب</summary>

**تحلیل:**

این سوال **محدودیت دسترسی** بعد از Upcasting را بررسی می‌کند.

1. `Animal animal = dog;` یک Upcast انجام می‌دهد.
2. `animal.Eat();` ✅ کار می‌کند چون `Eat()` در `Animal` تعریف شده.
3. `animal.Bark();` ❌ **خطای کامپایل** می‌دهد.

**خطای کامپایل:**
```
Error: 'Animal' does not contain a definition for 'Bark'
```

**چرا؟**
- کامپایلر فقط بر اساس **نوع رفرنس** (`Animal`) تصمیم می‌گیرد.
- `Animal` متد `Bark()` را نمی‌شناسد.
- حتی اگر شی واقعاً یک `Dog` باشد، رفرنس `Animal` به `Bark()` دسترسی ندارد.

**راه حل:**
```csharp
Dog dog2 = (Dog)animal;  // Downcast
dog2.Bark();  // ✅ OK
```

**نکات کلیدی:**
- Upcasting **دسترسی را محدود می‌کند**.
- برای دسترسی به متدهای Derived باید Downcast کنیم.

</details>

---

### سوال 8️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Animal { }
class Dog : Animal { }
class Cat : Animal { }

Animal animal = new Cat();
Dog dog = animal as Dog;

if (dog != null) {
    Console.WriteLine("Dog");
} else {
    Console.WriteLine("Not a Dog");
}
```

<div dir="rtl" style="text-align: right;">

**الف)** Dog  
**ب)** Not a Dog  
**ج)** خطای کامپایل  
**د)** خطای زمان اجرا  

<details>
<summary>✅ پاسخ صحیح: ب</summary>

**تحلیل:**

این سوال عملگر `as` را بررسی می‌کند.

1. `Animal animal = new Cat();` یک رفرنس `Animal` به یک شی `Cat` ایجاد می‌کند.
2. `Dog dog = animal as Dog;` تلاش می‌کند `animal` را به `Dog` تبدیل کند.
3. چون `animal` واقعاً یک `Cat` است (نه `Dog`)، `as` **null** برمی‌گرداند.
4. `dog != null` false است.
5. خروجی: **"Not a Dog"**

**نکات کلیدی:**
- `as` در صورت موفقیت، شی را برمی‌گرداند.
- `as` در صورت شکست، **null** برمی‌گرداند (نه Exception).
- `as` فقط برای **Reference Types** کار می‌کند.

**مقایسه با Direct Cast:**
```csharp
Dog dog = (Dog)animal;  // ❌ InvalidCastException
Dog dog = animal as Dog;  // ✅ null (ایمن‌تر)
```

</details>

---

### سوال 9️⃣

کد زیر چه خروجی می‌دهد؟ (C# 7+)

<div dir="ltr" style="text-align: left;">

```csharp
class Animal { }
class Dog : Animal {
    public string Name { get; set; }
}

Animal animal = new Dog { Name = "Buddy" };

if (animal is Dog d) {
    Console.WriteLine(d.Name);
} else {
    Console.WriteLine("Not a Dog");
}
```

<div dir="rtl" style="text-align: right;">

**الف)** Buddy  
**ب)** Not a Dog  
**ج)** خطای کامپایل  
**د)** خطای زمان اجرا  

<details>
<summary>✅ پاسخ صحیح: الف</summary>

**تحلیل:**

این سوال **Pattern Matching** با `is` را بررسی می‌کند.

1. `Animal animal = new Dog { Name = "Buddy" };` یک رفرنس `Animal` به یک `Dog` ایجاد می‌کند.
2. `if (animal is Dog d)`:
   - نوع `animal` را بررسی می‌کند
   - اگر `Dog` باشد، آن را به `d` کست می‌کند
   - `d` فقط در scope این `if` در دسترس است
3. چون `animal` واقعاً یک `Dog` است، شرط true می‌شود.
4. `d.Name` مقدار **"Buddy"** را برمی‌گرداند.
5. خروجی: **"Buddy"**

**نکات کلیدی:**
- Pattern Matching (`is Type variable`) **بررسی و کست** را در یک خط انجام می‌دهد.
- متغیر (`d`) فقط در **scope** مربوطه در دسترس است.
- این روش **ایمن‌تر** و **خوانا‌تر** از روش قدیمی است.

**مقایسه با روش قدیمی:**
```csharp
// روش قدیمی:
if (animal is Dog) {
    Dog d = (Dog)animal;
    Console.WriteLine(d.Name);
}

// روش جدید (Pattern Matching):
if (animal is Dog d) {
    Console.WriteLine(d.Name);  // ✅ کوتاه‌تر و ایمن‌تر
}
```

</details>

---

### سوال 🔟

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Animal { }
class Dog : Animal { }
class Cat : Animal { }

Animal[] animals = { new Dog(), new Cat(), new Dog() };
int dogCount = 0;

foreach (Animal animal in animals) {
    if (animal is Dog) {
        dogCount++;
    }
}

Console.WriteLine(dogCount);
```

<div dir="rtl" style="text-align: right;">

**الف)** 0  
**ب)** 2  
**ج)** 3  
**د)** خطای کامپایل  

<details>
<summary>✅ پاسخ صحیح: ب</summary>

**تحلیل:**

این سوال **Type Checking در Collections** را بررسی می‌کند.

1. `Animal[] animals` یک آرایه از رفرنس‌های `Animal` است.
2. آرایه شامل: `Dog`, `Cat`, `Dog`
3. در حلقه `foreach`:
   - `animal is Dog` برای هر عنصر بررسی می‌شود
   - `animals[0]` = `Dog` → true → `dogCount++` → 1
   - `animals[1]` = `Cat` → false
   - `animals[2]` = `Dog` → true → `dogCount++` → 2
4. خروجی: **2**

**نکات کلیدی:**
- `is` operator برای **Type Checking** در Collections مفید است.
- می‌توانیم با یک آرایه `Animal` انواع مختلف را پردازش کنیم.
- این الگو برای **Filtering** و **Type-based Processing** مفید است.

**بهبود با Pattern Matching:**
```csharp
foreach (Animal animal in animals) {
    if (animal is Dog d) {
        dogCount++;
        // می‌توانیم از d استفاده کنیم
    }
}
```

</details>

---

### سوال 1️⃣1️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Animal { }
class Dog : Animal { }

object obj = new Dog();
Animal animal = obj as Animal;
Dog dog = obj as Dog;

Console.WriteLine(animal != null ? "Animal OK" : "Animal null");
Console.WriteLine(dog != null ? "Dog OK" : "Dog null");
```

<div dir="rtl" style="text-align: right;">

**الف)** Animal OK, Dog OK  
**ب)** Animal null, Dog null  
**ج)** Animal OK, Dog null  
**د)** خطای کامپایل  

<details>
<summary>✅ پاسخ صحیح: الف</summary>

**تحلیل:**

این سوال **Casting از object** را بررسی می‌کند.

1. `object obj = new Dog();` یک `object` رفرنس به یک `Dog` ایجاد می‌کند.
2. `Animal animal = obj as Animal;`:
   - `obj` واقعاً یک `Dog` است
   - `Dog : Animal` → می‌تواند به `Animal` تبدیل شود
   - `animal` یک رفرنس `Animal` به همان شی می‌شود
   - `animal != null` → true → **"Animal OK"**
3. `Dog dog = obj as Dog;`:
   - `obj` واقعاً یک `Dog` است
   - می‌تواند به `Dog` تبدیل شود
   - `dog` یک رفرنس `Dog` به همان شی می‌شود
   - `dog != null` → true → **"Dog OK"**
4. خروجی: **"Animal OK", "Dog OK"**

**نکات کلیدی:**
- `as` برای **Casting از object** مفید است.
- `as` در صورت موفقیت، رفرنس را برمی‌گرداند.
- `as` در صورت شکست، `null` برمی‌گرداند.

</details>

---

### سوال 1️⃣2️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Animal { }
class Dog : Animal { }
class Cat : Animal { }

Animal animal = new Cat();

if (animal is Dog) {
    Console.WriteLine("Dog");
} else if (animal is Cat) {
    Console.WriteLine("Cat");
} else {
    Console.WriteLine("Unknown");
}
```

<div dir="rtl" style="text-align: right;">

**الف)** Dog  
**ب)** Cat  
**ج)** Unknown  
**د)** خطای کامپایل  

<details>
<summary>✅ پاسخ صحیح: ب</summary>

**تحلیل:**

این سوال **Type Checking با if-else** را بررسی می‌کند.

1. `Animal animal = new Cat();` یک رفرنس `Animal` به یک `Cat` ایجاد می‌کند.
2. `if (animal is Dog)`:
   - `animal` یک `Cat` است (نه `Dog`)
   - شرط false می‌شود
3. `else if (animal is Cat)`:
   - `animal` واقعاً یک `Cat` است
   - شرط true می‌شود
   - خروجی: **"Cat"**
4. خروجی: **"Cat"**

**نکات کلیدی:**
- `is` operator برای **Type Checking** در if-else مفید است.
- می‌توانیم با Pattern Matching بهبود دهیم:

**بهبود با Pattern Matching:**
```csharp
if (animal is Dog d) {
    Console.WriteLine("Dog");
} else if (animal is Cat c) {
    Console.WriteLine("Cat");
} else {
    Console.WriteLine("Unknown");
}
```

**بهبود با Switch Expression (C# 8+):**
```csharp
string result = animal switch {
    Dog d => "Dog",
    Cat c => "Cat",
    _ => "Unknown"
};
```

</details>

---

### سوال 1️⃣3️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Animal { }
class Dog : Animal { }

Animal animal = new Dog();
Dog dog1 = (Dog)animal;
Dog dog2 = animal as Dog;

Console.WriteLine(dog1 != null ? "dog1 OK" : "dog1 null");
Console.WriteLine(dog2 != null ? "dog2 OK" : "dog2 null");
```

<div dir="rtl" style="text-align: right;">

**الف)** dog1 OK, dog2 OK  
**ب)** dog1 null, dog2 null  
**ج)** خطای کامپایل  
**د)** خطای زمان اجرا  

<details>
<summary>✅ پاسخ صحیح: الف</summary>

**تحلیل:**

این سوال **مقایسه Direct Cast و `as`** را بررسی می‌کند.

1. `Animal animal = new Dog();` یک رفرنس `Animal` به یک `Dog` ایجاد می‌کند.
2. `Dog dog1 = (Dog)animal;`:
   - Direct Cast انجام می‌دهد
   - `animal` واقعاً یک `Dog` است
   - Cast موفق می‌شود
   - `dog1` یک رفرنس `Dog` به همان شی می‌شود
   - `dog1 != null` → true → **"dog1 OK"**
3. `Dog dog2 = animal as Dog;`:
   - `as` operator استفاده می‌شود
   - `animal` واقعاً یک `Dog` است
   - `as` موفق می‌شود و رفرنس را برمی‌گرداند
   - `dog2` یک رفرنس `Dog` به همان شی می‌شود
   - `dog2 != null` → true → **"dog2 OK"**
4. خروجی: **"dog1 OK", "dog2 OK"**

**نکات کلیدی:**
- هر دو روش در این مورد موفق می‌شوند.
- **تفاوت**: Direct Cast در صورت شکست Exception می‌دهد، اما `as` null برمی‌گرداند.
- `as` **ایمن‌تر** است برای مواردی که مطمئن نیستیم.

**مقایسه:**
```csharp
// Direct Cast (خطرناک):
Dog dog = (Dog)animal;  // ❌ InvalidCastException اگر شکست بخورد

// as operator (ایمن):
Dog dog = animal as Dog;  // ✅ null اگر شکست بخورد
if (dog != null) { /* استفاده */ }
```

</details>

---

### سوال 1️⃣4️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Animal { }
class Dog : Animal { }
class Cat : Animal { }

Animal animal1 = new Dog();
Animal animal2 = new Cat();

bool result1 = animal1 is Dog;
bool result2 = animal2 is Dog;
bool result3 = animal1 is Animal;
bool result4 = animal2 is Animal;

Console.WriteLine($"{result1}, {result2}, {result3}, {result4}");
```

<div dir="rtl" style="text-align: right;">

**الف)** True, False, True, True  
**ب)** False, False, True, True  
**ج)** True, True, True, True  
**د)** خطای کامپایل  

<details>
<summary>✅ پاسخ صحیح: الف</summary>

**تحلیل:**

این سوال **عملگر `is` با انواع مختلف** را بررسی می‌کند.

1. `Animal animal1 = new Dog();` → `animal1` واقعاً یک `Dog` است
2. `Animal animal2 = new Cat();` → `animal2` واقعاً یک `Cat` است
3. `animal1 is Dog`:
   - `animal1` واقعاً یک `Dog` است
   - `result1 = true`
4. `animal2 is Dog`:
   - `animal2` یک `Cat` است (نه `Dog`)
   - `result2 = false`
5. `animal1 is Animal`:
   - `animal1` یک `Dog` است
   - `Dog : Animal` → هر `Dog` یک `Animal` است
   - `result3 = true`
6. `animal2 is Animal`:
   - `animal2` یک `Cat` است
   - `Cat : Animal` → هر `Cat` یک `Animal` است
   - `result4 = true`
7. خروجی: **"True, False, True, True"**

**نکات کلیدی:**
- `is` operator **نوع واقعی** را بررسی می‌کند.
- `is` با **Inheritance** کار می‌کند (Derived is Base = true).

</details>

---

### سوال 1️⃣5️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Animal { }
class Dog : Animal { }

Animal animal = new Dog();
Type actualType = animal.GetType();
Type declaredType = typeof(Animal);

Console.WriteLine(actualType == declaredType);
Console.WriteLine(actualType.Name);
```

<div dir="rtl" style="text-align: right;">

**الف)** True, Animal  
**ب)** False, Dog  
**ج)** True, Dog  
**د)** خطای کامپایل  

<details>
<summary>✅ پاسخ صحیح: ب</summary>

**تحلیل:**

این سوال **تفاوت GetType() و typeof** را بررسی می‌کند.

1. `Animal animal = new Dog();` یک رفرنس `Animal` به یک `Dog` ایجاد می‌کند.
2. `animal.GetType()`:
   - نوع **واقعی** شی را برمی‌گرداند
   - `actualType = typeof(Dog)`
3. `typeof(Animal)`:
   - نوع **اعلان شده** را برمی‌گرداند
   - `declaredType = typeof(Animal)`
4. `actualType == declaredType`:
   - `typeof(Dog) == typeof(Animal)` → false
   - خروجی: **False**
5. `actualType.Name`:
   - `typeof(Dog).Name` → **"Dog"**
   - خروجی: **"Dog"**
6. خروجی نهایی: **"False", "Dog"**

**نکات کلیدی:**
- `GetType()` نوع **واقعی** را برمی‌گرداند (Runtime).
- `typeof()` نوع **اعلان شده** را برمی‌گرداند (Compile-time).
- این تفاوت برای **Reflection** و **Type Checking** مهم است.

</details>

---

## 🔴 بخش سوم: سوالات سخت (5 سوال)

### سوال 1️⃣6️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Animal { }
class Dog : Animal { }
class Puppy : Dog { }

Animal animal = new Puppy();

bool result1 = animal is Dog;
bool result2 = animal is Puppy;
bool result3 = animal is Animal;

Console.WriteLine($"{result1}, {result2}, {result3}");
```

<div dir="rtl" style="text-align: right;">

**الف)** True, True, True  
**ب)** False, True, True  
**ج)** True, False, True  
**د)** خطای کامپایل  

<details>
<summary>✅ پاسخ صحیح: الف</summary>

**تحلیل:**

این سوال **Multi-Level Inheritance** و **Type Checking** را بررسی می‌کند.

1. `Animal animal = new Puppy();` یک رفرنس `Animal` به یک `Puppy` ایجاد می‌کند.
2. `animal is Dog`:
   - `animal` واقعاً یک `Puppy` است
   - `Puppy : Dog` → هر `Puppy` یک `Dog` است
   - `result1 = true`
3. `animal is Puppy`:
   - `animal` واقعاً یک `Puppy` است
   - `result2 = true`
4. `animal is Animal`:
   - `animal` واقعاً یک `Puppy` است
   - `Puppy : Dog : Animal` → هر `Puppy` یک `Animal` است
   - `result3 = true`
5. خروجی: **"True, True, True"**

**نکات کلیدی:**
- `is` operator با **Inheritance Chain** کار می‌کند.
- اگر `Derived : Base` باشد، `derived is Base` = true.
- این برای **Multi-Level Inheritance** هم کار می‌کند.

**Inheritance Chain:**
```
Animal (Base)
  └─ Dog (Derived)
      └─ Puppy (Derived from Dog)
```

</details>

---

### سوال 1️⃣7️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Animal { }
class Dog : Animal { }

object obj = new Dog();
Animal animal = obj as Animal;
Dog dog = obj as Dog;

Console.WriteLine(animal?.GetType().Name ?? "null");
Console.WriteLine(dog?.GetType().Name ?? "null");
Console.WriteLine(ReferenceEquals(animal, dog));
```

<div dir="rtl" style="text-align: right;">

**الف)** Dog, Dog, True  
**ب)** Animal, Dog, False  
**ج)** Dog, Dog, False  
**د)** خطای کامپایل  

<details>
<summary>✅ پاسخ صحیح: الف</summary>

**تحلیل:**

این سوال **Casting از object** و **Reference Equality** را بررسی می‌کند.

1. `object obj = new Dog();` یک `object` رفرنس به یک `Dog` ایجاد می‌کند.
2. `Animal animal = obj as Animal;`:
   - `obj` واقعاً یک `Dog` است
   - `Dog : Animal` → می‌تواند به `Animal` تبدیل شود
   - `animal` یک رفرنس `Animal` به **همان شی** می‌شود
   - `animal.GetType().Name` → **"Dog"** (نوع واقعی)
3. `Dog dog = obj as Dog;`:
   - `obj` واقعاً یک `Dog` است
   - می‌تواند به `Dog` تبدیل شود
   - `dog` یک رفرنس `Dog` به **همان شی** می‌شود
   - `dog.GetType().Name` → **"Dog"**
4. `ReferenceEquals(animal, dog)`:
   - هر دو به **همان شی** اشاره می‌کنند
   - `ReferenceEquals` بررسی می‌کند که آیا دو رفرنس به **همان شی** اشاره می‌کنند
   - `true`
5. خروجی: **"Dog", "Dog", True"**

**نکات کلیدی:**
- Casting فقط **نوع رفرنس** را تغییر می‌دهد، نه شی را.
- همه رفرنس‌ها به **همان شی** اشاره می‌کنند.
- `ReferenceEquals` برای بررسی **Reference Equality** استفاده می‌شود.

</details>

---

### سوال 1️⃣8️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Animal { }
class Dog : Animal { }
class Cat : Animal { }

Animal animal = new Cat();

try {
    Dog dog = (Dog)animal;
    Console.WriteLine("Success");
} catch (InvalidCastException) {
    Console.WriteLine("InvalidCast");
} catch (Exception) {
    Console.WriteLine("Other Exception");
}
```

<div dir="rtl" style="text-align: right;">

**الف)** Success  
**ب)** InvalidCast  
**ج)** Other Exception  
**د)** خطای کامپایل  

<details>
<summary>✅ پاسخ صحیح: ب</summary>

**تحلیل:**

این سوال **Exception Handling در Casting** را بررسی می‌کند.

1. `Animal animal = new Cat();` یک رفرنس `Animal` به یک `Cat` ایجاد می‌کند.
2. `Dog dog = (Dog)animal;`:
   - Direct Cast انجام می‌دهد
   - `animal` واقعاً یک `Cat` است (نه `Dog`)
   - در Runtime، نوع واقعی (`Cat`) بررسی می‌شود
   - `Cat` نمی‌تواند به `Dog` تبدیل شود
   - **InvalidCastException** رخ می‌دهد
3. `catch (InvalidCastException)`:
   - Exception catch می‌شود
   - خروجی: **"InvalidCast"**

**نکات کلیدی:**
- Direct Cast در صورت شکست **InvalidCastException** می‌دهد.
- باید با `try-catch` یا `is`/`as` مدیریت شود.
- `as` operator **ایمن‌تر** است (null برمی‌گرداند).

**راه حل ایمن:**
```csharp
Dog dog = animal as Dog;
if (dog != null) {
    Console.WriteLine("Success");
} else {
    Console.WriteLine("Not a Dog");
}
```

</details>

---

### سوال 1️⃣9️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
interface IAnimal { }
class Animal : IAnimal { }
class Dog : Animal { }

IAnimal iAnimal = new Dog();
Animal animal = iAnimal as Animal;
Dog dog = iAnimal as Dog;

Console.WriteLine(animal != null ? "Animal OK" : "Animal null");
Console.WriteLine(dog != null ? "Dog OK" : "Dog null");
```

<div dir="rtl" style="text-align: right;">

**الف)** Animal OK, Dog OK  
**ب)** Animal null, Dog null  
**ج)** Animal OK, Dog null  
**د)** خطای کامپایل  

<details>
<summary>✅ پاسخ صحیح: الف</summary>

**تحلیل:**

این سوال **Casting از Interface** را بررسی می‌کند.

1. `IAnimal iAnimal = new Dog();` یک رفرنس `IAnimal` به یک `Dog` ایجاد می‌کند.
2. `Animal animal = iAnimal as Animal;`:
   - `iAnimal` واقعاً یک `Dog` است
   - `Dog : Animal` → می‌تواند به `Animal` تبدیل شود
   - `animal` یک رفرنس `Animal` به همان شی می‌شود
   - `animal != null` → true → **"Animal OK"**
3. `Dog dog = iAnimal as Dog;`:
   - `iAnimal` واقعاً یک `Dog` است
   - می‌تواند به `Dog` تبدیل شود
   - `dog` یک رفرنس `Dog` به همان شی می‌شود
   - `dog != null` → true → **"Dog OK"**
4. خروجی: **"Animal OK", "Dog OK"**

**نکات کلیدی:**
- می‌توانیم از Interface به Concrete Type کست کنیم.
- `as` operator برای این کار مفید است.
- باید مطمئن شویم که نوع واقعی سازگار است.

**Inheritance Chain:**
```
IAnimal (Interface)
  └─ Animal (Implements IAnimal)
      └─ Dog (Inherits from Animal)
```

</details>

---

### سوال 2️⃣0️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Animal { }
class Dog : Animal { }
class Cat : Animal { }

Animal animal1 = new Dog();
Animal animal2 = new Cat();

// Method 1: Direct Cast
Dog dog1 = (Dog)animal1;
Dog dog2 = (Dog)animal2;

// Method 2: as operator
Dog dog3 = animal1 as Dog;
Dog dog4 = animal2 as Dog;

Console.WriteLine($"dog1: {dog1 != null}, dog2: {dog2 != null}");
Console.WriteLine($"dog3: {dog3 != null}, dog4: {dog4 != null}");
```

<div dir="rtl" style="text-align: right;">

**الف)** dog1: True, dog2: Exception | dog3: True, dog4: False  
**ب)** dog1: True, dog2: True | dog3: True, dog4: True  
**ج)** خطای کامپایل  
**د)** همه Exception می‌دهند  

<details>
<summary>✅ پاسخ صحیح: الف</summary>

**تحلیل:**

این سوال **مقایسه Direct Cast و `as`** در موارد مختلف را بررسی می‌کند.

1. `Animal animal1 = new Dog();` → `animal1` واقعاً یک `Dog` است
2. `Animal animal2 = new Cat();` → `animal2` واقعاً یک `Cat` است
3. **Direct Cast:**
   - `Dog dog1 = (Dog)animal1;`:
     - `animal1` واقعاً یک `Dog` است
     - Cast موفق می‌شود
     - `dog1 != null` → true
   - `Dog dog2 = (Dog)animal2;`:
     - `animal2` یک `Cat` است (نه `Dog`)
     - Cast شکست می‌خورد
     - **InvalidCastException** رخ می‌دهد
     - کد به خط بعد نمی‌رود
     - `dog2 != null` هرگز اجرا نمی‌شود
4. **as operator:**
   - `Dog dog3 = animal1 as Dog;`:
     - `animal1` واقعاً یک `Dog` است
     - `as` موفق می‌شود و رفرنس را برمی‌گرداند
     - `dog3 != null` → true
   - `Dog dog4 = animal2 as Dog;`:
     - `animal2` یک `Cat` است (نه `Dog`)
     - `as` شکست می‌خورد و **null** برمی‌گرداند
     - `dog4 != null` → false
5. خروجی: **"dog1: True, dog2: Exception"** (کد متوقف می‌شود)
   - اما اگر Exception handle شود: **"dog3: True, dog4: False"**

**نکات کلیدی:**
- **Direct Cast**: در صورت شکست Exception می‌دهد.
- **as operator**: در صورت شکست null برمی‌گرداند (ایمن‌تر).
- `as` برای مواردی که مطمئن نیستیم **بهتر** است.

**کد اصلاح شده:**
```csharp
try {
    Dog dog1 = (Dog)animal1;  // ✅ Success
    Dog dog2 = (Dog)animal2;  // ❌ Exception
} catch (InvalidCastException) {
    Console.WriteLine("dog2: Exception");
}

Dog dog3 = animal1 as Dog;  // ✅ Success
Dog dog4 = animal2 as Dog;  // ✅ null (ایمن)
```

</details>

---

## 📊 خلاصه آزمون

### آمار پاسخ‌ها:
- **سوالات آسان**: 6 سوال (سوالات 1-6)
- **سوالات متوسط**: 9 سوال (سوالات 7-15)
- **سوالات سخت**: 5 سوال (سوالات 16-20)

### موضوعات پوشش داده شده:
1. ✅ تعریف Casting
2. ✅ Upcasting (Implicit)
3. ✅ Downcasting (Explicit)
4. ✅ عملگر `is` (Type Checking)
5. ✅ عملگر `as` (Safe Casting)
6. ✅ Pattern Matching (C# 7+)
7. ✅ InvalidCastException
8. ✅ Type Information (GetType vs typeof)
9. ✅ Casting از object
10. ✅ Casting از Interface
11. ✅ Multi-Level Inheritance
12. ✅ Reference Equality
13. ✅ Exception Handling
14. ✅ Collections و Type Checking
15. ✅ مقایسه Direct Cast و `as`

### 🎯 نکات مهم برای موفقیت:
1. **Upcasting**: خودکار و همیشه ایمن (Derived → Base)
2. **Downcasting**: صریح و خطرناک (Base → Derived)
3. **`is`**: برای Type Checking (Boolean)
4. **`as`**: برای Safe Casting (null در صورت شکست)
5. **Direct Cast**: Exception در صورت شکست
6. **GetType()**: نوع واقعی (Runtime)
7. **typeof()**: نوع اعلان شده (Compile-time)

---

**موفق باشید! 🚀**
