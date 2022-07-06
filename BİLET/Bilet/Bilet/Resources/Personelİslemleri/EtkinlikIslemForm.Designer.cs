namespace Bilet.Resources.Personelİslemleri
{
    partial class EtkinlikIslemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EIslemBottomPanel = new System.Windows.Forms.Panel();
            this.EAraTxt = new System.Windows.Forms.TextBox();
            this.EtkinlikDGV = new System.Windows.Forms.DataGridView();
            this.EEkleBtn = new System.Windows.Forms.Button();
            this.EDuzenleTxt = new System.Windows.Forms.Button();
            this.ESilTxt = new System.Windows.Forms.Button();
            this.EtkinlikGB = new System.Windows.Forms.GroupBox();
            this.SalonCekTxt = new System.Windows.Forms.TextBox();
            this.MekanCekTxt = new System.Windows.Forms.TextBox();
            this.ESaatTxt = new System.Windows.Forms.TextBox();
            this.EBiletSatisBaslaTarihDTP = new System.Windows.Forms.DateTimePicker();
            this.EBiletSatisBitisTarihDTP = new System.Windows.Forms.DateTimePicker();
            this.EBiletFiyatTxt = new System.Windows.Forms.TextBox();
            this.EMaliyetTxt = new System.Windows.Forms.TextBox();
            this.EMekanCB = new System.Windows.Forms.ComboBox();
            this.ESalonCB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ETurCB = new System.Windows.Forms.ComboBox();
            this.EAdTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EtkinlikTarihDTimeP = new System.Windows.Forms.DateTimePicker();
            this.EtkinlikIslemTopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.EIslemBottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EtkinlikDGV)).BeginInit();
            this.EtkinlikGB.SuspendLayout();
            this.EtkinlikIslemTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EIslemBottomPanel
            // 
            this.EIslemBottomPanel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.EIslemBottomPanel.Controls.Add(this.EAraTxt);
            this.EIslemBottomPanel.Controls.Add(this.EtkinlikDGV);
            this.EIslemBottomPanel.Controls.Add(this.EEkleBtn);
            this.EIslemBottomPanel.Controls.Add(this.EDuzenleTxt);
            this.EIslemBottomPanel.Controls.Add(this.ESilTxt);
            this.EIslemBottomPanel.Controls.Add(this.EtkinlikGB);
            this.EIslemBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EIslemBottomPanel.Location = new System.Drawing.Point(0, 86);
            this.EIslemBottomPanel.Name = "EIslemBottomPanel";
            this.EIslemBottomPanel.Size = new System.Drawing.Size(968, 676);
            this.EIslemBottomPanel.TabIndex = 3;
            // 
            // EAraTxt
            // 
            this.EAraTxt.Location = new System.Drawing.Point(774, 13);
            this.EAraTxt.Name = "EAraTxt";
            this.EAraTxt.PlaceholderText = "          Etkinlik Ad Ara";
            this.EAraTxt.Size = new System.Drawing.Size(184, 27);
            this.EAraTxt.TabIndex = 7;
            this.EAraTxt.TextChanged += new System.EventHandler(this.EAraTxt_TextChanged);
            // 
            // EtkinlikDGV
            // 
            this.EtkinlikDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EtkinlikDGV.Location = new System.Drawing.Point(12, 357);
            this.EtkinlikDGV.Name = "EtkinlikDGV";
            this.EtkinlikDGV.RowHeadersWidth = 51;
            this.EtkinlikDGV.RowTemplate.Height = 29;
            this.EtkinlikDGV.Size = new System.Drawing.Size(948, 307);
            this.EtkinlikDGV.TabIndex = 4;
            this.EtkinlikDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EtkinlikDGV_CellDoubleClick);
            // 
            // EEkleBtn
            // 
            this.EEkleBtn.BackColor = System.Drawing.Color.DarkRed;
            this.EEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EEkleBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EEkleBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EEkleBtn.Location = new System.Drawing.Point(774, 46);
            this.EEkleBtn.Name = "EEkleBtn";
            this.EEkleBtn.Size = new System.Drawing.Size(184, 70);
            this.EEkleBtn.TabIndex = 5;
            this.EEkleBtn.Text = "Etkinlik Ekle";
            this.EEkleBtn.UseVisualStyleBackColor = false;
            this.EEkleBtn.Click += new System.EventHandler(this.EEkleBtn_Click);
            // 
            // EDuzenleTxt
            // 
            this.EDuzenleTxt.BackColor = System.Drawing.Color.DarkRed;
            this.EDuzenleTxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EDuzenleTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EDuzenleTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EDuzenleTxt.Location = new System.Drawing.Point(774, 198);
            this.EDuzenleTxt.Name = "EDuzenleTxt";
            this.EDuzenleTxt.Size = new System.Drawing.Size(184, 70);
            this.EDuzenleTxt.TabIndex = 3;
            this.EDuzenleTxt.Text = "Etkinlik Düzenle";
            this.EDuzenleTxt.UseVisualStyleBackColor = false;
            this.EDuzenleTxt.Click += new System.EventHandler(this.EDuzenleTxt_Click);
            // 
            // ESilTxt
            // 
            this.ESilTxt.BackColor = System.Drawing.Color.DarkRed;
            this.ESilTxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ESilTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ESilTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ESilTxt.Location = new System.Drawing.Point(774, 122);
            this.ESilTxt.Name = "ESilTxt";
            this.ESilTxt.Size = new System.Drawing.Size(184, 70);
            this.ESilTxt.TabIndex = 2;
            this.ESilTxt.Text = "Etkinlik Sil";
            this.ESilTxt.UseVisualStyleBackColor = false;
            this.ESilTxt.Click += new System.EventHandler(this.ESilTxt_Click);
            // 
            // EtkinlikGB
            // 
            this.EtkinlikGB.Controls.Add(this.SalonCekTxt);
            this.EtkinlikGB.Controls.Add(this.MekanCekTxt);
            this.EtkinlikGB.Controls.Add(this.ESaatTxt);
            this.EtkinlikGB.Controls.Add(this.EBiletSatisBaslaTarihDTP);
            this.EtkinlikGB.Controls.Add(this.EBiletSatisBitisTarihDTP);
            this.EtkinlikGB.Controls.Add(this.EBiletFiyatTxt);
            this.EtkinlikGB.Controls.Add(this.EMaliyetTxt);
            this.EtkinlikGB.Controls.Add(this.EMekanCB);
            this.EtkinlikGB.Controls.Add(this.ESalonCB);
            this.EtkinlikGB.Controls.Add(this.label11);
            this.EtkinlikGB.Controls.Add(this.label10);
            this.EtkinlikGB.Controls.Add(this.label9);
            this.EtkinlikGB.Controls.Add(this.label8);
            this.EtkinlikGB.Controls.Add(this.label7);
            this.EtkinlikGB.Controls.Add(this.label6);
            this.EtkinlikGB.Controls.Add(this.label5);
            this.EtkinlikGB.Controls.Add(this.label4);
            this.EtkinlikGB.Controls.Add(this.label3);
            this.EtkinlikGB.Controls.Add(this.ETurCB);
            this.EtkinlikGB.Controls.Add(this.EAdTxt);
            this.EtkinlikGB.Controls.Add(this.label2);
            this.EtkinlikGB.Controls.Add(this.EtkinlikTarihDTimeP);
            this.EtkinlikGB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EtkinlikGB.Location = new System.Drawing.Point(12, 13);
            this.EtkinlikGB.Name = "EtkinlikGB";
            this.EtkinlikGB.Size = new System.Drawing.Size(753, 338);
            this.EtkinlikGB.TabIndex = 0;
            this.EtkinlikGB.TabStop = false;
            this.EtkinlikGB.Text = "Etkinlik Bilgileri";
            // 
            // SalonCekTxt
            // 
            this.SalonCekTxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalonCekTxt.Location = new System.Drawing.Point(370, 146);
            this.SalonCekTxt.Name = "SalonCekTxt";
            this.SalonCekTxt.Size = new System.Drawing.Size(194, 30);
            this.SalonCekTxt.TabIndex = 21;
            // 
            // MekanCekTxt
            // 
            this.MekanCekTxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MekanCekTxt.Location = new System.Drawing.Point(370, 109);
            this.MekanCekTxt.Name = "MekanCekTxt";
            this.MekanCekTxt.Size = new System.Drawing.Size(194, 30);
            this.MekanCekTxt.TabIndex = 20;
            // 
            // ESaatTxt
            // 
            this.ESaatTxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ESaatTxt.Location = new System.Drawing.Point(165, 219);
            this.ESaatTxt.Name = "ESaatTxt";
            this.ESaatTxt.Size = new System.Drawing.Size(194, 30);
            this.ESaatTxt.TabIndex = 19;
            // 
            // EBiletSatisBaslaTarihDTP
            // 
            this.EBiletSatisBaslaTarihDTP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EBiletSatisBaslaTarihDTP.Location = new System.Drawing.Point(370, 73);
            this.EBiletSatisBaslaTarihDTP.Name = "EBiletSatisBaslaTarihDTP";
            this.EBiletSatisBaslaTarihDTP.Size = new System.Drawing.Size(194, 30);
            this.EBiletSatisBaslaTarihDTP.TabIndex = 18;
            this.EBiletSatisBaslaTarihDTP.ValueChanged += new System.EventHandler(this.EBiletSatisBaslaTarihDTP_ValueChanged);
            // 
            // EBiletSatisBitisTarihDTP
            // 
            this.EBiletSatisBitisTarihDTP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EBiletSatisBitisTarihDTP.Location = new System.Drawing.Point(370, 216);
            this.EBiletSatisBitisTarihDTP.Name = "EBiletSatisBitisTarihDTP";
            this.EBiletSatisBitisTarihDTP.Size = new System.Drawing.Size(194, 30);
            this.EBiletSatisBitisTarihDTP.TabIndex = 17;
            this.EBiletSatisBitisTarihDTP.ValueChanged += new System.EventHandler(this.EBiletSatisBitisTarihDTP_ValueChanged);
            // 
            // EBiletFiyatTxt
            // 
            this.EBiletFiyatTxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EBiletFiyatTxt.Location = new System.Drawing.Point(165, 255);
            this.EBiletFiyatTxt.Name = "EBiletFiyatTxt";
            this.EBiletFiyatTxt.Size = new System.Drawing.Size(194, 30);
            this.EBiletFiyatTxt.TabIndex = 16;
            // 
            // EMaliyetTxt
            // 
            this.EMaliyetTxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EMaliyetTxt.Location = new System.Drawing.Point(522, 255);
            this.EMaliyetTxt.Name = "EMaliyetTxt";
            this.EMaliyetTxt.Size = new System.Drawing.Size(194, 30);
            this.EMaliyetTxt.TabIndex = 15;
            // 
            // EMekanCB
            // 
            this.EMekanCB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EMekanCB.FormattingEnabled = true;
            this.EMekanCB.Location = new System.Drawing.Point(165, 109);
            this.EMekanCB.Name = "EMekanCB";
            this.EMekanCB.Size = new System.Drawing.Size(194, 31);
            this.EMekanCB.TabIndex = 14;
            this.EMekanCB.SelectedIndexChanged += new System.EventHandler(this.EMekanCB_SelectedIndexChanged);
            // 
            // ESalonCB
            // 
            this.ESalonCB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ESalonCB.FormattingEnabled = true;
            this.ESalonCB.Location = new System.Drawing.Point(165, 146);
            this.ESalonCB.Name = "ESalonCB";
            this.ESalonCB.Size = new System.Drawing.Size(194, 31);
            this.ESalonCB.TabIndex = 13;
            this.ESalonCB.SelectedIndexChanged += new System.EventHandler(this.ESalonCB_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(370, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 23);
            this.label11.TabIndex = 12;
            this.label11.Text = "Etkinlik Maliyeti:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(370, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 23);
            this.label10.TabIndex = 11;
            this.label10.Text = "Bilet Satış Bitiş Tarihi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(370, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Bilet Satış Başlangıç Tarihi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Bilet Ücreti:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Saat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Salon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mekan:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Etkinlik Adı:";
            // 
            // ETurCB
            // 
            this.ETurCB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ETurCB.FormattingEnabled = true;
            this.ETurCB.Location = new System.Drawing.Point(165, 36);
            this.ETurCB.Name = "ETurCB";
            this.ETurCB.Size = new System.Drawing.Size(194, 31);
            this.ETurCB.TabIndex = 3;
            this.ETurCB.SelectedIndexChanged += new System.EventHandler(this.ETurCB_SelectedIndexChanged);
            // 
            // EAdTxt
            // 
            this.EAdTxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EAdTxt.Location = new System.Drawing.Point(165, 73);
            this.EAdTxt.Name = "EAdTxt";
            this.EAdTxt.Size = new System.Drawing.Size(194, 30);
            this.EAdTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Etkinlik Türü:";
            // 
            // EtkinlikTarihDTimeP
            // 
            this.EtkinlikTarihDTimeP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EtkinlikTarihDTimeP.Location = new System.Drawing.Point(165, 183);
            this.EtkinlikTarihDTimeP.Name = "EtkinlikTarihDTimeP";
            this.EtkinlikTarihDTimeP.Size = new System.Drawing.Size(194, 30);
            this.EtkinlikTarihDTimeP.TabIndex = 0;
            this.EtkinlikTarihDTimeP.ValueChanged += new System.EventHandler(this.EtkinlikTarihDTimeP_ValueChanged);
            // 
            // EtkinlikIslemTopPanel
            // 
            this.EtkinlikIslemTopPanel.BackColor = System.Drawing.Color.Firebrick;
            this.EtkinlikIslemTopPanel.Controls.Add(this.ClearBtn);
            this.EtkinlikIslemTopPanel.Controls.Add(this.label1);
            this.EtkinlikIslemTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EtkinlikIslemTopPanel.Location = new System.Drawing.Point(0, 0);
            this.EtkinlikIslemTopPanel.Name = "EtkinlikIslemTopPanel";
            this.EtkinlikIslemTopPanel.Size = new System.Drawing.Size(968, 80);
            this.EtkinlikIslemTopPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(283, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "ETKİNLİK İŞLEMLERİ";
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackgroundImage = global::Bilet.Properties.Resources.clear;
            this.ClearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ClearBtn.Location = new System.Drawing.Point(896, 9);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(60, 60);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // EtkinlikIslemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 762);
            this.Controls.Add(this.EIslemBottomPanel);
            this.Controls.Add(this.EtkinlikIslemTopPanel);
            this.Name = "EtkinlikIslemForm";
            this.Text = "EtkinlikIslemForm";
            this.Load += new System.EventHandler(this.EtkinlikIslemForm_Load);
            this.EIslemBottomPanel.ResumeLayout(false);
            this.EIslemBottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EtkinlikDGV)).EndInit();
            this.EtkinlikGB.ResumeLayout(false);
            this.EtkinlikGB.PerformLayout();
            this.EtkinlikIslemTopPanel.ResumeLayout(false);
            this.EtkinlikIslemTopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EIslemBottomPanel;
        private System.Windows.Forms.Button EEkleBtn;
        private System.Windows.Forms.Button EDuzenleTxt;
        private System.Windows.Forms.Button ESilTxt;
        private System.Windows.Forms.GroupBox EtkinlikGB;
        private System.Windows.Forms.Panel EtkinlikIslemTopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EAraTxt;
        private System.Windows.Forms.DataGridView EtkinlikDGV;
        private System.Windows.Forms.DateTimePicker EtkinlikTarihDTimeP;
        private System.Windows.Forms.TextBox EAdTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ETurCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox EMekanCB;
        private System.Windows.Forms.ComboBox ESalonCB;
        private System.Windows.Forms.DateTimePicker EBiletSatisBaslaTarihDTP;
        private System.Windows.Forms.DateTimePicker EBiletSatisBitisTarihDTP;
        private System.Windows.Forms.TextBox EBiletFiyatTxt;
        private System.Windows.Forms.TextBox EMaliyetTxt;
        private System.Windows.Forms.TextBox ESaatTxt;
        private System.Windows.Forms.TextBox SalonCekTxt;
        private System.Windows.Forms.TextBox MekanCekTxt;
        private System.Windows.Forms.Button ClearBtn;
    }
}