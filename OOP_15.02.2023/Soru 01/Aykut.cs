using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_01
{
    internal class Aykut
    {
        public static void Topla()
        {

        }
        public Aykut()
        {
            Console.WriteLine("Ben OOP'ye başladım.");
        }

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool TamirYapabiliyorMu { get; set; }
        public List<string> BildigiDiller { get; set; }
        public List<string> BildigiProgramlamaDilleri { get; set; }
        public string EhliyetTipi { get; set; }
        public string CalabildigiEnstrumanlar { get; set; }
        public string BugunkuMesleginiz { get; set; }
        public string MedeniHali { get; set; }

    }
}
