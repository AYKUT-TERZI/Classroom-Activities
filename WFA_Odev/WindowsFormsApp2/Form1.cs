using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string file = @"C:\Users\Ata\Desktop\WFA_Odev\Text.txt";

        public Form1()
        {
            InitializeComponent();

            using (StreamReader reader = new StreamReader(file))
            {
                richTextBox1.Text = reader.ReadToEnd();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var foundIndexes = new List<int>();

            for (int i = richTextBox1.Text.IndexOf(textBox1.Text); i > -1; i = richTextBox1.Text.IndexOf(textBox1.Text, i + 1))
            {
                foundIndexes.Add(i);
            }


            foreach(var item in foundIndexes)
            {
                richTextBox1.Select(item, textBox1.Text.Length);
                richTextBox1.SelectionColor = Color.Red;
            }

        }


    }

}
