using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hamburgecimiz.Classlar;

namespace Hamburgecimiz
{
    public partial class ParentForm : Form
    {

        public ParentForm()
        {
            InitializeComponent();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {

        }

        
        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisOlusturma f2 = new SiparisOlusturma();
            f2.MdiParent = this;
            f2.Show();
        }

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisBilgileri f3 = new SiparisBilgileri();
            f3.MdiParent = this;
            f3.Show();
        }

        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEkle f4 = new MenuEkle();
            f4.MdiParent = this;
            f4.Show();
        }

        private void ekstraMalzemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EkstraMalzemeEkle f5 = new EkstraMalzemeEkle();
            f5.MdiParent = this;
            f5.Show();
        }
    }
}
