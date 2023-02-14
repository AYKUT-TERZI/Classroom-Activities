using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
          
            form.label5.Text = textBox1.Text;
            form.label6.Text = textBox2.Text;
            double ortalama = Math.Round((double.Parse(txtNot1.Text) + double.Parse(txtNot2.Text) + double.Parse(txtNot3.Text)) / 3, 2);

            form.label7.Text = (ortalama).ToString();

            if(ortalama > 50)
            {
                form.label8.Text = "Geçti";
            }
            else
            {
                form.label8.Text = "Kaldı";
            }


            form.Show();
        }
    }
}
