namespace Introduction
{
    partial class Degiskenler
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
            btnDelete = new Button();
            textBox1 = new TextBox();
            btnListele = new Button();
            button3 = new Button();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            btnGetir = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(46, 16);
            btnDelete.Margin = new Padding(6, 7, 6, 7);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(309, 62);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "button1";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(46, 320);
            textBox1.Margin = new Padding(6, 7, 6, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(630, 43);
            textBox1.TabIndex = 1;
            textBox1.Text = "Caner";
            // 
            // btnListele
            // 
            btnListele.Location = new Point(46, 78);
            btnListele.Margin = new Padding(6, 7, 6, 7);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(309, 62);
            btnListele.TabIndex = 0;
            btnListele.Text = "button1";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // button3
            // 
            button3.Location = new Point(46, 141);
            button3.Margin = new Padding(6, 7, 6, 7);
            button3.Name = "button3";
            button3.Size = new Size(309, 62);
            button3.TabIndex = 0;
            button3.Text = "button1";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(367, 16);
            btnKaydet.Margin = new Padding(6, 7, 6, 7);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(309, 62);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(367, 78);
            btnGuncelle.Margin = new Padding(6, 7, 6, 7);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(309, 62);
            btnGuncelle.TabIndex = 0;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnGetir
            // 
            btnGetir.Location = new Point(367, 141);
            btnGetir.Margin = new Padding(6, 7, 6, 7);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(309, 62);
            btnGetir.TabIndex = 0;
            btnGetir.Text = "button1";
            btnGetir.UseVisualStyleBackColor = true;
            btnGetir.Click += button6_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(46, 213);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(630, 45);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 276);
            label1.Name = "label1";
            label1.Size = new Size(219, 37);
            label1.TabIndex = 3;
            label1.Text = "Ad Soyad Giriniz:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(46, 385);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(244, 41);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Sistem Kapalı Mı?";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(425, 385);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(191, 41);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // Degiskenler
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 474);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(btnGetir);
            Controls.Add(button3);
            Controls.Add(btnGuncelle);
            Controls.Add(btnListele);
            Controls.Add(btnKaydet);
            Controls.Add(btnDelete);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Degiskenler";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private TextBox textBox1;
        private Button btnListele;
        private Button button3;
        private Button btnKaydet;
        private Button btnGuncelle;
        private Button btnGetir;
        private ComboBox comboBox1;
        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}
