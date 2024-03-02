using System;

class Program
{
    static int Min(int[] x)
    {
        int enKucuk = x[0];

        for (int i = 1; i < x.Length; ++i)
        {
            if (x[i] < enKucuk)
            {
                enKucuk = x[i];
            }
        }

        return enKucuk;
    }

    static void Main()
    {
        int s1, s2, s3;

        Console.Write("1. sayı : ");
        s1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("2. sayı : ");
        s2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("3. sayı : ");
        s3 = Convert.ToInt32(Console.ReadLine());

        int[] liste = { s1, s2, s3 };

        int result = Min(liste);
        Console.WriteLine("En küçük sayı: " + result);
    }
}
