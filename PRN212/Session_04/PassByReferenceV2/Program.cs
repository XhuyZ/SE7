namespace PassByReferenceV2;

class Program
{
    static void Main(string[] args)
    {
        int x = 69;
        PowerByTwo(ref x);
        Console.WriteLine($"X= {x}");
    }
    public static void PowerByTwo(ref int x)
    {
        x = 69;
    }
}
