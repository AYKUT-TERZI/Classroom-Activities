using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();

            Console.WriteLine("Lütfen öğrencinin adını giriniz.");
            ogrenci.Ad = Console.ReadLine();
            Console.WriteLine("Lütfen öğrencinin soyadını giriniz.");
            ogrenci.Soyad = Console.ReadLine();
            Console.WriteLine("Lütfen öğrencinin yaşını giriniz.");
            ogrenci.Yas = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen öğrencinin hobisini giriniz.");
            ogrenci.Hobi = Console.ReadLine();

            ogrenci.BilgileriYazdir();

            Console.ReadKey();
        }
    }
}
