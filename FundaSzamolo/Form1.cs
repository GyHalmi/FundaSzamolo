using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundaSzamolo
{
    public partial class Form1 : Form
    {
        DateTime KEZDET = new DateTime(2018,10,14);
        DateTime vizsgalt;
        public Form1()
        {
            InitializeComponent();
            txtKezdet.Text = idotKiir(KEZDET);
            txtKezdet.ReadOnly = true;
            txtKezdet.TextAlign = HorizontalAlignment.Center;
            
            vizsgalt = DateTime.Now;
            txtVizsgalt.Text = idotKiir(vizsgalt);
            txtVizsgalt.TextAlign = HorizontalAlignment.Center;
      
            eredmenyTxtFormaz();
            
        }

        private void eredmenyTxtFormaz()
        {
            List<TextBox> txtk = new List<TextBox> { txtHonapok, txtBefiz, txtTamogat, txtMegtakarit };
            foreach (var txt in txtk)
            {
                txt.TextAlign = HorizontalAlignment.Right;
                txt.ReadOnly = true;
            }
        }

        private string idotKiir(DateTime ido)
        {
            return ido.ToString("yyyy. MM. dd.");
        }

        private void szamol()
        {
            int BEFIZ = 20000;
            int TAMOGAT = 6000;
            int SZERZODESEKSZAMA = 3;

            int honapok = (vizsgalt.Year - KEZDET.Year) * 12 + vizsgalt.Month-KEZDET.Month;
            txtHonapok.Text = honapok.ToString();

            string formatum = "C";
            int szamoltBefiz = BEFIZ * honapok * SZERZODESEKSZAMA;
            txtBefiz.Text = szamoltBefiz.ToString(formatum);
            int szamoltTamogat = TAMOGAT * honapok * SZERZODESEKSZAMA;
            txtTamogat.Text =  szamoltTamogat.ToString(formatum);
            txtMegtakarit.Text = (szamoltBefiz + szamoltTamogat).ToString(formatum);
        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            vizsgalt= DateTime.Parse(txtVizsgalt.Text); 
            szamol();
        }
    }
}
