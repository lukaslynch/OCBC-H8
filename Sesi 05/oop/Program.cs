using System;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
        var count = true;
        do{
            Console.WriteLine("1. Pesawat Tempur ");
            Console.WriteLine("2. Overloading ");
            Console.WriteLine("3. Bilangan ");
            Console.WriteLine("4. About ");
            Console.Write("Pilih menu :  ");
            int solusi = int.Parse(Console.ReadLine());
            if (solusi == 1)
            {
                FighterJet jet = new FighterJet();
                Console.Write("Nama Pesawat :  ");
                jet.Nama = Console.ReadLine();
                Console.Write("Jumlah Roda :  ");
                jet.JumlahRoda = int.Parse(Console.ReadLine());
                Console.Write("Ketinggian :  ");
                jet.Ketinggian = Console.ReadLine();
                Console.Write("Jumlah penumpang :  ");
                jet.JumlahPenumpang = Console.ReadLine();
                jet.terbang();
            } else if (solusi == 2)
            {
                Overloading overl = new Overloading();
                overl.print("FOXYYYY");
                overl.print(0891273981273);
            } else if (solusi == 3)
            {
                Overriding overiding = new Overriding();
                Console.Write("Bilangan 1 :  ");
                overiding.bilangan1 = int.Parse(Console.ReadLine());
                Console.Write("Bilangan 2 :  ");
                overiding.bilangan2 = int.Parse(Console.ReadLine());

                overiding.penjumlahanperkalianll();
                anakover overiding2 = new anakover();
                overiding2.bilangan1 = overiding.bilangan1;
                overiding2.bilangan2 = overiding.bilangan2;
                overiding2.penjumlahanperkalianll();
            } else if (solusi == 4)
            {
                Console.WriteLine("Haloooo");
                Console.WriteLine("Nama saya Lukas, domisili Purwakarta");
                Console.WriteLine("Sesi 1 sampai saat ini berjalan lancar");
                Console.WriteLine("Jalani hobi agar tidak terlalu jenuh ngoding");
                Console.WriteLine("thank you");
            }
            else
            {
                Console.WriteLine("PILIHAN OUT OF RANGE!~");
            };
            Console.Write("Lagi? Y/N : ");
            char cek = Console.ReadKey().KeyChar;
            if (cek == 'N' || cek == 'n')
            {
                count = false;
                Console.WriteLine("Terima Kasih :D...");  
            }else if (cek == 'Y' || cek == 'y')
            {
                count = true;
                Console.Write("\n");
            } else 
            {
                Console.WriteLine("MASUKKAN PILIHAN YANG BENAR");
            };
        
        } while (count == true);
        }
        
    }
}
