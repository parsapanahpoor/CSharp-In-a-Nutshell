# Niche Runtimes

<div dir="ltr">

There are also the following niche runtimes:  

- **Unity** is a game development platform that allows game logic to be scripted with C#.  
- **Universal Windows Platform (UWP)** was designed for writing touch-first applications that run on Windows 10+ desktop and devices, including Xbox, Surface Hub, and HoloLens. UWP apps are sandboxed and ship via the Windows Store. UWP uses a version of the .NET Core 2.2 CLR/BCL, and it’s unlikely that this dependency will be updated; instead, Microsoft has recommended that users switch to its modern replacement, WinUI 3. But because WinUI 3 only supports Windows desktop, UWP still has a niche application for targeting Xbox, Surface Hub, and HoloLens.  
- **The .NET Micro Framework** is for running .NET code on highly resource constrained embedded devices (under one megabyte).  
- It’s also possible to run managed code within SQL Server. With SQL Server CLR integration, you can write custom functions, stored procedures, and aggregations in C# and then call them from SQL. This works in conjunction with .NET Framework and a special “hosted” CLR that enforces a sandbox to protect the integrity of the SQL Server process.

</div>

---

## ترجمه پاراگراف
<div dir="rtl">

همچنین Runtimeهای خاص زیر وجود دارند:  

- **Unity** یک پلتفرم توسعه‌ی بازی است که اجازه می‌دهد منطق بازی با C# نوشته شود.  

- **Universal Windows Platform (UWP)** برای نوشتن اپلیکیشن‌های touch-first طراحی شده که روی ویندوز 10+ و دستگاه‌هایی مثل Xbox، Surface Hub و HoloLens اجرا می‌شوند. اپلیکیشن‌های UWP در یک sandbox اجرا می‌شوند و از طریق Windows Store عرضه می‌گردند. UWP از نسخه‌ای از CLR/BCL مربوط به .NET Core 2.2 استفاده می‌کند و بعید است که این وابستگی به‌روزرسانی شود؛ به جای آن، مایکروسافت به کاربران توصیه کرده به جانشین مدرن‌تر یعنی WinUI 3 مهاجرت کنند. با این حال، از آنجا که WinUI 3 فقط از دسکتاپ ویندوز پشتیبانی می‌کند، UWP همچنان یک جایگاه خاص برای هدف‌گیری Xbox، Surface Hub و HoloLens دارد.  

- **.NET Micro Framework** برای اجرای کدهای .NET روی دستگاه‌های تعبیه‌شده (embedded devices) با منابع بسیار محدود (کمتر از یک مگابایت) ساخته شده است.  

- همچنین امکان اجرای کدهای مدیریت‌شده در داخل SQL Server هم وجود دارد. با **SQL Server CLR integration**، می‌توانید توابع سفارشی، stored procedureها و aggregationها را در C# بنویسید و سپس آن‌ها را از SQL فراخوانی کنید. این قابلیت با .NET Framework و یک CLR “میزبان‌شده (hosted)” کار می‌کند که sandbox خاصی برای محافظت از یکپارچگی فرآیند SQL Server دارد.

</div>

---

## توضیحات تکمیلی و نکات ارائه
<div dir="rtl">

### Unity:
- محبوب‌ترین موتور بازی‌سازی دنیا  
- از C# برای اسکریپت‌نویسی منطق بازی استفاده می‌کنه  
- نمونه کاربرد: ساخت بازی‌های 2D/3D، VR، AR  

### UWP (Universal Windows Platform):
- هدف: اپلیکیشن‌های مدرن لمسی روی ویندوز 10+ و دستگاه‌های خاص  
- محدودیت: sandbox → امنیت بیشتر، ولی دسترسی کمتر به منابع سیستم  
- آینده: مایکروسافت WinUI 3 رو جایگزین معرفی کرده، اما چون WinUI 3 فقط دسکتاپ رو ساپورت می‌کنه، UWP هنوز برای Xbox و HoloLens کاربرد داره  

### .NET Micro Framework:
- طراحی شده برای سخت‌افزارهای خیلی سبک (زیر 1MB)  
- کاربرد: دستگاه‌های اینترنت اشیا (IoT) و embedded systems  

### SQL Server CLR Integration:
- نوشتن logic درون دیتابیس با C#  
- مثال: توابع محاسباتی پیچیده، stored procedureها و aggregationها  
- CLR میزبان‌شده در SQL Server امنیت رو تضمین می‌کنه تا دیتابیس آسیب نبینه  

---

### جمع‌بندی ارائه برای این بخش
“علاوه بر Runtimeهای اصلی، چند Runtime خاص هم وجود دارن. Unity برای توسعه‌ی بازی با C#، UWP برای اپلیکیشن‌های ویندوزی لمسی و دستگاه‌های خاص، Micro Framework برای دستگاه‌های خیلی محدود، و حتی SQL Server CLR که اجازه میده کد C# رو مستقیم داخل دیتابیس اجرا کنیم. هرکدوم از این‌ها یک جایگاه خاص دارن که باعث میشه اکوسیستم .NET خیلی متنوع باشه.”

</div>
