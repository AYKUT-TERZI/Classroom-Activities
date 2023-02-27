using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Hamburgecimiz.Classlar
{
    internal class Fonksiyonlar
    {
        public static void GetMenuAdi(ComboBox cb)
        {
            foreach (var item in Menuler.MenuAdi)
            {
                cb.Items.Add(item);
            }
        }

        public static void GetSosAdi(FlowLayoutPanel flp)
        {
            foreach (var item in Ekstra.SosAdi)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = item;
                flp.Controls.Add(checkBox);
            }
        }

        public static decimal GetBoy(GroupBox gb)
        {
            decimal boyGeliri = 0m;
            foreach (RadioButton item in gb.Controls)
            {
                if (item.Checked)
                {
                    if (item.Text == "Küçük")
                    {
                        boyGeliri = Convert.ToDecimal(EnumClass.Boyut.Kucuk);
                    }
                    else if (item.Text == "Orta")
                    {
                        boyGeliri = Convert.ToDecimal(EnumClass.Boyut.Orta);
                    }
                    else
                    {
                        boyGeliri = Convert.ToDecimal(EnumClass.Boyut.Buyuk);
                    }
                }
            }
            return boyGeliri;
        }

        public static decimal GetSos(FlowLayoutPanel flp)
        {
            decimal sosGeliri = 0m;
            foreach (CheckBox item in flp.Controls)
            {
                if (item.Checked)
                {
                    int index = Ekstra.SosAdi.IndexOf(item.Text);
                    sosGeliri += Ekstra.SosFiyati[index];
                    index = 0;
                }
            }

            return sosGeliri;
        }

        public static void SetDefault(ComboBox cb, RadioButton rb, FlowLayoutPanel flp, NumericUpDown nmrc)
        {
            cb.SelectedIndex = 0;
            rb.Checked = true;
            foreach (CheckBox item in flp.Controls)
            {
                item.Checked = false;
            }
            nmrc.Value = 1;
            cb.Focus();
        }

        public static void SetList(ComboBox cb, GroupBox gb, NumericUpDown nmrc, FlowLayoutPanel flp, ListBox lb)
        {
            string siparisBilgisi = "Hamburgercimiz, " + DateTime.Now.ToString() + "; ";

            int index = cb.SelectedIndex;

            siparisBilgisi += Menuler.MenuAdi[index] + ", ";

            foreach (RadioButton item in gb.Controls)
            {
                if (item.Checked)
                {
                    siparisBilgisi += item.Text + ", Boy X " + nmrc.Value.ToString();
                }
            }

            siparisBilgisi += " + (";

            foreach (CheckBox item in flp.Controls)
            {
                if (item.Checked)
                {
                    siparisBilgisi += item.Text + ", ";
                }
            }

            string siparisBilgisi2 = siparisBilgisi.Trim().Trim(',');

            siparisBilgisi2 += ")";

            lb.Items.Add(siparisBilgisi2);
           
        }

        public static decimal GetMenuFiyati(ComboBox cb)
        {
            return Menuler.MenuFiyati[cb.SelectedIndex];
        }
  
    }
}
