using _02_Inheritance.Chapters._04_AbstractClasses;
using _02_Inheritance.Chapters._08_ConstructorsAndInheritance;
using System;

namespace _02_Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("╔═══════════════════════════════════════════╗");
            Console.WriteLine("║   C# in Nutshell - Chapter 2: Inheritance ║");
            Console.WriteLine("╚═══════════════════════════════════════════╝\n");

            Console.WriteLine("Select a topic to review:\n");
            Console.WriteLine("  [00] Inheritance");
            Console.WriteLine("  [01] Polymorphism");
            Console.WriteLine("  [02] Casting and Reference Conversions");
            Console.WriteLine("  [03] Virtual Function Members");
            Console.WriteLine("  [04] Abstract Classes and Abstract Members");
            Console.WriteLine("  [05] Hiding Inherited Members");
            Console.WriteLine("  [06] Sealing Functions and Classes");
            Console.WriteLine("  [07] The base Keyword");
            Console.WriteLine("  [08] Constructors and Inheritance");
            Console.WriteLine("  [09] Overloading and Resolution");
            Console.WriteLine("\n  [Q] Quit\n");
            Console.Write("Enter your choice: ");

            var choice = Console.ReadLine()?.Trim().ToUpper();

            Console.Clear();

            switch (choice)
            {
                case "0":
                case "1":
                case "01":
                    Chapters._01_Polymorphism.PolymorphismDemo.Run();
                    break;

                case "2":
                case "02":
                    Chapters._02_CastingAndReferenceConversions.CastingDemo.Run();
                    break;

                case "3":
                case "03":
                    Chapters._03_VirtualFunctionMembers.VirtualDemo.Run();
                    break;

                case "4":
                case "04":
                    AbstractDemo.Run();
                    break;

                case "5":
                case "05":
                    Chapters._05_HidingInheritedMembers.HidingDemo.Run();
                    break;

                case "6":
                case "06":
                    Chapters._06_SealingFunctionsAndClasses.SealingDemo.Run();
                    break;

                case "7":
                case "07":
                    Chapters._07_BaseKeyword.BaseKeywordDemo.Run();
                    break;

                case "8":
                case "08":
                    ConstructorsDemo.Run();
                    break;

                case "9":
                case "09":
                    Chapters._09_OverloadingAndResolution.OverloadingDemo.Run();
                    break;

                case "Q":
                    Console.WriteLine("Goodbye! 👋");
                    return;

                default:
                    Console.WriteLine("❌ Invalid choice! Press any key to continue...");
                    Console.ReadKey();
                    continue;
            }

            Console.WriteLine("\n" + new string('─', 50));
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
        }
    }
}
