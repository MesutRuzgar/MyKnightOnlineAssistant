using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKnightOnlineAssistant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPus_Click(object sender, EventArgs e)
        {
            if (tbx400npoint.Text == "" && tbxGb.Text == "" && tbxPus.Text == "")
            {

                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz.");
                tbx400npoint.Focus();
            }
            else if (tbx400npoint.Text == "")
            {
                MessageBox.Show("Lütfen 400 NPOİNT'in TL Karşılığını Giriniz.");
                tbx400npoint.Focus();
            }
            else if (tbxGb.Text == "")
            {
                MessageBox.Show("Lütfen  Gold Bar Alış Fiyatını Giriniz.");
                tbxGb.Focus();
            }
            else if (tbxPus.Text == "")
            {

                MessageBox.Show("Lütfen Hesaplanacak NPOİNT Miktarını Giriniz.");
                tbxPus.Focus();
            }
            else
            {

                double pus, sonuc,coinsTutar;
                int gbTl, calcPus;
                calcPus = Convert.ToInt32(tbxPus.Text);
                pus = Convert.ToDouble(tbx400npoint.Text);
                gbTl = Convert.ToInt32(tbxGb.Text);
                sonuc = pus / 400 * calcPus / gbTl * 100000;
                coinsTutar = sonuc;
                tbxCoins.Text = coinsTutar.ToString("N3").Replace(".", ",");

            }

        }

        private void btnTax_Click(object sender, EventArgs e)
        {
            if (tbxSell.Text == "")
            {
                MessageBox.Show("Lütfen Satmak İstediğiniz Tutarı Giriniz.");
                tbxSell.Focus();
            }
            else
            {
                double coin, vergi, sonuc;
                coin = Convert.ToDouble(tbxSell.Text);
                vergi = coin * 0.03;
                tbxTax.Text = vergi.ToString("0,000").Replace(".", ",");
                sonuc = coin - vergi;
                tbxNetCoins.Text = sonuc.ToString("0,000").Replace(".", ",");
            }
        }

    
    }
}
