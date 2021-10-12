using System;

public class Logika4
{
    public static void Main()
    {
        double nilai;
        Console.Write("Nilai: ");
        nilai = Convert.ToDouble(Console.ReadLine());
        
        string result = nilai >= 85 ? "Grade Kamu A" : 
                nilai >=  65 ? "Grade Kamu B" : 
                nilai >= 45 ?"Grade Kamu C":
                nilai >= 25 ? "Grade Kamu D" : "Kamu Galulus";
        Console.WriteLine(result);
    }
}