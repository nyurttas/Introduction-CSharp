namespace Introduction
{
    partial class _6_RandomSayiUretme
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
            btnSayiUret = new Button();
            lstListe = new ListBox();
            btnSayiOlustur = new Button();
            SuspendLayout();
            // 
            // btnSayiUret
            // 
            btnSayiUret.Location = new Point(12, 403);
            btnSayiUret.Name = "btnSayiUret";
            btnSayiUret.Size = new Size(292, 74);
            btnSayiUret.TabIndex = 0;
            btnSayiUret.Text = "Sayı Oluştur";
            btnSayiUret.UseVisualStyleBackColor = true;
            btnSayiUret.Click += btnSayiUret_Click;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 37;
            lstListe.Location = new Point(12, 23);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(292, 374);
            lstListe.TabIndex = 1;
            // 
            // btnSayiOlustur
            // 
            btnSayiOlustur.Location = new Point(12, 483);
            btnSayiOlustur.Name = "btnSayiOlustur";
            btnSayiOlustur.Size = new Size(292, 80);
            btnSayiOlustur.TabIndex = 2;
            btnSayiOlustur.Text = "Sayı Oluştur V2.0";
            btnSayiOlustur.UseVisualStyleBackColor = true;
            btnSayiOlustur.Click += btnSayiOlustur_Click;
            // 
            // _6_RandomSayiUretme
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 611);
            Controls.Add(btnSayiOlustur);
            Controls.Add(lstListe);
            Controls.Add(btnSayiUret);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "_6_RandomSayiUretme";
            Text = "_6_RandomSayiUretme";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSayiUret;
        private ListBox lstListe;
        private Button btnSayiOlustur;
    }
}