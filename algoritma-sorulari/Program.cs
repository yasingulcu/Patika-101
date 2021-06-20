using System;

namespace algoritma_sorulari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru 1

            // Console.WriteLine("**********Çift Sayıları Ekrana Yazdırma********");
            // Console.Write("Lütfen bir sayi giriniz: ");
            // int n = int.Parse(Console.ReadLine());
            // int[] sayiDizisi = new int[n];

            // for (int i = 0; i < n; i++)
            // {
            //     Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
            //     sayiDizisi[i] = int.Parse(Console.ReadLine());
            // }
            // foreach(var item in sayiDizisi)
            // {
            //     if(item%2==0)
            //     {
            //         Console.WriteLine("Girdiğiniz {0} sayısı çift sayıdır.",item);
            //     }
            // }

            //Soru 2

            // Console.WriteLine("**********Tam Bölünenleri Ekrana Yazdırma********");
            // Console.Write("Lütfen bir sayi giriniz: ");
            // int n = int.Parse(Console.ReadLine());
            // int[] sayiDizisi = new int[n];
            // Console.Write("Lütfen bir sayi giriniz: ");
            // int m=int.Parse(Console.ReadLine());
            // for (int i = 0; i < n; i++)
            // {
            //     Console.Write("Lütfen {0}. sayıyı giriniz: ", i + 1);
            //     sayiDizisi[i] = int.Parse(Console.ReadLine());
            // }
            // foreach(var item in sayiDizisi)
            // {
            //     if(item==m || item%m==0)
            //     {
            //        Console.WriteLine("Girdiğiniz {0} sayısı {1} eşit yada tam bölünüyor.", item, m);
            //     }
            // }

            //Soru 3

            // Console.WriteLine("**********Kelimeleri Sondan Başa Yazdırma********");
            // Console.Write("Lütfen bir sayi giriniz: ");
            // int n = int.Parse(Console.ReadLine());
            // string[] kelimeDizisi = new string[n];

            // for (int i = 0; i < n; i++)
            // {
            //     Console.Write("Lütfen {0}. kelimeyi giriniz: ", i + 1);
            //     kelimeDizisi[i] = Console.ReadLine();
            // }
            // Array.Reverse(kelimeDizisi);

            // foreach (var item in kelimeDizisi)
            // {
            //     Console.WriteLine(item);
            // }

            //Soru 4
            
            // Console.WriteLine("***** Harf ve Kelimele Sayısını Yazdır *****");
            // Console.Write("Bir cümle girin: ");
            // string cümle = Console.ReadLine();
            // int kelime = 0;
            // int harf = 0;
            // foreach (char c in cümle)
            // {
            //     if (c == ' ')
            //     {
            //         kelime++;
            //     }
            //     else
            //     {
            //         harf++;
            //     }
            // }
            // Console.WriteLine("Girdiğinizi cümlede {0} adet harf ve {1} adet kelime var.", harf, kelime + 1);
        }
    }
}
