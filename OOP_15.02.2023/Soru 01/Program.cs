using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aykut aykut = new Aykut();

            aykut.Ad = "Aykut";
            aykut.Soyad = "Terzi";
            aykut.Yas = 33;
            aykut.DogumTarihi = Convert.ToDateTime("08.07.1989");
            aykut.TamirYapabiliyorMu = true;
            aykut.BildigiDiller = new List<string> { "Türkçe", "İngilizce", "Almanca", "Fransızca", "Japonca" };
            aykut.BildigiProgramlamaDilleri = new List<string> { "C#", "Python" };
            aykut.EhliyetTipi = "B";
            aykut.CalabildigiEnstrumanlar = "Org";
            aykut.BugunkuMesleginiz = "Yıldız Yazılımcı";
            aykut.MedeniHali = "Bekar";

            Console.WriteLine("Ad: " + aykut.Ad);
            Console.WriteLine("Soyad: " + aykut.Soyad);
            Console.WriteLine("Yas: " + aykut.Yas);
            Console.WriteLine("Dogum Tarihi: " + aykut.DogumTarihi.ToShortDateString());
            Console.WriteLine("Tamir yapabiliyor mu?: " + aykut.TamirYapabiliyorMu);
            Console.WriteLine("Bildiği diller: ");
            foreach (string item in aykut.BildigiDiller)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Bildiği programlama dilleri: ");
            foreach (string item in aykut.BildigiProgramlamaDilleri)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Çalabildiği enstrümanlar: " + aykut.CalabildigiEnstrumanlar);
            Console.WriteLine("Bugünkü mesleği: " + aykut.BugunkuMesleginiz);
            Console.WriteLine("Medeni hali: " + aykut.MedeniHali);

            Aykut.Topla();

            Console.ReadKey();

        }
    }
}
