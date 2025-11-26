
namespace Chapter03_Classes
{
    public static class ConstantsDemo
    {
        public static void Run()
        {
            Console.WriteLine("=== Constants: Compile-Time vs Runtime ===\n");

            Console.WriteLine($"const (compile-time): {Config.MaxSize}");
            Console.WriteLine($"readonly (runtime):   {Config.StartTime}");

            Console.WriteLine("\n KEY POINT:");
            Console.WriteLine("  - const: Inlined at compile-time (use for primitives)");
            Console.WriteLine("  - readonly: Evaluated at runtime (use for objects/DateTime)");
        }

        class Config
        {
            public const int MaxSize = 100;              // Compile-time constant
            public static readonly DateTime StartTime = DateTime.Now; // Runtime constant
        }
    }
}
