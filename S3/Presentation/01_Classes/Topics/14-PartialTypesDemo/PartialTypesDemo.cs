namespace Chapter03_Classes;

public static class PartialTypesDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Partial Types: Code Generation ===\n");

        var plugin = new Plugin();
        plugin.CoreMethod();
        plugin.GeneratedMethod();

        Console.WriteLine("\n💡 KEY POINT: Partial classes split implementation across files (useful for code generation)");
    }

    // Manual code
    partial class Plugin
    {
        public void CoreMethod() => Console.WriteLine("Core logic");
    }

    // Generated code (simulated)
    partial class Plugin
    {
        public void GeneratedMethod() => Console.WriteLine("Generated logic");
    }
}
