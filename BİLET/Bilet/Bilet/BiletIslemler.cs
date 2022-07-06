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

namespace Bilet
{
    public partial class BiletIslemleri : Form
    {
        AnaEkran ae = new AnaEkran();
        public int j = 1, k = 1, x = 0, y = 0, EIdGelen, EIdGelen2, BSId, sirakoltuksayisi, koltuksirasi, toplam = 0, yetki, fiyat, IdSayisi, biletsayisi, Adet;
        int[,] koltuklar;
        string[] skoltuklar;
        string[] ekoltuklar;
        List<string> ksecim = new List<string>();
        List<string> gelen = new List<string>();
        List<Button> ButtonList = new List<Button>();
        Button Buton;
        public string mekan, salon, kullaniciad, SASoyad, SAAd, secilenkoltuklar = "", secim;

        private void CikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public BiletIslemleri()
        {
            InitializeComponent();
            CikanLbl.Visible = false;
        }
        private void BiletIslemleri_Load(object sender, EventArgs e)
        {
            BiletTopPanel.Size = new Size(Width, 160);
            BiletBottomPanel.Size = new Size(Width, Height - 160);
            KoltukPanel.Size = new Size(BiletBottomPanel.Width, BiletBottomPanel.Height - 520);
            BilgiPanel.Size = new Size(BiletBottomPanel.Width, 520);
            label1.Location = new Point(BiletTopPanel.Width / 2, BiletTopPanel.Height / 2);

            KoltuklarLbl.Text = "";

            EBilgiGetir(EIdGelen);
            EBilgiGetir(EIdGelen2);

            KoltukOlustur();

            if (yetki == 5)
            {
                SAAdTxt.Enabled = false;
                SASoyadTxt.Enabled = false;
                BiletBilgiGetir(EIdGelen2);
            }
        }
        public void EBilgiGetir(int EId)
        {
            ae.con.Open();

            string sorgu = $"Select * from Etkinlikler where Id={EId} ";

            SqlCommand etkinlik = new SqlCommand(sorgu, ae.con);
            SqlDataReader etkinlikoku = etkinlik.ExecuteReader();

            if (etkinlikoku.Read())
            {
                EIdGelen = Convert.ToInt32(etkinlikoku["Id"]);

                EtkinlikAdLbl.Text = "Etkinlik Adı: " + etkinlikoku["Ad"].ToString();
                ETarihLbl.Text = "Etkinlik Tarihi: " + etkinlikoku["Tarih"].ToString();
                mekan = etkinlikoku["Mekan"].ToString();
                salon = etkinlikoku["Salon"].ToString();
                biletsayisi = Convert.ToInt32(etkinlikoku["BiletSayisi"]);
                fiyat = Convert.ToInt32(etkinlikoku["BiletFiyat"]);
                EMekanLbl.Text = "Etkinliğin Yapılacağı Yer: \n" + mekan + "\n " + salon;
                BFiyatLbl.Text = "Bilet Fiyatı: " + fiyat.ToString();
                ToplamLbl.Text = toplam.ToString();
            }

            ae.con.Close();
        }
        public void SalonBilgisi()
        {
            ae.con.Open();

            string sorgu = $"select * from Salonlar where MekanAdi='{mekan}' and SalonAdi='{salon}'";
            SqlCommand SGetir = new SqlCommand(sorgu, ae.con);
            SqlDataReader SOku = SGetir.ExecuteReader();

            if (SOku.Read())
            {
                koltuksirasi = Convert.ToInt32(SOku["KoltukSirasi"]);
                sirakoltuksayisi = Convert.ToInt32(SOku["SiradakiKoltukSayisi"]);
            }

            ae.con.Close();
        }
        private Button AddNewButton(string ButtonName)
        {
        go:
            if (j <= sirakoltuksayisi * k)
            {
                Buton = new()
                {
                    Location = new Point(10 + x, 10 + y),
                    BackColor = Color.FromArgb(107, 107, 107),
                    ForeColor = Color.WhiteSmoke,
                    Size = new Size(50, 50),
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    FlatStyle = FlatStyle.Popup,
                    BackgroundImage = Properties.Resources.koltuk,
                    Text = j.ToString(),
                    Name = "0",
                    TextAlign = ContentAlignment.MiddleCenter,

                };

                Buton.Click += Buton_Click;

                j++;
                x += 55;
                KoltukPanel.Controls.Add(Buton);
                ButtonList.Add(Buton);
                return Buton;
            }
            k++;
            x = 0;
            y += 55;
            goto go;
            KoltukPanel.Controls.Add(Buton);
            ButtonList.Add(Buton);
            return Buton;
        }
        private void Buton_Click(object sender, EventArgs e)
        {
            KoltuklarLbl.Text = "";

            foreach (var button in KoltukPanel.Controls.OfType<Button>())
            {
                if ((sender as Button).Text == button.Text)
                {
                    if ((sender as Button).Name == "0")
                    {
                        DialogResult koltuksec = new DialogResult();
                        koltuksec = MessageBox.Show("Koltuk Eklensin Mi?", "Koltuk Seçme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (koltuksec == DialogResult.Yes)
                        {
                            ksecim.Add((sender as Button).Text);

                            for (int j = 0; j < ksecim.Count; j++)
                            {
                                KoltuklarLbl.Text += ksecim[j] + " - ";
                                secilenkoltuklar = KoltuklarLbl.Text;
                                (sender as Button).BackgroundImage = Properties.Resources.sarı_koltuk;
                            }

                            AdetNUD.Value += 1;
                            toplam += Convert.ToInt32(fiyat);
                            ToplamLbl.Text = "Toplam: " + toplam.ToString();
                            button.Name = "1";

                            MessageBox.Show("Koltuk Seçimi Başarılı");
                        }
                        else
                        {
                            MessageBox.Show("Koltuk Seçimi İptal Edildi.");
                        }
                    }
                    else if ((sender as Button).Name == "1")
                    {
                        DialogResult koltukver = new DialogResult();
                        koltukver = MessageBox.Show("Koltuk Geri Verilsin Mi?", "Koltuk Geri Verme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (koltukver == DialogResult.Yes)
                        {
                            ksecim.Remove((sender as Button).Text);

                            for (int i = 0; i < ksecim.Count; i++)
                            {
                                KoltuklarLbl.Text += ksecim[i] + "-";
                                secilenkoltuklar = KoltuklarLbl.Text;
                            }

                            (sender as Button).BackgroundImage = Properties.Resources.koltuk;
                            AdetNUD.Value -= 1;
                            toplam += Convert.ToInt32(fiyat);
                            ToplamLbl.Text = "Toplam: " + toplam.ToString();
                            button.Name = "0";
                            MessageBox.Show("Koltuk Geri Verme Başarılı");
                        }
                        else
                        {
                            MessageBox.Show("Koltuk Geri Verme İptal Edildi.");
                        }
                    }
                    else if ((sender as Button).Name == "2")
                    {
                        DialogResult koltukiadesec = new DialogResult();
                        koltukiadesec = MessageBox.Show("Koltuk Iadeye Seçilsin Mi?", "Koltuk Iade İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (koltukiadesec == DialogResult.Yes)
                        {
                            ksecim.Add((sender as Button).Text);

                            for (int i = 0; i < ksecim.Count; i++)
                            {
                                KoltuklarLbl.Text += ksecim[i];
                                (sender as Button).BackgroundImage = Properties.Resources.sarı_koltuk;
                                (sender as Button).Name = "1";
                            }
                            AdetNUD.Value -= 1;
                            toplam -= Convert.ToInt32(fiyat);
                            ToplamLbl.Text = "Toplam: " + toplam.ToString();
                            MessageBox.Show("Koltuk Geri Verme Başarılı");
                        }
                        else
                        {
                            MessageBox.Show("Koltuk Geri Verme İptal Edildi.");
                        }
                    }
                }
            }
        }
        public void KoltukOlustur()
        {
            SalonBilgisi();
            koltuklar = new int[koltuksirasi, sirakoltuksayisi];

            for (int i = 1; i <= koltuklar.Length; i++)
            {
                string ButtonName = "Koltuk" + i;
                AddNewButton(ButtonName);
            }

            #region AlinanKoltukGöster

            ae.con.Open();

            string sorgu2 = $"Select AlinanKoltuklar from BiletSatis where EtkinlikId= {EIdGelen}";
            SqlCommand egetir = new SqlCommand(sorgu2, ae.con);
            SqlDataReader eoku = egetir.ExecuteReader();

            while (eoku.Read())
            {
                string alinmislar = eoku["AlinanKoltuklar"].ToString();
                ekoltuklar = alinmislar.Split(" - ");
                for (int i = 0; i < ekoltuklar.Length; i++)
                {
                    gelen.Add(ekoltuklar[i]);
                }
            }
            if (biletsayisi != 0)
            {
                foreach (var item in gelen)
                {
                    KoltuklarLbl.Text += item + " ";

                    foreach (var button in KoltukPanel.Controls.OfType<Button>())
                    {
                        if (button.Text == item)
                        {
                            button.BackgroundImage = Properties.Resources.yeşil_koltuk;
                        }
                    }
                }
            }
            else
            {
                foreach (var button in KoltukPanel.Controls.OfType<Button>())
                {
                    button.BackgroundImage = Properties.Resources.yeşil_koltuk;
                    button.Enabled = false;
                }
                MessageBox.Show("Bu Etkinlikteki Tüm Biletler Satılmıştır.");
            }
            ae.con.Close();

            #endregion     
        }
        private void BiletAlBtn_Click(object sender, EventArgs e)
        {
            if (KoltuklarLbl.Text != "")
            {
                foreach (var button in KoltukPanel.Controls.OfType<Button>())
                {
                    if (button.Name == "1")
                    {
                        button.BackgroundImage = Properties.Resources.yeşil_koltuk;
                        button.Name = "2";
                    }
                }
                ae.con.Open();

                SqlCommand BiletSat = new();
                BiletSat.Connection = ae.con;
                BiletSat.CommandType = CommandType.StoredProcedure;
                BiletSat.CommandText = "BiletSatisSP";
                BiletSat.Parameters.Add("EtkinlikId", SqlDbType.Int).Value = Convert.ToInt32(EIdGelen);
                if (yetki == 5)
                {
                    BiletSat.Parameters.Add("SatinAlanAd", SqlDbType.NVarChar, 200).Value = SAAd;
                    BiletSat.Parameters.Add("SatinAlanSoyad", SqlDbType.NVarChar, 200).Value = SASoyad;
                }
                else
                {
                    BiletSat.Parameters.Add("SatinAlanAd", SqlDbType.NVarChar, 200).Value = SAAdTxt.Text;
                    BiletSat.Parameters.Add("SatinAlanSoyad", SqlDbType.NVarChar, 200).Value = SASoyadTxt.Text;
                }
                BiletSat.Parameters.Add("AlinanKoltuklar", SqlDbType.NVarChar, 1000).Value = KoltuklarLbl.Text;
                BiletSat.Parameters.Add("BiletAdet", SqlDbType.Int).Value = Convert.ToInt32(AdetNUD.Value);
                BiletSat.Parameters.Add("BiletFiyat", SqlDbType.Int).Value = Convert.ToUInt32(fiyat);
                BiletSat.Parameters.Add("ToplamBiletFiyat", SqlDbType.Int).Value = Convert.ToUInt32(toplam);
                BiletSat.ExecuteNonQuery();

                ae.con.Close();

                KoltuklarLbl.Text = "";
                ksecim.Clear();
                BiletTasarim bt = new();
                bt.secilenkoltuklar = secilenkoltuklar;
                bt.EIdGelen = EIdGelen;
                bt.EIdGelen2 = EIdGelen2;
                bt.toplam = toplam;
                if (yetki == 5)
                {
                    bt.SAAd = SAAd;
                    bt.SASoyad = SASoyad;
                }
                else
                {
                    bt.SAAd = SAAdTxt.Text;
                    bt.SASoyad = SASoyadTxt.Text;
                }
                bt.ShowDialog();
            }
            else
            {
                MessageBox.Show("Alıcı Ad-Soyad Giriniz.");
            }
        }
        public void BiletBilgiGetir(int EId)
        {
            ae.con.Open();

            string sorgu = $"Select * from BiletSatis where SatinAlanAd='{SAAd}' and SatinAlanSoyad='{SASoyad}' and EtkinlikId={EId} and Id={BSId}";

            SqlCommand bilet = new SqlCommand(sorgu, ae.con);
            SqlDataReader biletoku = bilet.ExecuteReader();

            if (biletoku.Read())
            {
                AdetNUD.Value = Convert.ToInt32(biletoku["BiletAdet"]);
                fiyat = Convert.ToInt32(biletoku["BiletFiyat"]);
                BFiyatLbl.Text = "Bilet Fiyatı: " + fiyat;
                toplam = Convert.ToInt32(biletoku["ToplamBiletFiyat"]);
                ToplamLbl.Text = "Toplam: " + toplam;

                string koltuk = biletoku["AlinanKoltuklar"].ToString();
                skoltuklar = koltuk.Split(" - ");
                foreach (var item in skoltuklar)
                {
                    KoltuklarLbl.Text += item + " ";
                    foreach (var button in KoltukPanel.Controls.OfType<Button>())
                    {
                        if (button.Text == item)
                        {
                            button.Name = "2";
                            button.BackgroundImage = Properties.Resources.yeşil_koltuk;
                        }
                    }
                }
                SAAdTxt.Text = biletoku["SatinAlanAd"].ToString();
                SASoyadTxt.Text = biletoku["SatinAlanSoyad"].ToString();
            }
            ae.con.Close();
        }
        private void AdetNUD_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(AdetNUD.Value) == 0)
            {
                toplam = Convert.ToInt32(AdetNUD.Value) * fiyat;
                ToplamLbl.Text = "Toplam: " + toplam;
            }

        }
        private void BIadeBtn_Click(object sender, EventArgs e)
        {
            DialogResult koltukiade = new DialogResult();
            koltukiade = MessageBox.Show("Koltuk(lar) Iade Edilsin Mi?", "Koltuk Iade İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (koltukiade == DialogResult.Yes)
            {
                foreach (var button in KoltukPanel.Controls.OfType<Button>())
                {
                    if (button.Name == "1")
                    {
                        for (int j = 0; j < ksecim.Count; j++)
                        {
                            IEnumerable<string> except = skoltuklar.Except(ksecim);
                            button.BackgroundImage = Properties.Resources.koltuk;
                            button.Name = "0";
                            CikanLbl.Text += ksecim[j];
                            KoltuklarLbl.Text = "";
                            KoltuklarLbl.Text += except.ToList()[j];
                            Adet = except.ToList().Count;
                        }

                        ae.con.Open();

                        SqlCommand BiletSat = new();
                        BiletSat.Connection = ae.con;
                        BiletSat.CommandType = CommandType.StoredProcedure;
                        BiletSat.CommandText = "BiletIadeSP";
                        BiletSat.Parameters.Add("EtkinlikId", SqlDbType.Int).Value = Convert.ToInt32(EIdGelen2);
                        BiletSat.Parameters.Add("SatinAlanAd", SqlDbType.NVarChar, 200).Value = SAAd;
                        BiletSat.Parameters.Add("SatinAlanSoyad", SqlDbType.NVarChar, 200).Value = SASoyad;
                        BiletSat.Parameters.Add("AlinanKoltuklar", SqlDbType.NVarChar, 1000).Value = CikanLbl.Text;
                        BiletSat.Parameters.Add("BiletAdet", SqlDbType.Int).Value = Convert.ToInt32(ksecim.Count);
                        BiletSat.Parameters.Add("BiletFiyat", SqlDbType.Int).Value = Convert.ToInt32(fiyat);
                        BiletSat.Parameters.Add("ToplamBiletFiyat", SqlDbType.Int).Value = Convert.ToInt32(toplam);
                        BiletSat.ExecuteNonQuery();

                        ae.con.Close();

                        ae.con.Open();

                        string sorgu = $"update BiletSatis set AlinanKoltuklar='{KoltuklarLbl.Text}',BiletAdet={Adet} where Id={BSId}";

                        SqlCommand degis = new SqlCommand(sorgu, ae.con);
                        degis.ExecuteNonQuery();

                        ae.con.Close();
                        MessageBox.Show("Bilet Iade Başarılı.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Iade İşlemi İptal Edildi.");
            }
        }
    }
}
