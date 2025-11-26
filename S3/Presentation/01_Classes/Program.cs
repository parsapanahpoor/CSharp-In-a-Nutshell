namespace Chapter03_Classes;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        while (true)
        {
            PrintMenu();
            var choice = Console.ReadLine();

            Console.Clear();

            switch (choice)
            {
                case "1": ClassesDemo.Run(); break;
                case "2": FieldsDemo.Run(); break;
                case "3": ConstantsDemo.Run(); break;
                case "4": MethodsDemo.Run(); break;
                case "5": InstanceConstructorsDemo.Run(); break;
                case "6": DeconstructorsDemo.Run(); break;
                case "7": ObjectInitializersDemo.Run(); break;
                case "8": ThisReferenceDemo.Run(); break;
                case "9": PropertiesDemo.Run(); break;
                case "10": IndexersDemo.Run(); break;
                case "11": PrimaryConstructorsDemo.Run(); break;
                case "12": StaticConstructorsDemo.Run(); break;
                case "13": StaticClassesDemo.Run(); break;
                case "14": FinalizersDemo.Run(); break;
                case "15": PartialTypesDemo.Run(); break;
                case "16": NameofOperatorDemo.Run(); break;
                case "0": return;
                default: Console.WriteLine("Invalid option!"); break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }

    static void PrintMenu()
    {
        Console.WriteLine("╔════════════════════════════════════════╗");
        Console.WriteLine("║  Chapter 3: Classes - Code Review     ║");
        Console.WriteLine("╠════════════════════════════════════════╣");
        Console.WriteLine("║ 1.  Classes                            ║");
        Console.WriteLine("║ 2.  Fields                             ║");
        Console.WriteLine("║ 3.  Constants                          ║");
        Console.WriteLine("║ 4.  Methods                            ║");
        Console.WriteLine("║ 5.  Instance Constructors              ║");
        Console.WriteLine("║ 6.  Deconstructors                     ║");
        Console.WriteLine("║ 7.  Object Initializers                ║");
        Console.WriteLine("║ 8.  The this Reference                 ║");
        Console.WriteLine("║ 9.  Properties                         ║");
        Console.WriteLine("║ 10. Indexers                           ║");
        Console.WriteLine("║ 11. Primary Constructors (C# 12)       ║");
        Console.WriteLine("║ 12. Static Constructors                ║");
        Console.WriteLine("║ 13. Static Classes                     ║");
        Console.WriteLine("║ 14. Finalizers                         ║");
        Console.WriteLine("║ 15. Partial Types and Methods          ║");
        Console.WriteLine("║ 16. The nameof Operator                ║");
        Console.WriteLine("║ 0.  Exit                               ║");
        Console.WriteLine("╚════════════════════════════════════════╝");
        Console.Write("\nYour choice: ");
    }
}
