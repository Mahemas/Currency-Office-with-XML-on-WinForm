using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace Doviz_Ofisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);

            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lblDA.Text = dolaralis;

            string dolarsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lblDS.Text = dolarsatis;

            string euroalis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lblEA.Text = euroalis;

            string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lblES.Text = eurosatis;
        }

        private void btnDA_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblDA.Text;
        }

        private void bntDS_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblDS.Text;

        }

        private void btnEA_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblEA.Text;
        }

        private void btnES_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblES.Text;
        }

        private void btnIslem1_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar;
            kur= Convert.ToDouble(txtKur.Text);
            miktar = Convert.ToDouble(txtMiktar.Text);
            tutar = kur * miktar;
            txtTutar.Text = tutar.ToString();
        }

        private void txtKur_TextChanged(object sender, EventArgs e)
        {
            txtKur.Text = txtKur.Text.Replace(".", ","); //Nokta gördüğü yerlere virgül basacak
        }

        private void btnIslem2_Click(object sender, EventArgs e)
        {
            double kur = Convert.ToDouble(txtKur.Text);
            int miktar = Convert.ToInt32(txtMiktar.Text);
            int tutar = Convert.ToInt32(miktar / kur);
            txtTutar.Text = tutar.ToString();
            double kalan;
            kalan = miktar % kur;
            txtKalan.Text = kalan.ToString();
        }
    }
}
