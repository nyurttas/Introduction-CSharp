namespace Introduction
{
    partial class _8_OgrenciTakip
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
            btnHesapla = new Button();
            txtAdSoyad = new TextBox();
            label1 = new Label();
            lstListe = new ListBox();
            txtVize = new TextBox();
            label2 = new Label();
            txtFinal = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(381, 424);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(384, 64);
            btnHesapla.TabIndex = 0;
            btnHesapla.Text = "Not Ortalaması Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(12, 57);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(753, 43);
            txtAdSoyad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(130, 37);
            label1.TabIndex = 2;
            label1.Text = "Ad Soyad";
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 37;
            lstListe.Location = new Point(12, 192);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(753, 226);
            lstListe.TabIndex = 3;
            // 
            // txtVize
            // 
            txtVize.Location = new Point(12, 143);
            txtVize.Name = "txtVize";
            txtVize.Size = new Size(340, 43);
            txtVize.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(134, 37);
            label2.TabIndex = 2;
            label2.Text = "Vize Notu";
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(425, 143);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(340, 43);
            txtFinal.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(425, 103);
            label3.Name = "label3";
            label3.Size = new Size(140, 37);
            label3.TabIndex = 2;
            label3.Text = "Final Notu";
            // 
            // _8_OgrenciTakip
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(781, 510);
            Controls.Add(lstListe);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtFinal);
            Controls.Add(label1);
            Controls.Add(txtVize);
            Controls.Add(txtAdSoyad);
            Controls.Add(btnHesapla);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "_8_OgrenciTakip";
            Text = "_8_OgrenciTakip";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHesapla;
        private TextBox txtAdSoyad;
        private Label label1;
        private ListBox lstListe;
        private TextBox txtVize;
        private Label label2;
        private TextBox txtFinal;
        private Label label3;
    }
}