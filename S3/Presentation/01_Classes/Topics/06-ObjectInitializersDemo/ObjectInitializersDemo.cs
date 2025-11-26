namespace Chapter03_Classes;

public static class ObjectInitializersDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Object Initializers: Syntactic Sugar ===\n");

        // Object initializer
        var plugin = new Plugin
        {
            Name = "MyPlugin",
            Version = "1.0.0"
        };

        Console.WriteLine($"{plugin.Name} v{plugin.Version}");

        Console.WriteLine("\n💡 KEY POINT: Object initializers call the parameterless constructor first, then set properties");
    }

    class Plugin
    {
        public string Name { get; set; }
        public string Version { get; set; }
    }
}
