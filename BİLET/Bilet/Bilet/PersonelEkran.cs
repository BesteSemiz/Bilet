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
using Bilet.Resources.Personelİslemleri;

namespace Bilet
{
    public partial class PersonelEkran : Form
    {
        public AnaEkran ae = new AnaEkran();
        public string PKullaniciAdi, PSifre;
        int i = 0;
        public PersonelEkran()
        {
            InitializeComponent();

        }
        private void KapatBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PersonelEkran_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Gorunum();

            EtkinlikGetir();
            PersonelGetir();
            GelirGetir();
            GiderGetir();

            PersonelIsleriBtn.Enabled = false;

            Islemler();
        }
        private void Gorunum()
        {
            Boyutlandirma(PersonelTopPanel, new(Width, 220));
            Boyutlandirma(PTopHeaderPanel, new(PersonelTopPanel.Width - LogoPanel.Width, PersonelTopPanel.Height));
            Boyutlandirma(LogoPB, new(LogoPanel.Width, LogoPanel.Height));
            Boyutlandirma(kormukPB, null ,new(PTopHeaderPanel.Width / 3, 0));
            Boyutlandirma(AnaMenuStrip, null, new(150, 0));
            Boyutlandirma(AramaTB, null, new(TopContentPanel.Width - AnaMenuStrip.Width, 0));

            Boyutlandirma(PersonelBottomPanel, new(Width, Height - 220));
            Boyutlandirma(PBTPanel, new(Width, 500));
            Boyutlandirma(PBTLeftPanel, new(350, 500));

            Boyutlandirma(EtkinlikPanel, new(PBTPanel.Width - 350, 500));
            Boyutlandirma(EtkinliklerDataGV, new(EtkinlikPanel.Width - 10, EtkinlikPanel.Height - 10), new(5, 5));

            Boyutlandirma(PersonelBLPanel, new(Width / 2, Height - 500));
            Boyutlandirma(PersonelDataGV, new(PersonelBLPanel.Width - 10, PersonelBLPanel.Height - 10), new(5, 5));

            Boyutlandirma(MuhasebePanel, new(Width / 2, Height - 500));
            Boyutlandirma(GelirDataGV, new(MuhasebePanel.Width / 2, MuhasebePanel.Height),new(0,0));
            Boyutlandirma(GiderDataGV, new(MuhasebePanel.Width / 2, MuhasebePanel.Height), new(0 + GelirDataGV.Width,0));

            Boyutlandirma(PersonelIsleriBtn, new(PBTLeftPanel.Width, 100), new(0,0));
            Boyutlandirma(UyeIsleriBtn, new(PBTLeftPanel.Width, 100), new(0,100));
            Boyutlandirma(EtkinlikIslemleriBtn, new(PBTLeftPanel.Width, 100), new(0,200));
            Boyutlandirma(MekanIslemleriBtn, new(PBTLeftPanel.Width, 100), new(0,300));
            Boyutlandirma(MuhasebeIslemleriBtn, new(PBTLeftPanel.Width, 100), new(0,400));
        }
        private void Boyutlandirma(Control control, Size? size = null, Point? point=null) //? : null bırakılabilir
        {
            if(size != null)
            {
                control.Size = (Size)size;
            }
            if (point != null)
            {
                control.Location = (Point)point; //Point? dan Point e convert etik
            }
        }
        private void AramaTB_TextChanged(object sender, EventArgs e)
        {
            ae.con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Etkinlikler where Ad like '%" + AramaTB.Text + "%'", ae.con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            EtkinliklerDataGV.DataSource = dt;
            ae.con.Close();
        }

        #region Getir

        public void EtkinlikGetir()
        {
            ae.con.Open();

            string sorgu = "Select * from Etkinlikler";

            DataTable dt = new DataTable();

            SqlDataAdapter etkinlikgetir = new SqlDataAdapter(sorgu, ae.con);

            etkinlikgetir.Fill(dt);

            EtkinliklerDataGV.DataSource = dt;
            EtkinliklerDataGV.Columns["Id"].Visible = false;
            ae.con.Close();
        }
        public void PersonelGetir()
        {
            ae.con.Open();

            string sorgu = "Select YetkiAd, Ad, Soyad, TCKimlik, Sifre, Maas, Durum from Personeller inner join Yetkiler on (Personeller.YetkiId=Yetkiler.Id)";

            DataTable dt = new DataTable();

            SqlDataAdapter personelgetir = new SqlDataAdapter(sorgu, ae.con);

            personelgetir.Fill(dt);

            PersonelDataGV.DataSource = dt;
            ae.con.Close();
        }
        public void GelirGetir()
        {
            ae.con.Open();

            string sorgu = "Select Tarih,Turu,Aciklama,Gelir from Muhasebe where Gelir!=0";
            DataTable dt = new DataTable();

            SqlDataAdapter gelirgetir = new SqlDataAdapter(sorgu, ae.con);
            gelirgetir.Fill(dt);           
            GelirDataGV.DataSource = dt;
            ae.con.Close();
        }
        public void GiderGetir()
        {
            ae.con.Open();

            string sorgu2 = "Select Tarih,Turu,Aciklama,Gider from Muhasebe where Gider!=0";
            DataTable dt2 = new DataTable();

            SqlDataAdapter gidergetir = new SqlDataAdapter(sorgu2, ae.con);
            gidergetir.Fill(dt2);

            GiderDataGV.DataSource = dt2;
            ae.con.Close();
        }

        #endregion

        public void Islemler()
        {
            ae.con.Open();

            string sorgu = "Select * from Kisiler where KullaniciAdi='" + PKullaniciAdi + "' and Sifre='" + PSifre + "' ";
            SqlCommand kullanici = new SqlCommand(sorgu, ae.con);
            SqlDataReader kullanicioku = kullanici.ExecuteReader();

            if (kullanicioku.Read())
            {
                if (Convert.ToInt32(kullanicioku["YetkiId"]) == 1)
                {
                    PersonelIsleriBtn.Enabled = true;
                }
            }

            ae.con.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 3)
            {
                EtkinlikGetir();
                PersonelGetir();
                GelirGetir();
                GiderGetir();
                i = 0;
            }
        }

        #region Click

        private void PersonelIsleriBtn_Click(object sender, EventArgs e)
        {
            PersonelIslemForm pis = new PersonelIslemForm();
            pis.Show();
        }
        private void UyeIsleriBtn_Click(object sender, EventArgs e)
        {
            UyeIslemForm uis = new UyeIslemForm();
            uis.Show();
        }
        private void EtkinlikIslemleriBtn_Click(object sender, EventArgs e)
        {
            EtkinlikIslemForm eif = new EtkinlikIslemForm();
            eif.Show();
        }
        private void MekanIslemleriBtn_Click(object sender, EventArgs e)
        {
            MekanİslemForm mis = new MekanİslemForm();
            mis.Show();
        }
        private void MuhasebeIslemleriBtn_Click(object sender, EventArgs e)
        {
            MuhasebeForm mf = new MuhasebeForm();
            mf.Show();
        }

        #endregion
    }
}
