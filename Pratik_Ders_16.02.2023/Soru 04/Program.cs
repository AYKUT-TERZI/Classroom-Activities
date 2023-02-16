using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun = new Urun();

            Console.WriteLine("Lütfen ürünün fiyatını giriniz.");

            urun.Fiyat = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ürünün fiyatı: " + urun.Fiyat);
            Console.WriteLine("Ürünün KDV'li fiyatı " + urun.KdvliFiyat);


            Console.ReadKey();
        }
    }
}
