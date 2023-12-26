using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hipotenüs_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double kenar1, kenar2, sonuc;

            kenar1 = Convert.ToSingle(txtKenar1.Text);
            kenar2 = Convert.ToSingle(txtKenar1.Text);
            sonuc = Math.Sqrt((Math.Pow(kenar1, 2) + Math.Pow(kenar2, 2)));

            lblSonuc.Text = sonuc.ToString();
        }
    }
}
