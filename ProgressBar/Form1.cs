using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.ForeColor = Color.Red;
            progressBar2.ForeColor = Color.Blue;
            progressBar3.ForeColor = Color.Black;
            progressBar4.ForeColor = Color.Yellow;
            progressBar1.Value = 30;
            progressBar2.Value = 60;
            progressBar3.Value = 50;
            progressBar4.Value = 75;
        }
    }
}
