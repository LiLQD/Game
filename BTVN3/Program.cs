namespace BTVN;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Bai 1: ");
        Bai1.cauA();
        Bai1.cauB();
        
        Console.WriteLine("Bai 2: ");
        Console.Write("Nhap chuoi: ");
        string input = Console.ReadLine();
        if (Bai2.kiemTra(input)) Console.WriteLine("Yes");
        else Console.WriteLine("No");
        
        Console.WriteLine("Bai 3: Em van chua biet lam dang hoc lai a :( ");
    }
}