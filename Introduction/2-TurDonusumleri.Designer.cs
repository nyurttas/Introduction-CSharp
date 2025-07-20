namespace Introduction
{
    partial class _2_TurDonusumleri
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
            txtBirimFiyat = new TextBox();
            btnHesapla = new Button();
            lblMesaj = new Label();
            SuspendLayout();
            // 
            // txtBirimFiyat
            // 
            txtBirimFiyat.Location = new Point(15, 56);
            txtBirimFiyat.Margin = new Padding(6, 7, 6, 7);
            txtBirimFiyat.Name = "txtBirimFiyat";
            txtBirimFiyat.Size = new Size(713, 43);
            txtBirimFiyat.TabIndex = 11;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(357, 102);
            btnHesapla.Margin = new Padding(6, 7, 6, 7);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(371, 74);
            btnHesapla.TabIndex = 10;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // lblMesaj
            // 
            lblMesaj.Font = new Font("Segoe UI", 20F);
            lblMesaj.Location = new Point(15, 207);
            lblMesaj.Margin = new Padding(6, 0, 6, 0);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(713, 97);
            lblMesaj.TabIndex = 9;
            // 
            // _2_TurDonusumleri
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 361);
            Controls.Add(txtBirimFiyat);
            Controls.Add(btnHesapla);
            Controls.Add(lblMesaj);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "_2_TurDonusumleri";
            Text = "_2_TurDonusumleri";
            Load += _2_TurDonusumleri_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBirimFiyat;
        private Button btnHesapla;
        private Label lblMesaj;
    }
}