## رویکرد استاندارد
MyProject/

├── Program.cs // Top-level statements

└── UnitConverter.cs // Class definition

فایل UnitConverter.cs:


```csharp
public class UnitConverter
{
    int ratio;
    public UnitConverter(int unitRatio) { ratio = unitRatio; }
    public int Convert(int unit) { return unit * ratio; }
}
```

فایل Program.cs:


```csharp
UnitConverter converter = new UnitConverter(12);
Console.WriteLine(converter.Convert(30));  // 360
```

## Instantiation (نمونه‌سازی) - مقایسه دقیق
Predefined Types

```csharp
// با Literal
int x = 12;
string s = "Hello world";
bool b = true;
double d = 3.14;
```
// بدون نیاز به new
Custom Types

```csharp
// با عملگر new
UnitConverter converter = new UnitConverter(12);
DateTime now = new DateTime(2025, 10, 15);
```
// همیشه نیاز به new
استثنا: string

```csharp
// string هم Predefined است هم Reference Type
string s1 = "Hello";              // Literal
string s2 = new string('A', 5);   // با new → "AAAAA"
```



## ویژگی‌های Constructor
- بدون Return Type
- فراخوانی خودکار


 ## Instance vs Static Members - تحلیل عمیق
Instance Members (پیش‌فرض)

```csharp

public class Panda
{
    public string Name;  // Instance field
    
    public void Eat()    // Instance method
    {
        Console.WriteLine($"{Name} is eating");
    }
}

// استفاده
Panda p1 = new Panda();
p1.Name = "Pan Dee";
p1.Eat();  // "Pan Dee is eating"
```
قانون: Instance members به شی خاص تعلق دارند.

Static Members

```csharp

public class Panda
{
    public static int Population;  // Static field
    
    public static void ShowPopulation()  // Static method
    {
        Console.WriteLine($"Total pandas: {Population}");
    }
}

// استفاده
Panda.Population = 100;
Panda.ShowPopulation();  // "Total pandas: 100"
```

قانون: Static members به Type تعلق دارند، نه شی خاص.



## خطاهای Compile-Time رایج
خطای 1: دسترسی Static از طریق Instance:
error CS0176: Member ‘Panda.Population’ cannot be accessed

with an instance reference; qualify it with a type name instead



خطای 2: دسترسی Instance از طریق Type
```csharp

Console.WriteLine(Panda.Name);  // ❌ خطا!
```

error CS0120: An object reference is required for the

non-static field, method, or property ‘Panda.Name’

خطای 3: استفاده از Instance member در Static context

```csharp

public class Panda
{
    public string Name;
    
    public static void PrintName()
    {
        Console.WriteLine(Name);  // ❌ خطا!
    }
}

```
راه‌حل:


```csharp
public static void PrintName(Panda panda)
{
    Console.WriteLine(panda.Name);  
}

```

## Static Class
تعریف

```csharp

public static class Console
{
    public static void WriteLine(string value) { ... }
    public static void Write(string value) { ... }
    // همه members باید static باشند
}
```
ویژگی‌های Static Class

```csharp

// ✅ فراخوانی مستقیم
Console.WriteLine("Hello");

// ❌ نمی‌توان نمونه‌سازی کرد
Console c = new Console();  // خطا!
```

خطا:

error CS0712: Cannot create an instance of the static class ‘Console’


## چه زمانی از Static استفاده کنیم؟
Static مناسب است برای:

```csharp

// 1. Utility Methods
public static class StringHelper
{
    public static bool IsNullOrEmpty(string value)
    {
        return string.IsNullOrEmpty(value);
    }
}

// 2. Shared State
public class GameSession
{
    public static int TotalPlayers;
    public static DateTime StartTime;
}

// 3. Constants
public static class Constants
{
    public const double PI = 3.14159;
    public const int MaxUsers = 100;
}

// 4. Factory Methods
public static class FileLogger
{
    public static Logger Create(string path)
    {
        return new Logger(path);
    }
}
```

## Instance مناسب است برای:

```csharp

// 1. Object-specific data
public class Person
{
    public string Name;    // هر شخص نام خاص خود را دارد
    public int Age;
}

// 2. Behaviors dependent on object state
public class Car
{
    public int Speed;
    
    public void Accelerate()
    {
        Speed += 10;  // وابسته به حالت شی
    }
}
```


## مثال پیشرفته: ترکیب Instance و Static

```csharp

public class Employee
{
    // Instance fields
    public string Name;
    public decimal Salary;
    
    // Static fields
    public static int TotalEmployees;
    public static decimal TotalSalaryExpense;
    
    // Constructor
    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
        
        // به‌روزرسانی static data
        TotalEmployees++;
        TotalSalaryExpense += salary;
    }
    
    // Instance method
    public void GiveRaise(decimal amount)
    {
        Salary += amount;
        TotalSalaryExpense += amount;  // به‌روزرسانی static
    }
    
    // Static method
    public static decimal GetAverageSalary()
    {
        if (TotalEmployees == 0) return 0;
        return TotalSalaryExpense / TotalEmployees;
    }
}

// استفاده
Employee emp1 = new Employee("Ali", 5000);
Employee emp2 = new Employee("Sara", 6000);

emp1.GiveRaise(1000);

Console.WriteLine($"Total Employees: {Employee.TotalEmployees}");        // 2
Console.WriteLine($"Average Salary: {Employee.GetAverageSalary()}");    // 6000
Console.WriteLine($"Ali's Salary: {emp1.Salary}");                      // 6000

```

## Static Class

```csharp

// فقط Static members
// نمی‌توان instantiate کرد
public static class Console { ... }
```


