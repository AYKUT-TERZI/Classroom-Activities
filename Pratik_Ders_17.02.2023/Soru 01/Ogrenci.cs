using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_01
{
    internal class Ogrenci : Insan
    {
        public string Hobi { get; set; }

        public void BilgileriYazdir()
        {
            Console.WriteLine("Ogrenci adi: " + Ad);
            Console.WriteLine("Ogrenci soyad " + Soyad);
            Console.WriteLine("Ogrenci yası " + Yas);
            Console.WriteLine("Ogencinin hobisi " + Hobi);
        }

	}
}
