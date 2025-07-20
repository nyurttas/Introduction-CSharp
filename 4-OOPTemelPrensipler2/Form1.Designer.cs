namespace _4_OOPTemelPrensipler2
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
            cmbKategoriler = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtUrunAdi = new TextBox();
            nmrAdet = new NumericUpDown();
            btnSepeteEkle = new Button();
            lstSepet = new ListBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)nmrAdet).BeginInit();
            SuspendLayout();
            // 
            // cmbKategoriler
            // 
            cmbKategoriler.FormattingEnabled = true;
            cmbKategoriler.Location = new Point(21, 61);
            cmbKategoriler.Name = "cmbKategoriler";
            cmbKategoriler.Size = new Size(519, 45);
            cmbKategoriler.TabIndex = 0;
            cmbKategoriler.SelectedIndexChanged += cmbKategoriler_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(326, 37);
            label1.TabIndex = 1;
            label1.Text = "Lütfen bir kategori seçiniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 109);
            label2.Name = "label2";
            label2.Size = new Size(122, 37);
            label2.TabIndex = 1;
            label2.Text = "Ürün Adı";
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(21, 158);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(519, 43);
            txtUrunAdi.TabIndex = 2;
            // 
            // nmrAdet
            // 
            nmrAdet.Location = new Point(340, 217);
            nmrAdet.Name = "nmrAdet";
            nmrAdet.Size = new Size(200, 43);
            nmrAdet.TabIndex = 3;
            // 
            // btnSepeteEkle
            // 
            btnSepeteEkle.Location = new Point(306, 269);
            btnSepeteEkle.Name = "btnSepeteEkle";
            btnSepeteEkle.Size = new Size(118, 68);
            btnSepeteEkle.TabIndex = 4;
            btnSepeteEkle.Text = "EKLE";
            btnSepeteEkle.UseVisualStyleBackColor = true;
            btnSepeteEkle.Click += btnSepeteEkle_Click;
            // 
            // lstSepet
            // 
            lstSepet.FormattingEnabled = true;
            lstSepet.ItemHeight = 37;
            lstSepet.Location = new Point(565, 61);
            lstSepet.Name = "lstSepet";
            lstSepet.Size = new Size(342, 448);
            lstSepet.TabIndex = 5;
            lstSepet.SelectedIndexChanged += lstSepet_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(21, 457);
            button1.Name = "button1";
            button1.Size = new Size(519, 52);
            button1.TabIndex = 6;
            button1.Text = "Polymorphism";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(430, 269);
            button2.Name = "button2";
            button2.Size = new Size(110, 68);
            button2.TabIndex = 7;
            button2.Text = "SİL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 547);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lstSepet);
            Controls.Add(btnSepeteEkle);
            Controls.Add(nmrAdet);
            Controls.Add(txtUrunAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbKategoriler);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nmrAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbKategoriler;
        private Label label1;
        private Label label2;
        private TextBox txtUrunAdi;
        private NumericUpDown nmrAdet;
        private Button btnSepeteEkle;
        private ListBox lstSepet;
        private Button button1;
        private Button button2;
    }
}
