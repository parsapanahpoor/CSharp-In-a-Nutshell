namespace Chapter03_Classes;

public static class InstanceConstructorsDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Instance Constructors: Chaining ===\n");

        var plugin = new Plugin("MyPlugin");

        Console.WriteLine("\n💡 KEY POINT: Constructor chaining (this) reduces code duplication");
    }

    class Plugin
    {
        public string Name { get; }
        public string Version { get; }

        public Plugin(string name) : this(name, "1.0.0")
        {
            Console.WriteLine("-> Two-parameter constructor");
        }

        public Plugin(string name, string version)
        {
            Console.WriteLine("-> Main constructor");
            Name = name;
            Version = version;
        }
    }
}
