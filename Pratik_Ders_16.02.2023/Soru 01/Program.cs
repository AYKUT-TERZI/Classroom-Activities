using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kebapci kebapci = new Kebapci();

            kebapci.SetIsim("Aspava");
            Console.WriteLine(kebapci.GetIsim());

            Ayrac();

            Console.ReadKey();
        }

        private static void Ayrac()
        {
            Console.WriteLine(new String('*', 5));
        }
    }
}
