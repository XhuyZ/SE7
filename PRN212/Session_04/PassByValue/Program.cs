namespace PassByValue;
public class Program
{
    public static void Main(string[] args)
    {
        int x = 5;
        PowerByTwo(x);
        Console.WriteLine($"After use Func = {x}");
    }

    public static void PowerByTwo(int x)
    {
        Console.WriteLine($"before = {x}");
        x = x * x;
        Console.WriteLine($"after = {x}");
    }
    public static void DoSomething(out int x)
    {
        x = 69;
    }
}
