using Ders26.Models;
using Ders26.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders26
{
    public partial class Form2 : Form
    {
        ListView listViewForm2;
        public Form2(ListView listView)
        {
            InitializeComponent();
            listViewForm2 = listView;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbBoxUrunTipi.SelectedItem.ToString() == "Gida")
            {
                Urun urun = new Gida();
                UrunListViewEkle(listViewForm2, UrunOlusturEkle(urun));
            }
            else if (cmbBoxUrunTipi.SelectedItem.ToString() == "Giyim")
            {
                Urun urun = new Giyim();
                UrunListViewEkle(listViewForm2, UrunOlusturEkle(urun));
            }
            else if (cmbBoxUrunTipi.SelectedItem.ToString() == "Hijyen")
            {
                Urun urun = new Hijyen();
                UrunListViewEkle(listViewForm2, UrunOlusturEkle(urun));
            }
            else if (cmbBoxUrunTipi.SelectedItem.ToString() == "Kirtasiye")
            {
                Urun urun = new Kirtasiye();
                UrunListViewEkle(listViewForm2, UrunOlusturEkle(urun));
            }
            else if (cmbBoxUrunTipi.SelectedItem.ToString() == "Makyaj")
            {
                Urun urun = new Makyaj();
                UrunListViewEkle(listViewForm2, UrunOlusturEkle(urun));
            }
            else if (cmbBoxUrunTipi.SelectedItem.ToString() == "Teknoloji")
            {
                Urun urun = new Teknoloji();
                UrunListViewEkle(listViewForm2, UrunOlusturEkle(urun));
            }

            this.Close();
        }

        private void UrunListViewEkle(ListView listViewForm2, Urun urun)
        {

            ListViewItem listViewItem = new ListViewItem(urun.Id.ToString());
            listViewItem.SubItems.Add(urun.Ismi.ToString());
            listViewItem.SubItems.Add(urun.Fiyat.ToString());
            listViewItem.SubItems.Add(urun.Adet.ToString());

            listViewForm2.Items.Add(listViewItem);
        }

        private Urun UrunOlusturEkle(Urun urun)
        {
            urun.Id = Convert.ToInt32(txtBoxUrunId.Text);
            urun.Ismi = txtBoxUrunIsmi.Text;
            urun.Fiyat = Convert.ToDecimal(txtBoxUrunFiyati.Text);
            urun.Adet = Convert.ToInt32(nmrUdUrunAdeti.Text);
            AlisverisServisi.urunListesi.Add(urun);

            return urun;
        }
    }
}
