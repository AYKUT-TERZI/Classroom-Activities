using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Toplama toplama = new Toplama();

            Console.WriteLine("Lütfen 1. sayıyı giriniz.");
            toplama.Sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2. sayıyı giriniz.");
            toplama.Sayi2 = int.Parse(Console.ReadLine());

            toplama.Toplam();

            Console.WriteLine(toplama.Sonuc);

            Console.ReadKey();
        }
    }
}
