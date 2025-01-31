namespace MusicCollection;
// khai bao bien nam trong class
// namespace chua class 
internal class Program
{
    static void Main(string[] args)
    {
        // PrinLyric();
        // PrinLyricV2();
        PrinLyricV3();
    }

    public static void PrinLyric()
    {
        int Year = 2024;
        int Month = 1;
        Console.WriteLine("okokok " + Year + " yeyeye " + Month);
        //concatenation
        Console.WriteLine("okokok {0}/{1}", Month, Year);
        // placeholder
        Console.WriteLine($"okokok {Year}/{Month}");
        // interpolation
    }
    public static void PrinLyricV2()
    {
        Console.WriteLine("");
    }

    public static void PrinLyricV3()
    {
        string path = @"/home/xhuyz/Arch-setup/";
        Console.WriteLine(@"Mùa thu mang giấc mơ quay về
Vẫn nguyên vẹn như hôm nào
Lá bay theo gió xôn xao
Chốn xưa em chờ (chốn xưa em chờ)
Đoạn đường ngày nào nơi ta từng đón đưa
Còn vấn vương không phai mờ
Giấu yêu thương trong vần thơ");
        Console.WriteLine(path);
        //verbatim

    }

}
