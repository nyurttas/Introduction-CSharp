namespace Introduction
{
    partial class _3_KararYapilari
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
            button1 = new Button();
            button2 = new Button();
            btnHesapla = new Button();
            txtTutar = new TextBox();
            label1 = new Label();
            lblMesaj = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(30, 29);
            button1.Name = "button1";
            button1.Size = new Size(360, 66);
            button1.TabIndex = 0;
            button1.Text = "Ve Operatörü";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(30, 101);
            button2.Name = "button2";
            button2.Size = new Size(360, 66);
            button2.TabIndex = 0;
            button2.Text = "Veya Operatörü";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(467, 301);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(162, 67);
            btnHesapla.TabIndex = 1;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(41, 252);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(588, 43);
            txtTutar.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 203);
            label1.Name = "label1";
            label1.Size = new Size(249, 37);
            label1.TabIndex = 3;
            label1.Text = "Müşteri Satış Tutarı:";
            // 
            // lblMesaj
            // 
            lblMesaj.Location = new Point(41, 377);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(588, 144);
            lblMesaj.TabIndex = 3;
            // 
            // _3_KararYapilari
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 530);
            Controls.Add(lblMesaj);
            Controls.Add(label1);
            Controls.Add(txtTutar);
            Controls.Add(btnHesapla);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "_3_KararYapilari";
            Text = "_3_KararYapilari";
            Load += _3_KararYapilari_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btnHesapla;
        private TextBox txtTutar;
        private Label label1;
        private Label lblMesaj;
    }
}