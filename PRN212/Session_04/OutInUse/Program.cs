using System;
class Program
{
    static void Main(string[] args)
    {
        int sumAll = ComputeOnIntegerList(10, out int sumEven, out int sumOdd);
        Console.WriteLine($"SumAll = {sumAll}, SumEven = {sumEven}, SumOdd = {sumOdd}");
    }
    public static int ComputeOnIntegerList(int n, out int sumEven, out int sumOdd)
    {
        int sumAll = 0;
        sumEven = 0;
        sumOdd = 0;

        for (int i = 0; i <= n; i++)
        {
            sumAll += i;

            if (i % 2 == 0)
                sumEven += i;
            else
                sumOdd += i;
        }

        return sumAll;
    }
}
