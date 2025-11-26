namespace Chapter03_Classes;

public static class MethodsDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Methods: Ref Returns (C# 7) ===\n");

        var buffer = new Buffer();

        ref int element = ref buffer.GetElement(2);
        Console.WriteLine($"Before: {element}");

        element = 999; // Modifies the array directly
        Console.WriteLine($"After:  {buffer.GetElement(2)}");

        Console.WriteLine("\n💡 KEY POINT: ref returns allow direct modification without copying");
    }

    class Buffer
    {
        private int[] _data = { 1, 2, 3, 4, 5 };

        public ref int GetElement(int index) => ref _data[index];
    }
}
