# عملگرهای Checked/Unchecked و عملگرهای Bitwise

## 1. عملگر Checked برای بررسی سرریز (Overflow)

### نکات کلیدی برای ارائه:

**استفاده از checked در سطح Expression:**
```csharp
int a = 1000000;
int b = 1000000;
int c = checked (a * b); // فقط این عبارت چک می‌شود
```
- زمانی که `a * b` از حداکثر مقدار `int` تجاوز کند، `OverflowException` پرتاب می‌شود
- مقدار حاصل از $1000000 \times 1000000 = 10^{12}$ که از `int.MaxValue` ($2^{31}-1 \approx 2.1 \times 10^9$) بیشتر است

**استفاده از checked در سطح Statement Block:**

```csharp
checked 
{
// تمام عبارات داخل این بلوک چک می‌شوند
c = a * b;
// سایر عملیات‌ها...
}
```
### نکته مهم در ارائه:

⚠️ **بدون `checked`، سرریز به صورت خاموش اتفاق می‌افتد و نتیجه اشتباه برمی‌گردد (wraparound behavior)**

---

## 2. تنظیمات سطح Project

### نکات عملی:

- در Visual Studio: **Advanced Build Settings → Check for arithmetic overflow/underflow**
- وقتی این گزینه فعال باشد، **تمام** عملیات‌های ریاضی به صورت پیش‌فرض چک می‌شوند
- هزینه عملکرد (Performance): بررسی سرریز باعث کمی کاهش سرعت می‌شود

---

## 3. عملگر Unchecked

### کاربرد:

```csharp
int x = int.MaxValue;
int y = unchecked (x + 1); // خطا پرتاب نمی‌شود، نتیجه: int.MinValue
unchecked 
{
int z = x + 1; // همچنین بدون خطا
}
```
### نکته کلیدی:

- حتی اگر پروژه در حالت `checked` باشد، `unchecked` آن را override می‌کند
- مفید برای الگوریتم‌هایی که به wraparound نیاز دارند (مثلاً hash functions، checksums)

---

## 4. Constant Expressions و Compile-time Checking

### نکته بسیار مهم:

```csharp
int x = int.MaxValue + 1; // خطای کامپایل! (همیشه checked است)
int y = unchecked (int.MaxValue + 1); // OK، نتیجه: -2147483648
```
**تاکید در ارائه:**

- عبارات ثابت (constant expressions) که در زمان کامپایل ارزیابی می‌شوند **همیشه** checked هستند
- **استثنا:** استفاده صریح از `unchecked`
- این رفتار **مستقل** از تنظیمات پروژه است

---

## 5. عملگرهای Bitwise

### جدول عملگرها:

| عملگر | نام فارسی | مثال | نتیجه |
```csharp
|-------|----------|------|-------|
| `~` | مکمل (Complement) | `~0xfU` | `0xfffffff0U` |
| `&` | AND | `0xf0 & 0x33` | `0x30` |
| `\|` | OR | `0xf0 \| 0x33` | `0xf3` |
| `^` | XOR | `0xff00 ^ 0x0ff0` | `0xf0f0` |
| `<<` | Shift Left | `0x20 << 2` | `0x80` |
| `>>` | Shift Right | `0x20 >> 1` | `0x10` |
| `>>>` | Unsigned Shift Right | `int.MinValue >>> 1` | `0x40000000` |
```
### نکات فنی برای ارائه:

#### الف) عملگر Complement (~):

```csharp
uint a = 0xfU;        // 0000...00001111 (binary)
uint result = ~a;     // 1111...11110000 (binary)
```
- تمام بیت‌ها معکوس می‌شوند

#### ب) AND (&) - استفاده برای Masking:

```csharp
int flags = 0xf0;     // 11110000
int mask = 0x33;      // 00110011
int result = flags & mask;  // 00110000 = 0x30
```
#### ج) OR (|) - استفاده برای Set کردن بیت‌ها:

```csharp
int flags = 0xf0;     // 11110000
int newBits = 0x33;   // 00110011
int result = flags | newBits;  // 11110011 = 0xf3
```
#### د) XOR (^) - استفاده برای Toggle:

```csharp
int a = 0xff00;       // 1111111100000000
int b = 0x0ff0;       // 0000111111110000
int result = a ^ b;   // 1111000011110000 = 0xf0f0
```
---

## 6. تفاوت Shift Right (>> vs >>>)

### نکته کلیدی:

**Arithmetic Shift Right (>>):**

```csharp
int negative = -8;    // 11111111111111111111111111111000 (binary)
int result = negative >> 1;  // 11111111111111111111111111111100 = -4
```
// بیت علامت (sign bit) تکرار می‌شود

**Logical Shift Right (>>>):**

```csharp
int minValue = int.MinValue;  // 10000000000000000000000000000000
int result = minValue >>> 1;  // 01000000000000000000000000000000 = 0x40000000
```
// صفر جایگزین می‌شود (بدون توجه به علامت)

### جدول مقایسه:
```csharp
| مورد | `>>` | `>>>` |
|------|------|-------|
| نوع | Arithmetic | Logical |
| با اعداد مثبت | بیت 0 وارد می‌شود | بیت 0 وارد می‌شود |
| با اعداد منفی | بیت 1 وارد می‌شود (حفظ علامت) | بیت 0 وارد می‌شود |
| کاربرد | تقسیم بر $2^n$ | عملیات روی bit patterns |
```
---

## 7. کلاس BitOperations

### معرفی:

```csharp
using System.Numerics;

// مثال‌های کاربردی
int value = 0b10110100;
int leadingZeros = BitOperations.LeadingZeroCount(value);
int trailingZeros = BitOperations.TrailingZeroCount(value);
int popCount = BitOperations.PopCount(value); // تعداد بیت‌های 1
```
**نکته برای ارائه:**

- این کلاس در namespace `System.Numerics` است
- توابع بهینه‌شده برای عملیات‌های پیشرفته روی بیت‌ها
- جزئیات بیشتر در صفحه 340 کتاب

---

## سوالات متداول برای آمادگی

### Q1: چرا باید از checked استفاده کنیم؟

نکته » **A:** برای جلوگیری از باگ‌های خاموش (silent bugs) که در محاسبات مالی یا حساس به امنیت می‌تواند خطرناک باشد.

### Q2: آیا checked روی performance تاثیر دارد؟


نکته » **A:** بله، اما معمولاً ناچیز است. در کدهای performance-critical می‌توان از `unchecked` استفاده کرد.

### Q3: چه زمانی از >>> استفاده کنیم?

نکته »**A:** 

- وقتی می‌خواهیم عدد را به عنوان bit pattern بی‌علامت در نظر بگیریم
- در الگوریتم‌های رمزنگاری و hash functions
- عملیات روی رنگ‌ها (Color manipulation)

---

## مثال عملی برای کلاس

```csharp
// مثال ترکیبی: استفاده از checked و bitwise
class BitwiseDemo
{
static void Main()
{
// 1. نمایش تفاوت >> و >>>
int negative = -16;
Console.WriteLine($">> : {negative >> 2}");   // -4
Console.WriteLine($">>> : {negative >>> 2}");  // 1073741820

// 2. استفاده از checked برای امنیت
checked
{
byte color1 = 200;
byte color2 = 100;
// byte result = color1 + color2; // خطا! سرریز
}

// 3. Bitwise برای کار با flags
const int Read = 1;    // 001
const int Write = 2;   // 010
const int Execute = 4; // 100

int permissions = Read | Write;  // 011
bool canWrite = (permissions & Write) != 0; // true
permissions ^= Write;  // Toggle write: 001
}
}
```
---

## خلاصه 

1. ✅ **Checked/Unchecked**: کنترل رفتار سرریز
2. ✅ **Constant expressions**: همیشه checked (مگر با unchecked صریح)
3. ✅ **Bitwise operators**: 7 عملگر اصلی برای کار با بیت‌ها
4. ✅ **>> vs >>>**: تفاوت در نحوه shift با اعداد منفی
5. ✅ **BitOperations**: توابع پیشرفته در `System.Numerics`
