using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonUygulamasi
{
    public class Phone
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }

        public TelefonunDurumu Durum { get; set; }

        public Phone(string Marka,string Model, int Yil,TelefonunDurumu Durum)
        {
            this.Marka = Marka;
            this.Model = Model;
            this.Yil = Yil;
            this.Durum = Durum;

        }
    }
}
