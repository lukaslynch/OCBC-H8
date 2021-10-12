using System;

class HitungNilai4
{
    public static void Main(string[] args)
    {
       Console.Write("Enter your age: ");
       int age = int.Parse(Console.ReadLine());
       Console.Write("Username: ");
       string username = Console.ReadLine();
       Console.Write("Password: ");
       string password = Console.ReadLine();
       

       bool isAdult = age > 18;
       bool isPasswordValid = (password == "OCBC") && (username == "LUKAS");
       Console.WriteLine("=== Menghitung Nilai ===");
       Console.Write("Masukkan nilai PERTAMA: ");
       pertama = int.Parse(Console.ReadLine());
       Console.Write("Masukkan nilai KEDUA: ");
       kedua = int.Parse(Console.ReadLine());
       Console.Write("Masukkan nilai KETIGA: ");
       ketiga = int.Parse(Console.ReadLine());

        total = pertama + kedua + ketiga;
        rata = total / 3.0;
        //Console.WriteLine("Total Nilai adalah: " + total);
        //Console.WriteLine("Rata-rata Nilai adalah: " + rata);

       if(isAdult && isPasswordValid)
       {
           Console.WriteLine("WELCOME TO THE CLUB!");
       } else {
           Console.WriteLine("Sorry, try again!");
       }
    }
}