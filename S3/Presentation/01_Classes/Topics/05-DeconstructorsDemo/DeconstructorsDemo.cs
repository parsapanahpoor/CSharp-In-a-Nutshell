namespace Chapter03_Classes;

public static class DeconstructorsDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Deconstructors: Tuple-like Deconstruction ===\n");

        var plugin = new Plugin("MyPlugin", "1.0.0");

        var (name, version) = plugin; // Deconstruction

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Version: {version}");

        Console.WriteLine("\n💡 KEY POINT: Deconstruct method enables tuple-like syntax");
    }

    class Plugin
    {
        public string Name { get; }
        public string Version { get; }

        public Plugin(string name, string version)
        {
            Name = name;
            Version = version;
        }

        public void Deconstruct(out string name, out string version)
        {
            name = Name;
            version = Version;
        }
    }
}
