using System;
using System.Collections.Generic;
using System.Text;

namespace belimakanan
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("List Makanan :");
            PesanMa();
            Console.WriteLine("List Minuman :");
            PesanMi();
            Console.WriteLine("Ambil Sendiri? (y/n)");
            string jawab = Console.ReadLine();
            if (jawab = "y")
            {
                total = totalmak + totalmin;
            }
            if (jawab = "n")
            {
                total = totalmak + totalmin + 10000;
            }
            Console.WriteLine("pesanan anda adalah:");
            Console.WriteLine("ayam bakar :" + ab + "\nayam goreng : " + ag);
            Console.WriteLine("bebek bakar : " + bb + "\nbebek goreng : " +bg);
            Console.WriteLine("ikan bakar" + ib + "\nikan goreng : " + ig);
            Console.WriteLine("es teh :" + et + "\nteh hangat : " + ht);
            Console.WriteLine("es jeruk" + ej + "\njeruk hangat :" + hj);
            Console.WriteLine("total harga = Rp" + total);
        }
    }
}