using Hamburgecimiz.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgecimiz
{
    public partial class EkstraMalzemeEkle : Form
    {
        public EkstraMalzemeEkle()
        {
            InitializeComponent();
        }

        private void btnEkstraMalzemeyiKaydet_Click(object sender, EventArgs e)
        {
            if (txtBoxEkstraMalzemeAdi.Text == "")
            {
                MessageBox.Show("Lütfen geçerli bir malzeme adı giriniz.");
            }
            else
            {
                Ekstra.SosAdi.Add(txtBoxEkstraMalzemeAdi.Text);
                Ekstra.SosFiyati.Add(nmrUpDownFiyat.Value);

                MessageBox.Show("Ekstra malzemeniz eklendi.");
            }


        }

        private void EkstraMalzemeEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
