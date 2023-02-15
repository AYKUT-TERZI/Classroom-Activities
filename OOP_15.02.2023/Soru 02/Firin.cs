using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_02
{
    internal class Firin
    {
        public Firin()
        {
            Console.WriteLine("Fırın oluşturuldu.");
        }

        public string Marka { get; set; }
        public decimal Fiyat { get; set; }
        public double Guc { get; set; }
        public string Model { get; set; }
        public int GarantiSuresi { get; set; }
        public bool GarantiVarMi { get; set; }
        public int MaxDerecesi { get; set; }

        public void GarantiSuresiUzat()
        {
            GarantiSuresi++;
            Console.WriteLine("Garanti süreniz 1 yıl uzatıldı.");
        }

    }
}
