namespace _7_BankProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnHesapAc = new Button();
            cmbHesapTuru = new ComboBox();
            txtAySonuBakiye = new TextBox();
            lblAySonu = new Label();
            txtIlkBakiye = new TextBox();
            label4 = new Label();
            txtAdSoyad = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtHesapNo = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnAySonu = new Button();
            btnIslemYap = new Button();
            cmbIslemTuru = new ComboBox();
            txtNot = new TextBox();
            label7 = new Label();
            txtTutar = new TextBox();
            label8 = new Label();
            label9 = new Label();
            lblHesapHareketleri = new Label();
            groupBox3 = new GroupBox();
            lblSonBakiye = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnHesapAc);
            groupBox1.Controls.Add(cmbHesapTuru);
            groupBox1.Controls.Add(txtAySonuBakiye);
            groupBox1.Controls.Add(lblAySonu);
            groupBox1.Controls.Add(txtIlkBakiye);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtHesapNo);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(640, 355);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hesap Açma İşlemleri";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnHesapAc
            // 
            btnHesapAc.Location = new Point(393, 287);
            btnHesapAc.Name = "btnHesapAc";
            btnHesapAc.Size = new Size(241, 61);
            btnHesapAc.TabIndex = 3;
            btnHesapAc.Text = "Hesap Aç";
            btnHesapAc.UseVisualStyleBackColor = true;
            btnHesapAc.Click += btnHesapAc_Click;
            // 
            // cmbHesapTuru
            // 
            cmbHesapTuru.FormattingEnabled = true;
            cmbHesapTuru.Location = new Point(222, 91);
            cmbHesapTuru.Name = "cmbHesapTuru";
            cmbHesapTuru.Size = new Size(412, 45);
            cmbHesapTuru.TabIndex = 2;
            cmbHesapTuru.SelectedIndexChanged += cmbHesapTuru_SelectedIndexChanged;
            // 
            // txtAySonuBakiye
            // 
            txtAySonuBakiye.Location = new Point(222, 238);
            txtAySonuBakiye.Name = "txtAySonuBakiye";
            txtAySonuBakiye.Size = new Size(412, 43);
            txtAySonuBakiye.TabIndex = 1;
            // 
            // lblAySonu
            // 
            lblAySonu.AutoSize = true;
            lblAySonu.Location = new Point(6, 244);
            lblAySonu.Name = "lblAySonu";
            lblAySonu.Size = new Size(196, 37);
            lblAySonu.TabIndex = 0;
            lblAySonu.Text = "Ay Sonu Bakiye";
            // 
            // txtIlkBakiye
            // 
            txtIlkBakiye.Location = new Point(222, 189);
            txtIlkBakiye.Name = "txtIlkBakiye";
            txtIlkBakiye.Size = new Size(412, 43);
            txtIlkBakiye.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 195);
            label4.Name = "label4";
            label4.Size = new Size(127, 37);
            label4.TabIndex = 0;
            label4.Text = "İlk Bakiye";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(222, 140);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(412, 43);
            txtAdSoyad.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 146);
            label3.Name = "label3";
            label3.Size = new Size(130, 37);
            label3.TabIndex = 0;
            label3.Text = "Ad Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 97);
            label2.Name = "label2";
            label2.Size = new Size(151, 37);
            label2.TabIndex = 0;
            label2.Text = "Hesap Türü";
            // 
            // txtHesapNo
            // 
            txtHesapNo.Enabled = false;
            txtHesapNo.Location = new Point(222, 42);
            txtHesapNo.Name = "txtHesapNo";
            txtHesapNo.Size = new Size(412, 43);
            txtHesapNo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 48);
            label1.Name = "label1";
            label1.Size = new Size(134, 37);
            label1.TabIndex = 0;
            label1.Text = "Hesap No";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAySonu);
            groupBox2.Controls.Add(btnIslemYap);
            groupBox2.Controls.Add(cmbIslemTuru);
            groupBox2.Controls.Add(txtNot);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtTutar);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(12, 373);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(640, 318);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nakit İşlemleri";
            // 
            // btnAySonu
            // 
            btnAySonu.Location = new Point(222, 246);
            btnAySonu.Name = "btnAySonu";
            btnAySonu.Size = new Size(165, 61);
            btnAySonu.TabIndex = 3;
            btnAySonu.Text = "Ay Sonu";
            btnAySonu.UseVisualStyleBackColor = true;
            // 
            // btnIslemYap
            // 
            btnIslemYap.Location = new Point(393, 246);
            btnIslemYap.Name = "btnIslemYap";
            btnIslemYap.Size = new Size(241, 61);
            btnIslemYap.TabIndex = 3;
            btnIslemYap.Text = "İşlem Yap";
            btnIslemYap.UseVisualStyleBackColor = true;
            btnIslemYap.Click += btnIslemYap_Click;
            // 
            // cmbIslemTuru
            // 
            cmbIslemTuru.FormattingEnabled = true;
            cmbIslemTuru.Location = new Point(222, 51);
            cmbIslemTuru.Name = "cmbIslemTuru";
            cmbIslemTuru.Size = new Size(412, 45);
            cmbIslemTuru.TabIndex = 2;
            cmbIslemTuru.SelectedIndexChanged += cmbIslemTuru_SelectedIndexChanged;
            // 
            // txtNot
            // 
            txtNot.Location = new Point(222, 149);
            txtNot.Multiline = true;
            txtNot.Name = "txtNot";
            txtNot.Size = new Size(412, 91);
            txtNot.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 155);
            label7.Name = "label7";
            label7.Size = new Size(146, 37);
            label7.TabIndex = 0;
            label7.Text = "İşlem Notu";
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(222, 100);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(412, 43);
            txtTutar.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 103);
            label8.Name = "label8";
            label8.Size = new Size(78, 37);
            label8.TabIndex = 0;
            label8.Text = "Tutar";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 57);
            label9.Name = "label9";
            label9.Size = new Size(139, 37);
            label9.TabIndex = 0;
            label9.Text = "İşlem Türü";
            // 
            // lblHesapHareketleri
            // 
            lblHesapHareketleri.Location = new Point(6, 48);
            lblHesapHareketleri.Name = "lblHesapHareketleri";
            lblHesapHareketleri.Size = new Size(431, 527);
            lblHesapHareketleri.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblHesapHareketleri);
            groupBox3.Controls.Add(lblSonBakiye);
            groupBox3.Location = new Point(658, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(443, 677);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hesap Hareketleri";
            // 
            // lblSonBakiye
            // 
            lblSonBakiye.Location = new Point(6, 619);
            lblSonBakiye.Name = "lblSonBakiye";
            lblSonBakiye.Size = new Size(431, 37);
            lblSonBakiye.TabIndex = 0;
            lblSonBakiye.Click += lblSonBakiye_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 701);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnHesapAc;
        private ComboBox cmbHesapTuru;
        private TextBox txtAySonuBakiye;
        private Label lblAySonu;
        private TextBox txtIlkBakiye;
        private Label label4;
        private TextBox txtAdSoyad;
        private Label label3;
        private Label label2;
        private TextBox txtHesapNo;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnIslemYap;
        private ComboBox cmbIslemTuru;
        private TextBox txtNot;
        private Label label7;
        private TextBox txtTutar;
        private Label label8;
        private Label label9;
        private Button btnAySonu;
        private Label lblHesapHareketleri;
        private GroupBox groupBox3;
        private Label lblSonBakiye;
    }
}
