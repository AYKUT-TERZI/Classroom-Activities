using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciAdiSifre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt1.Text == "aykut" && txt2.Text == "123")
            {
                Form2 form = new Form2();
                form.label1.Text = "Hoşgeldiniz" + " " + txt1.Text;
                form.Show();

                Hide();

            }
        }
    }
}
