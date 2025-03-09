using System;

class PosisiKarakterGame
{
    public enum State { Berdiri, Jongkok, Tengkurap, Terbang }
    private State posisi;
    private int modNIM; 

    public PosisiKarakterGame()
    {
        posisi = State.Berdiri;
    }

    public void SetNIM(long nim)
    {
        modNIM = (int)(nim % 3); 
        Console.WriteLine($"NIM Anda: {nim}");
        Console.WriteLine($"Hasil NIM % 3 = {modNIM}\n");
    }

    public void TombolS()
    {
        switch (posisi)
        {
            case State.Berdiri:
                posisi = State.Jongkok;
                Console.WriteLine("Karakter jongkok");
                if (modNIM == 0) Console.WriteLine("Tombol arah bawah ditekan");
                break;
            case State.Terbang:
                posisi = State.Jongkok;
                Console.WriteLine("Posisi landing");
                if (modNIM == 2) Console.WriteLine("Posisi landing");
                break;
        }
    }

    public void TombolW()
    {
        switch (posisi)
        {
            case State.Jongkok:
                posisi = State.Berdiri;
                Console.WriteLine("Karakter berdiri");
                if (modNIM == 1) Console.WriteLine("Posisi standby");
                break;
            case State.Berdiri:
                posisi = State.Terbang;
                Console.WriteLine("Posisi take off");
                if (modNIM == 0) Console.WriteLine("Tombol arah atas ditekan");
                if (modNIM == 2) Console.WriteLine("Posisi take off");
                break;
        }
    }

    public void TombolX()
    {
        if (posisi == State.Berdiri && modNIM == 1)
        {
            posisi = State.Tengkurap;
            Console.WriteLine("Posisi istirahat");
        }
    }
}
