namespace Chapter03_Classes;

public static class StaticClassesDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Static Classes: Utility Methods ===\n");

        Console.WriteLine(StringHelper.ToTitleCase("hello world"));
        Console.WriteLine(MathHelper.Square(5));

        Console.WriteLine("\n💡 KEY POINT: Static classes cannot be instantiated or inherited (sealed + abstract)");
    }

    static class StringHelper
    {
        public static string ToTitleCase(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            return char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }
    }

    static class MathHelper
    {
        public static int Square(int x) => x * x;
    }
}
