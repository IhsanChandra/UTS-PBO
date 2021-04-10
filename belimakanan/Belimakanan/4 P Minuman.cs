using System;

static void PesanMi()
{
    //Pilih makanan
    Console.WriteLine("1. Teh");
    Console.WriteLine("2. Jeruk");
    Console.WriteLine("Pilih minuman: ");

    int pilih = Convert.ToInt32(Console.Read());
    int totalmi = o;
            
    while (pilih > 0)
    {
        if (pilih == 1)
        {

            Console.WriteLine(es + "Teh : Rp 5000 :");
            int et = Convert.ToInt32(Console.Read());
            Console.WriteLine("Teh : " + hangat + "Rp 5000" );
            int ht = Convert.ToInt32(Console.Read());
                    
        }
        else if (pilih == 2)
        {
            Console.WriteLine(es + "Jeruk : Rp 5000 :");
            int ej = Convert.ToInt32(Console.Read());
            Console.WriteLine("Jeruk : " + hangat + "Rp 5000" );
            int hj = Convert.ToInt32(Console.Read());
        }
        else if (pilih == 3)
        {
            break;
        }
        else
        {
            Console.WriteLine("Tidak ada pilihan angka" + pilih);
        }
        int tet = et * 5000;
        int tht = ht * 5000;
        int tej = ej * 5000;
        int thj = hj * 5000;
        int temp = tet + tht + tej + thj;
        int totalmi = totalmi + temp;
    }
    int totalmin = toalmi;
    return totalmin;
}