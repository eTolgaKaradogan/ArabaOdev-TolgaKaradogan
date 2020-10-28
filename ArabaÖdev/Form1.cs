using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaÖdev
{
    public partial class Form1 : Form
    {
        Araba araba;
        string[] cekis = { "Önden Çekiş", "Arkadan İtiş", "Dört Çeker" };
        string[] kapiSayisi = { "İki Kapı", "Dört Kapı", "Beş Kapı" };
        public Form1()
        {
            InitializeComponent();
        }

        private void bKaydet_Click(object sender, EventArgs e)
        {
            araba = new Araba()
            {
                ID = Convert.ToInt32(tbID.Text),
                Marka = tbMarka.Text,
                Model = tbModel.Text,
                KapiSayisi = Convert.ToString(cbKapiSayisi.SelectedItem),
                BeygirGucu = Convert.ToDouble(tbBeygirGucu.Text),
                ArabaTuru = Convert.ToString(rbBinek.Checked),
                MaksimumHiz = Convert.ToDouble(tbMaksimumHiz.Text),
                Cekis = Convert.ToString(cbCekis.SelectedItem),
                SifirdanYuze = Convert.ToDouble(tbSifirdanYuze.Text),
                Agirlik = Convert.ToDouble(tbAgirlik.Text),
                MotorHacmi = Convert.ToDouble(tbMotorHacmi.Text)
            };
            tbID.Clear();
            tbMarka.Clear();
            tbModel.Clear();
            cbKapiSayisi.ResetText();
            tbBeygirGucu.Clear();
            rbBinek.Checked = false;
            rbTicari.Checked = false;
            tbMaksimumHiz.Clear();
            cbCekis.ResetText();
            tbSifirdanYuze.Clear();
            tbAgirlik.Clear();
            tbMotorHacmi.Clear();
        }

        private void bGoster_Click(object sender, EventArgs e)
        {
            rtbSonuc.Text = "ID: " + araba.ID + "\nMarka: " + araba.Marka + "\nModel: " + araba.Model + "\nBeygir Gücü: " + araba.BeygirGucu + " hp";
            if (rbBinek.Checked)
            {
                rtbSonuc.Text += "\nAraba Türü: Binek";
            }
            else
            {
                rtbSonuc.Text += "\nAraba Türü: Ticari";
            }
            rtbSonuc.Text += "\nMaksimum Hız: " + araba.MaksimumHiz + " km/saat\nÇekiş: " + araba.Cekis + "\nSıfırdan Yüze: " + araba.SifirdanYuze + " saniye \nAğırlık: " + araba.Agirlik + " kg \nMotor Hacmi: " + araba.MotorHacmi + " cm3";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCekis.Items.AddRange(cekis);
            cbKapiSayisi.Items.AddRange(kapiSayisi);
        }
    }
}
