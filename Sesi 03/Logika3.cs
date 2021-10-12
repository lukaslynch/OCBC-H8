using System;

public class Logika3
{
    public static void Main()
    {
        string Username;
        string password;

        Console.Write("Username: ");
        Username = Console.ReadLine();
        Console.Write("Password: ");
        password = Console.ReadLine();

        if (Username == "ocbc" && password == "bootcamp"){
            Console.WriteLine("Anda berhasil login");
        } else {
            Console.WriteLine("Username atau Password anda salah");
        }
        

    }
}