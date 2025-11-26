namespace Chapter03_Classes;

public static class NameofOperatorDemo
{
    public static void Run()
    {
        Console.WriteLine("=== nameof Operator: Refactoring-Safe Strings ===\n");

        var plugin = new Plugin();

        try
        {
            plugin.SetName(null);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }

        Console.WriteLine("\n💡 KEY POINT: nameof is refactoring-safe (compiler-checked strings)");
    }

    class Plugin
    {
        public string Name { get; private set; }

        public void SetName(string name)
        {
            // Instead of: throw new ArgumentNullException("name")
            if (name == null)
                throw new ArgumentNullException(nameof(name)); // Refactoring-safe

            Name = name;
        }
    }
}
