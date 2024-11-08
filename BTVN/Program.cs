namespace BTVN;

public class Program
{
    static void Main()
    {
        Console.Write("Bai 1: ");
        Bai1.cauA();
        Bai1.cauB();
        
        Console.Write("Bai 2: ");
        Console.Write("Nhap chuoi: ");
        string input = Console.ReadLine();
        if (Bai2.kiemTra(input)) Console.WriteLine("Yes");
        else Console.WriteLine("No");
    }
}