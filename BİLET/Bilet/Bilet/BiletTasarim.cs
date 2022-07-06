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
    public partial class BiletTasarim : Form
    {
        AnaEkran ae = new AnaEkran();
        public string mekan, salon, kullaniciad, SASoyad, SAAd, secilenkoltuklar;
        public int EIdGelen, EIdGelen2, toplam;
        string[] skoltuklar;

        public BiletTasarim()
        {
            InitializeComponent();
        }

        private void BiletTasarim_Load(object sender, EventArgs e)
        {
            EBilgiGetir(EIdGelen);
            KoltukLbl.Text = secilenkoltuklar;
            ToplamLbl.Text = toplam.ToString();
            AlanLbl.Text = SAAd + " " + SASoyad;
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

                EAdLbl.Text = "Etkinlik Adı: " + etkinlikoku["Ad"].ToString();
                ETarihLbl.Text = "Etkinlik Tarihi: " + etkinlikoku["Tarih"].ToString();
                ESaatLbl.Text = "Etkinlik Saati: " + etkinlikoku["Saat"].ToString();
                mekan = etkinlikoku["Mekan"].ToString();
                salon = etkinlikoku["Salon"].ToString();
                MekanLbl.Text = "Etkinliğin Yapılacağı Yer: \n" + mekan + "\n " + salon;
            }

            ae.con.Close();
        }
    }
}
