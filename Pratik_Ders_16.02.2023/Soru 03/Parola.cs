using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_03
{
    internal class Parola
    {
        private string _kullaniciAdi;

        public string KullaniciAdi
        {
            get 
            { 
                return _kullaniciAdi; 
            }
            set 
            { 
                if(value == "Admin")
                {
                    Console.WriteLine("Hoşgeldin Admin");
                    _kullaniciAdi = value;
                }
                else
                {
                    Console.WriteLine("Admin kullanici değilsiniz.");
                }
                 
            }
        }

    }
}
