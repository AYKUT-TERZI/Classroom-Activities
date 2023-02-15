using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_03
{
    internal class Toplama
    {
        public int Sayi1 { get; set; }
        public int Sayi2 { get; set; }
        
        public void Toplam()
        {
            Console.WriteLine("Bu iki sayının toplamı: " + (Sayi1 + Sayi2));
        }
    }
}
