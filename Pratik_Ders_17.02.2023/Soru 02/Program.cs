using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi = new Kisi();
            kisi.Ad = "Aykut";
            kisi.Soyad = "Bektaş";
            kisi.Boy = 1.74f;
            kisi.Cinsiyet = "Erkek";

            kisi.BilgileriGoster();
            kisi.MesajVer();
            Console.WriteLine();

            Ogrenci o1 = new Ogrenci();
            o1.Ad = "Mustafa";
            o1.Soyad = "Terzi";
            o1.Boy = 1.69f;
            o1.Cinsiyet = "Erkek";
            o1.BilgileriGoster();
            o1.MesajVer();
            Console.WriteLine();

            Ogrenci o2 = new Ogrenci();
            o2.Ad = "Sıla";
            o2.Soyad = "Şahin";
            o2.Boy = 1.65f;
            o2.Cinsiyet = "Kadın";
            o2.BilgileriGoster();
            o2.MesajVer();
            Console.WriteLine();

            DaliOlanOgrenci o3 = new DaliOlanOgrenci();
            o3.Ad = "Egemen";
            o3.Soyad = "Ergü";
            o3.Boy = 1.73f;
            o3.Cinsiyet = "Erkek";
            o3.BilgileriGoster();
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
