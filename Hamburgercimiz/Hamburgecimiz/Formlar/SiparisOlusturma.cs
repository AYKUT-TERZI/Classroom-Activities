using Hamburgecimiz.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgecimiz
{
    public partial class SiparisOlusturma : Form
    {

        #region Properties
        public static decimal toplamFiyat { get; set; } = 0;
        public static int toplamSiparisSayisi { get; set; } = 0;
        public static decimal ekstraMalzeme { get; set; } = 0;
        public static int toplamUrunSayisi { get; set; } = 0;
        public static List<string> list = new List<string>();

        #endregion


        public SiparisOlusturma()
        {
            InitializeComponent();

            Fonksiyonlar.GetMenuAdi(comboBox1);
            Fonksiyonlar.GetSosAdi(flowLayoutPanel1);
            Fonksiyonlar.SetDefault(comboBox1, rdBtnKucuk, flowLayoutPanel1, nmrcUpDownAdet);
            nmrcUpDownAdet.Minimum = 1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        decimal toplamTutar = 0m;
        decimal toplamSos = 0m;
        int toplamUrun = 0;

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            toplamTutar += Fonksiyonlar.GetMenuFiyati(comboBox1) * nmrcUpDownAdet.Value;
            toplamTutar += Fonksiyonlar.GetBoy(grpBoxBoyut) * nmrcUpDownAdet.Value;
            toplamTutar += Fonksiyonlar.GetSos(flowLayoutPanel1) * nmrcUpDownAdet.Value;
            toplamSos += Fonksiyonlar.GetSos(flowLayoutPanel1) * nmrcUpDownAdet.Value;
            toplamUrun += Convert.ToInt32(nmrcUpDownAdet.Value);
            

            lblTutar.Text = toplamTutar.ToString() + " TL";

            Fonksiyonlar.SetList(comboBox1, grpBoxBoyut, nmrcUpDownAdet, flowLayoutPanel1, lstBoxSiparisler);
            Fonksiyonlar.SetDefault(comboBox1, rdBtnKucuk, flowLayoutPanel1, nmrcUpDownAdet);
        }

        private void SiparisOlusturma_Load(object sender, EventArgs e)
        {
     
        }
        
        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();

            dr = MessageBox.Show("Siparişi iptal etmek isterseniz iptal tuşuna basın. Siparişi tamamlamak ister misiniz?","Dikkat", MessageBoxButtons.YesNoCancel);

            if(dr == DialogResult.Yes)
            {
                toplamFiyat += toplamTutar;
                toplamSiparisSayisi += lstBoxSiparisler.Items.Count;
                ekstraMalzeme += toplamSos;
                toplamUrunSayisi += toplamUrun;

                foreach (string item in lstBoxSiparisler.Items)
                {
                    list.Add(item);
                }
                
                SiparisBilgileri form = new SiparisBilgileri();

                form.MdiParent = ParentForm;
                form.Show();
                
            }
            else if(dr == DialogResult.Cancel)
            {
                lstBoxSiparisler.Items.Clear();
                Fonksiyonlar.SetDefault(comboBox1, rdBtnKucuk, flowLayoutPanel1, nmrcUpDownAdet);
                toplamTutar = 0;
                lblTutar.Text = "0 TL";
            }
            else
            {

            }
        }
    }
}
