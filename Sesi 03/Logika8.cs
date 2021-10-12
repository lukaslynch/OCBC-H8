using System;

public class Logika8
{
    public static void Main()
    {
        Console.Write("Jumlah iterasi : ");
        int imax = int.Parse(Console.ReadLine());
        Console.Write("Angka pertama : ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Angka operator aritmatika : ");
        int j = int.Parse(Console.ReadLine());
        Console.Write("Operator : ");
        string o = Console.ReadLine();
        int i = 1;
        do
        {
            switch(o){
                case("tambah"):{
                    Console.Write("i = {0}", i);
                    Console.WriteLine(" output {0}", a);
                    a += j;
                    break;
                }
                case("kurang"):{
                    Console.Write("i = {0}", i);
                    Console.WriteLine(" output {0}", a);
                    a -= j;
                    break;
                }
                case("kali"):{
                    Console.Write("i = {0}", i);
                    Console.WriteLine(" output {0}", a);
                    a *= j;
                    break;
                }
                case("bagi"):{
                    Console.Write("i = {0}", i);
                    Console.WriteLine(" output {0}", a);
                    a /= j;
                    break;
                }
            };
            i++;

            if (i > 8){
                break;
            }
        } while (i <= imax);
    }
}