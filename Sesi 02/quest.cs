using System;

class quest
{
    public static void Main(string[] args)
    {
       Console.Write("Enter your age: ");
       int age = int.Parse(Console.ReadLine());
       Console.Write("Username: ");
       string username = Console.ReadLine();
       Console.Write("Password: ");
       string password = Console.ReadLine();
       Console.Write("Jenis kelamin: ");
       string jenkel = Console.ReadLine();
       Console.Write("status nikah: ");
       string status = Console.ReadLine();
       bool isMarried = status == "menikah";

       bool cek = (password == "OCBC") && 
       (username == "LUKAS") && 
       (age > 18);

       Console.WriteLine("=== Menghitung Nilai ===");
       Console.Write("Masukkan nilai PERTAMA: ");
       int pertama = int.Parse(Console.ReadLine());
       Console.Write("Masukkan nilai KEDUA: ");
       int kedua = int.Parse(Console.ReadLine());
       Console.Write("Masukkan nilai KETIGA: ");
       int ketiga = int.Parse(Console.ReadLine());
       
       int total = pertama + kedua + ketiga;
       double rata = total / 3.0;

       if(cek)
       {
           Console.WriteLine($"WELCOME TO THE CLUB! {username}");
           Console.WriteLine($"Umur: {age} tahun");
           Console.WriteLine($"Jenis Kelamin : {jenkel}");
           Console.WriteLine($"Status nikah : {isMarried}");
           Console.WriteLine("Total Nilai adalah: " + total);
           Console.WriteLine("Rata-rata Nilai adalah: " + rata);
       } else {
           Console.WriteLine("Sorry, try again!");
       }
    }
}