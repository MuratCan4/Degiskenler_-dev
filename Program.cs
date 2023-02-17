// See https://aka.ms/new-console-template for more information
using System;

namespace degiskenler
{
class Program
{
    static void Main (string[] args)
    {
        int yas = 28;
        string isim = "Murat";
        string soy_isim = "CAN";
        string tam_isim = isim + " " + soy_isim;
        Console.WriteLine("İsim = " + tam_isim + "\n" +"Yas = " + yas);

        DateTime dt = DateTime.Now;
        Console.WriteLine("Tarih ve Saat = " + dt);

        string dt2 = DateTime.Now.ToString("dd.MM.yyy");
        Console.WriteLine("Tarih = " + dt2);

        int sayi1 = 14;
        int sayi2 = 22;
        int toplam = sayi1 + sayi2;

        Console.WriteLine("Toplam Sayi = " +toplam);
        
    }
}

}