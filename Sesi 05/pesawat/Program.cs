using System;

namespace pesawat
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesawat pesawat = new Pesawat();
            pesawat.nama = "GARUDA";
            pesawat.Ketinggian = "2500 kaki";

            pesawat.terbang();
            pesawat.sudahterbang();
        }
    }
}
