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
            Ogrenci ogrenci = new Ogrenci();

            ogrenci.Ad = "Aykut";
            ogrenci.Soyad = "Terzi";
            ogrenci.SetTcKimlikNo(575382790501);
            ogrenci.SetOgrenciNo(1621);


            Console.WriteLine("TC Kimlik No: " + ogrenci.GetTcKimlikNo());
            Console.WriteLine("Ogrenci No: "+ ogrenci.GetOgrenciNo());


            Console.ReadKey();
        }
    }
}
