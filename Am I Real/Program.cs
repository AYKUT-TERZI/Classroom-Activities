using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmIReal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi = new Kisi();

            BasaDon:

            Console.WriteLine("Lütfen Adınızı Giriniz.");
            kisi.Ad = Console.ReadLine();
            
            Console.WriteLine("Lütfen Soyad Giriniz.");
            kisi.Soyad = Console.ReadLine();
            
            Console.WriteLine("Lütfen Doğum Yılı Giriniz.");
            kisi.DogumYili = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Lütfen TcNo Giriniz.");
            kisi.TcNo = long.Parse(Console.ReadLine());

            bool durum;

            try
            {
                using (KimlikDogrula.KPSPublicSoapClient service = new KimlikDogrula.KPSPublicSoapClient { })
                {
                    durum = service.TCKimlikNoDogrula(kisi.TcNo, kisi.Ad, kisi.Soyad, kisi.DogumYili);
                }
            }
            catch (Exception)
            {
                throw;
            }
            if (durum == true)
            {
                Console.WriteLine("Girmiş olduğunuz bilgiler DOĞRUDUR");
            }
            else
            {
                Console.WriteLine("Girmiş olduğunuz bilgiler YANLIŞTIR");
            }
            goto BasaDon;

        }

        class Kisi
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int DogumYili { get; set; }
            public long TcNo { get; set; }

            


        }
    }
}
