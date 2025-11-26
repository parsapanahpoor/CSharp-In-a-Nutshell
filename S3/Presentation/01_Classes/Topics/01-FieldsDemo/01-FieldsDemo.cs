// 01_FieldsDemo.cs
using System.Runtime.InteropServices;

namespace Chapter03_Classes
{
    public static class FieldsDemo
    {
        public static void Run()
        {
            Console.WriteLine("=== Fields: Memory Layout Matters ===\n");

            Console.WriteLine($"BadLayout:  {Marshal.SizeOf<BadLayout>()} bytes");
            Console.WriteLine($"GoodLayout: {Marshal.SizeOf<GoodLayout>()} bytes");

            Console.WriteLine("\n KEY POINT: Order fields by size (largest first) to minimize padding - just in structs ");
        }

        [StructLayout(LayoutKind.Sequential)]
        struct BadLayout
        {
            public byte b1;   // 1 + 7 padding
            public long l1;   // 8
            public byte b2;   // 1 + 7 padding
        }

        [StructLayout(LayoutKind.Sequential)]
        struct GoodLayout
        {
            public long l1;   // 8
            public byte b1;   // 1
            public byte b2;   // 1 + 6 padding
        }
    }
}
