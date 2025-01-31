namespace Bmi;
class Program
{
    static void Main(string[] args)
    {
        // double bmi = GetBmi(80, 1.8);
        // Console.WriteLine("Bmi cua ban la: " + GetBmi(80, 1.8));
        // Console.WriteLine($"Bmi cua ban la: {bmi}");
        // Console.WriteLine($"Bmi cua ban la: {GetBmi(80, 1.8)}");
        var bmi = BmiCalculator.GetBmi(80, 1.8);
        Console.WriteLine($"Bmi cua ban la : {bmi}");
    }
    public static double GetBmi(double weight, double height)
    {
        return (weight / (height * height));

    }
}
