namespace Chapter03_Classes;

public static class StaticConstructorsDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Static Constructors: Lazy Initialization ===\n");

        Console.WriteLine("First access:");
        Console.WriteLine(Cache.Get("key1"));

        Console.WriteLine("\nSecond access:");
        Console.WriteLine(Cache.Get("key2"));

        Console.WriteLine("\n💡 KEY POINT: Static constructor runs once before first access (thread-safe)");
    }

    class Cache
    {
        private static System.Collections.Generic.Dictionary<string, string> _cache;

        static Cache()
        {
            Console.WriteLine("-> Static constructor called (happens only once)");
            _cache = new();
            _cache["key1"] = "value1";
        }

        public static string Get(string key) => _cache.TryGetValue(key, out var value) ? value : "Not found";
    }
}
