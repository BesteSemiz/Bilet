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
    public partial class MuhasebeForm : Form
    {
        public AnaEkran ae = new AnaEkran();
        string tarih;
        int Id;
        public MuhasebeForm()
        {
            InitializeComponent();
        }
        private void MuhasebeForm_Load(object sender, EventArgs e)
        {
            MuhasebeGetir();
            TurCBDoldur();

            MuhasebeTopPanel.Size = new Size(Width, 80);
            MuhasebeBottomPanel.Size = new Size(Width, Height - 120);
            tarih = TarihDTP.Value.Date.ToString("d.M.yyyy");
        }
        private void GiderEkleTxt_Click(object sender, EventArgs e)
        {
            DialogResult giderekle = new DialogResult();
            giderekle = MessageBox.Show("Gider Eklensin Mi?", "Gider Ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (giderekle == DialogResult.Yes)
            {
                ae.con.Open();

                SqlCommand GiderEkle = new();
                GiderEkle.Connection = ae.con;
                GiderEkle.CommandType = CommandType.StoredProcedure;
                GiderEkle.CommandText = "GiderEkle";
                GiderEkle.Parameters.Add("Tarih", SqlDbType.Date).Value = tarih;
                GiderEkle.Parameters.Add("Turu", SqlDbType.NVarChar, 200).Value = TurCB.SelectedItem.ToString();
                GiderEkle.Parameters.Add("Aciklama", SqlDbType.NVarChar, 1000).Value = AciklamaRTxt.Text;
                GiderEkle.Parameters.Add("Gider", SqlDbType.Int).Value = Convert.ToInt32(GelirGiderTutarTxt.Text);
                GiderEkle.Parameters.Add("HesapBakiyesi", SqlDbType.Int).Value = Convert.ToInt32(GelirGiderTutarTxt.Text);
                GiderEkle.ExecuteNonQuery();

                ae.con.Close();
                MessageBox.Show("Gider Ekleme Başarılı.");
            }
            else
            {
                MessageBox.Show("Gider Ekleme İptal Edildi.");
            }
            MuhasebeGetir();
            TurCB.SelectedIndex = -1;
            TarihDTP.Value = DateTime.Now;
            AciklamaRTxt.Clear();
            GelirGiderTutarTxt.Clear();
        }
        private void GelirEkleBtn_Click(object sender, EventArgs e)
        {
            DialogResult gelirekle = new DialogResult();
            gelirekle = MessageBox.Show("Gelir Eklensin Mi?", "Gelir Ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (gelirekle == DialogResult.Yes)
            {
                ae.con.Open();

                SqlCommand GelirEkle = new();
                GelirEkle.Connection = ae.con;
                GelirEkle.CommandType = CommandType.StoredProcedure;
                GelirEkle.CommandText = "GelirEkle";
                GelirEkle.Parameters.Add("Tarih", SqlDbType.Date).Value = tarih;
                GelirEkle.Parameters.Add("Turu", SqlDbType.NVarChar, 200).Value = TurCB.SelectedItem.ToString();
                GelirEkle.Parameters.Add("Aciklama", SqlDbType.NVarChar, 1000).Value = AciklamaRTxt.Text;
                GelirEkle.Parameters.Add("Gelir", SqlDbType.Int).Value = GelirGiderTutarTxt.Text;
                GelirEkle.Parameters.Add("HesapBakiyesi", SqlDbType.Int).Value = GelirGiderTutarTxt.Text;
                GelirEkle.ExecuteNonQuery();

                ae.con.Close();
                MessageBox.Show("Gelir Ekleme Başarılı.");
            }
            else
            {
                MessageBox.Show("Gelir Ekleme İptal Edildi.");
            }
            MuhasebeGetir();
            TurCB.SelectedIndex = -1;
            TarihDTP.Value = DateTime.Now;
            AciklamaRTxt.Clear();
            GelirGiderTutarTxt.Clear();
        }
        private void TurEkleBtn_Click(object sender, EventArgs e)
        {
            DialogResult turkontrol = new DialogResult();
            turkontrol = MessageBox.Show("Tür Eklensin Mi?", "Tür Ekleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (turkontrol == DialogResult.Yes)
            {
                ae.con.Open();

                SqlCommand TurEkle = new();
                TurEkle.Connection = ae.con;
                TurEkle.CommandType = CommandType.StoredProcedure;
                TurEkle.CommandText = "MuhasebeTuruEkle";
                TurEkle.Parameters.Add("MuhasebeTuru", SqlDbType.NVarChar, 200).Value = TurEkleTxt.Text;
                TurEkle.ExecuteNonQuery();

                ae.con.Close();
                MessageBox.Show("Tür Ekleme Başarılı.");
            }
            else
            {
                MessageBox.Show("Tür Ekleme İptal Edildi.");
            }
            TurCBDoldur();
            TurEkleTxt.Clear();
        }
        public void TurCBDoldur()
        {
            ae.con.Open();

            string sorgu = "Select * from MuhasebeTuru";

            SqlCommand tur = new SqlCommand(sorgu, ae.con);
            SqlDataReader turoku = tur.ExecuteReader();

            while (turoku.Read())
            {
                TurCB.Items.Add(turoku["MuhasebeTuru"]);
            }

            ae.con.Close();
        }
        public void MuhasebeGetir()
        {
            ae.con.Open();

            string sorgu = "Select * from Muhasebe";

            DataTable dt = new DataTable();

            SqlDataAdapter muhasebegetir = new SqlDataAdapter(sorgu, ae.con);

            muhasebegetir.Fill(dt);

            MuhasebeDataGV.DataSource = dt;
            MuhasebeDataGV.Columns["Id"].Visible = false;
            ae.con.Close();
        }
        private void MuhasebeDataGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(MuhasebeDataGV.CurrentRow.Cells["Id"].Value);

            ae.con.Open();

            string sorgu = "Select Gelir,Gider from Muhasebe where Id=" + Id + " ";

            SqlCommand verigetir = new SqlCommand(sorgu, ae.con);
            SqlDataReader verioku = verigetir.ExecuteReader();

            if (verioku.Read())
            {
                if (Convert.ToInt32(verioku["Gelir"]) == 0)
                {
                    GelirGiderTutarTxt.Text = verioku["Gider"].ToString();
                }
                if (Convert.ToInt32(verioku["Gider"]) == 0)
                {
                    GelirGiderTutarTxt.Text = verioku["Gelir"].ToString();
                }
                IslemNoLbl.Text = Id.ToString();
            }

            ae.con.Close();
        }
        private void TarihDTP_ValueChanged(object sender, EventArgs e)
        {
            tarih = TarihDTP.Value.Date.ToString("d.M.yyyy");
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            TurCB.SelectedIndex = -1;
            TarihDTP.Value = DateTime.Now;
            AciklamaRTxt.Clear();
            GelirGiderTutarTxt.Clear();
        }
    }
}
