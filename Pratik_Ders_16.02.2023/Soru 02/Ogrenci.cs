using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_02
{
    internal class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        private long TcKimlikNo;

        private int OgrenciNo;

        public void SetTcKimlikNo(long no)
        {
            if(no>10000000000 && no<=99999999999)
            {
                TcKimlikNo = no;
            }
            else
            {
                Console.WriteLine("TC kimlik no 11 haneli olmalıdır.");

            }
        }

        public string GetTcKimlikNo()
        {
            if (TcKimlikNo == 0)
            {
                return "Hatalı giriş yaptınız.";
            }
            else
            {
                return TcKimlikNo.ToString();
            }
        }

        public void SetOgrenciNo(int no)
        {
            if(no>= 100 && no<=999)
            {
                this.OgrenciNo = no;
            }
            else
            {
                Console.WriteLine("Ogrenci no 3 haneli olmalıdır.");
            }
        }

        public string GetOgrenciNo()
        {
            if (OgrenciNo == 0)
            {
                return "Hatalı giriş yaptınız.";
            }
            else
            {
                return OgrenciNo.ToString();
            }
            
        }

    }
}
