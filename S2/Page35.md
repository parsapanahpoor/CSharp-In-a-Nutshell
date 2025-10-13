If you really want to use an identifier that clashes with a reserved keyword, you can
 do so by qualifying it with the @ prefix. For instance:
 int using = 123;      // Illegal
 int @using = 123;     // Legal
 The @ symbol doesn’t form part of the identifier itself. So, @myVariable is the same
 as myVariable.
 Contextual keywords
 Some keywords are contextual, meaning that you also can use them as identifiers—
 without an @ symbol:

 With contextual keywords, ambiguity cannot arise within the context in which they
 are used. 

 اگر واقعاً می‌خواهید از یک identifier استفاده کنید که با یک keyword رزرو شده تضاد دارد، می‌توانید با قرار دادن پیشوند @ انجام دهید. برای مثال:
```csharp
int using = 123;      // غیر قانونی
int @using = 123;     // قانونی
```
نماد @ بخشی از خود identifier نیست. بنابراین، `@myVariable` با `myVariable` یکسان است.

## Contextual Keywords

برخی از keyword‌ها contextual هستند، به این معنی که می‌توانید از آن‌ها به عنوان identifier نیز استفاده کنید—بدون نماد @:


add          alias        and          ascending    async
await        by           descending   dynamic      equals
file         from         get          global       group
init         into         join         let          managed
nameof       nint         not          notnull      nuint
on           or           orderby      partial      remove
required     select       set          unmanaged    value
var          with         when         where        yield

با contextual keywords، هیچ ابهامی در زمینهٔ استفاده از آن‌ها بوجود نمی‌آید.

## Literals, Punctuators, and Operators
 Literals are primitive pieces of data lexically embedded into the program. The
 literals we used in our example program are 12 and 30.
 Punctuators help demarcate the structure of the program. An example is the semi
colon, which terminates a statement. Statements can wrap multiple lines:
 Console.WriteLine
  (1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10);
 An operator transforms and combines expressions. Most operators in C# are deno
ted with a symbol, such as the multiplication operator, *. We discuss operators in
 more detail later in this chapter. These are the operators we used in our example
 program:
 =  *  .  ()
 A period denotes a member of something (or a decimal point with numeric literals).
 Parentheses are used when declaring or calling a method; empty parentheses are
 used when the method accepts no arguments. (Parentheses also have other purposes
 that you’ll see later in this chapter.) An equals sign performs assignment. (The
 double equals sign, ==, performs equality comparison, as you’ll see later.)

## Literals، Punctuators و Operators

مقادیر ثابت (Literals) قطعات ابتدایی از داده هستند که به صورت لغوی در برنامه جاسازی شده‌اند. مقادیر ثابتی که در برنامهٔ نمونهٔ ما استفاده کردیم 12 و 30 هستند.

علائم نگارشی (Punctuators) به مشخص کردن ساختار برنامه کمک می‌کنند. یک مثال semicolon است که یک statement را خاتمه می‌دهد. عبارت‌ها (Statements) می‌توانند در چندین خط قرار بگیرند:
```csharp
Console.WriteLine
 (1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10);

یک عملگر (Operator) عبارات را تبدیل و ترکیب می‌کند. اکثر عملگرها در C# با یک نماد نشان داده می‌شوند، مانند عملگر ضرب، `*`. ما عملگرها را با جزئیات بیشتر در ادامهٔ این فصل بحث می‌کنیم. این‌ها عملگرهایی هستند که در برنامهٔ نمونهٔ ما استفاده کردیم:


=  *  .  ()

یک نقطه (period) نشان‌دهندهٔ یک عضو (member) از چیزی است (یا یک نقطهٔ اعشاری با literal‌های عددی). پرانتزها (Parentheses) هنگام تعریف یا فراخوانی یک method استفاده می‌شوند؛ پرانتزهای خالی زمانی استفاده می‌شوند که method هیچ argument قبول نمی‌کند. (پرانتزها همچنین اهداف دیگری دارند که بعداً در این فصل خواهید دید.) علامت مساوی (equals sign) عمل انتساب (assignment) را انجام می‌دهد. (علامت مساوی دوتایی، `==`، مقایسهٔ برابری را انجام می‌دهد، همان‌طور که بعداً خواهید دید.)

