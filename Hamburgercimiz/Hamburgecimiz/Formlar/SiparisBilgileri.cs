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
    public partial class SiparisBilgileri : Form
    {
        public SiparisBilgileri()
        {
            InitializeComponent();
        }

        private void SiparisBilgileri_Load(object sender, EventArgs e)
        {
            lblCiro.Text = SiparisOlusturma.toplamFiyat.ToString() + " TL";
            lblToplamSiparisSayisi.Text = SiparisOlusturma.toplamSiparisSayisi.ToString();
            lblEkstraMalzemeGeliri.Text = SiparisOlusturma.ekstraMalzeme.ToString() + " TL";
            lblSatilanUrunAdedi.Text = SiparisOlusturma.toplamUrunSayisi.ToString();

            foreach (var item in SiparisOlusturma.list)
            {
                lstBoxTumSiparisler.Items.Add(item);
            }

        }
    }
}
