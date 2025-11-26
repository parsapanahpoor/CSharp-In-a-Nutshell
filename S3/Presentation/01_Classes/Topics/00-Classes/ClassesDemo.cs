namespace Chapter03_Classes;

public static class ClassesDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Classes: Reference Types ===\n");

        var p1 = new Plugin { Name = "Plugin1" };
        var p2 = p1; // Reference copy
        p2.Name = "Plugin2";

        Console.WriteLine($"p1.Name: {p1.Name}"); // Plugin2
        Console.WriteLine($"p2.Name: {p2.Name}"); // Plugin2

        Console.WriteLine("\n KEY POINT: Classes are reference types - assignment copies the reference, not the object");
    }

    class Plugin
    {
        public string Name { get; set; }
    }
}


