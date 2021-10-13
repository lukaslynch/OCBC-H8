using System;

namespace oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Laptop();

            Console.Write("Masukkan Merk : ");
            laptop1.merk = Console.ReadLine();
            Console.Write("Masukkan RAM : ");
            laptop1.ram = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Memory : ");
            laptop1.memory = int.Parse(Console.ReadLine());

            Console.WriteLine("Merk Laptop adalah {0}", laptop1.merk);
            Console.WriteLine("Kapasitas RAM ada {0}", laptop1.ram);
            Console.WriteLine("Kapasitas Memory ada {0}", laptop1.memory);

            laptop1.Chatting();
            laptop1.Sosmed();
            laptop1.OnlineShop();
        }
    }
}
