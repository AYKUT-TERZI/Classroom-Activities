using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgecimiz.Classlar
{
    public static class Ekstra
    {
        public static List<string> SosAdi { get { return _sosAdi; } set { } }

        public static List<decimal> SosFiyati { get { return _sosFiyati; } set { } }

        static List<string> _sosAdi = new List<string>() { "Ketçap", "Mayonez", "Hardal" };
        static List<decimal> _sosFiyati = new List<decimal>() { 2m, 2m, 3m };
    }
}
