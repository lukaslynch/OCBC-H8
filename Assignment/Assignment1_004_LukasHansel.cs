using System;

public class String3
{
    public static void Main()
    {
        var count = true;
        Jawab soal = new Jawab();
        do{
            Console.Write("Pilih solusi 1/2/3/4/5/6 : ");
            int solusi = int.Parse(Console.ReadLine());
            if (solusi == 1){
                soal.Jawab1();
            } else if (solusi == 2){
                soal.Jawab2();
            } else if (solusi == 3){
                soal.Jawab3();
            } else if (solusi == 4){
                soal.Jawab4();
            } else if (solusi == 5){
                soal.Jawab5();
            } else if (solusi == 6){
                soal.Jawab6();
            } else{
                Console.WriteLine("PILIHAN OUT OF RANGE!~");
            };
            Console.Write("Lagi? Y/N : ");
            char cek = Console.ReadKey().KeyChar;
            if (cek == 'N' || cek == 'n'){
                count = false;
                Console.WriteLine("Terima Kasih :D...");  
            }else if (cek == 'Y' || cek == 'y'){
                count = true;
            } else {
                Console.WriteLine("MASUKKAN PILIHAN YANG BENAR");
            };
            Console.Write("\n");
            
        } while (count == true);
          
    }    
}

public class Jawab
{
    public void Jawab1(){
        char[] huruf = {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
        int i,j,k,l,n;           
        Console.Write("Enter the Range = ");   
        n= int.Parse(Console.ReadLine());     
        Console.Write("\n");     
        for(i=1; i<=n; i++)      
        {          
            for(j=1; j<=n-i; j++)      
            {      
                Console.Write(" ");
                Console.Write(" ");      
            }      
            for(k=1;k<=i;k++)      
            {      
                Console.Write(huruf[k-1]);
                Console.Write(" ");      
            }      
            for(l=i-1;l>=1;l--)      
            {      
                Console.Write(huruf[l-1]);
                Console.Write(" ");      
            }      
            Console.Write("\n");      
       }
       Console.Write("\n");
    }

    public void Jawab2(){
        int i,j,k,l,n;           
        Console.Write("Enter the Range = ");  
        n= int.Parse(Console.ReadLine());     
        Console.Write("\n");      
        for(i=1; i<=n; i++)      
        {          
            for(j=1; j<=n-i; j++)      
            {      
                Console.Write(" ");
                Console.Write(" ");      
            }      
            for(k=1;k<=i;k++)      
            {      
                Console.Write(k);
                Console.Write(" ");      
            }      
            for(l=i-1;l>=1;l--)      
            {      
                Console.Write(l);
                Console.Write(" ");      
            }      
            Console.Write("\n");      
       }
       Console.Write("\n");
    }

    public void Jawab3(){
        int n, fact=1;
        Console.Write("Enter any Number: ");
        n = int.Parse(Console.ReadLine()); 
        string str = n.ToString();
        string newstr = str.Substring(0,1);         
        for(int i = 1; i <= n; i++){      
        fact=fact*i;      
        };      
        if (newstr == "-"){
            Console.Write("MASUKKAN BILANGAN POSITIF!"); 
            Console.WriteLine("\n");
        } else {
            Console.Write("Factorial of " +n+" is: "+fact); 
            Console.WriteLine("\n");   
        }   
    }

    public void Jawab4(){
        int  n, reverse=0, rem;           
        Console.Write("Enter a POSITIVE number: ");      
        n= int.Parse(Console.ReadLine());     
        while(n!=0)      
        {      
        rem=n%10;        
        reverse=reverse*10+rem;      
        n/=10;      
        }      
        Console.Write("Reversed Number: "+reverse);
        Console.WriteLine("\n");    
    }

    public void Jawab5(){
        int n, z, vid = 0;     
        Console.Write("Enter the Number : ");    
        n = int.Parse(Console.ReadLine());     
        while(n > 0)      
        {      
        z =n % 10;      
        vid = vid * 10 + z;      
        n = n / 10;      
        }      
        n = vid;      
        while(n > 0)      
        {      
        z = n % 10;      
        switch(z)      
        {      
            case 1:      
                Console.Write("one ");  
                break;      
            case 2:      
                Console.Write("two ");      
                break;      
            case 3:      
                Console.Write("three ");    
                break;      
            case 4:      
                Console.Write("four ");    
                break;      
            case 5:      
                Console.Write("five ");    
                break;      
            case 6:      
                Console.Write("six ");     
                break;      
            case 7:    
                Console.Write("seven ");    
                break;    
            case 8:      
                Console.Write("eight ");      
                break;      
            case 9:      
                Console.Write("nine ");    
                break;      
            case 0:      
                Console.Write("zero ");    
                break;                  
            };    
        n = n / 10;      
        };
        Console.WriteLine("\n");   
    }

    public void Jawab6()
    {
        string kata, rev;
        Console.Write("Masukkan kata : ");
        kata = Console.ReadLine();
        char[] ch = kata.ToCharArray();
        Array.Reverse(ch);
        rev = new string(ch);
        bool b = kata.Equals(rev, StringComparison.OrdinalIgnoreCase);
        if (b == true) {
            Console.WriteLine("" + kata + " adalah palindrome");
        } else {
            Console.WriteLine(" " + kata + " adalah BUKAN palindrome");
        };  
    }
}