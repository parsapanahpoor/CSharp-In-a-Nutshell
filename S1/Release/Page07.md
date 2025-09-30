# Windows Desktop and WinUI 3

<div dir="ltr">

For writing rich-client applications that run on Windows 10 and above, you can choose between the classic Windows Desktop APIs (Windows Forms and WPF) and WinUI 3. The Windows Desktop APIs are part of the .NET Desktop runtime, whereas WinUI 3 is part of the Windows App SDK (a separate download). The classic Windows Desktop APIs have existed since 2006 and enjoy terrific third party library support, as well as offering a wealth of answered questions on sites such as StackOverflow. WinUI 3 was released in 2022 and is intended for writing modern immersive applications that feature the latest Windows 10+ controls. It is a successor to the Universal Windows Platform (UWP).

</div>

---

## ترجمه پاراگراف
<div dir="rtl">

برای نوشتن اپلیکیشن‌های rich-client که روی ویندوز 10 و بالاتر اجرا می‌شوند، می‌توانید بین Windows Desktop APIهای کلاسیک (یعنی Windows Forms و WPF) و WinUI 3 یکی را انتخاب کنید.  

Windows Desktop APIها بخشی از .NET Desktop Runtime هستند، در حالی که WinUI 3 بخشی از Windows App SDK است (که باید جداگانه دانلود شود).  

Windows Desktop APIها از سال 2006 وجود داشته‌اند و از پشتیبانی بسیار خوب کتابخانه‌های شخص ثالث برخوردارند، و همچنین در سایت‌هایی مثل StackOverflow حجم زیادی سؤال و جواب برای آن‌ها وجود دارد.  

WinUI 3 در سال 2022 منتشر شد و برای نوشتن اپلیکیشن‌های مدرن و غنی طراحی شده است که شامل آخرین کنترل‌های ویندوز 10 به بالا هستند.  
WinUI 3 جانشین UWP (Universal Windows Platform) محسوب می‌شود.

</div>

---

## توضیحات تکمیلی و نکات ارائه
<div dir="rtl">

### Windows Forms و WPF (کلاسیک):
- قدیمی‌تر (از 2006)  
- پایدار و امتحان‌شده  
- کتابخانه‌های جانبی فراوان + پاسخ‌های بی‌شمار در انجمن‌ها  
- مناسب برای اپلیکیشن‌های سازمانی یا پروژه‌هایی که ثبات مهم‌تر از ظاهر مدرن است  

### WinUI 3 (جدید):
- عرضه در 2022  
- بخشی از Windows App SDK (دانلود جداگانه)  
- هدف: اپلیکیشن‌های مدرن، غنی و immersive  
- ارائه‌ی آخرین کنترل‌ها و UIهای مخصوص Windows 10+  
- جانشین UWP و مسیر آینده‌ی مایکروسافت  

### انتخاب بین این دو:
- اگر ثبات و پشتیبانی مهم‌تره → Forms/WPF  
- اگر UI مدرن و ویژگی‌های جدید می‌خوای → WinUI 3  

👉 جمع‌بندی: “روی ویندوز 10 به بالا، برای ساخت اپ‌های دسکتاپ یا APIهای کلاسیک (Forms/WPF) یا WinUI 3 مدرن رو داریم. انتخاب بستگی به اولویت پروژه داره.”

</div>

---

# MAUI

<div dir="ltr">

MAUI (Multi-platform App UI) is designed primarily for creating mobile apps for iOS and Android, although it can also be used for desktop apps that run on macOS and Windows via Mac Catalyst and WinUI 3. MAUI is an evolution of Xamarin and allows a single project to target multiple platforms.

</div>

---

## ترجمه پاراگراف
<div dir="rtl">

MAUI عمدتاً برای ساخت اپلیکیشن‌های موبایل برای iOS و Android طراحی شده است، هرچند می‌تواند برای اپلیکیشن‌های دسکتاپ (روی macOS و Windows از طریق Mac Catalyst و WinUI 3) نیز استفاده شود.  

MAUI تکامل‌یافته‌ی Xamarin است و این امکان را می‌دهد که با استفاده از یک پروژه‌ی واحد، چندین پلتفرم را هدف قرار دهید.

</div>

---

## توضیحات تکمیلی و نکات ارائه
<div dir="rtl">

### هدف اصلی MAUI:
- تمرکز روی توسعه‌ی Cross-Platform Mobile Apps (iOS و Android)  
- پشتیبانی از دسکتاپ هم به‌عنوان مزیت اضافه  

### ارتباط با Xamarin:
- MAUI نسخه‌ی جدید و پیشرفته‌ی Xamarin.Forms  
- مایکروسافت MAUI را جایگزین Xamarin کرده → توسعه‌ی یکپارچه‌تر و مدرن‌تر  

### یک پروژه برای چند پلتفرم:
- یک پروژه به‌جای چند پروژه جدا برای iOS, Android, Desktop  
- مدیریت و نگهداری ساده‌تر  
- امکان اشتراک کدهای UI و logic  

### پلتفرم‌های پشتیبانی‌شده:
- موبایل: iOS, Android  
- دسکتاپ: Windows (با WinUI 3) و macOS (با Mac Catalyst)  

👉 جمع‌بندی: “MAUI تکامل‌یافته‌ی Xamarin هست و اجازه میده با یک پروژه برای موبایل (iOS, Android) و دسکتاپ (Windows, macOS) اپ ساخت.”

</div>

---

# Avalonia

<div dir="ltr">

For cross-platform desktop applications, a third-party library called Avalonia offers an alternative to MAUI. Avalonia also runs on Linux and is architecturally simpler than MAUI (as it operates without the Catalyst/WinUI indirection layer). Avalonia has an API similar to WPF, and it also offers a commercial add-on called XPF that provides almost complete WPF compatibility.

</div>

---

## ترجمه پاراگراف
<div dir="rtl">

برای اپلیکیشن‌های دسکتاپ چندسکویی (cross-platform) یک کتابخانه‌ی شخص ثالث به نام Avalonia جایگزینی برای MAUI ارائه می‌دهد.  

Avalonia روی Linux هم اجرا می‌شود و از نظر معماری ساده‌تر از MAUI است (چون بدون لایه‌های واسط Catalyst/WinUI کار می‌کند).  

Avalonia یک API شبیه به WPF دارد و همچنین یک افزودنی تجاری به نام XPF ارائه می‌دهد که تقریباً سازگاری کامل با WPF را فراهم می‌کند.

</div>

---

## توضیحات تکمیلی و نکات ارائه
<div dir="rtl">

### Avalonia به‌عنوان جایگزین MAUI:
- تمرکز روی Desktop Cross-Platform (ویندوز، مک، لینوکس)  
- مزیت اصلی: پشتیبانی از Linux که MAUI به‌طور رسمی نداره  

### مزیت‌های Avalonia:
- سادگی معماری → بدون نیاز به واسطه‌های WinUI یا Catalyst  
- شباهت API به WPF → یادگیری راحت برای توسعه‌دهندگان ویندوزی  
- XPF → افزونه‌ی تجاری برای سازگاری کامل با WPF  

👉 جمع‌بندی: “Avalonia گزینه‌ی قوی برای اپ دسکتاپ چندسکویی‌ه، با پشتیبانی از لینوکس، معماری ساده‌تر و API مشابه WPF.”

</div>

---

# .NET Framework

<div dir="ltr">

.NET Framework is Microsoft’s original Windows-only runtime for writing web and rich-client applications that run (only) on Windows desktop/server. No major new releases are planned, although Microsoft will continue to support and maintain the current 4.8 release due to the wealth of existing applications. With the .NET Framework, the CLR/BCL is integrated with the application layer. Applications written in .NET Framework can be recompiled under .NET 8, although they usually require some modification. Some features of .NET Framework are not present in .NET 8 (and vice versa). .NET Framework is preinstalled with Windows and is automatically patched via Windows Update. When you target .NET Framework 4.8, you can use the features of C# 7.3 and earlier. (You can override this by specifying a newer language version in the project file—this unlocks all of the latest language features except for those that require support from a newer runtime.)

</div>

---

## ترجمه پاراگراف
<div dir="rtl">

.NET Framework اولین Runtime اختصاصی ویندوز از مایکروسافت است که برای نوشتن اپلیکیشن‌های وب و دسکتاپ (rich-client) طراحی شده و فقط روی ویندوز اجرا می‌شود.  

هیچ نسخه‌ی اصلی جدیدی برای آن برنامه‌ریزی نشده، هرچند مایکروسافت همچنان از نسخه‌ی فعلی یعنی 4.8 پشتیبانی و نگهداری می‌کند به‌خاطر حجم زیاد اپلیکیشن‌های قدیمی.  

در .NET Framework، CLR و BCL با لایه‌ی اپلیکیشن یکپارچه‌اند.  

اپلیکیشن‌های نوشته‌شده با .NET Framework می‌توانند تحت .NET 8 دوباره کامپایل شوند، اما معمولاً نیاز به اصلاح دارند.  

.NET Framework به‌طور پیش‌فرض همراه ویندوز نصب است و از طریق Windows Update به‌روزرسانی می‌شود.  

وقتی پروژه‌ای را روی .NET Framework 4.8 هدف قرار دهید، می‌توانید از ویژگی‌های C# 7.3 و قبل‌تر استفاده کنید.  
(مگر اینکه نسخه‌ی زبان را در فایل پروژه بالاتر تنظیم کنید، که در این صورت ویژگی‌های جدید فعال می‌شوند به‌جز آن‌هایی که به Runtime جدیدتر نیاز دارند.)

</div>

---

# ابهام نام “.NET”

<div dir="ltr">

The word “.NET” has long been used as an umbrella term for any technology that includes the word “.NET” (.NET Framework, .NET Core, .NET Standard, and so on). This means that Microsoft’s renaming of .NET Core to .NET has created an unfortunate ambiguity. In this book, we’ll refer to the new .NET as .NET 5+ when an ambiguity arises. And to refer to .NET Core and its successors, we’ll use the phrase “.NET Core and .NET 5+.” To add to the confusion, .NET (5+) is a framework, yet it’s very different from the .NET Framework. Hence, we’ll use the term runtime in preference to framework, where possible.

</div>

---

## ترجمه پاراگراف
<div dir="rtl">

واژه‌ی ".NET" مدت‌ها به‌عنوان یک اصطلاح کلی برای هر فناوری‌ای که شامل ".NET" باشد استفاده شده است (مثل .NET Framework، .NET Core، .NET Standard و غیره).  

این تغییر نام .NET Core به .NET از طرف مایکروسافت باعث یک ابهام ناخوشایند شده است.  

در این کتاب هر جا ابهام پیش بیاید، به .NET جدید با عبارت ".NET 5+" اشاره می‌کنیم.  

و برای اشاره به .NET Core و جانشینان آن، از عبارت ".NET Core and .NET 5+" استفاده می‌کنیم.  

.NET (5+) یک Framework است اما تفاوت زیادی با .NET Framework دارد.  

به همین دلیل ما ترجیح می‌دهیم تا جای ممکن به‌جای واژه‌ی Framework از Runtime استفاده کنیم.

</div>
