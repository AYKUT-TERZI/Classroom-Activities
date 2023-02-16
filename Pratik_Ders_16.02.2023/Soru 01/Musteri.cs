using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_01
{
    internal class Musteri
    {

        private string Ad;

        public string GetIsim()
        {
            return Ad;
        }

        public void SetIsim(string ad)
        {
            this.Ad = ad;
        }
    }
}
