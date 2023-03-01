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
    public partial class MyPhone : Form
    {
        public MyPhone()
        {
            InitializeComponent();
        }

        private void telefonlarıDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelefonDuzenle f2 = new TelefonDuzenle();
            f2.MdiParent = this;
            f2.Show();
        }

        private void telefonlarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelefonlariListele f3 = new TelefonlariListele();
            f3.MdiParent = this;
            f3.Show();
        }

        private void MyPhone_Load(object sender, EventArgs e)
        {

        }
    }
}
