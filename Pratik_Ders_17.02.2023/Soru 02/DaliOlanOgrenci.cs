using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_02
{
    internal class DaliOlanOgrenci : Ogrenci
    {
        public override void BilgileriGoster()
        {
            Console.WriteLine("Dalı Olan Öğrenci Bilgileri");
            Console.WriteLine("Adı: " + Ad);
            Console.WriteLine("Soyadı: " + Soyad);
            Console.WriteLine("Boyu: " + Boy);
            Console.WriteLine("Cinsiyeti: " + Cinsiyet);
        }
    }
}
