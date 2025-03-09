using System;

class Program
{
    static void Main()
    {
        PosisiKarakterGame karakter = new PosisiKarakterGame();

        Console.Write("Masukkan NIM Anda: ");
        long nim = Convert.ToInt64(Console.ReadLine());

        karakter.SetNIM(nim);

        Console.WriteLine("\nMenekan TombolS:");
        karakter.TombolS();

        Console.WriteLine("\nMenekan TombolW:");
        karakter.TombolW();
    }
}