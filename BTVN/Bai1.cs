using System;

public class Bai1
{
    public static void cauA()
    {
        Console.Write("Nhap chieu dai: ");
        int dai = int.Parse(Console.ReadLine());
        Console.Write("Nhap chieu rong: ");
        int rong = int.Parse(Console.ReadLine());
        for (int i = 0; i < rong; i++)
        {
            for (int j = 0; j < dai; j++)
            {
                if (i == 0 || i == rong - 1 || j == 0 || j == dai - 1) Console.Write("*");
                else Console.Write(" ");
            }

            Console.WriteLine();
        }
    }

    public static void cauB()
    {
        Console.Write("Nhap do dai canh ben: ");
        int canhBen = int.Parse(Console.ReadLine());
        for (int i = 0; i < canhBen; i++)
        {
            for (int j = 0; j < 2 * canhBen - 1; j++)
            {
                if (j == canhBen - i - 1 || j == canhBen + i - 1 || i == canhBen - 1) Console.Write("*");
                else Console.Write(" ");
            }

            Console.WriteLine();
        }
    }


}