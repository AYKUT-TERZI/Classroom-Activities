using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Firin firin1 = new Firin();

            firin1.Marka = "Beko";
            firin1.Fiyat = 10000;
            firin1.Guc = 1000;
            firin1.Model = "FM 320 SF";
            firin1.GarantiSuresi = 3;
            firin1.GarantiVarMi = true;
            firin1.MaxDerecesi = 250;

            Console.WriteLine("Marka: " + firin1.Marka);
            Console.WriteLine("Fiyat: " + firin1.Fiyat);
            Console.WriteLine("Guc: " + firin1.Guc);
            Console.WriteLine("Model: " + firin1.Model);
            Console.WriteLine("Garanti Süresi: " + firin1.GarantiSuresi);
            Console.WriteLine("Garanti var mi?: " + firin1.GarantiVarMi);
            Console.WriteLine("Max Derecesi: " + firin1.MaxDerecesi);
            Console.WriteLine();

            Firin firin2 = new Firin();

            firin2.Marka = "Arçelik";
            firin2.Fiyat = 4000;
            firin2.Guc = 250;
            firin2.Model = "MF 30 QBB";
            firin2.GarantiSuresi = 2;
            firin2.GarantiVarMi = true;
            firin2.MaxDerecesi = 170;

            Console.WriteLine("Marka: " + firin2.Marka);
            Console.WriteLine("Fiyat: " + firin2.Fiyat);
            Console.WriteLine("Guc: " + firin2.Guc);
            Console.WriteLine("Model: " + firin2.Model);
            Console.WriteLine("Garanti Süresi: " + firin2.GarantiSuresi);
            Console.WriteLine("Garanti var mi?: " + firin2.GarantiVarMi);
            Console.WriteLine("Max Derecesi: " + firin2.MaxDerecesi);
            Console.WriteLine();

            firin1.GarantiSuresiUzat();

            Console.WriteLine(firin1.Marka + " " + firin1.Model + " " + "Garanti Süresi: " + firin1.GarantiSuresi);

            Console.ReadKey();
        }
    }
}
