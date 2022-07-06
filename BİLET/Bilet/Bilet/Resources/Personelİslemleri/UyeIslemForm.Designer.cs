namespace Bilet.Resources.Personelİslemleri
{
    partial class UyeIslemForm
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
            this.UyeIslemBottomPanel = new System.Windows.Forms.Panel();
            this.UyeList = new System.Windows.Forms.ListBox();
            this.UEkleBtn = new System.Windows.Forms.Button();
            this.UAraTxt = new System.Windows.Forms.TextBox();
            this.UDuzenleBtn = new System.Windows.Forms.Button();
            this.USilTxt = new System.Windows.Forms.Button();
            this.UyeGB = new System.Windows.Forms.GroupBox();
            this.UKullaniciAdTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UMailTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.USoyadTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UAdTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.USifreTxt = new System.Windows.Forms.TextBox();
            this.UyeIslemTopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.UyeIslemBottomPanel.SuspendLayout();
            this.UyeGB.SuspendLayout();
            this.UyeIslemTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UyeIslemBottomPanel
            // 
            this.UyeIslemBottomPanel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.UyeIslemBottomPanel.Controls.Add(this.UyeList);
            this.UyeIslemBottomPanel.Controls.Add(this.UEkleBtn);
            this.UyeIslemBottomPanel.Controls.Add(this.UAraTxt);
            this.UyeIslemBottomPanel.Controls.Add(this.UDuzenleBtn);
            this.UyeIslemBottomPanel.Controls.Add(this.USilTxt);
            this.UyeIslemBottomPanel.Controls.Add(this.UyeGB);
            this.UyeIslemBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UyeIslemBottomPanel.Location = new System.Drawing.Point(0, 86);
            this.UyeIslemBottomPanel.Name = "UyeIslemBottomPanel";
            this.UyeIslemBottomPanel.Size = new System.Drawing.Size(784, 364);
            this.UyeIslemBottomPanel.TabIndex = 3;
            // 
            // UyeList
            // 
            this.UyeList.BackColor = System.Drawing.Color.IndianRed;
            this.UyeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UyeList.FormattingEnabled = true;
            this.UyeList.ItemHeight = 17;
            this.UyeList.Location = new System.Drawing.Point(534, 81);
            this.UyeList.Name = "UyeList";
            this.UyeList.Size = new System.Drawing.Size(236, 191);
            this.UyeList.TabIndex = 6;
            this.UyeList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UyeList_MouseDoubleClick);
            // 
            // UEkleBtn
            // 
            this.UEkleBtn.BackColor = System.Drawing.Color.DarkRed;
            this.UEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UEkleBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UEkleBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UEkleBtn.Location = new System.Drawing.Point(14, 278);
            this.UEkleBtn.Name = "UEkleBtn";
            this.UEkleBtn.Size = new System.Drawing.Size(184, 70);
            this.UEkleBtn.TabIndex = 5;
            this.UEkleBtn.Text = "Üye Ekle";
            this.UEkleBtn.UseVisualStyleBackColor = false;
            this.UEkleBtn.Click += new System.EventHandler(this.UEkleBtn_Click);
            // 
            // UAraTxt
            // 
            this.UAraTxt.Location = new System.Drawing.Point(534, 48);
            this.UAraTxt.Name = "UAraTxt";
            this.UAraTxt.PlaceholderText = "Üye Giriniz";
            this.UAraTxt.Size = new System.Drawing.Size(236, 27);
            this.UAraTxt.TabIndex = 4;
            this.UAraTxt.TextChanged += new System.EventHandler(this.UAraTxt_TextChanged);
            // 
            // UDuzenleBtn
            // 
            this.UDuzenleBtn.BackColor = System.Drawing.Color.DarkRed;
            this.UDuzenleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UDuzenleBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UDuzenleBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UDuzenleBtn.Location = new System.Drawing.Point(394, 278);
            this.UDuzenleBtn.Name = "UDuzenleBtn";
            this.UDuzenleBtn.Size = new System.Drawing.Size(184, 70);
            this.UDuzenleBtn.TabIndex = 3;
            this.UDuzenleBtn.Text = "Üye Düzenle";
            this.UDuzenleBtn.UseVisualStyleBackColor = false;
            this.UDuzenleBtn.Click += new System.EventHandler(this.UDuzenleBtn_Click);
            // 
            // USilTxt
            // 
            this.USilTxt.BackColor = System.Drawing.Color.DarkRed;
            this.USilTxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.USilTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.USilTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.USilTxt.Location = new System.Drawing.Point(204, 278);
            this.USilTxt.Name = "USilTxt";
            this.USilTxt.Size = new System.Drawing.Size(184, 70);
            this.USilTxt.TabIndex = 2;
            this.USilTxt.Text = "Üye Sil";
            this.USilTxt.UseVisualStyleBackColor = false;
            this.USilTxt.Click += new System.EventHandler(this.USilTxt_Click);
            // 
            // UyeGB
            // 
            this.UyeGB.Controls.Add(this.UKullaniciAdTxt);
            this.UyeGB.Controls.Add(this.label6);
            this.UyeGB.Controls.Add(this.label5);
            this.UyeGB.Controls.Add(this.UMailTxt);
            this.UyeGB.Controls.Add(this.label4);
            this.UyeGB.Controls.Add(this.USoyadTxt);
            this.UyeGB.Controls.Add(this.label3);
            this.UyeGB.Controls.Add(this.UAdTxt);
            this.UyeGB.Controls.Add(this.label2);
            this.UyeGB.Controls.Add(this.USifreTxt);
            this.UyeGB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UyeGB.Location = new System.Drawing.Point(12, 13);
            this.UyeGB.Name = "UyeGB";
            this.UyeGB.Size = new System.Drawing.Size(516, 259);
            this.UyeGB.TabIndex = 0;
            this.UyeGB.TabStop = false;
            this.UyeGB.Text = "Personel Bilgileri";
            // 
            // UKullaniciAdTxt
            // 
            this.UKullaniciAdTxt.Location = new System.Drawing.Point(203, 33);
            this.UKullaniciAdTxt.Name = "UKullaniciAdTxt";
            this.UKullaniciAdTxt.Size = new System.Drawing.Size(297, 30);
            this.UKullaniciAdTxt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(28, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kullancı Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(28, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Üye Mail Adresi:";
            // 
            // UMailTxt
            // 
            this.UMailTxt.Location = new System.Drawing.Point(203, 179);
            this.UMailTxt.Name = "UMailTxt";
            this.UMailTxt.Size = new System.Drawing.Size(297, 30);
            this.UMailTxt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Üye Adı:";
            // 
            // USoyadTxt
            // 
            this.USoyadTxt.Location = new System.Drawing.Point(203, 140);
            this.USoyadTxt.Name = "USoyadTxt";
            this.USoyadTxt.Size = new System.Drawing.Size(297, 30);
            this.USoyadTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Üye Soyadı:";
            // 
            // UAdTxt
            // 
            this.UAdTxt.Location = new System.Drawing.Point(203, 102);
            this.UAdTxt.Name = "UAdTxt";
            this.UAdTxt.Size = new System.Drawing.Size(297, 30);
            this.UAdTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Üye Şifresi:";
            // 
            // USifreTxt
            // 
            this.USifreTxt.Location = new System.Drawing.Point(203, 68);
            this.USifreTxt.MaxLength = 5;
            this.USifreTxt.Name = "USifreTxt";
            this.USifreTxt.Size = new System.Drawing.Size(297, 30);
            this.USifreTxt.TabIndex = 0;
            // 
            // UyeIslemTopPanel
            // 
            this.UyeIslemTopPanel.BackColor = System.Drawing.Color.Firebrick;
            this.UyeIslemTopPanel.Controls.Add(this.ClearBtn);
            this.UyeIslemTopPanel.Controls.Add(this.label1);
            this.UyeIslemTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UyeIslemTopPanel.Location = new System.Drawing.Point(0, 0);
            this.UyeIslemTopPanel.Name = "UyeIslemTopPanel";
            this.UyeIslemTopPanel.Size = new System.Drawing.Size(784, 80);
            this.UyeIslemTopPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜYE İŞLEMLERİ";
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackgroundImage = global::Bilet.Properties.Resources.clear;
            this.ClearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ClearBtn.Location = new System.Drawing.Point(710, 11);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(60, 60);
            this.ClearBtn.TabIndex = 5;
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // UyeIslemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.UyeIslemBottomPanel);
            this.Controls.Add(this.UyeIslemTopPanel);
            this.Name = "UyeIslemForm";
            this.Text = "UyeIslemForm";
            this.Load += new System.EventHandler(this.UyeIslemForm_Load);
            this.UyeIslemBottomPanel.ResumeLayout(false);
            this.UyeIslemBottomPanel.PerformLayout();
            this.UyeGB.ResumeLayout(false);
            this.UyeGB.PerformLayout();
            this.UyeIslemTopPanel.ResumeLayout(false);
            this.UyeIslemTopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UyeIslemBottomPanel;
        private System.Windows.Forms.ListBox UyeList;
        private System.Windows.Forms.Button UEkleBtn;
        private System.Windows.Forms.TextBox UAraTxt;
        private System.Windows.Forms.Button UDuzenleBtn;
        private System.Windows.Forms.Button USilTxt;
        private System.Windows.Forms.GroupBox UyeGB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UMailTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox USoyadTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UAdTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox USifreTxt;
        private System.Windows.Forms.Panel UyeIslemTopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UKullaniciAdTxt;
        private System.Windows.Forms.Button ClearBtn;
    }
}