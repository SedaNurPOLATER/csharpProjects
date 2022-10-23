using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace harf_notu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double puan = Convert.ToDouble(tbPuan.Text);
            if (puan < 0 || puan > 100)
            {
                MessageBox.Show("[0-100] aralığında puan girebilirsiniz.");
                return;
            }

            if (puan >= 90)
                lbHarfNotu.Text = "AA";
            else if (puan >= 80)
                lbHarfNotu.Text = "BA";
            else if (puan >= 70)
                lbHarfNotu.Text = "BB";
            else if (puan >= 60)
                lbHarfNotu.Text = "CB";
            else if (puan >= 53)
                lbHarfNotu.Text = "CC";
            else if (puan >= 48)
                lbHarfNotu.Text = "DC";
            else if (puan >= 40)
                lbHarfNotu.Text = "DD";
            else if (puan >= 30)
                lbHarfNotu.Text = "FD";
            else
                lbHarfNotu.Text = "FF";
        }
    }
}
