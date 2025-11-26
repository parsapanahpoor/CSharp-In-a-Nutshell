namespace Chapter03_Classes;

public static class PrimaryConstructorsDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Primary Constructors (C# 12) ===\n");

        //var plugin = new Plugin("MyPlugin", "1.0.0");

        //Console.WriteLine(plugin.GetInfo());

        Console.WriteLine("\n💡 KEY POINT: Primary constructors reduce boilerplate (parameters are captured)");
    }

    // Primary constructor - parameters are available throughout the class
    //class Plugin(string name, string version)
    //{
    //    public string GetInfo() => $"{name} v{version}";

    //    public string FullName => $"{name}-{version}";
    //}
}
