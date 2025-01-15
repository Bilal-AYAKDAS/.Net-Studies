using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            String nameSurname = "Bilal Ayakdaş";
            char harf = 'B';
            Console.WriteLine("nameSurname : " +nameSurname);
            Console.WriteLine("harf : " + harf);
            Console.WriteLine("nameSurname.Contains(harf) : " + nameSurname.Contains(harf));

            int sayi = 19;
            byte kucukSayi = 255;
            short ortaSayi = 32767;

            Console.WriteLine("int sayi : "+sayi);
            Console.WriteLine("byte kucukSayi : " + kucukSayi);
            Console.WriteLine("short ortaSayi : " + ortaSayi);

            float ondalikliSayi = 3.14f;
            double cokluOndalikliSayi = 3.14;
            decimal para = 3.14m;


            Console.WriteLine("float ondalikliSayi :" + ondalikliSayi);
            Console.WriteLine("double cokluOndalikliSayi :" + cokluOndalikliSayi);
            Console.WriteLine("decimal para :"+para);

            Console.ReadLine();

        }
    }
}
