using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace DogusODEV1
{
    public partial class Form1 : Form
    {
        private OdemeFactory factory;
        private OdemeIslemcisi islemci;
        private Dictionary<string, string> odemeYontemleriMap = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            factory = new OdemeFactory();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            odemeYontemleriMap.Add("Seçiniz", "Seciniz");
            odemeYontemleriMap.Add("Kredi Kartı", "KrediKarti");
            odemeYontemleriMap.Add("Nakit", "Nakit");
            odemeYontemleriMap.Add("PayPal", "PayPal");

            comboBoxOdemeYontemleri.Items.Add("Seçiniz");
            comboBoxOdemeYontemleri.Items.Add("Kredi Kartı");
            comboBoxOdemeYontemleri.Items.Add("Nakit");
            comboBoxOdemeYontemleri.Items.Add("PayPal");
            comboBoxOdemeYontemleri.SelectedIndex = 0;

            islemci = new OdemeIslemcisi(GetOdemeYontemi());
        }

        private IOdeme GetOdemeYontemi()
        {
            string secilenDisplay = comboBoxOdemeYontemleri.SelectedItem.ToString();
            string secilenYontem = odemeYontemleriMap[secilenDisplay];
            return factory.YeniOdemeOlustur(secilenYontem);
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(textBoxTutar.Text, out decimal tutar))
                {
                    MessageBox.Show("Lütfen geçerli bir tutar giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                IOdeme yeniOdemeYontemi = GetOdemeYontemi();
                islemci.OdemeYontemiDegistir(yeniOdemeYontemi);
                string sonuc = islemci.OdemeYap(tutar);
                MessageBox.Show(sonuc, "Ödeme Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label3.Text = $"{DateTime.Now:HH:mm:ss} - {sonuc}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxOdemeYontemleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            islemci = new OdemeIslemcisi(GetOdemeYontemi());
        }
    }
}