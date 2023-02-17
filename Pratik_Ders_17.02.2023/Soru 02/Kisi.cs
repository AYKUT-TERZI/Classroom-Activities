using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_02
{
    internal class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public float Boy { get; set; }
        public string Cinsiyet { get; set; }

        public virtual void BilgileriGoster()
        {
            Console.WriteLine("Kişi Bilgileri");
            Console.WriteLine("Adı: " + Ad);
            Console.WriteLine("Soyadı: " + Soyad);
            Console.WriteLine("Boyu: " + Boy);
            Console.WriteLine("Cinsiyeti: " + Cinsiyet);
        }

        public virtual void MesajVer()
        {
            Console.WriteLine("Ben bir insanım.");
        }
    }
}
