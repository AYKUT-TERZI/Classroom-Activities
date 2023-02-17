using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string kucukHarf = "abcdefghijklmnopqrstuvwxyz";
        string buyukHarf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string rakam = "0123456789";
        string ozelKarakter = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";

        StringBuilder sb = new StringBuilder();
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < nmrcUpDownSifreSayisi.Value; j++)
            {
                while(sb.Length <= nmrcUpDownSifreUzunlugu.Value)
                {
                    int secim = rnd.Next(1, 5);

                    switch (secim)
                    {
                        case 1:
                            if (chkBoxKucukHarf.Checked == true)
                            {
                                int index = rnd.Next(kucukHarf.Length);
                                sb.Append(kucukHarf[index]);
                            }
                            break;
                        case 2:
                            if (chkBoxBuyukHarf.Checked == true)
                            {
                                int index = rnd.Next(buyukHarf.Length);
                                sb.Append(buyukHarf[index]); 
                            }
                            break;
                        case 3:
                            if (chkBoxRakam.Checked == true)
                            {
                                int index = rnd.Next(rakam.Length);
                                sb.Append(rakam[index]);
                            }
                            break;
                        case 4:
                            if (chkBoxOzelKarakter.Checked == true)
                            {
                                int index = rnd.Next(ozelKarakter.Length);
                                sb.Append(ozelKarakter[index]);
                            }
                            break;
                        default:
                            break;
                    }
                }

                lstBox.Items.Add($"{j+1})     " + sb.ToString());
                sb.Clear();
            }    
        }
    }
}
