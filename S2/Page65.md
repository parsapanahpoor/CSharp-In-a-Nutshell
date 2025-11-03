## Multidimensional Arrays
Multidimensional arrays come in two varieties: rectangular and jagged. Rectangular arrays represent
an n-dimensional block of memory, and jagged arrays are arrays of arrays

## Rectangular arrays
Rectangular arrays are declared using commas to separate each dimension. e following declares a
rectangular two-dimensional array for which the dimensions are 3 by 3:
int[,] matrix = new int[3,3];
e GetLength method of an array returns the length for a given dimension (starting at 0):
for (int i = 0; i < matrix.GetLength(0); i++)
for (int j = 0; j < matrix.GetLength(1); j++)
matrix[i,j] = i * 3 + j;
You can initialize a rectangular array with explicit values. e following code creates an array
identical to the previous example:
int[,] matrix = new int[,]
{
{0,1,2},
{3,4,5},
{6,7,8}
};

## Jagged arrays
Jagged arrays are declared using successive square brackets to represent each dimension. Here is an
example of declaring a jagged two-dimensional array for which the outermost dimension is 3:
int[][] matrix = new int[3][];

## NOTE
Interestingly, this is new int[3][] and not new int[][3]. Eric Lippert has written an excellent article on why this
is so.

## Note 
e inner dimensions aren’t specified in the declaration because, unlike a rectangular array, each
inner array can be an arbitrary length. Each inner array is implicitly initialized to null rather than an
empty array. You must manually create each inner array:
for (int i = 0; i < matrix.Length; i++)
{
matrix[i] = new int[3]; // Create inner array
for (int j = 0; j < matrix[i].Length; j++)
matrix[i][j] = i * 3 + j;
}
66
You can initialize a jagged array with explicit values. e following code creates an array identical to
the previous example with an additional element at the end:
int[][] matrix = new int[][]
{
new int[] {0,1,2},
new int[] {3,4,5},
new int[] {6,7,8,9}
};


## آرایه‌های چندبعدی

آرایه‌های چندبعدی در دو نوع ارائه می‌شوند: مستطیلی (rectangular) و دندانه‌دار (jagged). آرایه‌های مستطیلی یک بلوک n-بعدی از حافظه را نمایش می‌دهند، و آرایه‌های دندانه‌دار، آرایه‌هایی از آرایه‌ها هستند.

## آرایه‌های مستطیلی

آرایه‌های مستطیلی با استفاده از کاما برای جداسازی هر بعد declare می‌شوند. کد زیر یک آرایه دوبعدی مستطیلی را declare می‌کند که ابعاد آن 3 در 3 است:
```csharp
int[,] matrix = new int[3,3];
```
متد `GetLength` یک آرایه، طول را برای یک بعد مشخص (شروع از 0) برمی‌گرداند:

```csharp
for (int i = 0; i < matrix.GetLength(0); i++)
for (int j = 0; j < matrix.GetLength(1); j++)
matrix[i,j] = i * 3 + j;
```
می‌توانید یک آرایه مستطیلی را با مقادیر صریح مقداردهی اولیه کنید. کد زیر آرایه‌ای یکسان با مثال قبلی ایجاد می‌کند:

```csharp
int[,] matrix = new int[,]
{
{0,1,2},
{3,4,5},
{6,7,8}
};
```
## آرایه‌های دندانه‌دار

آرایه‌های دندانه‌دار با استفاده از براکت‌های مربعی پشت سر هم برای نمایش هر بعد declare می‌شوند. در اینجا مثالی از declare کردن یک آرایه دوبعدی دندانه‌دار است که بیرونی‌ترین بعد آن 3 است:

```csharp
int[][] matrix = new int[3][];
```
## نکته
جالب توجه است که این `new int[3][]` است و نه `new int[][3]`. Eric Lippert مقاله عالی‌ای در مورد دلیل این موضوع نوشته است.

## توجه
ابعاد داخلی در declaration مشخص نمی‌شوند زیرا، برخلاف یک آرایه مستطیلی، هر آرایه داخلی می‌تواند طول دلخواهی داشته باشد. هر آرایه داخلی به صورت ضمنی به `null` مقداردهی اولیه می‌شود نه یک آرایه خالی. باید هر آرایه داخلی را به صورت دستی ایجاد کنید:

```csharp
for (int i = 0; i < matrix.Length; i++)
{
matrix[i] = new int[3]; // ایجاد آرایه داخلی
for (int j = 0; j < matrix[i].Length; j++)
matrix[i][j] = i * 3 + j;
}
```
می‌توانید یک آرایه دندانه‌دار را با مقادیر صریح مقداردهی اولیه کنید. کد زیر آرایه‌ای یکسان با مثال قبلی با یک element اضافی در انتها ایجاد می‌کند:

```csharp
int[][] matrix = new int[][]
{
new int[] {0,1,2},
new int[] {3,4,5},
new int[] {6,7,8,9}
};
```

**خلاصه نکات مهم:**

 ترجمه => 178. **Multidimensional arrays:** دو نوع آرایه چندبعدی وجود دارد: مستطیلی (rectangular) و دندانه‌دار (jagged).

ترجمه => 179. **Rectangular arrays definition:** آرایه‌های مستطیلی یک بلوک n-بعدی از حافظه را نمایش می‌دهند و با کاما بین ابعاد declare می‌شوند (مثل `int[,]`).

ترجمه => 180. **Rectangular array declaration:** برای یک آرایه دوبعدی 3×3: `int[,] matrix = new int[3,3];`

ترجمه => 181. **GetLength method:** متد `GetLength(dimension)` طول یک بعد مشخص را برمی‌گرداند (شروع از index 0).

ترجمه => 182. **Rectangular array initialization:** امکان مقداردهی اولیه با مقادیر صریح با استفاده از براکت‌های تو در تو.

ترجمه => 183. **Jagged arrays definition:** آرایه‌های دندانه‌دار، آرایه‌هایی از آرایه‌ها هستند و با براکت‌های مربعی پشت سر هم declare می‌شوند (مثل `int[][]`).

ترجمه => 184. **Jagged array syntax:** declaration به صورت `new int[3][]` است نه `new int[][3]`.

ترجمه => 185. **Inner dimensions flexibility:** در آرایه‌های دندانه‌دار، ابعاد داخلی در declaration مشخص نمی‌شوند زیرا هر آرایه داخلی می‌تواند طول متفاوتی داشته باشد.

ترجمه => 186. **Inner array initialization:** آرایه‌های داخلی به صورت ضمنی `null` هستند (نه آرایه خالی) و باید به صورت دستی ایجاد شوند.

ترجمه => 187. **Manual creation requirement:** نیاز به حلقه برای ایجاد دستی هر آرایه داخلی در آرایه‌های دندانه‌دار.

ترجمه => 188. **Jagged array explicit initialization:** امکان مقداردهی اولیه صریح با طول‌های متفاوت برای هر آرایه داخلی.

آماده دریافت بخش بعدی هستم.
