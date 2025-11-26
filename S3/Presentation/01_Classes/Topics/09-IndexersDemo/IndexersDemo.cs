// 10_IndexersDemo.cs
using System;

namespace Chapter03_Classes
{
    public static class IndexersDemo
    {
        public static void Run()
        {
            Console.WriteLine("=== Indexers: Custom Collection Access ===\n");

            var config = new Configuration();

            config["MaxSize"] = "100";
            config["Timeout"] = "30";

            Console.WriteLine($"MaxSize: {config["MaxSize"]}");
            Console.WriteLine($"Timeout: {config["Timeout"]}");

            Console.WriteLine("\n💡 KEY POINT: Indexers provide array-like syntax for custom types");
        }

        class Configuration
        {
            private System.Collections.Generic.Dictionary<string, string> _settings = new();

            public string this[string key]
            {
                get => _settings.TryGetValue(key, out var value) ? value : null;
                set => _settings[key] = value;
            }
        }
    }
}
