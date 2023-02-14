using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CokluForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Normal_Form form = new Normal_Form();
            form.Show();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Dialog_Form form = new Dialog_Form();
            form.ShowDialog();
        }
    }
}
