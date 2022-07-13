using System;
using System.Collections.Generic;

namespace Patika_DEVAlgoritma2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("INTEGER İKİLİLERİ KONSOLU");
            Console.WriteLine("Kaç tane ikili girmek istediğinizi seçiniz: ");
            a1:
            int secim = int.Parse(Console.ReadLine());
            if (secim % 2 == 0)
            {
                for (int i = 0; i < secim; i++)
                {
                    Console.Write((i + 1) + ". Sayıyı giriniz: ");
                    int sayi1 = int.Parse(Console.ReadLine());
                    i++;
                    Console.Write((i + 1) + ". Sayıyı giriniz: ");
                    int sayi2 = int.Parse(Console.ReadLine());
                    List<int> sayilar = new List<int>();


                    sayilar.Add(sayi1);
                    sayilar.Add(sayi2);
                    int toplama = sayilar[0] + sayilar[1];

                    if (sayi1 == sayi2)
                    {
                        int toplam = sayi1 + sayi2;
                        int sonuc = toplam * toplam;
                        Console.Write("Sayılar aynı toplanıp kareleri alınıyor.\n Sonuc: {0}", sonuc);
                        Console.WriteLine();
                        continue;
                    }
                    Console.WriteLine("Sayılar farklı toplamları: {0} ", toplama);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Girilen sayı tektir lütfen çift bir sayı girerek tekrar deneyiniz.");
                goto a1;
            }
        }
    }
}
