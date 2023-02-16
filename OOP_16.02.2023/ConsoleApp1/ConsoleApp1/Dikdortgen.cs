using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dikdortgen
    {
        private double Solx { get; set; }
        private double Soly { get; set; }
        private double Sagx { get; set; }
        private double Sagy { get; set; }

        public Dikdortgen(double a, double b, double c, double d)
        {
            Solx = a;
            Soly = b;
            Sagx = c;
            Sagy = d;
        }

        public void Yaz()
        {
            Console.WriteLine($"Sol Üst ({Solx},{Soly}) Sağ Alt: ({Sagx},{Sagy})");
        }

        public void SetSolUst(double a, double b)
        {
            Solx = a;
            Soly = b;
        }

        public void setSagAlt(double a, double b)
        {
            Sagx = a;
            Sagy = b;
        }

        public double GetBoy()
        {
            return Math.Abs(Soly - Sagy);
        }

        public double GetEn()
        {
            return Math.Abs(Sagx - Solx);
        }

        public double GetAlan()
        {
            return GetEn() * GetBoy();
        }

        public double GetCevre()
        {
            return 2 * (GetBoy() + GetEn());
        }

        public Dikdortgen BuyukOlan(Dikdortgen other)
        {
            return this.GetAlan() > b.GetAlan() ? this : other;
        }

        public void KareYap()
        {
            if (GetEn() > GetBoy())
            {
                Sagx = Solx + GetBoy();
            }
            else
            {
                Sagy = Soly - GetEn();
            }
        }
    }
}
