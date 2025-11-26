namespace Chapter03_Classes;

public static class PropertiesDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Properties: Expression-Bodied Members (C# 6+) ===\n");

        var plugin = new Plugin("MyPlugin");

        Console.WriteLine($"Display Name: {plugin.DisplayName}");

        plugin.IsActive = false;
        Console.WriteLine($"Status: {plugin.Status}");

        Console.WriteLine("\n💡 KEY POINT: Use expression-bodied properties for computed values");
    }

    class Plugin
    {
        public string Name { get; }
        public bool IsActive { get; set; } = true;

        // Expression-bodied property
        public string DisplayName => $"[Plugin] {Name}";

        // Read-only property with logic
        public string Status => IsActive ? "Active" : "Inactive";

        public Plugin(string name) => Name = name;
    }
}
