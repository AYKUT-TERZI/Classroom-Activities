using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        
        private void rchTxt1_TextChanged(object sender, EventArgs e)
        {
            lbl1.Text = (rchTxt1.MaxLength-rchTxt1.Text.Length).ToString();
            lbl1.ForeColor = Color.FromArgb(rchTxt1.Text.Length, 0, 0);
        }


    }
}
