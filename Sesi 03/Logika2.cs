using System;

public class Logika2
{
    public static void Main()
    {
        int nilai = 20;
        string result = nilai < 60 ? "Nilai Kamu C" : nilai < 80 ? "Nilai Kamu B" : "Nilai Kamu A";
        
        Console.WriteLine(result);
        

    }
}