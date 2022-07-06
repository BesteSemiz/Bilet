namespace Bilet
{
    partial class BiletIslemleri
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
            this.BiletTopPanel = new System.Windows.Forms.Panel();
            this.CikisBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BiletBottomPanel = new System.Windows.Forms.Panel();
            this.BilgiPanel = new System.Windows.Forms.Panel();
            this.CikanLbl = new System.Windows.Forms.Label();
            this.SAAdTxt = new System.Windows.Forms.TextBox();
            this.SASoyadTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KoltuklarLbl = new System.Windows.Forms.Label();
            this.BIadeBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ToplamLbl = new System.Windows.Forms.Label();
            this.ETarihLbl = new System.Windows.Forms.Label();
            this.EMekanLbl = new System.Windows.Forms.Label();
            this.BFiyatLbl = new System.Windows.Forms.Label();
            this.BiletAlBtn = new System.Windows.Forms.Button();
            this.AdetNUD = new System.Windows.Forms.NumericUpDown();
            this.EtkinlikAdLbl = new System.Windows.Forms.Label();
            this.KoltukPanel = new System.Windows.Forms.Panel();
            this.BiletTopPanel.SuspendLayout();
            this.BiletBottomPanel.SuspendLayout();
            this.BilgiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdetNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // BiletTopPanel
            // 
            this.BiletTopPanel.BackColor = System.Drawing.Color.Firebrick;
            this.BiletTopPanel.Controls.Add(this.CikisBtn);
            this.BiletTopPanel.Controls.Add(this.label1);
            this.BiletTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BiletTopPanel.Location = new System.Drawing.Point(0, 0);
            this.BiletTopPanel.Name = "BiletTopPanel";
            this.BiletTopPanel.Size = new System.Drawing.Size(1149, 125);
            this.BiletTopPanel.TabIndex = 0;
            // 
            // CikisBtn
            // 
            this.CikisBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CikisBtn.BackColor = System.Drawing.Color.Red;
            this.CikisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CikisBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CikisBtn.ForeColor = System.Drawing.Color.Black;
            this.CikisBtn.Location = new System.Drawing.Point(1087, 12);
            this.CikisBtn.Name = "CikisBtn";
            this.CikisBtn.Size = new System.Drawing.Size(50, 50);
            this.CikisBtn.TabIndex = 2;
            this.CikisBtn.Text = "X";
            this.CikisBtn.UseVisualStyleBackColor = false;
            this.CikisBtn.Click += new System.EventHandler(this.CikisBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(394, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "BİLET İŞLEMLERİ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BiletBottomPanel
            // 
            this.BiletBottomPanel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BiletBottomPanel.Controls.Add(this.BilgiPanel);
            this.BiletBottomPanel.Controls.Add(this.KoltukPanel);
            this.BiletBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BiletBottomPanel.Location = new System.Drawing.Point(0, 131);
            this.BiletBottomPanel.Name = "BiletBottomPanel";
            this.BiletBottomPanel.Size = new System.Drawing.Size(1149, 593);
            this.BiletBottomPanel.TabIndex = 1;
            // 
            // BilgiPanel
            // 
            this.BilgiPanel.Controls.Add(this.CikanLbl);
            this.BilgiPanel.Controls.Add(this.SAAdTxt);
            this.BilgiPanel.Controls.Add(this.SASoyadTxt);
            this.BilgiPanel.Controls.Add(this.label4);
            this.BilgiPanel.Controls.Add(this.label2);
            this.BilgiPanel.Controls.Add(this.KoltuklarLbl);
            this.BilgiPanel.Controls.Add(this.BIadeBtn);
            this.BilgiPanel.Controls.Add(this.label3);
            this.BilgiPanel.Controls.Add(this.ToplamLbl);
            this.BilgiPanel.Controls.Add(this.ETarihLbl);
            this.BilgiPanel.Controls.Add(this.EMekanLbl);
            this.BilgiPanel.Controls.Add(this.BFiyatLbl);
            this.BilgiPanel.Controls.Add(this.BiletAlBtn);
            this.BilgiPanel.Controls.Add(this.AdetNUD);
            this.BilgiPanel.Controls.Add(this.EtkinlikAdLbl);
            this.BilgiPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BilgiPanel.Location = new System.Drawing.Point(0, 101);
            this.BilgiPanel.Name = "BilgiPanel";
            this.BilgiPanel.Size = new System.Drawing.Size(1149, 492);
            this.BilgiPanel.TabIndex = 1;
            // 
            // CikanLbl
            // 
            this.CikanLbl.AutoSize = true;
            this.CikanLbl.BackColor = System.Drawing.Color.LightSalmon;
            this.CikanLbl.Location = new System.Drawing.Point(1016, 451);
            this.CikanLbl.Name = "CikanLbl";
            this.CikanLbl.Size = new System.Drawing.Size(0, 20);
            this.CikanLbl.TabIndex = 18;
            // 
            // SAAdTxt
            // 
            this.SAAdTxt.Location = new System.Drawing.Point(711, 32);
            this.SAAdTxt.Name = "SAAdTxt";
            this.SAAdTxt.Size = new System.Drawing.Size(258, 27);
            this.SAAdTxt.TabIndex = 17;
            // 
            // SASoyadTxt
            // 
            this.SASoyadTxt.Location = new System.Drawing.Point(711, 84);
            this.SASoyadTxt.Name = "SASoyadTxt";
            this.SASoyadTxt.Size = new System.Drawing.Size(258, 27);
            this.SASoyadTxt.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(527, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Satın Alan Adı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(527, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Satın Alan Soyadı:";
            // 
            // KoltuklarLbl
            // 
            this.KoltuklarLbl.AutoSize = true;
            this.KoltuklarLbl.BackColor = System.Drawing.Color.Firebrick;
            this.KoltuklarLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KoltuklarLbl.Location = new System.Drawing.Point(19, 305);
            this.KoltuklarLbl.Name = "KoltuklarLbl";
            this.KoltuklarLbl.Size = new System.Drawing.Size(0, 28);
            this.KoltuklarLbl.TabIndex = 13;
            // 
            // BIadeBtn
            // 
            this.BIadeBtn.BackColor = System.Drawing.Color.DarkRed;
            this.BIadeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BIadeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BIadeBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BIadeBtn.Location = new System.Drawing.Point(225, 425);
            this.BIadeBtn.Name = "BIadeBtn";
            this.BIadeBtn.Size = new System.Drawing.Size(184, 70);
            this.BIadeBtn.TabIndex = 12;
            this.BIadeBtn.Text = "BİLET IADE";
            this.BIadeBtn.UseVisualStyleBackColor = false;
            this.BIadeBtn.Click += new System.EventHandler(this.BIadeBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bilet Adeti: ";
            // 
            // ToplamLbl
            // 
            this.ToplamLbl.AutoSize = true;
            this.ToplamLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToplamLbl.Location = new System.Drawing.Point(329, 359);
            this.ToplamLbl.Name = "ToplamLbl";
            this.ToplamLbl.Size = new System.Drawing.Size(80, 28);
            this.ToplamLbl.TabIndex = 10;
            this.ToplamLbl.Text = "Toplam:";
            // 
            // ETarihLbl
            // 
            this.ETarihLbl.AutoSize = true;
            this.ETarihLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ETarihLbl.Location = new System.Drawing.Point(19, 83);
            this.ETarihLbl.Name = "ETarihLbl";
            this.ETarihLbl.Size = new System.Drawing.Size(135, 28);
            this.ETarihLbl.TabIndex = 9;
            this.ETarihLbl.Text = "Etkinlik Tarihi: ";
            // 
            // EMekanLbl
            // 
            this.EMekanLbl.AutoSize = true;
            this.EMekanLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EMekanLbl.Location = new System.Drawing.Point(19, 137);
            this.EMekanLbl.Name = "EMekanLbl";
            this.EMekanLbl.Size = new System.Drawing.Size(207, 28);
            this.EMekanLbl.TabIndex = 8;
            this.EMekanLbl.Text = "Etkinlik Yapılacağı Yer: ";
            // 
            // BFiyatLbl
            // 
            this.BFiyatLbl.AutoSize = true;
            this.BFiyatLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BFiyatLbl.Location = new System.Drawing.Point(19, 359);
            this.BFiyatLbl.Name = "BFiyatLbl";
            this.BFiyatLbl.Size = new System.Drawing.Size(111, 28);
            this.BFiyatLbl.TabIndex = 7;
            this.BFiyatLbl.Text = "Bilet Fiyatı: ";
            // 
            // BiletAlBtn
            // 
            this.BiletAlBtn.BackColor = System.Drawing.Color.DarkRed;
            this.BiletAlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BiletAlBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BiletAlBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BiletAlBtn.Location = new System.Drawing.Point(19, 425);
            this.BiletAlBtn.Name = "BiletAlBtn";
            this.BiletAlBtn.Size = new System.Drawing.Size(184, 70);
            this.BiletAlBtn.TabIndex = 6;
            this.BiletAlBtn.Text = "BİLET AL";
            this.BiletAlBtn.UseVisualStyleBackColor = false;
            this.BiletAlBtn.Click += new System.EventHandler(this.BiletAlBtn_Click);
            // 
            // AdetNUD
            // 
            this.AdetNUD.Location = new System.Drawing.Point(168, 248);
            this.AdetNUD.Name = "AdetNUD";
            this.AdetNUD.Size = new System.Drawing.Size(150, 27);
            this.AdetNUD.TabIndex = 1;
            this.AdetNUD.ValueChanged += new System.EventHandler(this.AdetNUD_ValueChanged);
            // 
            // EtkinlikAdLbl
            // 
            this.EtkinlikAdLbl.AutoSize = true;
            this.EtkinlikAdLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EtkinlikAdLbl.Location = new System.Drawing.Point(19, 28);
            this.EtkinlikAdLbl.Name = "EtkinlikAdLbl";
            this.EtkinlikAdLbl.Size = new System.Drawing.Size(119, 28);
            this.EtkinlikAdLbl.TabIndex = 0;
            this.EtkinlikAdLbl.Text = "Etkinlik Adı: ";
            // 
            // KoltukPanel
            // 
            this.KoltukPanel.AutoScroll = true;
            this.KoltukPanel.BackColor = System.Drawing.Color.IndianRed;
            this.KoltukPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.KoltukPanel.Location = new System.Drawing.Point(0, 0);
            this.KoltukPanel.Name = "KoltukPanel";
            this.KoltukPanel.Size = new System.Drawing.Size(1149, 219);
            this.KoltukPanel.TabIndex = 0;
            // 
            // BiletIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 724);
            this.Controls.Add(this.BiletBottomPanel);
            this.Controls.Add(this.BiletTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BiletIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilet İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BiletIslemleri_Load);
            this.BiletTopPanel.ResumeLayout(false);
            this.BiletTopPanel.PerformLayout();
            this.BiletBottomPanel.ResumeLayout(false);
            this.BilgiPanel.ResumeLayout(false);
            this.BilgiPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdetNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BiletTopPanel;
        private System.Windows.Forms.Panel BiletBottomPanel;
        private System.Windows.Forms.Panel KoltukPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel BilgiPanel;
        private System.Windows.Forms.Label EtkinlikAdLbl;
        private System.Windows.Forms.NumericUpDown AdetNUD;
        private System.Windows.Forms.Button BiletAlBtn;
        private System.Windows.Forms.Label ETarihLbl;
        private System.Windows.Forms.Label EMekanLbl;
        private System.Windows.Forms.Label BFiyatLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ToplamLbl;
        private System.Windows.Forms.Button BIadeBtn;
        private System.Windows.Forms.Label KoltuklarLbl;
        private System.Windows.Forms.Button CikisBtn;
        private System.Windows.Forms.TextBox SAAdTxt;
        private System.Windows.Forms.TextBox SASoyadTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CikanLbl;
    }
}