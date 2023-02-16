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
            Console.WriteLine("Lütfen kullanıcı adınızı giriniz.");
            Parola parola = new Parola();

            parola.KullaniciAdi = Console.ReadLine();


            Console.ReadKey();
        }
    }
}
