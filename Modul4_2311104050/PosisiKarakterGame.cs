using System;

class PosisiKarakterGame
{
    public enum State { Berdiri, Jongkok, Tengkurap, Terbang }
    private State posisi;

    public PosisiKarakterGame()
    {
        posisi = State.Berdiri;
    }

    public void TombolS()
    {
        if (posisi == State.Berdiri)
        {
            posisi = State.Jongkok;
            Console.WriteLine("Karakter jongkok");
        }
        else if (posisi == State.Terbang)
        {
            posisi = State.Jongkok;
            Console.WriteLine("Posisi landing");
        }
    }

    public void TombolW()
    {
        if (posisi == State.Jongkok)
        {
            posisi = State.Berdiri;
            Console.WriteLine("Karakter berdiri");
        }
        else if (posisi == State.Berdiri)
        {
            posisi = State.Terbang;
            Console.WriteLine("Posisi take off");
        }
    }

    public void SetNIM(long nim)
    {
        int mod = (int)(nim % 3);
        switch (mod)
        {
            case 0:
                Console.WriteLine("Mode: TombolS menampilkan 'tombol arah bawah ditekan'");
                Console.WriteLine("Mode: TombolW menampilkan 'tombol arah atas ditekan'");
                break;
            case 1:
                Console.WriteLine("Mode: Saat Berdiri -> 'posisi standby'");
                Console.WriteLine("Mode: Saat Tengkurap -> 'posisi istirahat'");
                break;
            case 2:
                Console.WriteLine("Mode: Saat Terbang ke Jongkok -> 'posisi landing'");
                Console.WriteLine("Mode: Saat Berdiri ke Terbang -> 'posisi take off'");
                break;
        }
    }
}