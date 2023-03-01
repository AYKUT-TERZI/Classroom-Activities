using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonUygulamasi
{
    public partial class TelefonDuzenle : Form
    {

        public static List<Phone> phonelist = new List<Phone>();

        public void SetDefault()
        {
            txtBoxMarka.Clear();
            txtBoxModel.Clear();
            txtBoxYil.Clear();
            rdBtnSatista.Checked = true;
        }

        public void Sil()
        {
            int index = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(index);
            phonelist.RemoveAt(index);
        }


        public TelefonDuzenle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string Marka = txtBoxMarka.Text;
            string Model = txtBoxModel.Text;
            int Yil = int.Parse(txtBoxYil.Text);
            TelefonunDurumu Durum = TelefonunDurumu.Satista;

            foreach (RadioButton item in groupBox1.Controls)
            {
                if (item.Checked)
                {
                    if (item.Text == "Satışta") Durum = TelefonunDurumu.Satista;
                    else if (item.Text == "Kullanımda") Durum = TelefonunDurumu.Kullanimda;
                    else Durum = TelefonunDurumu.Hurda;
                }
            }
            Phone telefon = new Phone(Marka,Model,Yil,Durum);
            phonelist.Add(telefon);
            listBox1.Items.Add(telefon.Marka + " | " + telefon.Model + " | " + telefon.Yil + " | " + telefon.Durum);

            SetDefault();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string Marka = txtBoxMarka.Text;
            string Model = txtBoxModel.Text;
            int Yil = int.Parse(txtBoxYil.Text); 
            TelefonunDurumu Durum = TelefonunDurumu.Satista;

            foreach (RadioButton item in groupBox1.Controls)
            {
                if (item.Checked)
                {
                    if (item.Text == "Satışta") Durum = TelefonunDurumu.Satista;
                    else if (item.Text == "Kullanımda") Durum = TelefonunDurumu.Kullanimda;
                    else Durum = TelefonunDurumu.Hurda;
                }
            }

            Phone telefon = phonelist[listBox1.SelectedIndex];
            
            telefon.Marka = Marka;
            telefon.Model = Model;
            telefon.Yil = Yil;
            telefon.Durum = Durum;

            phonelist[listBox1.SelectedIndex] = telefon;

            listBox1.Items.Clear();

            foreach (Phone item in phonelist)
            {
                listBox1.Items.Add(item.Marka + " | " + item.Model + " | " + item.Yil + " | " + item.Durum);
            }

        }

        private void TelefonDuzenle_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Phone item in phonelist)
            {
                listBox1.Items.Add(item.Marka + " | " + item.Model + " | " + item.Yil + " | " + item.Durum);
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
