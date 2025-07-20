namespace _2_Ado.Net
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
            btnUrunler = new Button();
            btnKategoriler = new Button();
            button3 = new Button();
            lstListe = new ListBox();
            dgwKategoriler = new DataGridView();
            cmbKategoriler = new ComboBox();
            txtPrdName = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwKategoriler).BeginInit();
            SuspendLayout();
            // 
            // btnUrunler
            // 
            btnUrunler.Location = new Point(13, 16);
            btnUrunler.Name = "btnUrunler";
            btnUrunler.Size = new Size(386, 51);
            btnUrunler.TabIndex = 0;
            btnUrunler.Text = "Ürünleri Getir";
            btnUrunler.UseVisualStyleBackColor = true;
            btnUrunler.Click += btnUrunler_Click;
            // 
            // btnKategoriler
            // 
            btnKategoriler.Location = new Point(13, 73);
            btnKategoriler.Name = "btnKategoriler";
            btnKategoriler.Size = new Size(386, 51);
            btnKategoriler.TabIndex = 0;
            btnKategoriler.Text = "Kategorileri Getir";
            btnKategoriler.UseVisualStyleBackColor = true;
            btnKategoriler.Click += btnKategoriler_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 258);
            button3.Name = "button3";
            button3.Size = new Size(386, 51);
            button3.TabIndex = 0;
            button3.Text = "Ürün Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 37;
            lstListe.Location = new Point(418, 16);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(341, 411);
            lstListe.TabIndex = 1;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // dgwKategoriler
            // 
            dgwKategoriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwKategoriler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwKategoriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwKategoriler.Location = new Point(790, 16);
            dgwKategoriler.Name = "dgwKategoriler";
            dgwKategoriler.Size = new Size(584, 411);
            dgwKategoriler.TabIndex = 2;
            // 
            // cmbKategoriler
            // 
            cmbKategoriler.FormattingEnabled = true;
            cmbKategoriler.Location = new Point(13, 130);
            cmbKategoriler.Name = "cmbKategoriler";
            cmbKategoriler.Size = new Size(386, 45);
            cmbKategoriler.TabIndex = 3;
            // 
            // txtPrdName
            // 
            txtPrdName.Location = new Point(12, 209);
            txtPrdName.Name = "txtPrdName";
            txtPrdName.Size = new Size(386, 43);
            txtPrdName.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(13, 315);
            button1.Name = "button1";
            button1.Size = new Size(385, 64);
            button1.TabIndex = 5;
            button1.Text = "Kategori Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(13, 388);
            button2.Name = "button2";
            button2.Size = new Size(385, 53);
            button2.TabIndex = 6;
            button2.Text = "Kategori Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1392, 453);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPrdName);
            Controls.Add(cmbKategoriler);
            Controls.Add(dgwKategoriler);
            Controls.Add(lstListe);
            Controls.Add(button3);
            Controls.Add(btnKategoriler);
            Controls.Add(btnUrunler);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwKategoriler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUrunler;
        private Button btnKategoriler;
        private Button button3;
        private ListBox lstListe;
        private DataGridView dgwKategoriler;
        private ComboBox cmbKategoriler;
        private TextBox txtPrdName;
        private Button button1;
        private Button button2;
    }
}
