namespace Bilet.Resources.Personelİslemleri
{
    partial class PersonelIslemForm
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
            this.PersonelIslemBottomPanel = new System.Windows.Forms.Panel();
            this.PersonelList = new System.Windows.Forms.ListBox();
            this.PEkleBtn = new System.Windows.Forms.Button();
            this.PAraTxt = new System.Windows.Forms.TextBox();
            this.PDuzenleTxt = new System.Windows.Forms.Button();
            this.PSilTxt = new System.Windows.Forms.Button();
            this.PersonelGB = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PKullaniciAdTxt = new System.Windows.Forms.TextBox();
            this.PYetkiCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PMaasTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PSifreTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PTCTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PSoyadTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PAdTxt = new System.Windows.Forms.TextBox();
            this.PersonelIslemTopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.PersonelIslemBottomPanel.SuspendLayout();
            this.PersonelGB.SuspendLayout();
            this.PersonelIslemTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersonelIslemBottomPanel
            // 
            this.PersonelIslemBottomPanel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.PersonelIslemBottomPanel.Controls.Add(this.PersonelList);
            this.PersonelIslemBottomPanel.Controls.Add(this.PEkleBtn);
            this.PersonelIslemBottomPanel.Controls.Add(this.PAraTxt);
            this.PersonelIslemBottomPanel.Controls.Add(this.PDuzenleTxt);
            this.PersonelIslemBottomPanel.Controls.Add(this.PSilTxt);
            this.PersonelIslemBottomPanel.Controls.Add(this.PersonelGB);
            this.PersonelIslemBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PersonelIslemBottomPanel.Location = new System.Drawing.Point(0, 84);
            this.PersonelIslemBottomPanel.Name = "PersonelIslemBottomPanel";
            this.PersonelIslemBottomPanel.Size = new System.Drawing.Size(982, 419);
            this.PersonelIslemBottomPanel.TabIndex = 1;
            // 
            // PersonelList
            // 
            this.PersonelList.BackColor = System.Drawing.Color.IndianRed;
            this.PersonelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PersonelList.FormattingEnabled = true;
            this.PersonelList.ItemHeight = 17;
            this.PersonelList.Location = new System.Drawing.Point(734, 49);
            this.PersonelList.Name = "PersonelList";
            this.PersonelList.Size = new System.Drawing.Size(236, 293);
            this.PersonelList.TabIndex = 6;
            this.PersonelList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PersonelList_MouseDoubleClick);
            // 
            // PEkleBtn
            // 
            this.PEkleBtn.BackColor = System.Drawing.Color.DarkRed;
            this.PEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PEkleBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PEkleBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PEkleBtn.Location = new System.Drawing.Point(544, 68);
            this.PEkleBtn.Name = "PEkleBtn";
            this.PEkleBtn.Size = new System.Drawing.Size(184, 70);
            this.PEkleBtn.TabIndex = 5;
            this.PEkleBtn.Text = "Personel Ekle";
            this.PEkleBtn.UseVisualStyleBackColor = false;
            this.PEkleBtn.Click += new System.EventHandler(this.PEkleBtn_Click_1);
            // 
            // PAraTxt
            // 
            this.PAraTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PAraTxt.Location = new System.Drawing.Point(734, 21);
            this.PAraTxt.Name = "PAraTxt";
            this.PAraTxt.PlaceholderText = "Personel Giriniz";
            this.PAraTxt.Size = new System.Drawing.Size(236, 22);
            this.PAraTxt.TabIndex = 4;
            this.PAraTxt.TextChanged += new System.EventHandler(this.PAraTxt_TextChanged);
            // 
            // PDuzenleTxt
            // 
            this.PDuzenleTxt.BackColor = System.Drawing.Color.DarkRed;
            this.PDuzenleTxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PDuzenleTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PDuzenleTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PDuzenleTxt.Location = new System.Drawing.Point(544, 245);
            this.PDuzenleTxt.Name = "PDuzenleTxt";
            this.PDuzenleTxt.Size = new System.Drawing.Size(184, 70);
            this.PDuzenleTxt.TabIndex = 3;
            this.PDuzenleTxt.Text = "Personel Düzenle";
            this.PDuzenleTxt.UseVisualStyleBackColor = false;
            this.PDuzenleTxt.Click += new System.EventHandler(this.PDuzenleTxt_Click);
            // 
            // PSilTxt
            // 
            this.PSilTxt.BackColor = System.Drawing.Color.DarkRed;
            this.PSilTxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PSilTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PSilTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PSilTxt.Location = new System.Drawing.Point(544, 160);
            this.PSilTxt.Name = "PSilTxt";
            this.PSilTxt.Size = new System.Drawing.Size(184, 70);
            this.PSilTxt.TabIndex = 2;
            this.PSilTxt.Text = "Personel Sil";
            this.PSilTxt.UseVisualStyleBackColor = false;
            this.PSilTxt.Click += new System.EventHandler(this.PSilTxt_Click);
            // 
            // PersonelGB
            // 
            this.PersonelGB.Controls.Add(this.label8);
            this.PersonelGB.Controls.Add(this.PKullaniciAdTxt);
            this.PersonelGB.Controls.Add(this.PYetkiCB);
            this.PersonelGB.Controls.Add(this.label7);
            this.PersonelGB.Controls.Add(this.PMaasTxt);
            this.PersonelGB.Controls.Add(this.label6);
            this.PersonelGB.Controls.Add(this.label5);
            this.PersonelGB.Controls.Add(this.PSifreTxt);
            this.PersonelGB.Controls.Add(this.label4);
            this.PersonelGB.Controls.Add(this.PTCTxt);
            this.PersonelGB.Controls.Add(this.label3);
            this.PersonelGB.Controls.Add(this.PSoyadTxt);
            this.PersonelGB.Controls.Add(this.label2);
            this.PersonelGB.Controls.Add(this.PAdTxt);
            this.PersonelGB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PersonelGB.Location = new System.Drawing.Point(12, 13);
            this.PersonelGB.Name = "PersonelGB";
            this.PersonelGB.Size = new System.Drawing.Size(516, 340);
            this.PersonelGB.TabIndex = 0;
            this.PersonelGB.TabStop = false;
            this.PersonelGB.Text = "Personel Bilgileri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(25, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Personel Kullanıcı Adı:";
            // 
            // PKullaniciAdTxt
            // 
            this.PKullaniciAdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PKullaniciAdTxt.Location = new System.Drawing.Point(207, 196);
            this.PKullaniciAdTxt.MaxLength = 500;
            this.PKullaniciAdTxt.Name = "PKullaniciAdTxt";
            this.PKullaniciAdTxt.Size = new System.Drawing.Size(290, 22);
            this.PKullaniciAdTxt.TabIndex = 13;
            // 
            // PYetkiCB
            // 
            this.PYetkiCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PYetkiCB.FormattingEnabled = true;
            this.PYetkiCB.Location = new System.Drawing.Point(207, 44);
            this.PYetkiCB.Name = "PYetkiCB";
            this.PYetkiCB.Size = new System.Drawing.Size(290, 24);
            this.PYetkiCB.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(25, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Personel Maaş:";
            // 
            // PMaasTxt
            // 
            this.PMaasTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PMaasTxt.Location = new System.Drawing.Point(207, 279);
            this.PMaasTxt.Name = "PMaasTxt";
            this.PMaasTxt.Size = new System.Drawing.Size(290, 22);
            this.PMaasTxt.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(25, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Personel Yetkisi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(25, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Personel Şifresi:";
            // 
            // PSifreTxt
            // 
            this.PSifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PSifreTxt.Location = new System.Drawing.Point(207, 240);
            this.PSifreTxt.MaxLength = 5;
            this.PSifreTxt.Name = "PSifreTxt";
            this.PSifreTxt.Size = new System.Drawing.Size(290, 22);
            this.PSifreTxt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "T.C. Kimlik Numarası:";
            // 
            // PTCTxt
            // 
            this.PTCTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PTCTxt.Location = new System.Drawing.Point(207, 155);
            this.PTCTxt.MaxLength = 11;
            this.PTCTxt.Name = "PTCTxt";
            this.PTCTxt.Size = new System.Drawing.Size(290, 22);
            this.PTCTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Personel Soyadı:";
            // 
            // PSoyadTxt
            // 
            this.PSoyadTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PSoyadTxt.Location = new System.Drawing.Point(207, 119);
            this.PSoyadTxt.Name = "PSoyadTxt";
            this.PSoyadTxt.Size = new System.Drawing.Size(290, 22);
            this.PSoyadTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personel Adı:";
            // 
            // PAdTxt
            // 
            this.PAdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PAdTxt.Location = new System.Drawing.Point(207, 81);
            this.PAdTxt.Name = "PAdTxt";
            this.PAdTxt.Size = new System.Drawing.Size(290, 22);
            this.PAdTxt.TabIndex = 0;
            // 
            // PersonelIslemTopPanel
            // 
            this.PersonelIslemTopPanel.BackColor = System.Drawing.Color.Firebrick;
            this.PersonelIslemTopPanel.Controls.Add(this.ClearBtn);
            this.PersonelIslemTopPanel.Controls.Add(this.label1);
            this.PersonelIslemTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PersonelIslemTopPanel.Location = new System.Drawing.Point(0, 0);
            this.PersonelIslemTopPanel.Name = "PersonelIslemTopPanel";
            this.PersonelIslemTopPanel.Size = new System.Drawing.Size(982, 78);
            this.PersonelIslemTopPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "PERSONEL İŞLEMLERİ";
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackgroundImage = global::Bilet.Properties.Resources.clear;
            this.ClearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ClearBtn.Location = new System.Drawing.Point(910, 9);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(60, 60);
            this.ClearBtn.TabIndex = 6;
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // PersonelIslemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 503);
            this.Controls.Add(this.PersonelIslemTopPanel);
            this.Controls.Add(this.PersonelIslemBottomPanel);
            this.Name = "PersonelIslemForm";
            this.Text = "Personel İşlem Form";
            this.Load += new System.EventHandler(this.PersonelİslemForm_Load);
            this.PersonelIslemBottomPanel.ResumeLayout(false);
            this.PersonelIslemBottomPanel.PerformLayout();
            this.PersonelGB.ResumeLayout(false);
            this.PersonelGB.PerformLayout();
            this.PersonelIslemTopPanel.ResumeLayout(false);
            this.PersonelIslemTopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PersonelIslemBottomPanel;
        private System.Windows.Forms.GroupBox PersonelGB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PSifreTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PTCTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PSoyadTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PAdTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PMaasTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button PDuzenleTxt;
        private System.Windows.Forms.Button PSilTxt;
        private System.Windows.Forms.TextBox PAraTxt;
        private System.Windows.Forms.Button PEkleBtn;
        private System.Windows.Forms.ComboBox PYetkiCB;
        private System.Windows.Forms.ListBox PersonelList;
        private System.Windows.Forms.Panel PersonelIslemTopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox PKullaniciAdTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ClearBtn;
    }
}