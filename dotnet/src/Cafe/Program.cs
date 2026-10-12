namespace Cafe;

public static class Program
{
    public static void Main(string[] args)
    {
        CafeConfig c = CafeConfig.getInstance();
        Console.WriteLine(c.getCafeName());
        CafeConfig c2 = CafeConfig.getInstance();
        Console.WriteLine(c2.getCafeName());
    }
}
