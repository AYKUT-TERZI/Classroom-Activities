using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_01
{
    internal class Kebapci
    {
        public string Ad { get; set; }

        public string GetIsim()
        {
            if(Ad == "Aspava")
            {
                Console.WriteLine("Girilen isim aynıdır.");
            }
            else
            {
                Console.WriteLine("İsimler farklıdır.");
            }

            return Ad;
        }

        public void SetIsim(string ad)
        {
            this.Ad = ad;
        }

      

    }
}
