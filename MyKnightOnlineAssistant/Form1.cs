using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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

                double pus, sonuc, coinsTutar;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxActivity.SelectedIndex = 0;
        }


        private void cbxActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxActivity.SelectedIndex == 0)
            {
                tbxExp.Focus();
                lblMob.Text = "Dakikada Kesilen Mob Sayısı:";
                tbxExp.Text = "";
                tbxMob.Text = "";
                tbxTotalExp.Text = "";
                tbxMob.Enabled = true;
            }
            if (cbxActivity.SelectedIndex == 1)
            {
                tbxExp.Focus();
                lblMob.Text = "Dakikada Kaç Defa Exp Alıyorsun:";
                tbxExp.Text = "";
                tbxMob.Text = " 4";
                tbxTotalExp.Text = "";
                tbxMob.Enabled = false;
            }
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            if (cbxActivity.SelectedIndex == 0)
            {
                if (tbxExp.Text == "" && tbxMob.Text == "")
                {
                    MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz.");
                    tbxExp.Focus();
                }
                else if (tbxExp.Text == "")
                {
                    MessageBox.Show("Lütfen Gelen Exp Miktarını Yazınız.");
                    tbxExp.Focus();
                }
                else if (tbxMob.Text == "")
                {
                    MessageBox.Show("Lütfen Dakikada Kesilen Mob Sayısını Yazınız.");
                    tbxMob.Focus();
                }
                else
                {
                    ExpCalcMethod();
                }

            }
            else
            {
                if (tbxExp.Text == "")
                {
                    MessageBox.Show("Lütfen Gelen Exp Miktarını Yazınız.");
                    tbxExp.Focus();
                }
                else
                {
                    ExpCalcMethod();
                }
            }

        }




        private void ExpCalcMethod()
        {
            double totalExp = 0;
            double lvlExp,exp, mob, daysExp,daysYuzde,hourYuzde;
            exp = Convert.ToDouble(tbxExp.Text);
            mob = Convert.ToDouble(tbxMob.Text);
            lvlExp = Convert.ToDouble(tbxLvlExp.Text);
            daysExp = mob * 1440 * exp;            
            totalExp = daysExp;
            tbxTotalExp.Text = totalExp.ToString("0,000");
            //24 saatte % kaç exp alıcaz
            daysYuzde = daysExp * 100 / lvlExp;
            tbxTotalExpYuzde.Text = daysYuzde.ToString("00.##") +" %";
            //saatlik % kaç exp alıcaz
            hourYuzde =(totalExp/24)*100/lvlExp;
            tbxSaatlikExp.Text = hourYuzde.ToString("00.##") + " %";

        }

    }
}
//100   1596
//x     xacaca
//4317589248

