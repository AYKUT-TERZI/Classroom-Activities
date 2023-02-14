using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifreZorlukDerecesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 //       1- )Eğer şifre 6 karakterden az ise düşük
 //2-) Eğer şifre 6 karakterden fazla ve sadece tek tip karakter içeriyorsa(harf - sayi - özel karakter) => düşük
 // 3-) Eğer şifre 6 karakterden fazla ve üçlü kombinasyon varsa yüksek
 //  4-) Eğer şifre 6 karakterde fazla ve iki tip karakterden oluşuyorsa(harfSayi - harfOzelKarakter - sayiÖzelKarakter) => orta

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            if (txt1.TextLength < 6)
            {
                lbl2.Text = "Düşük";
            }
            else
            {
                int sayac = 0;
                int sayac1 = 0;
                int sayac2 = 0;
                int sayac3 = 0;

                for (int i=0; i<txt1.TextLength; i++)
                {
                    if (txt1.Text[0] != txt1.Text[i]) sayac++;
                }

                if (sayac == 0)
                {
                    lbl2.Text = "Düşük";
                }
                else
                {
                    foreach (char c in lbl2.Text)
                    {
                        if(((int)c >= 32 && (int)c <= 47) || ((int)c >= 58 && (int)c <= 64))
                        {
                            sayac1++;
                        }

                        if (char.IsDigit(c)) sayac2++;
                        if (char.IsLetter(c)) sayac3++;
                    }

                    if (sayac1 > 0 && sayac2 > 0 && sayac3 > 0) lbl2.Text = "Yüksek";
                    if ((sayac1 == 0 && sayac2 > 0 && sayac3 > 0) || (sayac1 > 0 && sayac2 == 0 && sayac3 > 0) || (sayac1 > 0 && sayac2 > 0 && sayac3 == 0)) lbl2.Text = "Orta";
                }
            }
        }
    }
}
