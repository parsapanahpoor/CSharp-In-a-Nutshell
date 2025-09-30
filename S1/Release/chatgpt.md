# Introducing C# and .NET

<div dir="ltr">

C# is a general-purpose, type-safe, object-oriented programming language. The goal of the language is programmer productivity. To this end, C# balances simplicity, expressiveness, and performance. The chief architect of the language since its first version is Anders Hejlsberg (creator of Turbo Pascal and architect of Delphi). The C# language is platform neutral and works with a range of platform-specific runtimes.

</div>

---

## ترجمه پاراگراف
<div dir="rtl">

C# یک زبان برنامه‌نویسی همه‌منظوره،  type-safe و  object-oriented است. هدف اصلی این زبان، افزایش بهره‌وری برنامه‌نویس‌هاست. برای رسیدن به این هدف، C# بین سادگی، بیان‌پذیری (expressiveness) و کارایی (performance) تعادل ایجاد می‌کند.  
معمار اصلی این زبان از نسخه اول تاکنون آندرس هایلسبرگ بوده است - خالق Turbo Pascal و معمار Delphi.  
زبان C# مستقل از پلتفرم است و می‌تواند با مجموعه‌ای از runtimeهای خاص هر پلتفرم کار کند.

</div>

---

## توضیحات تکمیلی و نکات ارائه
<div dir="rtl">

### General-purpose
یعنی C# محدود به یک نوع نرم‌افزار خاص نیست؛ میشه باهاش وب‌اپلیکیشن، اپلیکیشن موبایل، دسکتاپ، بازی، سیستم‌های توزیع‌شده و حتی هوش مصنوعی نوشت.

### Type-safe
امنیت در نوع داده‌ها.  
یعنی مثلاً نمی‌تونی به اشتباه یک عدد صحیح رو مثل یک رشته (string) استفاده کنی بدون تبدیل درست.  
این باعث میشه خطاهای برنامه‌ کمتر باشه.

### Object-Oriented
همه‌چیز حول محور کلاس و شیء می‌چرخه.  
پشتیبانی از مفاهیمی مثل ارث‌بری، پلی‌مورفیسم، کپسوله‌سازی.

### Programmer Productivity
C# کمک میکنه برنامه‌نویس سریع‌تر، راحت‌تر و با خطای کمتر کد بزنه.  
IntelliSense، کتابخانه‌های آماده، و syntax ساده → همه در همین راستا طراحی شدن.

### Platform Neutral
C# خودش مستقل از پلتفرمه.  
چیزی که تغییر می‌کنه runtimeها هستن - مثلاً .NET Framework روی ویندوز، .NET 8 روی همه سیستم‌ها، Unity runtime برای بازی‌ها.  
یعنی یک زبان، اما چند محیط اجرا.

</div>

---

# Object Orientation

<div dir="ltr">

C# is a rich implementation of the object-orientation paradigm, which includes encapsulation, inheritance, and polymorphism. Encapsulation means creating a boundary around an object to separate its external (public) behavior from its inter nal (private) implementation details. Following are the distinctive features of C# from an object-oriented perspective:

- **Unified type system**  
  The fundamental building block in C# is an encapsulated unit of data and functions called a type. C# has a unified type system in which all types ultimately share a common base type. This means that all types, whether they represent business objects or are primitive types such as numbers, share the same basic functionality. For example, an instance of any type can be converted to a string by calling its ToString method.

- **Classes and interfaces**  
  In a traditional object-oriented paradigm, the only kind of type is a class. In C#, there are several other kinds of types, one of which is an interface. An interface is like a class that cannot hold data. This means that it can define only behavior (and not state), which allows for multiple inheritance as well as a separation between specification and implementation.

- **Properties, methods, and events**  
  In the pure object-oriented paradigm, all functions are methods. In C#, methods are only one kind of function member, which also includes properties and events (there are others, too). Properties are function members that encapsulate a piece of an object’s state such as a button’s color or a label’s text. Events are function members that simplify acting on object state changes.

Although C# is primarily an object-oriented language, it also borrows from the functional programming paradigm, specifically:  
- Functions can be treated as values  
- Using delegates, C# allows functions to be passed as values to and from other functions.  
- C# supports patterns for purity  
- Core to functional programming is avoiding the use of variables whose values change, in favor of declarative patterns.  
- C# has key features to help with those patterns, including the ability to write unnamed functions on the fly that “capture” variables (lambda expressions), and the ability to perform list or reactive programming via query expressions.  
- C# also provides records, which make it easy to write immutable (read-only) types.

</div>

---

## ترجمه پاراگراف
<div dir="rtl">

### شیءگرایی
C# پیاده‌سازی غنی‌ای از پارادایم شیءگرایی ارائه می‌دهد که شامل encapsulation،  inheritance و polymorphism است.  
encapsulation یعنی ایجاد یک مرز به دور یک شیء برای جداسازی رفتار بیرونی (عمومی) آن از جزئیات پیاده‌سازی درونی (خصوصی).

---

### ویژگی‌های متمایز C# از دیدگاه object-oriented

#### سیستم نوع یکپارچه (Unified type system)
واحد اصلی ساخت برنامه در #C ،  Type است — یعنی یک واحد کپسوله‌شده از داده و توابع.  
در این زبان، همه نوع‌ها در نهایت زیرمجموعه‌ای از یک نوع پایه مشترک هستند. این یعنی فرقی نمی‌کند با یک شی تجاری (Business Object) کار می‌کنید یا با یک عدد ساده، همه این نوع‌ها از یک سری قابلیت‌های پایه برخوردارند.  
برای مثال: می‌تونید روی هر شیئی در #C متد ToString را صدا بزنید و نسخه متنی (رشته‌ای) از آن دریافت کنید — چون همه نوع‌ها این متد را دارند.

#### کلاس‌ها و اینترفیس‌ها (Classes and interfaces)
در پارادایم سنتی شیءگرایی، تنها نوع موجود کلاس است. در C#، انواع دیگری هم وجود دارند که یکی از آن‌ها interface است. اینترفیس شبیه یک کلاس است، اما نمی‌تواند داده نگه دارد. یعنی فقط می‌تواند رفتار (behavior) تعریف کند، نه حالت (state). این ویژگی امکان چند ارث‌بری و همچنین جداسازی مشخصات (specification) از پیاده‌سازی (implementation) را فراهم می‌کند.

#### ویژگی‌ها (Properties)، متدها (Methods) و رویدادها (Events)
در پارادایم خالص شیءگرایی، تمام توابع به شکل متد هستند. در C#، متدها فقط یکی از انواع اعضای تابعی (function members) هستند. علاوه بر آن‌ها، ویژگی‌ها (properties) و رویدادها (events) هم وجود دارند (و موارد دیگر نیز).  
Properties اعضایی هستند که بخشی از حالت یک شیء را کپسوله می‌کنند، مثل رنگ یک دکمه یا متن یک لیبل. رویدادها اعضایی هستند که واکنش به تغییر حالت یک شیء را ساده می‌کنند.

---

### گرچه C# عمدتاً یک زبان شیءگراست، اما از پارادایم برنامه‌نویسی تابعی (functional programming) هم الهام گرفته است:

- **توابع به‌عنوان مقدار**: با استفاده از delegates، C# اجازه می‌دهد توابع مثل مقادیر به توابع دیگر ارسال یا از آن‌ها بازگردانده شوند.  
- **الگوهای خلوص (Purity patterns)**: اساس برنامه‌نویسی تابعی اجتناب از متغیرهایی است که مقدارشان تغییر می‌کند و به‌جای آن از الگوهای اعلامی (declarative patterns) استفاده می‌شود.  
- **Lambda expressions**: امکان نوشتن توابع بی‌نام در لحظه که متغیرها را “capture” می‌کنند.  
- **Query expressions**: امکان برنامه‌نویسی لیستی یا واکنشی (reactive) از طریق query expressions.  
- **Records**: نوشتن انواع تغییرناپذیر (immutable) یا فقط خواندنی را ساده می‌کند.

</div>
