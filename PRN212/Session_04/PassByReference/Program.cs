namespace PassByReference;

class Program
{
    // static void Main(string[] args)
    // {
    //     int x;
    //     PowerByTwo(out x);
    //     Console.WriteLine($"x^2 main = {x}");
    // }
    static void Main(string[] args)
    {
        PowerByTwo(out int x);
        Console.WriteLine($"x^2 main = {x}");
    }
    public static void PowerByTwo(out int x)
    {
        x = 10;
        x = x * x;
        Console.WriteLine($"func = {x}");
    }


}
