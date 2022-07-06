using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bilet.Resources.Personelİslemleri
{
    public partial class PersonelIslemForm : Form
    {
        public AnaEkran ae = new AnaEkran();
        public List<string> PList = new List<string>();
        string kisi;

        public PersonelIslemForm()
        {
            InitializeComponent();
        }
        private void PersonelİslemForm_Load(object sender, EventArgs e)
        {
            YetkiGetir();
            PListGetir();

            PersonelIslemTopPanel.Size = new Size(Width, 80);
            PersonelIslemBottomPanel.Size = new Size(Width, Height - 125);

            PersonelGB.Location = new Point(0, 0);
        }
        public void YetkiGetir()
        {
            ae.con.Open();

            string sorgu = "Select * from Yetkiler";
            SqlCommand yetki = new SqlCommand(sorgu, ae.con);
            SqlDataReader yetkioku = yetki.ExecuteReader();

            PYetkiCB.Items.Clear();
            PYetkiCB.Items.Add("");

            while (yetkioku.Read())
            {
                PYetkiCB.Items.Add(yetkioku["YetkiAd"]);
            }

            ae.con.Close();
        }
        public void PListGetir()
        {
            PersonelList.Items.Clear();

            ae.con.Open();

            string sorgu = "Select * from Personeller";
            SqlCommand Pgetir = new SqlCommand(sorgu, ae.con);
            SqlDataReader Pgetiroku = Pgetir.ExecuteReader();

            while (Pgetiroku.Read())
            {
                kisi = Pgetiroku["KullaniciAdi"].ToString();
                PList.Add(kisi);

                foreach (string kisi in PList)
                {
                    if (!PersonelList.Items.Contains(kisi))
                    {
                        PersonelList.Items.Add(kisi);
                    }
                }
            }
            ae.con.Close();
        }
        public void PGetir()
        {
            ae.con.Open();

            string sorgu = "Select * from Personeller where KullaniciAdi='" + PersonelList.SelectedItem + "'";
            SqlCommand PGetir = new SqlCommand(sorgu, ae.con);
            SqlDataReader POku = PGetir.ExecuteReader();

            if (POku.Read())
            {
                PYetkiCB.SelectedIndex = Convert.ToInt32(POku["YetkiId"]);
                PKullaniciAdTxt.Text = POku["KullaniciAdi"].ToString();
                PAdTxt.Text = POku["Ad"].ToString();
                PSoyadTxt.Text = POku["Soyad"].ToString();
                PTCTxt.Text = POku["TCKimlik"].ToString();
                PSifreTxt.Text = POku["Sifre"].ToString();
                PMaasTxt.Text = POku["Maas"].ToString();
            }

            ae.con.Close();
        }
        private void PDuzenleTxt_Click(object sender, EventArgs e)
        {
            if (PersonelList.SelectedItem != null)
            {

                if (PAdTxt.Text != "" && PSoyadTxt.Text != "" && PTCTxt.Text != "" && PSifreTxt.Text != "" && PYetkiCB.SelectedIndex != 0 && PMaasTxt.Text != "")
                {
                    ae.con.Open();

                    string sorgu = "Update Personeller set KullaniciAdi='" + PKullaniciAdTxt.Text + "', Sifre='" + PSifreTxt.Text + "',  YetkiId='" + PYetkiCB.SelectedIndex + "', Ad='" + PAdTxt.Text + "', Soyad='" + PSoyadTxt.Text + "', TCKimlik='" + PTCTxt.Text + "', Maas='" + Convert.ToInt32(PMaasTxt.Text) + "' where KullaniciAdi= '" + PersonelList.SelectedItem + "' ";
                    SqlCommand PDuzenle = new SqlCommand(sorgu, ae.con);
                    PDuzenle.ExecuteNonQuery();

                    ae.con.Close();
                    MessageBox.Show("Personel Bilgileri Düzenlendi.");

                    PListGetir();
                    PKullaniciAdTxt.Clear();
                    PAdTxt.Clear();
                    PSoyadTxt.Clear();
                    PTCTxt.Clear();
                    PSifreTxt.Clear();
                    PYetkiCB.SelectedIndex = -1;
                    PMaasTxt.Clear();
                }
                else
                {
                    MessageBox.Show("Bilgi Eksiği Mevcut.");
                }
            }
            else
            {
                MessageBox.Show("Önce Personel Seçiniz.");
            }
        }
        private void PEkleBtn_Click_1(object sender, EventArgs e)
        {
            if (PAdTxt.Text != "" && PSoyadTxt.Text != "" && PTCTxt.Text != "" && PSifreTxt.Text != "" && PYetkiCB.SelectedItem.ToString() != "" && PMaasTxt.Text != "")
            {
                ae.con.Open();

                SqlCommand PEkle = new();
                PEkle.Connection = ae.con;
                PEkle.CommandType = CommandType.StoredProcedure;
                PEkle.CommandText = "PersonelEkle";
                PEkle.Parameters.Add("KullaniciAdi", SqlDbType.NVarChar, 200).Value = PKullaniciAdTxt.Text;
                PEkle.Parameters.Add("Sifre", SqlDbType.NVarChar, 5).Value = PSifreTxt.Text;
                PEkle.Parameters.Add("YetkiId", SqlDbType.Int).Value = PYetkiCB.SelectedIndex;
                PEkle.Parameters.Add("Ad", SqlDbType.NVarChar, 200).Value = PAdTxt.Text;
                PEkle.Parameters.Add("Soyad", SqlDbType.NVarChar, 200).Value = PSoyadTxt.Text;
                PEkle.Parameters.Add("TCKimlik", SqlDbType.NVarChar, 11).Value = PTCTxt.Text;
                PEkle.Parameters.Add("Maas", SqlDbType.Int).Value = Convert.ToInt32(PMaasTxt.Text);
                PEkle.Parameters.Add("Durum", SqlDbType.Bit).Value = 1;
                PEkle.ExecuteNonQuery();

                ae.con.Close();
                MessageBox.Show("Personel ekleme Başarılı.");

                PListGetir();
                PKullaniciAdTxt.Clear();
                PAdTxt.Clear();
                PSoyadTxt.Clear();
                PTCTxt.Clear();
                PSifreTxt.Clear();
                PYetkiCB.SelectedIndex = -1;
                PMaasTxt.Clear();
            }
            else
            {
                MessageBox.Show("Personel Ekleme Başarısız. Eksik Bilgi Girmiş Olabilirsiniz.");
            }
        }
        private void PSilTxt_Click(object sender, EventArgs e)
        {
            DialogResult Psilkontrol = new DialogResult();
            Psilkontrol = MessageBox.Show("Personel Silinsin Mi?", "Personel Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Psilkontrol == DialogResult.Yes)
            {
                ae.con.Open();

                SqlCommand PSil = new();
                PSil.Connection = ae.con;
                PSil.CommandType = CommandType.StoredProcedure;
                PSil.CommandText = "PersonelSil";
                PSil.Parameters.Add("TCKimlik", SqlDbType.NVarChar, 11).Value = PTCTxt.Text;
                PSil.ExecuteNonQuery();

                ae.con.Close();

                PKullaniciAdTxt.Clear();
                PAdTxt.Clear();
                PSoyadTxt.Clear();
                PTCTxt.Clear();
                PSifreTxt.Clear();
                PYetkiCB.SelectedIndex = -1;
                PMaasTxt.Clear();
                MessageBox.Show("Personel Silme Başarılı.");
                PListGetir();
            }
            else
            {
                MessageBox.Show("Personel Silme İptal Edildi.");
            }
        }
        private void PAraTxt_TextChanged(object sender, EventArgs e)
        {
            if (PAraTxt.Text == "")
            {
                PListGetir();
            }
            List<string> list = new List<string>();

            foreach (string item in PersonelList.Items)
            {
                list.Add(item);
            }

            PersonelList.Items.Clear();

            foreach (string kisi in list)
            {
                if (kisi.Contains(PAraTxt.Text))
                {
                    PersonelList.Items.Add(kisi);
                }
            }
        }
        private void PersonelList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PGetir();
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            PKullaniciAdTxt.Clear();
            PAdTxt.Clear();
            PSoyadTxt.Clear();
            PTCTxt.Clear();
            PSifreTxt.Clear();
            PYetkiCB.SelectedIndex = -1;
            PMaasTxt.Clear();
        }
    }
}
