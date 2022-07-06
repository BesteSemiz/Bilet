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
    public partial class AnaEkran : Form
    {
        public SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = Bilet; Integrated Security = True");
        GroupBox[] gb;
        DataGridView[] dgv;
        List<Button> ButtonList = new List<Button>();
        Button Buton;
        int[] Gunler = new int[DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)];
        public int j = 1, k = 1, x = 0, y = 0, EId = 0, EId2 = 0, BSId=0, YetkiId, i = 0;
        public string KullaniciAdi, Sifre, Ad, Soyad;
        public AnaEkran()
        {
            InitializeComponent();
            gb = new GroupBox[] { EtkinlikGB, İletisimGB, KurumsalGB, MuzikGB, PopGB, RockGB, CazGB, KlasikGB, SahneGB, TiyatroGB, StandUpGB, SoylesiGB, SporGB, FutbolGB, VoleybolGB, BasketbolGB };

            dgv = new DataGridView[] { MuzikDGV, PopDGV, RockDGV, CazDGV, KlasikDGV, SahneDGV, TiyatroDGV, StandUpDGV, SoylesiDGV, SporDGV, FutbolDGV, VoleybolDGV, BasketbolDGV };

            GroupBoxProcess(showGB: Fill.Fill, processType: VisibilityProcess.HideAll);
            TakvimGetir();
            EtkinlikDGVGetir();

        }
        private void AnaEkran_Load(object sender, EventArgs e)
        {
            AnaEkranPanelTop.Size = new Size(Width, 220);
            AnaEkranPanelBottom.Size = new Size(Width, Height - 220);

            TopHeaderPanel.Size = new Size(AnaEkranPanelTop.Width - LogoPanel.Width, AnaEkranPanelTop.Height);
            LogoPB.Size = new Size(LogoPanel.Width, LogoPanel.Height);
            kormukPB.Location = new Point(TopHeaderPanel.Width / 3, 0);
            AnaMenuStrip.Location = new Point(150, 0);

            AnaEkranBLeftPanel.Size = new Size(Width / 2, AnaEkranPanelBottom.Height);
            GBPanel.Size = new Size(Width / 2, AnaEkranPanelBottom.Height);

            CikisBtn.Enabled = false;
            PersonelBtn.Visible = false;
            BILETLERIMTSMI.Enabled = false;
            BILETLERIMTSMI.Visible = false;
            BiletlerimGB.Visible = false;
            timer1.Start();

        }

        #region Click
        private void KapatBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void PGirisBtn_Click(object sender, EventArgs e)
        {
            KullaniciAdi = GirisAdTxt.Text;
            Sifre = GirisSifreTxt.Text;

            if (KullaniciAdi != "" && Sifre != "")
            {
                con.Open();

                string girissorgu = "Select * from Kisiler where KullaniciAdi='" + KullaniciAdi + "' and Sifre='" + Sifre + "' ";
                SqlCommand giris = new SqlCommand(girissorgu, con);
                SqlDataReader giriskontrol = giris.ExecuteReader();

                if (giriskontrol.Read())
                {
                    KullaniciAdi = giriskontrol["KullaniciAdi"].ToString();
                    Ad = giriskontrol["Ad"].ToString();
                    Soyad = giriskontrol["Soyad"].ToString();
                    YetkiId = Convert.ToInt32(giriskontrol["YetkiId"]);
                    if (Convert.ToInt32(giriskontrol["YetkiId"]) == 5)
                    {
                        BILETLERIMTSMI.Enabled = true;
                        BILETLERIMTSMI.Visible = true;
                    }
                    if (Convert.ToInt32(giriskontrol["YetkiId"]) == 1 || Convert.ToInt32(giriskontrol["YetkiId"]) == 2)
                    {
                        PersonelBtn.Visible = true;
                        PersonelBtn.Enabled = true;
                    }
                    GirisBtn.Enabled = false;
                    CikisBtn.Enabled = true;
                    GirisAdTxt.Clear();
                    GirisSifreTxt.Clear();

                    MessageBox.Show("Giriş Başarılı", "Giriş Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Girilen Bilgiler Uyuşmuyor. Lütfen Tekrar Deneyiniz.", "Giriş Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Giriş Bilgileri Eksik", "Giriş Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PersonelBtn_Click_1(object sender, EventArgs e)
        {
            PersonelEkran pe = new();

            pe.PKullaniciAdi = KullaniciAdi;
            pe.PSifre = Sifre;

            pe.ShowDialog();
        }
        private void PCikisBtn_Click(object sender, EventArgs e)
        {
            PersonelBtn.Enabled = false;
            PersonelBtn.Visible = false;
            GirisBtn.Enabled = true;
            CikisBtn.Enabled = false;
            GroupBoxProcess(showGB: Fill.Fill, processType: VisibilityProcess.HideAll);
            BILETLERIMTSMI.Visible = false;
            EtkinlikGB.Visible = false;
            BiletlerimGB.Visible = false;
        }
        private void TumMuzikTSMI_Click(object sender, EventArgs e)
        {
            GroupBoxProcess(MuzikGB);
            GetDGV("", MuzikDGV, Fill.Fill, "Pop", "Rock", "Caz", "Klasik");
        }
        private void PopTSMI_Click(object sender, EventArgs e)
        {
            GroupBoxProcess(PopGB);
            GetDGV("", PopDGV, Fill.Fill, "Pop");
        }
        private void RockTSMI_Click(object sender, EventArgs e)
        {
            GroupBoxProcess(RockGB);
            GetDGV("", RockDGV, Fill.Fill, "Rock");
        }
        private void CazTSMI_Click(object sender, EventArgs e)
        {
            GroupBoxProcess(CazGB);
            GetDGV("", CazDGV, Fill.Fill, "Caz");
        }
        private void KlasikTSMI_Click(object sender, EventArgs e)
        {
            GroupBoxProcess(KlasikGB);
            GetDGV("", KlasikDGV, Fill.Fill, "Klasik");
        }
        private void TumSahneTSMI_Click(object sender, EventArgs e)
        {
            GroupBoxProcess(SahneGB);
            GetDGV("", SahneDGV, Fill.Fill, "Tiyatro", "Stand Up", "Söyleşi");
        }
        private void TiyatroTSMI_Click(object sender, EventArgs e)
        {
            GroupBoxProcess(TiyatroGB);
            GetDGV("", TiyatroDGV, Fill.Fill, "Tiyatro");
        }
        private void StandUpTSMI_Click(object sender, EventArgs e)
        {
            GroupBoxProcess(StandUpGB);
            GetDGV("", StandUpDGV, Fill.Fill, "Stand Up");
        }
        private void SoylesiTSMI_Click(object sender, EventArgs e)
        {
            GroupBoxProcess(SoylesiGB);
            GetDGV("", SoylesiDGV, Fill.Fill, "Söyleşi");
        }
        private void TumSporTSMI_Click(object sender, EventArgs e)
        {
            GroupBoxProcess(SporGB);
            GetDGV("", SporDGV, Fill.Fill, "Futbol", "Voleybol", "Basketbol");
        }
        private void FutbolTSMI_Click(object sender, EventArgs e)
        {
            GroupBoxProcess(FutbolGB);
            GetDGV("", FutbolDGV, Fill.Fill, "Futbol");
        }
        private void VoleybolTSMI_Click(object sender, EventArgs e)
        {
            GroupBoxProcess(VoleybolGB);
            GetDGV("", VoleybolDGV, Fill.Fill, "Voleybol");
        }
        private void BasketbolTSMI_Click(object sender, EventArgs e)
        {
            GroupBoxProcess(BasketbolGB);
            GetDGV("", BasketbolDGV, Fill.Fill, "Basketbol");
        }
        private void KurumsalTSMI_Click(object sender, EventArgs e)
        {
            GroupBoxProcess(KurumsalGB);
        }
        private void IletisimTSMI_Click(object sender, EventArgs e)
        {
            GroupBoxProcess(İletisimGB);
        }
        private void Buton_Click(object? sender, EventArgs e)
        {
            #region
            //   if(((sender) as Button).Text == "2")
            //    {
            //MessageBox.Show(((sender) as Button).Text);
            //    }
            #endregion
            GroupBoxProcess(EtkinlikGB);
            EtkinlikDGV.Dock = DockStyle.Fill;

            con.Open();

            string sorgu = $"Select Etkinlikler.Id,EtkinlikTuru.TurAdi,Ad,Mekan,Salon,Tarih,Saat from Etkinlikler inner join EtkinlikTuru on (EtkinlikTuru.Id=Etkinlikler.EtkinlikTurId) where Tarih='{$"{((Button)sender).Text}.{DateTime.Now.Month}.{DateTime.Now.Year}"}' ";

            SqlDataAdapter verigetir = new SqlDataAdapter(sorgu, con);

            DataTable dt = new DataTable();

            verigetir.Fill(dt);

            EtkinlikDGV.DataSource = dt;
            EtkinlikDGV.Columns["Id"].Visible = false;
            con.Close();
        }
        private void BILETLERIMTSMI_Click(object sender, EventArgs e)
        {
            EtkinlikGB.Visible = false;
            if (YetkiId == 5)
            {
                BiletlerimGB.Visible = true;
                BiletlerimGB.Dock = DockStyle.Fill;
                BDGV.Dock = DockStyle.Fill;
                BDGVGetir();
            }
        }
        #endregion

        public void BDGVGetir()
        {
            con.Open();

            string sorgu = $"Select BiletSatis.Id,EtkinlikId, Etkinlikler.Ad as 'Etkinlik Adı',SatinAlanAd as 'Satın Alanın Adı', SatinAlanSoyad as 'Satın Alanın Soyadı', AlinanKoltuklar as 'Koltuklar', BiletAdet, ToplamBiletFiyat from BiletSatis inner join Etkinlikler on (Etkinlikler.Id=BiletSatis.EtkinlikId) where SatinAlanAd='{Ad}' and SatinAlanSoyad='{Soyad}' ";

            SqlDataAdapter verigetir = new SqlDataAdapter(sorgu, con);

            DataTable dt = new DataTable();

            verigetir.Fill(dt);

            BDGV.DataSource = dt;
            BDGV.Columns["Id"].Visible = false;
            BDGV.Columns["EtkinlikId"].Visible = false;
            BDGV.Columns["Etkinlik Adı"].Width = (BDGV.Width / 4) + 5;
            con.Close();
        }
        public void EtkinlikDGVGetir()
        {
            for (int i = 1; i <= Gunler.Length; i++)
            {
                con.Open();

                string sorgu = $"Select Etkinlikler.Id,EtkinlikTuru.TurAdi,Ad,Mekan,Salon,Tarih,Saat from Etkinlikler inner join EtkinlikTuru on (EtkinlikTuru.Id=Etkinlikler.EtkinlikTurId) where Tarih='{$"{i}.{DateTime.Now.Month}.{DateTime.Now.Year}"}' ";

                SqlDataAdapter verigetir = new SqlDataAdapter(sorgu, con);

                DataTable dt = new DataTable();

                verigetir.Fill(dt);

                EtkinlikDGV.DataSource = dt;

                if (EtkinlikDGV.RowCount != 1)
                {
                    for (int j = 1; j <= ButtonList.Count; j++)
                    {
                        ButtonList[i - 1].BackColor = Color.DarkGoldenrod;
                    }
                }
                con.Close();
            }

        }
        private Button AddNewButton(string ButtonName)
        {
        go:
            if (j <= 7 * k)
            {
                Buton = new()
                {
                    Location = new Point(70 + x, 70 + y),
                    FlatStyle = FlatStyle.Popup,
                    BackColor = Color.FromArgb(107, 107, 107),
                    ForeColor = Color.WhiteSmoke,
                    Size = new Size(110, 110),
                    Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                    Text = j.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,

                };
                Buton.Click += Buton_Click;
                j++;
                x += 115;
                AnaEkranBLeftPanel.Controls.Add(Buton);
                ButtonList.Add(Buton);
                return Buton;
            }
            k++;
            x = 0;
            y += 115;
            goto go;
            AnaEkranBLeftPanel.Controls.Add(Buton);
            ButtonList.Add(Buton);
            return Buton;
        }
        private void TakvimGetir()
        {
            for (int i = 1; i <= Gunler.Length; i++)
            {
                string ButtonName = "Buton " + i;
                AddNewButton(ButtonName);
            }
        }

        #region DoubleClick
        private void MuzikDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenBiletIslem(MuzikDGV);
        }
        private void SahneDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenBiletIslem(SahneDGV);
        }
        private void SporDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenBiletIslem(SporDGV);
        }
        private void PopDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenBiletIslem(PopDGV);
        }
        private void RockDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenBiletIslem(RockDGV);
        }
        private void CazDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenBiletIslem(CazDGV);
        }
        private void KlasikDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenBiletIslem(KlasikDGV);
        }
        private void TiyatroDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenBiletIslem(TiyatroDGV);
        }
        private void StandUpDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenBiletIslem(StandUpDGV);
        }
        private void SoylesiDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenBiletIslem(SoylesiDGV);
        }
        private void EtkinlikDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenBiletIslem(EtkinlikDGV);
        }
        private void BDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EId2 = Convert.ToInt32(BDGV.CurrentRow.Cells["EtkinlikId"].Value);
            BSId = Convert.ToInt32(BDGV.CurrentRow.Cells["Id"].Value);
            BiletIslemleri bi = new BiletIslemleri();

            bi.EIdGelen2 = EId2;
            bi.BSId = BSId;
            bi.kullaniciad = KullaniciAdi;
            bi.yetki = YetkiId;
            bi.SAAd = Ad;
            bi.SASoyad = Soyad;
            bi.ShowDialog();
        }
        private void FutbolDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenBiletIslem(FutbolDGV);
        }
        private void VoleybolDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenBiletIslem(VoleybolDGV);
        }
        private void BasketbolDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenBiletIslem(BasketbolDGV);
        }

        #endregion

        public void GroupBoxProcess(GroupBox GB = null, Fill showGB = Fill.Fill, VisibilityProcess processType = VisibilityProcess.ShowSingle)
        {
            BiletlerimGB.Visible = false;
            for (int i = 0; i < gb.Length; i++)
            {
                gb[i].Visible = false;

                if (showGB == Fill.Fill)
                    gb[i].Dock = DockStyle.Fill;
            }

            if (processType == VisibilityProcess.ShowSingle)
                GB.Visible = true;
        }
        public enum VisibilityProcess { ShowSingle, HideAll }
        public void GetDGV(string whereValue = null, DataGridView DGV = null, Fill showDGV = Fill.Fill, params string[] Tur)
        {

            for (int i = 0; i < dgv.Length; i++)
            {
                dgv[i].Visible = false;

                if (showDGV == Fill.Fill)
                {
                    dgv[i].Dock = DockStyle.Fill;
                }
            }

            if (showDGV == Fill.Fill)
            {
                DGV.Visible = true;

                con.Open();

                for (int i = 0; i < Tur.Length; i++)
                {
                    if (i == 0)
                    {
                        whereValue += " EtkinlikTuru.TurAdi= '" + Tur[i] + "' ";
                    }
                    else
                    {
                        whereValue += " or EtkinlikTuru.TurAdi= '" + Tur[i] + "' ";
                    }
                }

                string sorgu = $"Select Etkinlikler.Id,Ad,Mekan,Salon,Tarih,Saat from Etkinlikler inner join EtkinlikTuru on (EtkinlikTuru.Id=Etkinlikler.EtkinlikTurId) where {whereValue} ";

                SqlDataAdapter verigetir = new SqlDataAdapter(sorgu, con);

                DataTable dt = new DataTable();

                verigetir.Fill(dt);

                DGV.DataSource = dt;
                DGV.Columns["Id"].Visible = false;
                con.Close();
            }
        }
        public enum Fill { Fill }
        public void OpenBiletIslem(DataGridView DGV)
        {
            if (GirisBtn.Enabled == false)
            {
                EId = Convert.ToInt32(DGV.CurrentRow.Cells["Id"].Value);

                BiletIslemleri bi = new();

                bi.EIdGelen = EId;
                bi.kullaniciad = KullaniciAdi;
                bi.yetki = YetkiId;
                bi.SAAd = Ad;
                bi.SASoyad = Soyad;

                bi.ShowDialog();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 3)
            {
                BDGVGetir();
            }
        }
    }
}
