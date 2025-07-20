namespace Introduction
{
    partial class _10_KursTakip
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
            lstListe = new ListBox();
            btnKaydet = new Button();
            grpEgitimler = new GroupBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            txtAdSoyad = new TextBox();
            label2 = new Label();
            txtTC = new TextBox();
            label1 = new Label();
            grpEgitimler.SuspendLayout();
            SuspendLayout();
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 37;
            lstListe.Location = new Point(8, 12);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(894, 263);
            lstListe.TabIndex = 2;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(212, 394);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(373, 56);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // grpEgitimler
            // 
            grpEgitimler.Controls.Add(checkBox5);
            grpEgitimler.Controls.Add(checkBox4);
            grpEgitimler.Controls.Add(checkBox3);
            grpEgitimler.Controls.Add(checkBox2);
            grpEgitimler.Controls.Add(checkBox1);
            grpEgitimler.Location = new Point(601, 287);
            grpEgitimler.Name = "grpEgitimler";
            grpEgitimler.Size = new Size(291, 286);
            grpEgitimler.TabIndex = 8;
            grpEgitimler.TabStop = false;
            grpEgitimler.Text = "Eğitim Listesi";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(21, 237);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(212, 41);
            checkBox5.TabIndex = 0;
            checkBox5.Text = ".Net Core MVC";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(21, 190);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(100, 41);
            checkBox4.TabIndex = 0;
            checkBox4.Text = "React";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(21, 143);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(169, 41);
            checkBox3.TabIndex = 0;
            checkBox3.Text = "Yapay Zeka";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(21, 96);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(119, 41);
            checkBox2.TabIndex = 0;
            checkBox2.Text = "Phyton";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(21, 49);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(222, 41);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "C# Introduction";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(212, 345);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(373, 43);
            txtAdSoyad.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 345);
            label2.Name = "label2";
            label2.Size = new Size(142, 37);
            label2.TabIndex = 3;
            label2.Text = "AD SOYAD";
            // 
            // txtTC
            // 
            txtTC.Location = new Point(212, 296);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(373, 43);
            txtTC.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 296);
            label1.Name = "label1";
            label1.Size = new Size(94, 37);
            label1.TabIndex = 4;
            label1.Text = "TC NO";
            // 
            // _10_KursTakip
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(914, 600);
            Controls.Add(btnKaydet);
            Controls.Add(grpEgitimler);
            Controls.Add(txtAdSoyad);
            Controls.Add(label2);
            Controls.Add(txtTC);
            Controls.Add(label1);
            Controls.Add(lstListe);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "_10_KursTakip";
            Text = "_10_KursTakip";
            Load += _10_KursTakip_Load;
            grpEgitimler.ResumeLayout(false);
            grpEgitimler.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private ListBox lstListe;
        private Button btnKaydet;
        private GroupBox grpEgitimler;
        private CheckBox checkBox1;
        private TextBox txtAdSoyad;
        private Label label2;
        private TextBox txtTC;
        private Label label1;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
    }
}