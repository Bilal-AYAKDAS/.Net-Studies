using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Ex1
            Console.WriteLine("---region Ex1 Begin---");
            int age = 24;
            if (age < 18)
               Console.WriteLine("You are a minor");
            else if (age >= 18 && age < 65)
                Console.WriteLine("You are an adult");
            else
                Console.WriteLine("You are a senior citizen");

            Console.WriteLine("---region Ex1 End---");
            Console.ReadLine();

            #endregion


            #region Ex2
            Console.WriteLine("---region Ex2 Begin---");
            int sayi = 10;

            Console.WriteLine("sayi++ : " + sayi++);
            Console.WriteLine("sayi : "+sayi);
            
            Console.WriteLine("---------------------");
            Console.WriteLine("++sayi : " + ++sayi);
            Console.WriteLine("sayi : " + sayi);
            
            Console.WriteLine("---------------------");
            Console.WriteLine("sayi-- : "+ sayi--);
            Console.WriteLine("sayi : " + sayi);
         
            Console.WriteLine("---------------------");
            Console.WriteLine("--sayi : "+ --sayi);
            Console.WriteLine("sayi : "+sayi);

            Console.WriteLine("---region Ex2 End---");
            Console.ReadLine();
            #endregion

            #region Ex3

            Console.WriteLine("---region Ex3 Begin ---");
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                default:
                    Console.WriteLine("Unknown number");
                    break;
            }

            Console.WriteLine("---region Ex3 End---");
            Console.ReadLine();
            #endregion

            #region Ex4

            Console.WriteLine("---regionEx4 Begin ---");

            string[] sehirler = new string[3] { "Ankara", "İstanbul", "İzmir" };
            for (int i = 0; i < sehirler.Length; i++)
            {
                Console.WriteLine(sehirler[i]);
            }

            string[] sehirler2 = new string[6];
            for (int i = 0; i < sehirler.Length; i++)
            {
                sehirler2[i] = sehirler[i];
            }
            sehirler = sehirler2;
            sehirler[3] = "Adana";
            sehirler[4] = "Bursa";
            Console.WriteLine("---------------------");
            List<string> iller = new List<string>();
            foreach (var s in sehirler)
            {
                iller.Add(s);
                Console.WriteLine(s);

            }

            Console.WriteLine("---region Ex4 End---");
            Console.ReadLine();

            #endregion

            #region Ex5

            Console.WriteLine("---region Ex5 Begin---");

            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            int k = 0;
            while (k < numbers.Length)
            {
                Console.WriteLine(numbers[k]);
                k++;
            }

            Console.WriteLine("---region Ex5 End---");
            Console.ReadLine();

            #endregion

            #region Ex6

            Console.WriteLine("---region Ex6 Begin---");

            string cumle = "Manisa Celal Bayar Üniversitesi";

            Console.WriteLine("string cumle = "+cumle);

            Console.WriteLine("cumle.Length : "+cumle.Length);

            string cloneCumle = cumle.Clone().ToString();
            Console.WriteLine("cumle.Clone().ToString() : "+cloneCumle);

            Console.WriteLine("cumle.Contains(\"Manisa\") : "+cumle.Contains("Manisa"));

            Console.WriteLine("cumle.IndexOf(\"Celal\") : "+cumle.IndexOf("Celal"));

            Console.WriteLine("cumle.LastIndexOf(\"i\") : "+cumle.LastIndexOf("i")); //Sondan bakmaya başlar

            Console.WriteLine("cumle.Insert(0, \"MCBU \") : "+cumle.Insert(0, "MCBU "));
            
            Console.WriteLine("cumle.Substring(0,6) : " + cumle.Substring(0,6));

            Console.WriteLine("cumle.Remove(0, 6) : " + cumle.Remove(0, 6));

            Console.WriteLine("cumle.Replace(\"Manisa\", \"İzmir\") : " +cumle.Replace("Manisa", "İzmir"));

            Console.WriteLine("cumle.ToLower() : " + cumle.ToLower());

            Console.WriteLine("cumle.ToUpper() : " + cumle.ToUpper());

            Console.WriteLine("cumle.Trim() : " + cumle.Trim());
            #endregion

            Console.ReadLine();

        }
    }
}
