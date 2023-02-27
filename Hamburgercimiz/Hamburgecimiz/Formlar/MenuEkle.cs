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
    public partial class MenuEkle : Form
    {
        public MenuEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuyuKaydet_Click(object sender, EventArgs e)
        {
            if (txtBoxMenuAdi.Text == "")
            {
                MessageBox.Show("Geçerli bir ad giriniz.");
            }
            else
            {
                Menuler.MenuAdi.Add(txtBoxMenuAdi.Text);
                Menuler.MenuFiyati.Add(nmrUpDownFiyat.Value);

                MessageBox.Show("Menünüz eklendi.");
            }
        }

        private void MenuEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
