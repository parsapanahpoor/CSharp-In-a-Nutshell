## Numeric Types
C# has the predefined numeric types shown in Table 2-1.
Table 2-1. Predefined numeric types in C#
C# type System type Suffix Size Range
Integral—signed
sbyte SByte 8 bits –27
 to 27–1
short Int16 16 bits –215 to 215–1
int Int32 32 bits –231 to 231–1
long Int64 L 64 bits –263 to 263–1
nint IntPtr 32/64 bits
Integral—unsigned
byte Byte 8 bits 0 to 28–1
ushort UInt16 16 bits 0 to 216–1
uint UInt32 U 32 bits 0 to 232–1
ulong UInt64 UL 64 bits 0 to 264–1
nuint UIntPtr 32/64 bits
Real
float Single F 32 bits ± (~10–45 to 1038)
double Double D 64 bits ± (~10–324 to 10308)
decimal Decimal M 128 bits ± (~10–28 to 1028)
Of the integral types, int and long are first-class citizens and are favored by both C#
and the runtime. The other integral types are typically used for interoperability or
when space efficiency is paramount. The nint and nuint native-sized integer types
are most useful when working with pointers, so we will describe these in a later
chapter (see “Native-Sized Integers” on page 266).

Of the real number types, float and double are called floating-point types2
and
are typically used for scientific and graphical calculations. The decimal type is
typically used for financial calculations, for which base-10-accurate arithmetic and
high precision are required.


.NET supplements this list with several specialized numeric
types, including Int128 and UInt128 for signed and unsigned
128-bit integers, BigInteger for arbitrarily large integers, and
Half for 16-bit floating point numbers. Half is intended
mainly for interoperating with graphics card processors and
does not have native support in most CPUs, making float
and double better choices for general use.

---------------------------------------------------------------------------------------


### Numeric Types

سی شارپ دارای typeهای عددی از پیش تعریف شده‌ای است که در جدول 2-1 نشان داده شده‌اند.

**جدول 2-1. typeهای عددی از پیش تعریف شده در C#**

| C# type | System type | Suffix | Size | Range |
|---------|-------------|--------|------|-------|
| **Integral—signed** |
| sbyte | SByte | | 8 bits | $-2^7$ تا $2^7-1$ |
| short | Int16 | | 16 bits | $-2^{15}$ تا $2^{15}-1$ |
| int | Int32 | | 32 bits | $-2^{31}$ تا $2^{31}-1$ |
| long | Int64 | L | 64 bits | $-2^{63}$ تا $2^{63}-1$ |
| nint | IntPtr | | 32/64 bits | |
| **Integral—unsigned** |
| byte | Byte | | 8 bits | 0 تا $2^8-1$ |
| ushort | UInt16 | | 16 bits | 0 تا $2^{16}-1$ |
| uint | UInt32 | U | 32 bits | 0 تا $2^{32}-1$ |
| ulong | UInt64 | UL | 64 bits | 0 تا $2^{64}-1$ |
| nuint | UIntPtr | | 32/64 bits | |
| **Real** |
| float | Single | F | 32 bits | $\pm$ (~$10^{-45}$ تا $10^{38}$) |
| double | Double | D | 64 bits | $\pm$ (~$10^{-324}$ تا $10^{308}$) |
| decimal | Decimal | M | 128 bits | $\pm$ (~$10^{-28}$ تا $10^{28}$) |

از بین typeهای integral، `int` و `long` شهروندان درجه یک هستند و هم توسط C# و هم توسط runtime مورد علاقه قرار می‌گیرند. سایر typeهای integral معمولاً برای interoperability یا زمانی که کارایی فضا از اهمیت بالایی برخوردار است، استفاده می‌شوند. typeهای اعداد صحیح با اندازه بومی (native-sized integer) به نام‌های `nint` و `nuint` زمانی که با pointerها کار می‌کنید بیشترین فایده را دارند، بنابراین آن‌ها را در فصل بعدی توضیح خواهیم داد (به بخش "Native-Sized Integers" در صفحه 266 مراجعه کنید).

---------------------------------------------------------------------------------------


از بین typeهای اعداد حقیقی، `float` و `double` به عنوان floating-point types شناخته می‌شوند و معمولاً برای محاسبات علمی و گرافیکی استفاده می‌شوند. type به نام `decimal` معمولاً برای محاسبات مالی استفاده می‌شود که در آن‌ها به محاسبات دقیق مبنای 10 (base-10-accurate arithmetic) و دقت بالا نیاز است.
---------------------------------------------------------------------------------------

دات نت.NET این لیست را با چندین type عددی تخصصی تکمیل می‌کند، از جمله `Int128` و `UInt128` برای اعداد صحیح علامت‌دار و بدون علامت 128 بیتی، `BigInteger` برای اعداد صحیح با اندازه دلخواه بزرگ، و `Half` برای اعداد floating-point با 16 بیت. `Half` عمدتاً برای تعامل با پردازنده‌های کارت گرافیک در نظر گرفته شده است و پشتیبانی بومی (native) در اکثر CPUها ندارد، که این امر `float` و `double` را به گزینه‌های بهتری برای استفاده عمومی تبدیل می‌کند.
