## مفهوم Encapsulation (کپسوله‌سازی)
کپسوله‌سازی یعنی پنهان‌سازی جزئیات پیاده‌سازی داخلی و نمایش فقط رابط عمومی.

نقش Access Modifiers در Encapsulation : 
```csharp
public class BankAccount
{
    // ===== Public Interface (رابط عمومی) =====
    public string AccountNumber;
    
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            _balance += amount;
            LogTransaction("Deposit", amount);  // استفاده از جزئیات خصوصی
        }
    }
    
    public decimal GetBalance()
    {
        return _balance;
    }
    
    // ===== Private Implementation (جزئیات خصوصی) =====
    private decimal _balance;  // داده‌های حساس
    
    private void LogTransaction(string type, decimal amount)
    {
        // منطق لاگ‌گذاری داخلی
    }
}
```

## چرا Encapsulation مهم است؟

// ❌ بدون Encapsulation
```csharp
public class BankAccount
{
    public decimal balance;  // مستقیماً قابل تغییر
}

BankAccount acc = new BankAccount();
acc.balance = -1000;  // 😱 موجودی منفی!


// ✅ با Encapsulation
public class BankAccount
{
    private decimal _balance;
    
    public void Deposit(decimal amount)
    {
        if (amount > 0)  // اعتبارسنجی
            _balance += amount;
    }
}

BankAccount acc = new BankAccount();
acc._balance = -1000;  // ❌ خطای Compile - دسترسی غیرمجاز
acc.Deposit(-1000);    // ✅ کار می‌کند اما مبلغ منفی رد می‌شود
```


 ## الگوهای رایج استفاده از Namespace
الگو 1: یک Namespace برای هر ماژول

```csharp
namespace MyCompany.Accounting
{
    public class Invoice { }
    public class Payment { }
}

namespace MyCompany.Inventory
{
    public class Product { }
    public class Stock { }
}
```
الگو 2: Nested Namespaces

```csharp
namespace MyCompany
{
    namespace DataAccess
    {
        namespace Repositories
        {
            public class UserRepository { }
        }
    }
}

// معادل:
namespace MyCompany.DataAccess.Repositories
{
    public class UserRepository { }
}

```

<img width="662" height="297" alt="image" src="https://github.com/user-attachments/assets/e5520764-dd03-4f57-8da1-83850cb92282" />
