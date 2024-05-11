namespace UFT;

internal static class Program
{
    private const string Version = "1.0";
    private static void Main(string[] Args)
    {
        if (Args.Length != 2 && Args.Length != 1) Error("requires 1 or 2 arguments");
        if (Args.Length == 2)
            UFTHost.CreateFile(Args[0], Args[1]);
        else if (Args[0] != "about")
            UFTHost.CreateTemplate(Args[0]);
        else
        {
            Console.WriteLine("UFT - Universal File Template");
            Console.WriteLine($"Version: {Version}");
            Console.WriteLine("by NonExistPlayer / nonex");
        }
    }

    public static void Error(string Message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("error: "+Message);
        Console.ResetColor();
        Environment.Exit(1);
    }
}