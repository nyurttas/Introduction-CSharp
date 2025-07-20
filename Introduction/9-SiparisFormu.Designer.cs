namespace Introduction
{
    partial class _9_SiparisFormu
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
            btnSepeteEkle = new Button();
            label1 = new Label();
            cmbKategori = new ComboBox();
            lstUrunListesi = new ListBox();
            label2 = new Label();
            nmrAdet = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            txtBirimFiyat = new TextBox();
            label5 = new Label();
            txtToplamTutar = new TextBox();
            label6 = new Label();
            lstSepet = new ListBox();
            grpFaturaTipi = new GroupBox();
            rdKurumsal = new RadioButton();
            rdBireysel = new RadioButton();
            lblSepetToplami = new Label();
            ((System.ComponentModel.ISupportInitialize)nmrAdet).BeginInit();
            grpFaturaTipi.SuspendLayout();
            SuspendLayout();
            // 
            // btnSepeteEkle
            // 
            btnSepeteEkle.Location = new Point(12, 513);
            btnSepeteEkle.Name = "btnSepeteEkle";
            btnSepeteEkle.Size = new Size(485, 61);
            btnSepeteEkle.TabIndex = 0;
            btnSepeteEkle.Text = "Sepete Ekle >>";
            btnSepeteEkle.UseVisualStyleBackColor = true;
            btnSepeteEkle.Click += btnSepeteEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(331, 37);
            label1.TabIndex = 1;
            label1.Text = "Lütfen Bir Kategori Seçiniz:";
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(12, 59);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(485, 45);
            cmbKategori.TabIndex = 2;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // lstUrunListesi
            // 
            lstUrunListesi.FormattingEnabled = true;
            lstUrunListesi.ItemHeight = 37;
            lstUrunListesi.Location = new Point(12, 147);
            lstUrunListesi.Name = "lstUrunListesi";
            lstUrunListesi.Size = new Size(485, 189);
            lstUrunListesi.TabIndex = 3;
            lstUrunListesi.SelectedIndexChanged += lstUrunListesi_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(154, 37);
            label2.TabIndex = 1;
            label2.Text = "Ürün Listesi";
            // 
            // nmrAdet
            // 
            nmrAdet.Location = new Point(12, 379);
            nmrAdet.Name = "nmrAdet";
            nmrAdet.Size = new Size(204, 43);
            nmrAdet.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 339);
            label3.Name = "label3";
            label3.Size = new Size(73, 37);
            label3.TabIndex = 1;
            label3.Text = "Adet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 339);
            label4.Name = "label4";
            label4.Size = new Size(141, 37);
            label4.TabIndex = 1;
            label4.Text = "Birim Fiyat";
            // 
            // txtBirimFiyat
            // 
            txtBirimFiyat.Location = new Point(239, 378);
            txtBirimFiyat.Name = "txtBirimFiyat";
            txtBirimFiyat.Size = new Size(258, 43);
            txtBirimFiyat.TabIndex = 5;
            txtBirimFiyat.KeyDown += txtBirimFiyat_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 425);
            label5.Name = "label5";
            label5.Size = new Size(172, 37);
            label5.TabIndex = 1;
            label5.Text = "Toplam Tutar";
            // 
            // txtToplamTutar
            // 
            txtToplamTutar.Location = new Point(12, 464);
            txtToplamTutar.Name = "txtToplamTutar";
            txtToplamTutar.Size = new Size(485, 43);
            txtToplamTutar.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(530, 19);
            label6.Name = "label6";
            label6.Size = new Size(84, 37);
            label6.TabIndex = 1;
            label6.Text = "Sepet";
            // 
            // lstSepet
            // 
            lstSepet.FormattingEnabled = true;
            lstSepet.ItemHeight = 37;
            lstSepet.Location = new Point(530, 59);
            lstSepet.Name = "lstSepet";
            lstSepet.Size = new Size(995, 189);
            lstSepet.TabIndex = 3;
            // 
            // grpFaturaTipi
            // 
            grpFaturaTipi.Controls.Add(rdKurumsal);
            grpFaturaTipi.Controls.Add(rdBireysel);
            grpFaturaTipi.Location = new Point(530, 316);
            grpFaturaTipi.Name = "grpFaturaTipi";
            grpFaturaTipi.Size = new Size(485, 212);
            grpFaturaTipi.TabIndex = 6;
            grpFaturaTipi.TabStop = false;
            grpFaturaTipi.Text = "Fatura Tipi";
            // 
            // rdKurumsal
            // 
            rdKurumsal.AutoSize = true;
            rdKurumsal.Location = new Point(22, 106);
            rdKurumsal.Name = "rdKurumsal";
            rdKurumsal.Size = new Size(225, 41);
            rdKurumsal.TabIndex = 0;
            rdKurumsal.TabStop = true;
            rdKurumsal.Text = "Kurumsal Fatura";
            rdKurumsal.UseVisualStyleBackColor = true;
            // 
            // rdBireysel
            // 
            rdBireysel.AutoSize = true;
            rdBireysel.Location = new Point(22, 59);
            rdBireysel.Name = "rdBireysel";
            rdBireysel.Size = new Size(205, 41);
            rdBireysel.TabIndex = 0;
            rdBireysel.TabStop = true;
            rdBireysel.Text = "Bireysel Fatura";
            rdBireysel.UseVisualStyleBackColor = true;
            // 
            // lblSepetToplami
            // 
            lblSepetToplami.AutoSize = true;
            lblSepetToplami.Location = new Point(530, 251);
            lblSepetToplami.Name = "lblSepetToplami";
            lblSepetToplami.Size = new Size(185, 37);
            lblSepetToplami.TabIndex = 1;
            lblSepetToplami.Text = "Sepet Toplamı";
            // 
            // _9_SiparisFormu
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1537, 581);
            Controls.Add(grpFaturaTipi);
            Controls.Add(txtToplamTutar);
            Controls.Add(txtBirimFiyat);
            Controls.Add(nmrAdet);
            Controls.Add(lstSepet);
            Controls.Add(lstUrunListesi);
            Controls.Add(cmbKategori);
            Controls.Add(lblSepetToplami);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnSepeteEkle);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "_9_SiparisFormu";
            Text = "_9_SiparisFormu";
            Load += _9_SiparisFormu_Load;
            ((System.ComponentModel.ISupportInitialize)nmrAdet).EndInit();
            grpFaturaTipi.ResumeLayout(false);
            grpFaturaTipi.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSepeteEkle;
        private Label label1;
        private ComboBox cmbKategori;
        private ListBox lstUrunListesi;
        private Label label2;
        private NumericUpDown nmrAdet;
        private Label label3;
        private Label label4;
        private TextBox txtBirimFiyat;
        private Label label5;
        private TextBox txtToplamTutar;
        private Label label6;
        private ListBox lstSepet;
        private GroupBox grpFaturaTipi;
        private RadioButton rdKurumsal;
        private RadioButton rdBireysel;
        private Label lblSepetToplami;
    }
}