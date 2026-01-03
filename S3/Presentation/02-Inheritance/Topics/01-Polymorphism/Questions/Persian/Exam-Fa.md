<div dir="rtl" style="text-align: right;">

# 📝 آزمون چندریختی (Polymorphism) در C#

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
class Animal {
    public virtual void Speak() {
        Console.WriteLine("Animal sound");
    }
}

class Dog : Animal {
    public override void Speak() {
        Console.WriteLine("Woof!");
    }
}

Animal animal = new Dog();
animal.Speak();
```

<div dir="rtl" style="text-align: right;">

**الف)** Animal sound  
**ب)** Woof!  
**ج)** خطای کامپایل  
**د)** خطای زمان اجرا  

<details>
<summary>✅ پاسخ صحیح: ب</summary>

**تحلیل:**

این سوال مفهوم پایه **Runtime Polymorphism** را بررسی می‌کند.

1. `Animal animal = new Dog();` یک رفرنس از نوع `Animal` ایجاد می‌کند که به یک شی `Dog` اشاره می‌کند.
2. `animal.Speak();` یک **Virtual Call** است.
3. در زمان اجرا، CLR نوع واقعی شی را بررسی می‌کند (`Dog`).
4. از آنجایی که `Speak()` در `Dog` با `override` بازنویسی شده، متد `Dog.Speak()` اجرا می‌شود.
5. خروجی: **"Woof!"**

**نکات کلیدی:**
- `virtual` در کلاس پایه برای فعال کردن Polymorphism ضروری است.
- `override` در کلاس مشتق برای بازنویسی متد پایه استفاده می‌شود.
- بدون `virtual`/`override`، متد مشتق **Hiding** می‌شود نه Override.

</details>

---

### سوال 2️⃣

کدام گزینه تعریف صحیح **Polymorphism** است؟

**الف)** توانایی یک کلاس برای ارث‌بری از چند کلاس  
**ب)** توانایی یک شی برای گرفتن فرم‌های مختلف در زمان اجرا  
**ج)** تعریف چند متد با نام یکسان در یک کلاس  
**د)** استفاده از `sealed` برای جلوگیری از ارث‌بری  

<details>
<summary>✅ پاسخ صحیح: ب</summary>

**تحلیل:**

**Polymorphism** (چندریختی) به معنای توانایی یک شی برای گرفتن فرم‌های مختلف است.

**مثال:**
```csharp
Animal animal1 = new Dog();    // ✅
Animal animal2 = new Cat();    // ✅
Animal animal3 = new Bird();   // ✅
```

همه این رفرنس‌ها از نوع `Animal` هستند، اما به اشیای مختلف (`Dog`, `Cat`, `Bird`) اشاره می‌کنند و رفتار متفاوتی دارند.

**گزینه‌های نادرست:**
- **الف**: این تعریف **Multiple Inheritance** است که در C# پشتیبانی نمی‌شود.
- **ج**: این تعریف **Method Overloading** (Static Polymorphism) است.
- **د**: این تعریف **Sealed Classes** است.

</details>

---

### سوال 3️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Calculator {
    public int Add(int a, int b) => a + b;
    public double Add(double a, double b) => a + b;
}

var calc = new Calculator();
Console.WriteLine(calc.Add(5, 3));
Console.WriteLine(calc.Add(5.5, 3.2));
```

<div dir="rtl" style="text-align: right;">

**الف)** 8 و 8.7  
**ب)** 8.0 و 8.7  
**ج)** خطای کامپایل  
**د)** خطای زمان اجرا  

<details>
<summary>✅ پاسخ صحیح: الف</summary>

**تحلیل:**

این سوال **Method Overloading** (Static Polymorphism) را بررسی می‌کند.

1. `calc.Add(5, 3)`: کامپایلر نوع پارامترها را بررسی می‌کند (`int`, `int`) و `Add(int, int)` را انتخاب می‌کند. خروجی: **8**
2. `calc.Add(5.5, 3.2)`: کامپایلر نوع پارامترها را بررسی می‌کند (`double`, `double`) و `Add(double, double)` را انتخاب می‌کند. خروجی: **8.7**

**نکات کلیدی:**
- Overloading در **Compile-time** resolve می‌شود.
- کامپایلر بر اساس **تعداد، نوع و ترتیب** پارامترها تصمیم می‌گیرد.
- Return Type در Overloading مهم نیست.

</details>

---

### سوال 4️⃣

کدام کلیدواژه برای فعال کردن Runtime Polymorphism در کلاس پایه ضروری است؟

**الف)** `override`  
**ب)** `virtual`  
**ج)** `new`  
**د)** `sealed`  

<details>
<summary>✅ پاسخ صحیح: ب</summary>

**تحلیل:**

برای فعال کردن **Runtime Polymorphism** باید:

1. در کلاس پایه: از `virtual` استفاده کنیم
2. در کلاس مشتق: از `override` استفاده کنیم

**مثال:**
```csharp
class Animal {
    public virtual void Speak() { }  // ✅ virtual در Base
}

class Dog : Animal {
    public override void Speak() { }  // ✅ override در Derived
}
```

**گزینه‌های نادرست:**
- **الف**: `override` فقط در کلاس مشتق استفاده می‌شود.
- **ج**: `new` برای **Hiding** استفاده می‌شود (Compile-time).
- **د**: `sealed` برای جلوگیری از Override استفاده می‌شود.

</details>

---

### سوال 5️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Shape {
    public virtual double GetArea() => 0;
}

class Circle : Shape {
    private double radius = 5;
    public override double GetArea() => Math.PI * radius * radius;
}

Shape shape = new Circle();
Console.WriteLine(shape.GetArea());
```

<div dir="rtl" style="text-align: right;">

**الف)** 0  
**ب)** 78.54 (تقریبا)  
**ج)** خطای کامپایل  
**د)** خطای زمان اجرا  

<details>
<summary>✅ پاسخ صحیح: ب</summary>

**تحلیل:**

این یک مثال کلاسیک از **Polymorphism** است.

1. `Shape shape = new Circle();` یک رفرنس `Shape` به یک شی `Circle` ایجاد می‌کند.
2. `shape.GetArea()` یک Virtual Call است.
3. در Runtime، نوع واقعی (`Circle`) بررسی می‌شود.
4. `Circle.GetArea()` اجرا می‌شود: π × 5² = 25π ≈ **78.54**

**نکات کلیدی:**
- این قدرت Polymorphism است: **یک کد، چند رفتار** بر اساس نوع واقعی.
- می‌توانیم با یک رفرنس `Shape` با انواع مختلف (`Circle`, `Rectangle`, etc.) کار کنیم.

</details>

---

### سوال 6️⃣

کدام نوع Polymorphism در **Compile-time** resolve می‌شود؟

**الف)** Method Overriding  
**ب)** Method Overloading  
**ج)** Virtual Methods  
**د)** Abstract Methods  

<details>
<summary>✅ پاسخ صحیح: ب</summary>

**تحلیل:**

**Static Polymorphism** (چندریختی ایستا) در **Compile-time** resolve می‌شود.

**Method Overloading** نمونه‌ای از Static Polymorphism است:
```csharp
class Math {
    public int Add(int a, int b) => a + b;
    public double Add(double a, double b) => a + b;
}

var math = new Math();
math.Add(5, 3);  // کامپایلر در Compile-time تصمیم می‌گیرد
```

**گزینه‌های نادرست:**
- **الف، ج، د**: همه در **Runtime** resolve می‌شوند (Dynamic Polymorphism).

</details>

---

## 🟡 بخش دوم: سوالات متوسط (9 سوال)

### سوال 7️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Animal {
    public void Speak() {  // virtual نیست
        Console.WriteLine("Animal");
    }
}

class Dog : Animal {
    public void Speak() {  // override نیست
        Console.WriteLine("Dog");
    }
}

Animal animal = new Dog();
animal.Speak();
```

<div dir="rtl" style="text-align: right;">

**الف)** Animal  
**ب)** Dog  
**ج)** خطای کامپایل  
**د)** خطای زمان اجرا  

<details>
<summary>✅ پاسخ صحیح: الف</summary>

**تحلیل:**

این سوال تفاوت بین **Hiding** و **Overriding** را بررسی می‌کند.

1. در `Animal`: متد `Speak()` **virtual نیست**.
2. در `Dog`: متد `Speak()` **override نیست** (در واقع **Hiding** است).
3. `Animal animal = new Dog();` یک رفرنس `Animal` به `Dog` ایجاد می‌کند.
4. `animal.Speak()` در **Compile-time** resolve می‌شود.
5. کامپایلر نوع رفرنس را می‌بیند (`Animal`) و `Animal.Speak()` را صدا می‌زند.
6. خروجی: **"Animal"**

**نکات کلیدی:**
- بدون `virtual`/`override`، Polymorphism کار نمی‌کند.
- این **Member Hiding** است نه Overriding.
- برای Polymorphism باید `virtual` در Base و `override` در Derived استفاده شود.

</details>

---

### سوال 8️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Base {
    public virtual void Method() => Console.WriteLine("Base");
}

class Derived : Base {
    public override void Method() => Console.WriteLine("Derived");
}

class Derived2 : Derived {
    public override void Method() => Console.WriteLine("Derived2");
}

Base obj = new Derived2();
obj.Method();
```

<div dir="rtl" style="text-align: right;">

**الف)** Base  
**ب)** Derived  
**ج)** Derived2  
**د)** خطای کامپایل  

<details>
<summary>✅ پاسخ صحیح: ج</summary>

**تحلیل:**

این سوال **Multi-Level Inheritance** و **Virtual Method Resolution** را بررسی می‌کند.

1. `Base obj = new Derived2();` یک رفرنس `Base` به `Derived2` ایجاد می‌کند.
2. `obj.Method()` یک Virtual Call است.
3. در Runtime:
   - نوع واقعی: `Derived2`
   - `Derived2` متد `Method()` را override کرده
   - `Derived2.Method()` اجرا می‌شود
4. خروجی: **"Derived2"**

**نکات کلیدی:**
- Virtual Method Resolution همیشه **نوع واقعی** را در نظر می‌گیرد.
- در Multi-Level Inheritance، متد **آخرین override** اجرا می‌شود.
- VMT (Virtual Method Table) برای `Derived2` به `Derived2.Method()` اشاره می‌کند.

</details>

---

### سوال 9️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Animal {
    public virtual void Speak() => Console.WriteLine("Animal");
}

class Dog : Animal {
    public sealed override void Speak() => Console.WriteLine("Dog");
}

class Puppy : Dog {
    public override void Speak() => Console.WriteLine("Puppy");
}

Animal animal = new Puppy();
animal.Speak();
```

<div dir="rtl" style="text-align: right;">

**الف)** Animal  
**ب)** Dog  
**ج)** Puppy  
**د)** خطای کامپایل  

<details>
<summary>✅ پاسخ صحیح: د</summary>

**تحلیل:**

این سوال مفهوم **Sealed Override** را بررسی می‌کند.

1. در `Dog`: متد `Speak()` با `sealed override` بازنویسی شده است.
2. `sealed override` به معنای این است که این متد **دیگر نمی‌تواند** در کلاس‌های مشتق بعدی override شود.
3. در `Puppy`: تلاش برای override کردن `Speak()` انجام شده که **خطای کامپایل** می‌دهد.

**خطای کامپایل:**
```
Error: 'Puppy.Speak()': cannot override inherited member 'Dog.Speak()' because it is sealed
```

**نکات کلیدی:**
- `sealed override` برای جلوگیری از Override بیشتر استفاده می‌شود.
- این برای **Performance Optimization** و **Security** مفید است.
- فقط می‌توان متدهای `virtual` یا `override` را seal کرد.

</details>

---

### سوال 🔟

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Base {
    public virtual void Method() {
        Console.WriteLine("Base");
    }
}

class Derived : Base {
    public new void Method() {
        Console.WriteLine("Derived");
    }
}

Base obj = new Derived();
obj.Method();
```

<div dir="rtl" style="text-align: right;">

**الف)** Base  
**ب)** Derived  
**ج)** خطای کامپایل  
**د)** خطای زمان اجرا  

<details>
<summary>✅ پاسخ صحیح: الف</summary>

**تحلیل:**

این سوال تفاوت بین **Hiding** (`new`) و **Overriding** (`override`) را بررسی می‌کند.

1. در `Base`: متد `Method()` **virtual** است.
2. در `Derived`: متد `Method()` با `new` تعریف شده (نه `override`).
3. `new` به معنای **Hiding** است، نه Overriding.
4. `Base obj = new Derived();` یک رفرنس `Base` به `Derived` ایجاد می‌کند.
5. `obj.Method()` در **Compile-time** resolve می‌شود.
6. کامپایلر نوع رفرنس را می‌بیند (`Base`) و `Base.Method()` را صدا می‌زند.
7. خروجی: **"Base"**

**نکات کلیدی:**
- `new` = Hiding (Compile-time) → بر اساس نوع رفرنس
- `override` = Overriding (Runtime) → بر اساس نوع واقعی
- برای Polymorphism باید از `override` استفاده شود، نه `new`.

</details>

---

### سوال 1️⃣1️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Animal {
    public virtual void Speak() => Console.WriteLine("Animal");
}

class Dog : Animal {
    public override void Speak() {
        base.Speak();
        Console.WriteLine("Dog");
    }
}

Animal animal = new Dog();
animal.Speak();
```

<div dir="rtl" style="text-align: right;">

**الف)** Animal  
**ب)** Dog  
**ج)** Animal سپس Dog  
**د)** Dog سپس Animal  

<details>
<summary>✅ پاسخ صحیح: ج</summary>

**تحلیل:**

این سوال استفاده از `base` keyword در Override را بررسی می‌کند.

1. `Animal animal = new Dog();` یک رفرنس `Animal` به `Dog` ایجاد می‌کند.
2. `animal.Speak()` یک Virtual Call است که `Dog.Speak()` را اجرا می‌کند.
3. در `Dog.Speak()`:
   - `base.Speak()` متد `Animal.Speak()` را صدا می‌زند → خروجی: **"Animal"**
   - سپس `Console.WriteLine("Dog")` اجرا می‌شود → خروجی: **"Dog"**
4. خروجی نهایی: **"Animal" سپس "Dog"**

**نکات کلیدی:**
- `base` keyword برای دسترسی به متد کلاس پایه استفاده می‌شود.
- `base.Speak()` یک **Direct Call** است (نه Virtual Call).
- این الگو برای **Template Method Pattern** مفید است.

</details>

---

### سوال 1️⃣2️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Calculator {
    public int Add(int a, int b) => a + b;
    public int Add(int a, int b = 0, int c = 0) => a + b + c;
}

var calc = new Calculator();
calc.Add(5, 3);
```

<div dir="rtl" style="text-align: right;">

**الف)** 8  
**ب)** 8 (با warning)  
**ج)** خطای کامپایل: Ambiguous call  
**د)** خطای زمان اجرا  

<details>
<summary>✅ پاسخ صحیح: ج</summary>

**تحلیل:**

این سوال **Ambiguous Overload Resolution** با Optional Parameters را بررسی می‌کند.

1. `calc.Add(5, 3)` می‌تواند به دو متد اشاره کند:
   - `Add(int a, int b)` → دقیقاً 2 پارامتر
   - `Add(int a, int b = 0, int c = 0)` → با optional parameters می‌تواند 2 پارامتر بگیرد
2. کامپایلر نمی‌تواند تصمیم بگیرد کدام متد را انتخاب کند.
3. **خطای کامپایل: Ambiguous call**

**خطای کامپایل:**
```
Error: The call is ambiguous between 'Add(int, int)' and 'Add(int, int, int)'
```

**راه حل:**
```csharp
// فقط یک متد با optional parameters:
public int Add(int a, int b = 0, int c = 0) => a + b + c;
```

**نکات کلیدی:**
- Optional Parameters می‌تواند باعث Ambiguity در Overloading شود.
- بهتر است از Optional Parameters به جای Overloading زیاد استفاده شود.

</details>

---

### سوال 1️⃣3️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Animal {
    public virtual void Speak() => Console.WriteLine("Animal");
}

class Dog : Animal {
    public override void Speak() => Console.WriteLine("Dog");
}

class Cat : Animal {
    public override void Speak() => Console.WriteLine("Cat");
}

Animal[] animals = { new Dog(), new Cat(), new Dog() };
foreach (Animal animal in animals) {
    animal.Speak();
}
```

<div dir="rtl" style="text-align: right;">

**الف)** Animal, Animal, Animal  
**ب)** Dog, Cat, Dog  
**ج)** خطای کامپایل  
**د)** خطای زمان اجرا  

<details>
<summary>✅ پاسخ صحیح: ب</summary>

**تحلیل:**

این سوال **Polymorphism در Collections** را بررسی می‌کند.

1. `Animal[] animals` یک آرایه از رفرنس‌های `Animal` است.
2. هر عنصر می‌تواند به یک شی `Dog` یا `Cat` اشاره کند.
3. در حلقه `foreach`:
   - `animal.Speak()` یک Virtual Call است.
   - برای هر عنصر، Runtime نوع واقعی را بررسی می‌کند.
   - `animals[0]` = `Dog` → `Dog.Speak()` → **"Dog"**
   - `animals[1]` = `Cat` → `Cat.Speak()` → **"Cat"**
   - `animals[2]` = `Dog` → `Dog.Speak()` → **"Dog"**
4. خروجی: **"Dog", "Cat", "Dog"**

**نکات کلیدی:**
- این قدرت Polymorphism است: **یک کد، چند رفتار**.
- می‌توانیم با یک آرایه `Animal` انواع مختلف را پردازش کنیم.
- این الگو برای **Strategy Pattern** و **Factory Pattern** مفید است.

</details>

---

### سوال 1️⃣4️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Base {
    public virtual void Method(int x) => Console.WriteLine("Base: int");
    public virtual void Method(double x) => Console.WriteLine("Base: double");
}

class Derived : Base {
    public override void Method(int x) => Console.WriteLine("Derived: int");
}

Base obj = new Derived();
obj.Method(5);
obj.Method(5.0);
```

<div dir="ltr" style="text-align: right;">

**الف)** Base: int, Base: double  
**ب)** Derived: int, Base: double  
**ج)** Derived: int, Derived: double  
**د)** خطای کامپایل  

<details>
<summary>✅ پاسخ صحیح: ب</summary>

**تحلیل:**

این سوال ترکیب **Overloading** و **Overriding** را بررسی می‌کند.

1. `Base obj = new Derived();` یک رفرنس `Base` به `Derived` ایجاد می‌کند.
2. `obj.Method(5)`:
   - کامپایلر نوع پارامتر را بررسی می‌کند: `int`
   - `Method(int)` را انتخاب می‌کند
   - سپس Virtual Call: Runtime نوع واقعی (`Derived`) را بررسی می‌کند
   - `Derived.Method(int)` اجرا می‌شود → **"Derived: int"**
3. `obj.Method(5.0)`:
   - کامپایلر نوع پارامتر را بررسی می‌کند: `double`
   - `Method(double)` را انتخاب می‌کند
   - سپس Virtual Call: Runtime نوع واقعی (`Derived`) را بررسی می‌کند
   - `Derived` متد `Method(double)` را override نکرده
   - `Base.Method(double)` اجرا می‌شود → **"Base: double"**
4. خروجی: **"Derived: int", "Base: double"**

**نکات کلیدی:**
- ابتدا **Overload Resolution** (Compile-time) انجام می‌شود.
- سپس **Virtual Method Resolution** (Runtime) انجام می‌شود.
- فقط متدهای override شده در Derived اجرا می‌شوند.

</details>

---

### سوال 1️⃣5️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Animal {
    public virtual void Speak() => Console.WriteLine("Animal");
}

class Dog : Animal {
    public override void Speak() => Console.WriteLine("Dog");
}

class Cat : Animal {
    public override void Speak() => Console.WriteLine("Cat");
}

void Process(Animal animal) {
    animal.Speak();
}

Process(new Dog());
Process(new Cat());
```

<div dir="rtl" style="text-align: right;">

**الف)** Animal, Animal  
**ب)** Dog, Cat  
**ج)** خطای کامپایل  
**د)** خطای زمان اجرا  

<details>
<summary>✅ پاسخ صحیح: ب</summary>

**تحلیل:**

این سوال **Polymorphism در Method Parameters** را بررسی می‌کند.

1. متد `Process(Animal animal)` یک پارامتر از نوع `Animal` می‌گیرد.
2. `Process(new Dog())`:
   - یک شی `Dog` به متد پاس داده می‌شود (Upcast به `Animal`)
   - `animal.Speak()` یک Virtual Call است
   - Runtime نوع واقعی (`Dog`) را بررسی می‌کند
   - `Dog.Speak()` اجرا می‌شود → **"Dog"**
3. `Process(new Cat())`:
   - یک شی `Cat` به متد پاس داده می‌شود (Upcast به `Animal`)
   - `animal.Speak()` یک Virtual Call است
   - Runtime نوع واقعی (`Cat`) را بررسی می‌کند
   - `Cat.Speak()` اجرا می‌شود → **"Cat"**
4. خروجی: **"Dog", "Cat"**

**نکات کلیدی:**
- این قدرت Polymorphism است: **یک متد، چند رفتار**.
- می‌توانیم با یک پارامتر `Animal` انواع مختلف را پردازش کنیم.
- این الگو برای **Dependency Injection** و **Strategy Pattern** مفید است.

</details>

---

## 🔴 بخش سوم: سوالات سخت (5 سوال)

### سوال 1️⃣6️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Animal {
    public virtual void Speak() => Console.WriteLine("Animal");
}

class Dog : Animal {
    public override void Speak() => Console.WriteLine("Dog");
}

class Puppy : Dog {
    public override void Speak() {
        base.Speak();
        Console.WriteLine("Puppy");
    }
}

Animal animal = new Puppy();
animal.Speak();
```

<div dir="rtl" style="text-align: right;">

**الف)** Animal  
**ب)** Dog  
**ج)** Puppy  
**د)** Dog سپس Puppy  

<details>
<summary>✅ پاسخ صحیح: د</summary>

**تحلیل:**

این سوال **Multi-Level Inheritance** و **base keyword** را بررسی می‌کند.

1. `Animal animal = new Puppy();` یک رفرنس `Animal` به `Puppy` ایجاد می‌کند.
2. `animal.Speak()` یک Virtual Call است که `Puppy.Speak()` را اجرا می‌کند.
3. در `Puppy.Speak()`:
   - `base.Speak()` متد **مستقیم Base Class** (`Dog`) را صدا می‌زند
   - `base` فقط **یک سطح بالا** می‌رود، نه به `Animal`
   - `Dog.Speak()` اجرا می‌شود → **"Dog"**
   - سپس `Console.WriteLine("Puppy")` اجرا می‌شود → **"Puppy"**
4. خروجی: **"Dog" سپس "Puppy"**

**نکات کلیدی:**
- `base` keyword فقط به **مستقیم Base Class** اشاره می‌کند.
- `base.base` وجود ندارد! فقط یک سطح بالا می‌رود.
- برای دسترسی به GrandParent باید از Cast استفاده کرد: `((Animal)this).Method()`

</details>

---

### سوال 1️⃣7️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Animal {
    public virtual void Speak() => Console.WriteLine("Animal");
}

class Dog : Animal {
    public override void Speak() => Console.WriteLine("Dog");
}

class Cat : Animal {
    public override void Speak() => Console.WriteLine("Cat");
}

void Process<T>(T item) where T : Animal {
    item.Speak();
}

Process(new Dog());
Process(new Cat());
```

<div dir="rtl" style="text-align: right;">

**الف)** Animal, Animal  
**ب)** Dog, Cat  
**ج)** خطای کامپایل  
**د)** خطای زمان اجرا  

<details>
<summary>✅ پاسخ صحیح: ب</summary>

**تحلیل:**

این سوال **Polymorphism با Generic Constraints** را بررسی می‌کند.

1. `Process<T>(T item) where T : Animal` یک Generic Method با Constraint است.
2. `Process(new Dog())`:
   - Type Inference: `T = Dog`
   - Constraint: `Dog : Animal` ✅
   - `item.Speak()` یک Virtual Call است
   - Runtime نوع واقعی (`Dog`) را بررسی می‌کند
   - `Dog.Speak()` اجرا می‌شود → **"Dog"**
3. `Process(new Cat())`:
   - Type Inference: `T = Cat`
   - Constraint: `Cat : Animal` ✅
   - `item.Speak()` یک Virtual Call است
   - Runtime نوع واقعی (`Cat`) را بررسی می‌کند
   - `Cat.Speak()` اجرا می‌شود → **"Cat"**
4. خروجی: **"Dog", "Cat"**

**نکات کلیدی:**
- Generic Constraints در **Compile-time** چک می‌شوند.
- Virtual Method Resolution در **Runtime** انجام می‌شود.
- Polymorphism با Generics ترکیب قدرتمندی است.
- Type Erasure در C# وجود ندارد (برخلاف Java).

</details>

---

### سوال 1️⃣8️⃣

کد زیر چه خروجی می‌دهد؟ (C# 9+)

<div dir="ltr" style="text-align: left;">

```csharp
class Animal { }
class Dog : Animal { }

class AnimalFactory {
    public virtual Animal Create() => new Animal();
}

class DogFactory : AnimalFactory {
    public override Dog Create() => new Dog();  // Covariant Return Type
}

var factory = new DogFactory();
var result = factory.Create();
Console.WriteLine(result.GetType().Name);
```

<div dir="rtl" style="text-align: right;">

**الف)** Animal  
**ب)** Dog  
**ج)** خطای کامپایل  
**د)** خطای زمان اجرا  

<details>
<summary>✅ پاسخ صحیح: ب</summary>

**تحلیل:**

این سوال **Covariant Return Types** (C# 9+) را بررسی می‌کند.

1. در `AnimalFactory`: متد `Create()` نوع `Animal` برمی‌گرداند.
2. در `DogFactory`: متد `Create()` با `override` نوع `Dog` برمی‌گرداند (Covariant).
3. `var factory = new DogFactory();` یک شی `DogFactory` ایجاد می‌کند.
4. `factory.Create()`:
   - Virtual Call: Runtime نوع واقعی (`DogFactory`) را بررسی می‌کند
   - `DogFactory.Create()` اجرا می‌شود
   - نوع برگشتی: `Dog`
5. `result.GetType().Name` نوع واقعی شی را برمی‌گرداند → **"Dog"**

**نکات کلیدی:**
- **Covariant Return Types** فقط در C# 9.0+ پشتیبانی می‌شود.
- می‌توانیم در Override نوع Derived را برگردانیم.
- این فقط برای **Return Types** کار می‌کند، نه Parameter Types.
- قبل از C# 9، باید همان نوع Base را برمی‌گرداندیم.

</details>

---

### سوال 1️⃣9️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Animal {
    public virtual void Speak() => Console.WriteLine("Animal");
}

class Dog : Animal {
    public sealed override void Speak() => Console.WriteLine("Dog");
}

class Puppy : Dog {
    // Speak() override نشده
}

Animal animal1 = new Dog();
Animal animal2 = new Puppy();
animal1.Speak();
animal2.Speak();
```

<div dir="rtl" style="text-align: right;">

**الف)** Dog, Dog  
**ب)** Dog, Animal  
**ج)** Animal, Animal  
**د)** خطای کامپایل  

<details>
<summary>✅ پاسخ صحیح: الف</summary>

**تحلیل:**

این سوال **Sealed Override** و **Virtual Method Resolution** را بررسی می‌کند.

1. `Animal animal1 = new Dog();`:
   - Virtual Call: Runtime نوع واقعی (`Dog`) را بررسی می‌کند
   - `Dog.Speak()` sealed override شده
   - `Dog.Speak()` اجرا می‌شود → **"Dog"**
2. `Animal animal2 = new Puppy();`:
   - Virtual Call: Runtime نوع واقعی (`Puppy`) را بررسی می‌کند
   - `Puppy` متد `Speak()` را override نکرده
   - VMT برای `Puppy` به `Dog.Speak()` اشاره می‌کند (از Base ارث برده)
   - `Dog.Speak()` اجرا می‌شود → **"Dog"**
3. خروجی: **"Dog", "Dog"**

**نکات کلیدی:**
- `sealed override` جلوگیری از Override بیشتر می‌کند.
- اگر کلاس مشتق Override نکند، متد Base (که sealed است) استفاده می‌شود.
- VMT برای `Puppy` به `Dog.Speak()` اشاره می‌کند.

</details>

---

### سوال 2️⃣0️⃣

کد زیر چه خروجی می‌دهد؟

<div dir="ltr" style="text-align: left;">

```csharp
class Base {
    public virtual void Method(int x) => Console.WriteLine("Base: int");
    public virtual void Method(object x) => Console.WriteLine("Base: object");
}

class Derived : Base {
    public override void Method(int x) => Console.WriteLine("Derived: int");
    public new void Method(object x) => Console.WriteLine("Derived: object");
}

Base obj = new Derived();
obj.Method(5);
obj.Method((object)5);
```

<div dir="rtl" style="text-align: right;">

**الف)** Derived: int, Base: object  
**ب)** Derived: int, Derived: object  
**ج)** Base: int, Base: object  
**د)** خطای کامپایل  

<details>
<summary>✅ پاسخ صحیح: الف</summary>

**تحلیل:**

این سوال ترکیب پیچیده **Overloading**, **Overriding** و **Hiding** را بررسی می‌کند.

1. `Base obj = new Derived();` یک رفرنس `Base` به `Derived` ایجاد می‌کند.
2. `obj.Method(5)`:
   - **Overload Resolution** (Compile-time): نوع پارامتر `int` → `Method(int)` انتخاب می‌شود
   - **Virtual Method Resolution** (Runtime): نوع واقعی (`Derived`) → `Derived.Method(int)` اجرا می‌شود
   - خروجی: **"Derived: int"**
3. `obj.Method((object)5)`:
   - **Overload Resolution** (Compile-time): نوع پارامتر `object` → `Method(object)` انتخاب می‌شود
   - **Virtual Method Resolution** (Runtime): نوع واقعی (`Derived`) → اما `Derived.Method(object)` با `new` تعریف شده (Hiding)
   - Hiding در Compile-time resolve می‌شود → نوع رفرنس (`Base`) → `Base.Method(object)` اجرا می‌شود
   - خروجی: **"Base: object"**
4. خروجی: **"Derived: int", "Base: object"**

**نکات کلیدی:**
- ابتدا **Overload Resolution** (Compile-time) انجام می‌شود.
- سپس **Virtual Method Resolution** (Runtime) انجام می‌شود.
- اما اگر متد با `new` (Hiding) تعریف شده باشد، Compile-time resolve می‌شود.
- `override` = Runtime Resolution | `new` = Compile-time Resolution

</details>

---

## 📊 خلاصه آزمون

### آمار پاسخ‌ها:
- **سوالات آسان**: 6 سوال (سوالات 1-6)
- **سوالات متوسط**: 9 سوال (سوالات 7-15)
- **سوالات سخت**: 5 سوال (سوالات 16-20)

### موضوعات پوشش داده شده:
1. ✅ تعریف Polymorphism
2. ✅ Static vs Dynamic Polymorphism
3. ✅ Method Overloading
4. ✅ Method Overriding
5. ✅ virtual و override
6. ✅ Hiding vs Overriding
7. ✅ Multi-Level Inheritance
8. ✅ Sealed Override
9. ✅ base keyword
10. ✅ Optional Parameters و Ambiguity
11. ✅ Polymorphism در Collections
12. ✅ Polymorphism در Method Parameters
13. ✅ ترکیب Overloading و Overriding
14. ✅ Generic Constraints و Polymorphism
15. ✅ Covariant Return Types
16. ✅ Virtual Method Resolution پیچیده

### 🎯 نکات مهم برای موفقیت:
1. **virtual/override** برای Runtime Polymorphism ضروری است.
2. **Hiding** (`new`) در Compile-time resolve می‌شود.
3. **Overriding** (`override`) در Runtime resolve می‌شود.
4. ابتدا **Overload Resolution**، سپس **Virtual Method Resolution**.
5. `base` فقط به **مستقیم Base Class** اشاره می‌کند.

---

**موفق باشید! 🚀**
