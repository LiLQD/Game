namespace ConsoleApp1;

class Program
{
    
    public static void Main(string[] args)
    {
        Cau1.a1();
        Cau1.b1();
        Cau2.abcd();
    }
}

class Cau1
{
    const double A = 9;
    const double Omega = Math.PI * 5;
    const double T = (2*Math.PI) / Omega;
    const double Phi = Math.PI / 2;
    public static void a1()
    {
        Console.WriteLine("Cau a");
        double SoT = 2.125 / 0.4;
        int temp = (int)(2.125 / 0.4);
        double result = (SoT - temp) * 4 * A + temp * A * 4;
        Console.WriteLine(result);
    }
    
    public static void b1()
    {
        Console.WriteLine("Cau b");
        double A = double.Parse(Console.ReadLine());
        double t = double.Parse(Console.ReadLine());
        double omega = double.Parse(Console.ReadLine()) * Math.PI;
        double T = (2 * Math.PI) / omega;
        double SoT = t / T;
        int temp = (int)(t / T);
        double Result = (SoT - temp) * 4 * A + temp * A * 4;
        Console.WriteLine(Result);
    }
}

class Cau2
{
    const double a = 9.8;
    const double v = 20;
    const double rad = (30 * Math.PI) / 180;
    public static void abcd()
    {
        Console.WriteLine("Cau a");
        double vNgang = v * Math.Cos(rad);
        double vThangDung = v * Math.Sin(rad);
        Console.WriteLine(vNgang + " m/s " + vThangDung + " m/s");
        
        Console.WriteLine("Cau b");
        double t1 = vThangDung / a;
        Console.WriteLine(t1 + " s");
        
        Console.WriteLine("Cau c");
        double maxH = (Math.Pow(vThangDung, 2)) / (2 * a);
        Console.WriteLine(maxH + " m");
        
        Console.WriteLine("Cau d");
        double t2 = 2 * t1; 
        double S = vNgang * t2; 
        Console.WriteLine(S + " m");
    }
}