using System;

namespace hello_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //type data string
            string fname, lname;
            int umur;

            Console.Write("enter your first name : ");
            fname = Console.ReadLine();

            Console.Write("enter your last name : ");
            lname = Console.ReadLine();

            Console.Write("enter your age : ");
            umur = int.Parse(Console.ReadLine());

            Console.Write("your full name is "+fname+ " "+lname+
             " dan kamu berumur "+umur+" tahun.");
        }
    }
}
