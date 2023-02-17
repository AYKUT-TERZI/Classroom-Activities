using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_02
{
    internal class Ogrenci : Kisi
    {
        public override void MesajVer()
        {
            Console.WriteLine("Ben bir öğrenciyim.");
        }

        public override void BilgileriGoster()
        {
            Console.WriteLine("Öğrenci Bilgileri");
            Console.WriteLine("Adı: " + Ad);
            Console.WriteLine("Soyadı: " + Soyad);
            Console.WriteLine("Boyu: " + Boy);
            Console.WriteLine("Cinsiyeti: " + Cinsiyet);
        }
    
    }
}
