using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_04
{
    internal class Urun
    {
        private decimal _fiyat;

        public decimal Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        }

        public decimal KdvliFiyat
        {
            get { return _fiyat * 1.18m; }
        }


    }
}
