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
    public partial class UyeIslemForm : Form
    {
        public AnaEkran ae = new AnaEkran();
        int KartNo;
        public UyeIslemForm()
        {
            InitializeComponent();
        }
        private void UyeIslemForm_Load(object sender, EventArgs e)
        {
            UyeListGetir();
        }
        private void UEkleBtn_Click(object sender, EventArgs e)
        {
            if (UAdTxt.Text != "" && USoyadTxt.Text != "" && UKullaniciAdTxt.Text != "" && USifreTxt.Text != "" && UMailTxt.Text != "")
            {
                ae.con.Open();

                SqlCommand UEkle = new();
                UEkle.Connection = ae.con;
                UEkle.CommandType = CommandType.StoredProcedure;
                UEkle.CommandText = "UyeEkle";
                UEkle.Parameters.Add("KullaniciAdi", SqlDbType.NVarChar, 200).Value = UKullaniciAdTxt.Text;
                UEkle.Parameters.Add("Sifre", SqlDbType.NVarChar, 5).Value = USifreTxt.Text;
                UEkle.Parameters.Add("YetkiId", SqlDbType.Int).Value = 5;
                UEkle.Parameters.Add("Ad", SqlDbType.NVarChar, 200).Value = UAdTxt.Text;
                UEkle.Parameters.Add("Soyad", SqlDbType.NVarChar, 200).Value = USoyadTxt.Text;
                UEkle.Parameters.Add("Mail", SqlDbType.NVarChar, 200).Value = UMailTxt.Text;        
                UEkle.Parameters.Add("Durum", SqlDbType.Bit).Value = 1;
                UEkle.ExecuteNonQuery();

                ae.con.Close();
                MessageBox.Show("Üye Ekleme Başarılı.");

                UyeListGetir();
                UKullaniciAdTxt.Clear();
                USoyadTxt.Clear();
                UAdTxt.Clear();
                USifreTxt.Clear();
                UMailTxt.Clear();
            }
            else
            {
                MessageBox.Show("Üye Ekleme Başarısız. Eksik Bilgi Girmiş Olabilirsiniz.");
            }
        }
        private void USilTxt_Click(object sender, EventArgs e)
        {
            DialogResult Usilkontrol = new DialogResult();
            Usilkontrol = MessageBox.Show("Üye Silinsin Mi?", "Üye Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Usilkontrol == DialogResult.Yes)
            {
                ae.con.Open();

                SqlCommand PSil = new();
                PSil.Connection = ae.con;
                PSil.CommandType = CommandType.StoredProcedure;
                PSil.CommandText = "UyeSil";
                PSil.Parameters.Add("KullaniciAdi", SqlDbType.NVarChar, 200).Value = UKullaniciAdTxt.Text;
                PSil.ExecuteNonQuery();

                ae.con.Close();

                UKullaniciAdTxt.Clear();
                USoyadTxt.Clear();
                UAdTxt.Clear();
                USifreTxt.Clear();
                UMailTxt.Clear();
                MessageBox.Show("Üye Silme Başarılı.");

            }
            else
            {
                MessageBox.Show("Üye Silme İptal Edildi.");
            }
            UyeListGetir();
        }
        private void UDuzenleBtn_Click(object sender, EventArgs e)
        {
            if (UyeList.SelectedItem != null)
            {

                if (UAdTxt.Text != "" && USoyadTxt.Text != "" && UKullaniciAdTxt.Text != "" && USifreTxt.Text != "" && UMailTxt.Text != "")
                {
                    ae.con.Open();

                    string sorgu = "Update Uyeler set KullaniciAdi='" + UKullaniciAdTxt.Text + "',  Sifre='" + USifreTxt.Text + "', Ad='" + UAdTxt.Text + "', Soyad='" + USoyadTxt.Text + "', Mail='" + UMailTxt.Text + "' where KullaniciAdi='" + UyeList.SelectedItem + "' ";
                    SqlCommand PDuzenle = new SqlCommand(sorgu, ae.con);
                    PDuzenle.ExecuteNonQuery();

                    ae.con.Close();
                    MessageBox.Show("Üye Bilgileri Düzenlendi.");

                    UyeListGetir();
                    UKullaniciAdTxt.Clear();
                    USoyadTxt.Clear();
                    UAdTxt.Clear();
                    USifreTxt.Clear();
                    UMailTxt.Clear();
                }
                else
                {
                    MessageBox.Show("Bilgi Eksiği Mevcut.");
                }
            }
            else
            {
                MessageBox.Show("Önce Üye Seçiniz.");
            }
        }
        private void UAraTxt_TextChanged(object sender, EventArgs e)
        {
            if (UAraTxt.Text == "")
            {
                UyeListGetir();
            }
            List<string> list = new List<string>();

            foreach (string item in UyeList.Items)
            {
                list.Add(item);
            }

            UyeList.Items.Clear();

            foreach (string kisi in list)
            {
                if (kisi.Contains(UAraTxt.Text))
                {
                    UyeList.Items.Add(kisi);
                }
            }
        }
        public void UyeListGetir()
        {
            UyeList.Items.Clear();

            ae.con.Open();

            string sorgu = "Select * from Uyeler";
            SqlCommand UGetir = new SqlCommand(sorgu, ae.con);
            SqlDataReader UOku = UGetir.ExecuteReader();

            while (UOku.Read())
            {

                if (!UyeList.Items.Contains(UOku["KullaniciAdi"]))
                {
                    UyeList.Items.Add(UOku["KullaniciAdi"]);
                }

            }
            ae.con.Close();
        }
        public void UyeGetir()
        {
            ae.con.Open();

            string sorgu = "Select * from Uyeler where KullaniciAdi = '" + UyeList.SelectedItem + "'";
            SqlCommand UGetir = new SqlCommand(sorgu, ae.con);
            SqlDataReader UOku = UGetir.ExecuteReader();

            if (UOku.Read())
            {
                if (UyeList.SelectedItem.ToString() == UOku["KullaniciAdi"].ToString() || UyeList.SelectedItem.ToString() == UOku["Ad"].ToString() || UyeList.SelectedItem.ToString() == UOku["Soyad"].ToString())
                {
                    UKullaniciAdTxt.Text = UOku["KullaniciAdi"].ToString();
                    USifreTxt.Text = UOku["Sifre"].ToString();
                    UAdTxt.Text = UOku["Ad"].ToString();
                    USoyadTxt.Text = UOku["Soyad"].ToString();
                    UMailTxt.Text = UOku["Mail"].ToString();
                }
            }

            ae.con.Close();
        }
        private void UyeList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            UyeGetir();
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            UKullaniciAdTxt.Clear();
            USoyadTxt.Clear();
            UAdTxt.Clear();
            USifreTxt.Clear();
            UMailTxt.Clear();
        }
    }
}
