internal class Program
{
    private static void Main(string[] args)
    {
        string name = "";
        Console.WriteLine("ENter your name");
        name=Console.ReadLine();
        Console.WriteLine("Hello, World!"+name);
        Console.WriteLine($"Hello ! {name}");
        Console.WriteLine("Hello ! {0}", name);
    }
}


