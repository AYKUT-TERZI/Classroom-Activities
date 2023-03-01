using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonUygulamasi
{
    public partial class TelefonlariListele : Form
    {
        public List<Phone> telefonlar = new List<Phone>();
        

        public TelefonlariListele()
        {
            InitializeComponent();
        }

        private void TelefonlariListele_Load(object sender, EventArgs e)
        {
            this.telefonlar = TelefonDuzenle.phonelist;

            foreach (Phone phone in telefonlar)
            {
                cmBoxModel.Items.Add(phone.Marka + " " + phone.Model + " " + phone.Yil);
            }
        }

        private void cmBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmBoxModel.SelectedIndex;
            lblMarka.Text = telefonlar[index].Marka;
            lblModel.Text = telefonlar[index].Model;
            lblYil.Text = telefonlar[index].Yil.ToString();
            lblCalimaDurumu.Text = telefonlar[index].Durum.ToString();
    
            TelefonunDurumu durum = telefonlar[index].Durum;

            if (durum==TelefonunDurumu.Satista)
            {
                lblCalimaDurumu.BackColor = Color.Yellow;
            }
            else if (durum == TelefonunDurumu.Kullanimda)
            {
                lblCalimaDurumu.BackColor = Color.Green;
            }
            else
            {
                lblCalimaDurumu.BackColor = Color.Red;
            }

        }
    }
}
