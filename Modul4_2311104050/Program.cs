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

        Console.WriteLine("\nMenekan TombolX:");
        karakter.TombolX(); 

        Console.WriteLine("\nMenekan TombolW lagi:");
        karakter.TombolW(); 

        Console.WriteLine("\nMenekan TombolS lagi:");
        karakter.TombolS(); 
    }
}