using System;


static void PesanMa()
{
    Console.WriteLine("1. Ayam");
    Console.WriteLine("2. Bebek");
    Console.WriteLine("3. Ikan");
    Console.WriteLine("Pilih makanan");

    int pilih = Convert.ToInt32(Console.Read());
    int totalma = 0;
    int ab = 0;
    int ag = 0;
    int bb = 0;
    int bg = 0;
    int ib = 0;
    int ig = 0;

    while (pilih > 0)
    {
        if (pilih == 1)
        {
            Console.WriteLine("Ayam : " + bakar + "Rp 15000 :");
            int ab = Convert.ToInt32(Console.Read());
            Console.WriteLine("Ayam : " + goreng + "Rp 13000");
            int ag = Convert.ToInt32(Console.Read());
                    
        }
        else if (pilih == 2)
        {
            Console.WriteLine("Bebek : " + bakar + "Rp 15000");
            int bb = Convert.ToInt32(Console.Read());
            Console.WriteLine("Bebek : " + goreng + "Rp 13000");
            int bg = Convert.ToInt32(Console.Read());
        }
        else if (pilih == 3)
        {
            Console.WriteLine("Ikan : " + bakar + "Rp 12000");
            int ib = Convert.ToInt32(Console.Read());
            Console.WriteLine("Ikan : " + goreng + "Rp 12000");
            int ig = Convert.ToInt32(Console.Read());
        }
        else if (pilih == 4)
        {
            break;
        }
        else
        {
            Console.WriteLine("Tidak ada pilihan angka" + pilih);
        }
        int tab = ab * 15000;
        int tag = ag * 13000;
        int tbb = bb * 15000;
        int tbg = bg * 13000;
        int tib = ib * 12000;
        int tig = ig * 12000;
        int temp = tab + tag + tbb + tbg + tib + tig;
        int totalma = totalma + temp;
    }
    int totalmak = totalma;
    return totalmak;
}