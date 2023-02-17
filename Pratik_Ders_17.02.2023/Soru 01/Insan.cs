using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_01
{
    internal class Insan
    {
        private string _ad;

        public string Ad
        {
            get { return "Sayın "+_ad; }
            set { _ad = value; }
        }


        public string Soyad { get; set; }

        private int _yas;
        public int Yas
        {
            get { return _yas; }
            set
            {
                if (value < 18)
                {
                    _yas = 18;
                }
                else if (value > 26)
                {
                    _yas = value + 3;
                }
                else
                {
                    _yas = value;
                }
            }
        }
    }
}
