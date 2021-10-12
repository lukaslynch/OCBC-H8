using System;

public class array1d
{
    public static void Main()
    {
        Console.Write("Tulis kalimat : ");
        string hmm = Console.ReadLine();
        Console.Write("Mau tampil array index ke berapa? : ");
        int wow = int.Parse(Console.ReadLine());

        string[] contoh = hmm.Split(' ');

        Console.WriteLine("Menampilkan array : ");
        foreach (var kata in contoh)
        {
            Console.WriteLine(kata);
        };
        Console.WriteLine();
        Console.Write("Menampilkan array index ke : " + wow + " = ");
        Console.Write(contoh[wow]);

    }
}