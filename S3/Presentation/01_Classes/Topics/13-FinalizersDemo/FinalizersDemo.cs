namespace Chapter03_Classes;

public static class FinalizersDemo
{
    public static void Run()
    {
        Console.WriteLine("=== Finalizers: IDisposable Pattern ===\n");

        using (var resource = new ManagedResource())
        {
            resource.DoWork();
        } // Dispose called automatically

        Console.WriteLine("\n💡 KEY POINT: Prefer IDisposable over finalizers (deterministic cleanup)");
    }

    class ManagedResource : IDisposable
    {
        private bool _disposed = false;

        public void DoWork() => Console.WriteLine("Working...");

        public void Dispose()
        {
            if (_disposed) return;

            Console.WriteLine("-> Dispose called (deterministic)");
            _disposed = true;
            GC.SuppressFinalize(this);
        }

        //If you missed use Using statement for instanaiting this class
        ~ManagedResource()
        {
            Console.WriteLine("-> Finalizer called (non-deterministic)");
        }
    }
}
