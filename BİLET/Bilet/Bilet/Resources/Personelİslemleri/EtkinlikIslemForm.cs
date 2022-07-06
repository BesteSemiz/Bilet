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
    public partial class EtkinlikIslemForm : Form
    {
        public AnaEkran ae = new AnaEkran();
        int biletsayisi, turId, Id;
        string etkinliktarih, etkinliksaat, biletacilis, biletbitis;
        public string ad, mekan, salon, tarih, saat;
        List<string> EAd, EMekan, ESalon, ETarih, ESaat;
        bool durum;
        public EtkinlikIslemForm()
        {
            InitializeComponent();
            EAd = new List<string>();
            EMekan = new List<string>();
            ESalon = new List<string>();
            ETarih = new List<string>();
            ESaat = new List<string>();
        }
        private void EtkinlikIslemForm_Load(object sender, EventArgs e)
        {
            EtkinlikGetir();
            MekanCBGetir();
            TurCBGetir();
            ESaatTxt.Enabled = false;
            SalonCekTxt.Enabled = false;
            MekanCekTxt.Enabled = false;
            EtkinlikIslemTopPanel.Size = new Size(Width, 80);
            EIslemBottomPanel.Size = new Size(Width, Height - 120);
            biletacilis = EBiletSatisBaslaTarihDTP.Value.Date.ToString("d.M.yyyy");
            biletbitis= EBiletSatisBitisTarihDTP.Value.Date.ToString("d.M.yyyy");
        }

        #region Call
        public void EBilgiDizi()
        {
            ae.con.Open();

            string sorgu = "Select * from Etkinlikler";
            SqlCommand getir = new SqlCommand(sorgu, ae.con);
            SqlDataReader bilgi = getir.ExecuteReader();

            while (bilgi.Read())
            {
                EAd.Add(bilgi["Ad"].ToString());
                EMekan.Add(bilgi["Mekan"].ToString());
                ESalon.Add(bilgi["Salon"].ToString());
                ETarih.Add(bilgi["Tarih"].ToString());
                ESaat.Add(bilgi["Saat"].ToString());
            }
            for (int i = 0; i < EAd.Count; i++)
            {
            go:
                if (EAd[i] == EAdTxt.Text)
                {
                    for (int i1 = 0; i1 < EMekan.Count; i1++)
                    {
                    go1:
                        if (EMekan[i1] == EMekanCB.SelectedItem.ToString())
                        {
                            for (int i2 = 0; i2 < ESalon.Count; i2++)
                            {
                            go2:
                                if (ESalon[i2] == ESalonCB.SelectedItem.ToString())
                                {
                                    for (int i3 = 0; i3 < ETarih.Count; i3++)
                                    {
                                    go3:
                                        if (ETarih[i3] == (EtkinlikTarihDTimeP.Value.Day + "." + EtkinlikTarihDTimeP.Value.Month + "." + EtkinlikTarihDTimeP.Value.Year).ToString())
                                        {
                                            for (int i4 = 0; i4 < ESaat.Count; i4++)
                                            {
                                            go4:
                                                if (ESaat[i4] == EtkinlikTarihDTimeP.Value.ToString("t"))
                                                {
                                                    MessageBox.Show("Bu Etkinlik Mevcuttur");
                                                }
                                                else
                                                {
                                                    if (i4 == ESaat.Count - 1)
                                                    {
                                                        durum = true;
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        i4++;
                                                        goto go4;
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (i3 == ETarih.Count - 1)
                                            {
                                                durum = true;
                                                break;
                                            }
                                            else
                                            {
                                                i3++;
                                                goto go3;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (i2 == ESalon.Count - 1)
                                    {
                                        durum = true;
                                        break;
                                    }
                                    else
                                    {
                                        i2++;
                                        goto go2;
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (i1 == EMekan.Count - 1)
                            {
                                durum = true;
                                break;
                            }
                            else
                            {
                                i1++;
                                goto go1;
                            }
                        }
                    }
                }
                else
                {
                    if (i == EAd.Count - 1)
                    {
                        durum = true;
                        break;
                    }
                    else
                    {
                        i++;
                        goto go;
                    }
                }
            }

            ae.con.Close();
        }
        public void EtkinlikGetir()
        {
            ae.con.Open();

            string sorgu = "Select Etkinlikler.Id,EtkinlikTuru.TurAdi,Ad,Mekan,Salon,Tarih,Saat,BiletFiyat,BiletSayisi,BiletAcilis,BiletBitis from Etkinlikler inner join EtkinlikTuru on (EtkinlikTuru.Id=Etkinlikler.EtkinlikTurId)";

            DataTable dt = new DataTable();

            SqlDataAdapter etkinlikgetir = new SqlDataAdapter(sorgu, ae.con);

            etkinlikgetir.Fill(dt);

            EtkinlikDGV.DataSource = dt;
            EtkinlikDGV.Columns["Id"].Visible = false;
            ae.con.Close();
        }
        public void EtkinlikDoldur()
        {
            ae.con.Open();

            string sorgu = "Select * from Etkinlikler where Id= " + Id + "";

            SqlCommand etkinlik = new SqlCommand(sorgu, ae.con);
            SqlDataReader eoku = etkinlik.ExecuteReader();

            if (eoku.Read())
            {
                ETurCB.SelectedIndex = (int)eoku["EtkinlikTurId"];
                ad = eoku["Ad"].ToString();
                EAdTxt.Text = ad;
                mekan = eoku["Mekan"].ToString();
                MekanCekTxt.Text = mekan;
                salon = eoku["Salon"].ToString();
                SalonCekTxt.Text = salon;
                tarih = Convert.ToDateTime(eoku["Tarih"]).Date.ToString();
                EtkinlikTarihDTimeP.Value = Convert.ToDateTime(tarih);
                saat = eoku["Saat"].ToString();
                ESaatTxt.Text = saat;
                EBiletFiyatTxt.Text = eoku["BiletFiyat"].ToString();
                EBiletSatisBaslaTarihDTP.Value = Convert.ToDateTime(eoku["BiletAcilis"]).Date;
                EBiletSatisBitisTarihDTP.Value = Convert.ToDateTime(eoku["BiletBitis"]).Date;
                EMaliyetTxt.Text = eoku["EtkinlikMaliyeti"].ToString();
            }

            ae.con.Close();
        }
        public void MekanCBGetir()
        {
            ae.con.Open();

            string sorgu = "Select MekanAdi from Mekanlar";
            SqlCommand mekangetir = new SqlCommand(sorgu, ae.con);
            SqlDataReader mekanoku = mekangetir.ExecuteReader();

            EMekanCB.Items.Clear();
            EMekanCB.Items.Add("");

            while (mekanoku.Read())
            {
                if (!EMekanCB.Items.Contains(mekanoku["MekanAdi"]))
                {
                    EMekanCB.Items.Add(mekanoku["MekanAdi"]);
                }
            }
            ae.con.Close();
        }
        public void SalonCBGetir()
        {
            ae.con.Open();

            string sorgu = "Select SalonAdi from Salonlar where MekanAdi='" + EMekanCB.SelectedItem + "'";
            SqlCommand salongetir = new SqlCommand(sorgu, ae.con);
            SqlDataReader salonoku = salongetir.ExecuteReader();

            ESalonCB.Items.Clear();
            ESalonCB.Items.Add("");

            while (salonoku.Read())
            {
                if (!ESalonCB.Items.Contains(salonoku["SalonAdi"]))
                {
                    ESalonCB.Items.Add(salonoku["SalonAdi"]);
                }
            }

            ae.con.Close();
        }
        public void TurCBGetir()
        {
            ae.con.Open();

            string sorgu = "Select TurAdi from EtkinlikTuru";
            SqlCommand turgetir = new SqlCommand(sorgu, ae.con);
            SqlDataReader turoku = turgetir.ExecuteReader();

            ETurCB.Items.Clear();
            ETurCB.Items.Add("");

            while (turoku.Read())
            {
                if (!ETurCB.Items.Contains(turoku["TurAdi"]))
                {
                    ETurCB.Items.Add(turoku["TurAdi"]);
                }
            }

            ae.con.Close();
        }
        public void BiletSayisiAl()
        {
            ae.con.Open();

            string sorgu = $"Select ToplamKoltukSayisi from Salonlar where MekanAdi='{EMekanCB.SelectedItem}' and SalonAdi='{ESalonCB.SelectedItem}'";
            SqlCommand koltuk = new SqlCommand(sorgu, ae.con);
            SqlDataReader koltukoku = koltuk.ExecuteReader();

            if (koltukoku.Read())
            {
                biletsayisi = Convert.ToInt32(koltukoku["ToplamKoltukSayisi"]);
            }

            ae.con.Close();
        }
        #endregion

        #region Click

        private void EEkleBtn_Click(object sender, EventArgs e)
        {
            EBilgiDizi();

            if (durum)
            {
                if (EAdTxt.Text != "" && EBiletFiyatTxt.Text != "" && ETurCB.SelectedIndex != -1 && EMekanCB.SelectedIndex != -1 && ESalonCB.SelectedIndex != -1 && EtkinlikTarihDTimeP.Value.Day != DateTime.Now.Day)
                {
                    ae.con.Open();

                    SqlCommand EEkle = new();
                    EEkle.Connection = ae.con;
                    EEkle.CommandType = CommandType.StoredProcedure;
                    EEkle.CommandText = "EtkinlikEkle";
                    EEkle.Parameters.Add("EtkinlikTurId", SqlDbType.Int).Value = turId;
                    EEkle.Parameters.Add("Ad", SqlDbType.NVarChar, 1000).Value = EAdTxt.Text;
                    EEkle.Parameters.Add("Mekan", SqlDbType.NVarChar, 200).Value = EMekanCB.SelectedItem.ToString();
                    EEkle.Parameters.Add("Salon", SqlDbType.NVarChar, 200).Value = ESalonCB.SelectedItem.ToString();
                    EEkle.Parameters.Add("Tarih", SqlDbType.NVarChar, 200).Value = etkinliktarih;
                    EEkle.Parameters.Add("Saat", SqlDbType.NVarChar, 200).Value = etkinliksaat;
                    EEkle.Parameters.Add("BiletSayisi", SqlDbType.Int).Value = biletsayisi;
                    EEkle.Parameters.Add("BiletFiyat", SqlDbType.Int).Value = EBiletFiyatTxt.Text;
                    EEkle.Parameters.Add("BiletAcilis", SqlDbType.NVarChar, 200).Value = biletacilis;
                    EEkle.Parameters.Add("BiletBitis", SqlDbType.NVarChar, 200).Value = biletbitis;
                    EEkle.Parameters.Add("EtkinlikMaliyeti", SqlDbType.Int).Value = Convert.ToUInt32(EMaliyetTxt.Text);
                    EEkle.Parameters.Add("Durum", SqlDbType.Bit).Value = 1;
                    EEkle.ExecuteNonQuery();

                    ae.con.Close();
                    MessageBox.Show("Etkinlik Ekleme Başarılı.");
                    EtkinlikGetir();
                    EMekanCB.SelectedIndex = 0;
                    ESalonCB.SelectedIndex = 0;
                    ETurCB.SelectedIndex = 0;
                    EAdTxt.Clear();
                    EBiletFiyatTxt.Clear();
                    ESaatTxt.Clear();
                    EMaliyetTxt.Clear();
                    EBiletSatisBaslaTarihDTP.Value = DateTime.Now;
                    EBiletSatisBitisTarihDTP.Value = DateTime.Now;
                    EtkinlikTarihDTimeP.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Etkinlik Ekleme Başarısız. Eksik Bilgi Girmiş Olabilirsiniz.");
                }

            }
        }
        private void ESilTxt_Click(object sender, EventArgs e)
        {
            DialogResult Esilkontrol = new DialogResult();
            Esilkontrol = MessageBox.Show("Etkinlik Silinsin Mi?", "Etkinlik Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Esilkontrol == DialogResult.Yes)
            {
                ae.con.Open();

                string sorgu = $"delete from Etkinlikler where Ad='{EAdTxt.Text}' and Mekan='{MekanCekTxt.Text}' and Salon='{SalonCekTxt.Text}' ";

                SqlCommand esil = new SqlCommand(sorgu, ae.con);
                esil.ExecuteNonQuery();

                ae.con.Close();

                EtkinlikGetir();
                EMekanCB.SelectedIndex = -1;
                ESalonCB.SelectedIndex = -1;
                ETurCB.SelectedIndex = -1;
                EAdTxt.Clear();
                EBiletFiyatTxt.Clear();
                ESaatTxt.Clear();
                EMaliyetTxt.Clear();
                EBiletSatisBaslaTarihDTP.Value = DateTime.Now;
                EBiletSatisBitisTarihDTP.Value = DateTime.Now;
                EtkinlikTarihDTimeP.Value = DateTime.Now;
                MessageBox.Show("Etkinlik Silme Başarılı.");

            }
            else
            {
                MessageBox.Show("Etkinlik Silme İptal Edildi.");
            }
        }
        private void EDuzenleTxt_Click(object sender, EventArgs e)
        {
            if (EMekanCB.Enabled == false)
            {
                DialogResult Eduzenlekontrol = new DialogResult();
                Eduzenlekontrol = MessageBox.Show("Etkinlik Düzenlensin Mi?", "Etkinlik Düzenleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Eduzenlekontrol == DialogResult.Yes)
                {
                    if (EAdTxt.Text != "" && EMaliyetTxt.Text != "" && EBiletFiyatTxt.Text != "" && ESaatTxt.Text != "")
                    {

                        if (ad != EAdTxt.Text && mekan != MekanCekTxt.Text && salon != SalonCekTxt.Text && tarih != (EtkinlikTarihDTimeP.Value.Day + "." + EtkinlikTarihDTimeP.Value.Month + "." + EtkinlikTarihDTimeP.Value.Year).ToString() && saat != ESaatTxt.Text)
                        {
                            ae.con.Open();

                            string sorgu = $"update Etkinlikler set EtkinlikTurId={ETurCB.SelectedIndex}," +
                                $"Ad='{EAdTxt.Text}', Mekan='{MekanCekTxt.Text}', Salon='{SalonCekTxt.Text}'," +
                                $"Tarih='{EtkinlikTarihDTimeP.Value.Day + "." + EtkinlikTarihDTimeP.Value.Month + "." + EtkinlikTarihDTimeP.Value.Year}'" +
                                $",Saat='{ESaatTxt.Text}', BiletSayisi={biletsayisi},BiletFiyat={EBiletFiyatTxt.Text}," +
                                $"BiletAcilis='{EBiletSatisBaslaTarihDTP.Value.Day + "." + EBiletSatisBaslaTarihDTP.Value.Month + "." + EBiletSatisBaslaTarihDTP.Value.Year}'," +
                                $"Biletbitis='{EBiletSatisBitisTarihDTP.Value.Day + "." + EBiletSatisBitisTarihDTP.Value.Month + "." + EBiletSatisBitisTarihDTP.Value.Year}'," +
                                $"EtkinlikMaliyeti={EMaliyetTxt.Text},Durum=1 where Id={Id}";

                            SqlCommand Eduzenle = new SqlCommand(sorgu, ae.con);
                            Eduzenle.ExecuteNonQuery();

                            ae.con.Close();

                            EtkinlikGetir();
                            EMekanCB.SelectedIndex = -1;
                            ESalonCB.SelectedIndex = -1;
                            ETurCB.SelectedIndex = -1;
                            MekanCekTxt.Clear();
                            SalonCekTxt.Clear();
                            EAdTxt.Clear();
                            EBiletFiyatTxt.Clear();
                            ESaatTxt.Clear();
                            EMaliyetTxt.Clear();
                            EBiletSatisBaslaTarihDTP.Value = DateTime.Now;
                            EBiletSatisBitisTarihDTP.Value = DateTime.Now;
                            EtkinlikTarihDTimeP.Value = DateTime.Now;
                            MessageBox.Show("Etkinlik Düzenleme Başarılı.");

                        }
                        else
                        {
                            MessageBox.Show("Etkinlik Bilgileri Eski Bilgilerle Aynı.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Değerler Boş Bırakılamaz.");
                    }
                }
                else
                {
                    MessageBox.Show("Etkinlik Düzenleme İptal Edildi.");
                }
            }
            else if (EMekanCB.Enabled == true)
            {
                DialogResult Eduzenlekontrol = new DialogResult();
                Eduzenlekontrol = MessageBox.Show("Etkinlik Düzenlensin Mi?", "Etkinlik Düzenleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Eduzenlekontrol == DialogResult.Yes)
                {
                    if (EAdTxt.Text != "" && EMaliyetTxt.Text != "" && EBiletFiyatTxt.Text != "" && ESaatTxt.Text != "")
                    {

                        if (ad != EAdTxt.Text && mekan != EMekanCB.SelectedItem.ToString() && salon != ESalonCB.SelectedItem.ToString() && tarih != (EtkinlikTarihDTimeP.Value.Day + "." + EtkinlikTarihDTimeP.Value.Month + "." + EtkinlikTarihDTimeP.Value.Year).ToString() && saat != ESaatTxt.Text)
                        {
                            ae.con.Open();

                            string sorgu = $"update Etkinlikler set EtkinlikTurId={ETurCB.SelectedIndex}," +
                                $"Ad='{EAdTxt.Text}', Mekan='{EMekanCB.SelectedItem}', Salon='{ESalonCB.SelectedItem}'," +
                                $"Tarih='{EtkinlikTarihDTimeP.Value.Day + "." + EtkinlikTarihDTimeP.Value.Month + "." + EtkinlikTarihDTimeP.Value.Year}'," +
                                $"Saat='{ESaatTxt.Text}', BiletSayisi={biletsayisi},BiletFiyat={EBiletFiyatTxt.Text}," +
                                $"BiletAcilis='{EBiletSatisBaslaTarihDTP.Value.Day + "." + EBiletSatisBaslaTarihDTP.Value.Month + "." + EBiletSatisBaslaTarihDTP.Value.Year}'," +
                                $"Biletbitis='{EBiletSatisBitisTarihDTP.Value.Day + "." + EBiletSatisBitisTarihDTP.Value.Month + "." + EBiletSatisBitisTarihDTP.Value.Year}'," +
                                $"EtkinlikMaliyeti={EMaliyetTxt.Text},Durum=1  where Id={Id}";

                            SqlCommand Eduzenle = new SqlCommand(sorgu, ae.con);
                            Eduzenle.ExecuteNonQuery();

                            ae.con.Close();

                            EtkinlikGetir();
                            EMekanCB.SelectedIndex = -1;
                            ESalonCB.SelectedIndex = -1;
                            ETurCB.SelectedIndex = -1;
                            MekanCekTxt.Clear();
                            SalonCekTxt.Clear();
                            EAdTxt.Clear();
                            EBiletFiyatTxt.Clear();
                            ESaatTxt.Clear();
                            EMaliyetTxt.Clear();
                            EBiletSatisBaslaTarihDTP.Value = DateTime.Now;
                            EBiletSatisBitisTarihDTP.Value = DateTime.Now;
                            EtkinlikTarihDTimeP.Value = DateTime.Now;
                            MessageBox.Show("Etkinlik Düzenleme Başarılı.");
                        }
                        else
                        {
                            MessageBox.Show("Etkinlik Bilgileri Eski Bilgilerle Aynı.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Değerler Boş Bırakılamaz.");
                    }
                }
                else
                {
                    MessageBox.Show("Etkinlik Düzenleme İptal Edildi.");
                }
            }
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            EMekanCB.SelectedIndex = -1;
            ESalonCB.SelectedIndex = -1;
            ETurCB.SelectedIndex = -1;
            EAdTxt.Clear();
            EBiletFiyatTxt.Clear();
            ESaatTxt.Clear();
            EMaliyetTxt.Clear();
            EBiletSatisBaslaTarihDTP.Value = DateTime.Now;
            EBiletSatisBitisTarihDTP.Value = DateTime.Now;
            EtkinlikTarihDTimeP.Value = DateTime.Now;
        }
        private void EtkinlikDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(EtkinlikDGV.CurrentRow.Cells["Id"].Value);

            MekanCekTxt.Clear();
            SalonCekTxt.Clear();
            EAdTxt.Clear();
            EMaliyetTxt.Clear();
            EBiletFiyatTxt.Clear();
            ESalonCB.SelectedIndex = -1;
            EMekanCB.SelectedIndex = -1;

            EtkinlikDoldur();

            DialogResult Eduzenlekontrol = new DialogResult();
            Eduzenlekontrol = MessageBox.Show("Etkinlik Düzenlenecek Mi?", "Etkinlik Düzenleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Eduzenlekontrol == DialogResult.Yes)
            {
                DialogResult mekansor = new DialogResult();
                mekansor = MessageBox.Show("Etkinlik Mekanı Aynı Mı?", "Etkinlik Düzenleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mekansor == DialogResult.Yes)
                {
                    EMekanCB.Enabled = false;
                    ESalonCB.Enabled = false;
                }
                else if (mekansor == DialogResult.No)
                {
                    EMekanCB.Enabled = true;
                    ESalonCB.Enabled = true;
                }
                ESaatTxt.Enabled = true;
            }
        }

        #endregion

        #region Changed

        private void EBiletSatisBaslaTarihDTP_ValueChanged(object sender, EventArgs e)
        {
            biletacilis = EBiletSatisBaslaTarihDTP.Value.Date.ToString("d.M.yyyy");
        }
        private void ESalonCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            BiletSayisiAl();
        }
        private void EBiletSatisBitisTarihDTP_ValueChanged(object sender, EventArgs e)
        {
            biletbitis = EBiletSatisBitisTarihDTP.Value.Date.ToString("d.M.yyyy");
        }
        private void EMekanCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EMekanCB.SelectedIndex != 0 && EMekanCB.SelectedIndex != -1)
            {
                SalonCBGetir();
            }
        }
        private void ETurCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ETurCB.SelectedIndex != 0 && ETurCB.SelectedIndex != -1)
            {
                turId = ETurCB.SelectedIndex;
            }
        }
        private void EtkinlikTarihDTimeP_ValueChanged(object sender, EventArgs e)
        {
            etkinliktarih = EtkinlikTarihDTimeP.Value.Date.ToString("d.M.yyyy");
            etkinliksaat = EtkinlikTarihDTimeP.Value.ToString("HH:mm");
        }
        private void EAraTxt_TextChanged(object sender, EventArgs e)
        {
            EtkinlikDGV.ClearSelection();

            ae.con.Open();

            string sorgu2 = "Select * from Etkinlikler where Ad like '%" + EAraTxt.Text + "%' ";

            DataTable dt = new DataTable();

            SqlDataAdapter etkinlikgetir = new SqlDataAdapter(sorgu2, ae.con);

            etkinlikgetir.Fill(dt);

            EtkinlikDGV.DataSource = dt;

            ae.con.Close();
        }

        #endregion
    }
}

