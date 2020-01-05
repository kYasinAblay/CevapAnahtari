namespace CevapAnahtari
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtCevaplar = new System.Windows.Forms.TextBox();
            this.listCevapAnahtari = new System.Windows.Forms.ListBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblSonucInklap = new System.Windows.Forms.Label();
            this.lblDin = new System.Windows.Forms.Label();
            this.lblIngilizce = new System.Windows.Forms.Label();
            this.lblMatematik = new System.Windows.Forms.Label();
            this.lblFen = new System.Windows.Forms.Label();
            this.lblSoruSirasi = new System.Windows.Forms.Label();
            this.txtSoruSayisi = new System.Windows.Forms.TextBox();
            this.lblSoruSayisi = new System.Windows.Forms.Label();
            this.btnSoruSayisiAl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGeriAl = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnOku = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCevaplar
            // 
            this.txtCevaplar.Enabled = false;
            this.txtCevaplar.Font = new System.Drawing.Font("Heartwrecked", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCevaplar.Location = new System.Drawing.Point(24, 273);
            this.txtCevaplar.Name = "txtCevaplar";
            this.txtCevaplar.Size = new System.Drawing.Size(176, 31);
            this.txtCevaplar.TabIndex = 0;
            this.txtCevaplar.TextChanged += new System.EventHandler(this.txtCevaplar_TextChanged);
            // 
            // listCevapAnahtari
            // 
            this.listCevapAnahtari.ItemHeight = 16;
            this.listCevapAnahtari.Location = new System.Drawing.Point(12, 12);
            this.listCevapAnahtari.Name = "listCevapAnahtari";
            this.listCevapAnahtari.Size = new System.Drawing.Size(17, 20);
            this.listCevapAnahtari.TabIndex = 2;
            this.listCevapAnahtari.Visible = false;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Heartwrecked", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSonuc.Location = new System.Drawing.Point(18, 64);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(173, 31);
            this.lblSonuc.TabIndex = 6;
            this.lblSonuc.Text = "Türkçe Soruları";
            // 
            // lblSonucInklap
            // 
            this.lblSonucInklap.AutoSize = true;
            this.lblSonucInklap.Font = new System.Drawing.Font("Heartwrecked", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSonucInklap.Location = new System.Drawing.Point(18, 91);
            this.lblSonucInklap.Name = "lblSonucInklap";
            this.lblSonucInklap.Size = new System.Drawing.Size(166, 31);
            this.lblSonucInklap.TabIndex = 7;
            this.lblSonucInklap.Text = "Inkılap Soruları";
            // 
            // lblDin
            // 
            this.lblDin.AutoSize = true;
            this.lblDin.Font = new System.Drawing.Font("Heartwrecked", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDin.Location = new System.Drawing.Point(18, 119);
            this.lblDin.Name = "lblDin";
            this.lblDin.Size = new System.Drawing.Size(130, 31);
            this.lblDin.TabIndex = 8;
            this.lblDin.Text = "Din Soruları";
            // 
            // lblIngilizce
            // 
            this.lblIngilizce.AutoSize = true;
            this.lblIngilizce.Font = new System.Drawing.Font("Heartwrecked", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIngilizce.Location = new System.Drawing.Point(19, 148);
            this.lblIngilizce.Name = "lblIngilizce";
            this.lblIngilizce.Size = new System.Drawing.Size(181, 31);
            this.lblIngilizce.TabIndex = 9;
            this.lblIngilizce.Text = "Ingilizce Soruları";
            // 
            // lblMatematik
            // 
            this.lblMatematik.AutoSize = true;
            this.lblMatematik.Font = new System.Drawing.Font("Heartwrecked", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMatematik.Location = new System.Drawing.Point(18, 179);
            this.lblMatematik.Name = "lblMatematik";
            this.lblMatematik.Size = new System.Drawing.Size(208, 31);
            this.lblMatematik.TabIndex = 10;
            this.lblMatematik.Text = "Matematik Soruları";
            // 
            // lblFen
            // 
            this.lblFen.AutoSize = true;
            this.lblFen.Font = new System.Drawing.Font("Heartwrecked", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFen.Location = new System.Drawing.Point(19, 208);
            this.lblFen.Name = "lblFen";
            this.lblFen.Size = new System.Drawing.Size(134, 31);
            this.lblFen.TabIndex = 11;
            this.lblFen.Text = "Fen Soruları";
            // 
            // lblSoruSirasi
            // 
            this.lblSoruSirasi.AutoSize = true;
            this.lblSoruSirasi.Font = new System.Drawing.Font("Blazed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoruSirasi.Location = new System.Drawing.Point(131, 321);
            this.lblSoruSirasi.Name = "lblSoruSirasi";
            this.lblSoruSirasi.Size = new System.Drawing.Size(53, 34);
            this.lblSoruSirasi.TabIndex = 15;
            this.lblSoruSirasi.Text = "__";
            // 
            // txtSoruSayisi
            // 
            this.txtSoruSayisi.Font = new System.Drawing.Font("Federation", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoruSayisi.Location = new System.Drawing.Point(25, 325);
            this.txtSoruSayisi.Name = "txtSoruSayisi";
            this.txtSoruSayisi.Size = new System.Drawing.Size(94, 30);
            this.txtSoruSayisi.TabIndex = 16;
            this.txtSoruSayisi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoruSayisi_KeyDown);
            this.txtSoruSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoruSayisi_KeyPress);
            // 
            // lblSoruSayisi
            // 
            this.lblSoruSayisi.AutoSize = true;
            this.lblSoruSayisi.Font = new System.Drawing.Font("ResotYg PERSONAL USE", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoruSayisi.Location = new System.Drawing.Point(22, 307);
            this.lblSoruSayisi.Name = "lblSoruSayisi";
            this.lblSoruSayisi.Size = new System.Drawing.Size(117, 15);
            this.lblSoruSayisi.TabIndex = 17;
            this.lblSoruSayisi.Text = "Soru Sayısı";
            // 
            // btnSoruSayisiAl
            // 
            this.btnSoruSayisiAl.Image = global::CevapAnahtari.Properties.Resources.icons8_space_shuttle_64;
            this.btnSoruSayisiAl.Location = new System.Drawing.Point(9, 26);
            this.btnSoruSayisiAl.Name = "btnSoruSayisiAl";
            this.btnSoruSayisiAl.Size = new System.Drawing.Size(20, 25);
            this.btnSoruSayisiAl.TabIndex = 18;
            this.btnSoruSayisiAl.UseVisualStyleBackColor = true;
            this.btnSoruSayisiAl.Visible = false;
            this.btnSoruSayisiAl.Click += new System.EventHandler(this.btnSoruSayisiAl_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::CevapAnahtari.Properties.Resources.icons8_delete_16;
            this.button1.Location = new System.Drawing.Point(378, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 52);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGeriAl
            // 
            this.btnGeriAl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGeriAl.Image = global::CevapAnahtari.Properties.Resources.icons8_take_it_easy_64;
            this.btnGeriAl.Location = new System.Drawing.Point(203, 272);
            this.btnGeriAl.Name = "btnGeriAl";
            this.btnGeriAl.Size = new System.Drawing.Size(90, 80);
            this.btnGeriAl.TabIndex = 12;
            this.btnGeriAl.UseVisualStyleBackColor = false;
            this.btnGeriAl.Click += new System.EventHandler(this.btnGeriAl_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Image = global::CevapAnahtari.Properties.Resources.icons8_clear_symbol_100;
            this.btnTemizle.Location = new System.Drawing.Point(293, 272);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(124, 80);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemizle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnOku
            // 
            this.btnOku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOku.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOku.Image = global::CevapAnahtari.Properties.Resources.icons8_steam_engine_40;
            this.btnOku.Location = new System.Drawing.Point(25, 12);
            this.btnOku.Margin = new System.Windows.Forms.Padding(5);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(345, 52);
            this.btnOku.TabIndex = 13;
            this.btnOku.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOku.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnOku.UseVisualStyleBackColor = true;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ResotYg PERSONAL USE", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cevaplar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Kamil Yasin ABLAY tarafından yapılmıştır. 2020";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(427, 402);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSoruSayisiAl);
            this.Controls.Add(this.lblSoruSayisi);
            this.Controls.Add(this.txtSoruSayisi);
            this.Controls.Add(this.lblSoruSirasi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGeriAl);
            this.Controls.Add(this.lblFen);
            this.Controls.Add(this.lblMatematik);
            this.Controls.Add(this.lblIngilizce);
            this.Controls.Add(this.lblDin);
            this.Controls.Add(this.lblSonucInklap);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.listCevapAnahtari);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.txtCevaplar);
            this.Controls.Add(this.btnOku);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cevap Anahtarı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCevaplar;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ListBox listCevapAnahtari;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblSonucInklap;
        private System.Windows.Forms.Label lblDin;
        private System.Windows.Forms.Label lblIngilizce;
        private System.Windows.Forms.Label lblMatematik;
        private System.Windows.Forms.Label lblFen;
        private System.Windows.Forms.Button btnGeriAl;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnOku;
        private System.Windows.Forms.Label lblSoruSirasi;
        private System.Windows.Forms.TextBox txtSoruSayisi;
        private System.Windows.Forms.Label lblSoruSayisi;
        private System.Windows.Forms.Button btnSoruSayisiAl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

