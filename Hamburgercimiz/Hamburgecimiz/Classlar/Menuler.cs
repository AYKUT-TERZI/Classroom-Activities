using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgecimiz.Classlar
{
    public static class Menuler
    {
        public static List<string> MenuAdi { get { return _menulerAdi; } set { } }
        public static List<decimal> MenuFiyati { get { return _menulerFiyat; } set { } }

        static List<string> _menulerAdi = new List<string>() {"Big King Menu", "Double King Chicken Menü", "Steakhouse Menü", "Whooper Menü", "Whooper Jr. Menü", "Chicken Royal Menü" };
        static List<decimal> _menulerFiyat = new List<decimal>() { 50m, 60m, 70m, 75m, 80m, 90m };

        //public static Dictionary<string, decimal> menuler = new Dictionary<string, decimal>();

        /*public static Dictionary<string, decimal> GetMenuler()
        {
            return menuler;
        }*/

        /*public static void GetMenu(string menuAdi, decimal menuFiyati)
        {
            menuler.Add(menuAdi, menuFiyati);
        }*/
               
    }
}
