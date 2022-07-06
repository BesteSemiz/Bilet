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
    public partial class MekanİslemForm : Form
    {
        public AnaEkran ae = new AnaEkran();
        public MekanİslemForm()
        {
            InitializeComponent();
        }
        private void MekanİslemForm_Load(object sender, EventArgs e)
        {
            IlGetir();
            IlceGetir();
        }

        #region Call

        public void IlGetir()
        {
            ae.con.Open();

            string sorgu = "Select MekanIl from Mekanlar";
            SqlCommand ilgetir = new SqlCommand(sorgu, ae.con);
            SqlDataReader iloku = ilgetir.ExecuteReader();

            MIlCB.Items.Clear();
            MIlCB.Items.Add("");


            while (iloku.Read())
            {
                if (!MIlCB.Items.Contains(iloku["MekanIl"]))
                {
                    MIlCB.Items.Add(iloku["MekanIl"]);
                }
            }

            ae.con.Close();
        }
        public void IlceGetir()
        {
            ae.con.Open();

            string sorgu = "Select MekanIlce from Mekanlar";
            SqlCommand ilgetir = new SqlCommand(sorgu, ae.con);
            SqlDataReader iloku = ilgetir.ExecuteReader();

            MIlceCB.Items.Clear();
            MIlceCB.Items.Add("");


            while (iloku.Read())
            {
                if (!MIlceCB.Items.Contains(iloku["MekanIlce"]))
                {
                    MIlceCB.Items.Add(iloku["MekanIlce"]);
                }
            }
            ae.con.Close();
        }
        public void MekanAdGetir()
        {
            ae.con.Open();

            string sorgu = "Select MekanAdi from Mekanlar where MekanIlce='" + MIlceCB.SelectedItem + "'";
            SqlCommand mekangetir = new SqlCommand(sorgu, ae.con);
            SqlDataReader mekanoku = mekangetir.ExecuteReader();

            MAdCB.Items.Clear();
            MAdCB.Items.Add("");

            while (mekanoku.Read())
            {
                if (!MAdCB.Items.Contains(mekanoku["MekanAdi"]))
                {
                    MAdCB.Items.Add(mekanoku["MekanAdi"]);
                }
            }
            ae.con.Close();
        }
        public void SalonCBGetir()
        {
            ae.con.Open();

            string sorgu = "Select SalonAdi from Salonlar where MekanAdi='" + MAdCB.SelectedItem + "'";
            SqlCommand salongetir = new SqlCommand(sorgu, ae.con);
            SqlDataReader salonoku = salongetir.ExecuteReader();

            MSalonCB.Items.Clear();
            MSalonCB.Items.Add("");

            while (salonoku.Read())
            {
                if (!MSalonCB.Items.Contains(salonoku["SalonAdi"]))
                {
                    MSalonCB.Items.Add(salonoku["SalonAdi"]);
                }
            }

            ae.con.Close();
        }
        public void SalonBilgiListGetir()
        {
            ae.con.Open();

            string sorgu = $"Select * from Etkinlikler where Mekan='{MAdCB.SelectedItem}' and Salon='{MSalonCB.SelectedItem}' ";
            SqlCommand Sbilgigetir = new SqlCommand(sorgu, ae.con);
            SqlDataReader bilgial = Sbilgigetir.ExecuteReader();

            SalonBilgiList.Items.Clear();

            if (bilgial.Read())
            {
                SalonBilgiList.Items.Add("Salondaki Koltuk Sayısı: " + bilgial["BiletSayisi"]);
                SalonBilgiList.Items.Add("Etkinlikler: ");
                SalonBilgiList.Items.Add(bilgial["Ad"]);
            }

            ae.con.Close();
        }
        public void MekanGetir()
        {
            ae.con.Open();

            string sorgu = $"select * from Mekanlar where MekanAdi='{MAdCB.SelectedItem}' ";
            SqlCommand MGetir = new SqlCommand(sorgu, ae.con);
            SqlDataReader MOku = MGetir.ExecuteReader();

            if (MOku.Read())
            {
                if (MIlCB.SelectedIndex != -1 && MIlceCB.SelectedIndex != -1 && MAdCB.SelectedIndex != -1)
                {
                    MIlTxt.Text = MOku["MekanIl"].ToString();
                    MIlceTxt.Text = MOku["MekanIlce"].ToString();
                    MAdTxt.Text = MOku["MekanAdi"].ToString();
                }
            }

            ae.con.Close();
        }
        public void SalonGetir()
        {
            ae.con.Open();

            string sorgu = $"select * from Salonlar where MekanAdi='{MAdCB.SelectedItem}' and SalonAdi='{MSalonCB.SelectedItem}'";
            SqlCommand SGetir = new SqlCommand(sorgu, ae.con);
            SqlDataReader SOku = SGetir.ExecuteReader();

            if (SOku.Read())
            {
                if (MIlCB.SelectedIndex != -1 && MIlceCB.SelectedIndex != -1 && MAdCB.SelectedIndex != -1 && MSalonCB.SelectedIndex != -1)
                {
                    if (MAdCB.SelectedItem.ToString() == SOku["MekanAdi"].ToString() && MSalonCB.SelectedItem.ToString() == SOku["SalonAdi"].ToString())
                    {
                        MSalonMekanTxt.Text = SOku["MekanAdi"].ToString();
                        MSalonTxt.Text = SOku["SalonAdi"].ToString();
                        KoltukSiraNUD.Value = Convert.ToInt32(SOku["KoltukSirasi"]);
                        SiraKoltukSayiNUD.Value = Convert.ToInt32(SOku["SiradakiKoltukSayisi"]);
                        SalonKiraTxt.Text = SOku["SalonKirasi"].ToString();
                    }
                }
            }

            ae.con.Close();
        }

        #endregion

        #region Click

        private void MEkleBtn_Click(object sender, EventArgs e)
        {
            if (MIlTxt.Text != "" && MIlceTxt.Text != "" && MAdTxt.Text != "")
            {
                ae.con.Open();

                SqlCommand MEkle = new();
                MEkle.Connection = ae.con;
                MEkle.CommandType = CommandType.StoredProcedure;
                MEkle.CommandText = "MekanEkle";
                MEkle.Parameters.Add("MekanIl", SqlDbType.NVarChar, 200).Value = MIlTxt.Text;
                MEkle.Parameters.Add("MekanIlce", SqlDbType.NVarChar, 200).Value = MIlceTxt.Text;
                MEkle.Parameters.Add("MekanAdi", SqlDbType.NVarChar, 200).Value = MAdTxt.Text;
                MEkle.Parameters.Add("Durum", SqlDbType.Bit).Value = 1;
                MEkle.ExecuteNonQuery();

                ae.con.Close();
                MessageBox.Show("Mekan Ekleme Başarılı.");

                MIlTxt.Clear();
                MIlceTxt.Clear();
                MAdTxt.Clear();
            }
            else
            {
                MessageBox.Show("Mekan Ekleme Başarısız. Eksik Bilgi Girmiş Olabilirsiniz.");
            }
        }
        private void MSilBtn_Click(object sender, EventArgs e)
        {
            DialogResult Msilkontrol = new DialogResult();
            Msilkontrol = MessageBox.Show("Mekan Silinsin Mi?", "Mekan Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Msilkontrol == DialogResult.Yes)
            {
                ae.con.Open();

                SqlCommand MSil = new();
                MSil.Connection = ae.con;
                MSil.CommandType = CommandType.StoredProcedure;
                MSil.CommandText = "MekanSil";
                MSil.Parameters.Add("MekanAdi", SqlDbType.NVarChar, 200).Value = MAdCB.SelectedItem.ToString();
                MSil.ExecuteNonQuery();

                ae.con.Close();
                MessageBox.Show("Mekan Silme Başarılı.");

                MIlCB.SelectedIndex = -1;
                MIlceCB.SelectedIndex = -1;
                MAdCB.SelectedIndex = -1;
                MSalonCB.SelectedIndex = -1;
                MAdTxt.Clear();
                MIlTxt.Clear();
                MIlceTxt.Clear();
                MSalonMekanTxt.Clear();
                SalonKiraTxt.Clear();
                MSalonTxt.Clear();
                KoltukSiraNUD.Value = 0;
                SiraKoltukSayiNUD.Value = 0;
            }
            else
            {
                MessageBox.Show("Mekan Silme İptal Edildi.");
            }
        }
        private void MDuzenleBtn_Click(object sender, EventArgs e)
        {
            ae.con.Open();

            string sorgu = "update Mekanlar set MekanIl='" + MIlTxt.Text + "', MekanIlce='" + MIlceTxt.Text + "',MekanAdi='" + MAdTxt.Text + "' where MekanIlce='" + MIlceTxt.Text + "' and  MekanIl='" + MIlTxt.Text + "' ";
            SqlCommand Mduzen = new SqlCommand(sorgu, ae.con);
            Mduzen.ExecuteNonQuery();

            ae.con.Close();

            if (MSalonMekanTxt.Text == "")
            {
                ae.con.Open();

                string sorgu2 = "update Salonlar set MekanAdi='" + MAdTxt.Text + "' where MekanAdi='" + MAdCB.SelectedItem + "' and SalonAdi='A Salonu'  or MekanAdi='" + MAdCB.SelectedItem + "' and SalonAdi='B Salonu' or MekanAdi='" + MAdCB.SelectedItem + "' and SalonAdi='C Salonu' ";
                SqlCommand MSduzen = new SqlCommand(sorgu2, ae.con);
                MSduzen.ExecuteNonQuery();

                ae.con.Close();
            }
            else
            {
                ae.con.Open();

                string sorgu3 = "update Salonlar set MekanAdi='" + MAdTxt.Text + "', SalonAdi='" + MSalonTxt.Text + "',KoltukSirasi='" + KoltukSiraNUD.Value + "', SiradakiKoltukSayisi='" + SiraKoltukSayiNUD.Value + "', SalonKirasi='" + SalonKiraTxt.Text + "' where MekanAdi='" + MAdCB.SelectedItem + "' and SalonAdi='" + MSalonCB.SelectedItem + "' ";
                SqlCommand MSduzen = new SqlCommand(sorgu3, ae.con);
                MSduzen.ExecuteNonQuery();

                ae.con.Close();
            }

           

            MessageBox.Show("Mekan Düzenlemesi Başarılı.");

            MIlCB.SelectedIndex = -1;
            MIlceCB.SelectedIndex = -1;
            MAdCB.SelectedIndex = -1;
            MSalonCB.SelectedIndex = -1;
            MAdTxt.Clear();
            MIlTxt.Clear();
            MIlceTxt.Clear();
            MSalonMekanTxt.Clear();
            SalonKiraTxt.Clear();
            MSalonTxt.Clear();
            KoltukSiraNUD.Value = 0;
            SiraKoltukSayiNUD.Value = 0;

        }
        private void MSalonEkleBtn_Click(object sender, EventArgs e)
        {
            if (MSalonMekanTxt.Text != "" && MSalonTxt.Text != "" && SalonKiraTxt.Text != "" && SiraKoltukSayiNUD.Value != 0 && KoltukSiraNUD.Value != 0)
            {
                ae.con.Open();

                SqlCommand SEkle = new();
                SEkle.Connection = ae.con;
                SEkle.CommandType = CommandType.StoredProcedure;
                SEkle.CommandText = "SalonEkle";
                SEkle.Parameters.Add("MekanAdi", SqlDbType.NVarChar, 200).Value = MSalonMekanTxt.Text;
                SEkle.Parameters.Add("SalonAdi", SqlDbType.NVarChar, 200).Value = MSalonTxt.Text;
                SEkle.Parameters.Add("KoltukSirasi", SqlDbType.NVarChar, 11).Value = KoltukSiraNUD.Value;
                SEkle.Parameters.Add("SiradakiKoltukSayisi", SqlDbType.NVarChar, 11).Value = SiraKoltukSayiNUD.Value;
                SEkle.Parameters.Add("ToplamKoltukSayisi", SqlDbType.NVarChar, 11).Value = (KoltukSiraNUD.Value * SiraKoltukSayiNUD.Value);
                SEkle.Parameters.Add("SalonKirasi", SqlDbType.NVarChar, 11).Value = SalonKiraTxt.Text;
                SEkle.Parameters.Add("Durum", SqlDbType.Bit).Value = 1;
                SEkle.ExecuteNonQuery();

                ae.con.Close();
                MessageBox.Show("Salon Ekleme Başarılı.");

                MSalonMekanTxt.Clear();
                MSalonTxt.Clear();
                KoltukSiraNUD.Value = 0;
                SiraKoltukSayiNUD.Value = 0;
                SalonKiraTxt.Clear();
            }
            else
            {
                MessageBox.Show("Salon Ekleme Başarısız. Eksik Bilgi Girmiş Olabilirsiniz.");
            }
        }
        private void SalonDuzenleBtn_Click(object sender, EventArgs e)
        {
            ae.con.Open();

            string sorgu = "update Salonlar set MekanAdi='" + MSalonMekanTxt.Text + "', SalonAdi='" + MSalonTxt.Text + "',KoltukSirasi='" + KoltukSiraNUD.Value + "', SiradakiKoltukSayisi='" + SiraKoltukSayiNUD.Value + "', SalonKirasi='" + SalonKiraTxt.Text + "' where MekanAdi='" + MSalonMekanTxt.Text + "' and SalonAdi='" + MSalonTxt.Text + "' ";
            SqlCommand SDuzen = new SqlCommand(sorgu, ae.con);
            SDuzen.ExecuteNonQuery();

            ae.con.Close();

            MessageBox.Show("Salon Düzenlemesi Başarılı.");

            MSalonMekanTxt.Clear();
            MSalonTxt.Clear();
            KoltukSiraNUD.Value = 0;
            SiraKoltukSayiNUD.Value = 0;
            SalonKiraTxt.Clear();
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            MIlCB.SelectedIndex = -1;
            MIlceCB.SelectedIndex = -1;
            MAdCB.SelectedIndex = -1;
            MSalonCB.SelectedIndex = -1;
            MAdTxt.Clear();
            MIlTxt.Clear();
            MIlceTxt.Clear();
            MSalonMekanTxt.Clear();
            SalonKiraTxt.Clear();
            MSalonTxt.Clear();
            KoltukSiraNUD.Value = 0;
            SiraKoltukSayiNUD.Value = 0;
        }

        #endregion

        #region Changed

        private void MIlceCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MIlceCB.SelectedIndex != 0 && MIlceCB.SelectedIndex != -1)
            {
                MekanAdGetir();
            }
        }
        private void MAdCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MAdCB.SelectedIndex != 0 && MAdCB.SelectedIndex != -1)
            {
                SalonCBGetir();
                MekanGetir();
            }
        }
        private void MSalonCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MIlCB.SelectedIndex != -1 && MIlceCB.SelectedIndex != -1 && MAdCB.SelectedIndex != -1 && MSalonCB.SelectedIndex != -1)
            {
                SalonBilgiListGetir();
                SalonGetir();
            }
        }

        #endregion

    }
}
