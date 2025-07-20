namespace Introduction
{
    partial class _12_KelimeOyunu1
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

        private Button button1;
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            grpButonlar = new GroupBox();
            txtKelime = new TextBox();
            btnKelime = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(37, 29);
            button1.Name = "button1";
            button1.Size = new Size(261, 63);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // grpButonlar
            // 
            grpButonlar.Location = new Point(37, 139);
            grpButonlar.Name = "grpButonlar";
            grpButonlar.Size = new Size(851, 252);
            grpButonlar.TabIndex = 1;
            grpButonlar.TabStop = false;
            grpButonlar.Text = "Kelime Oluştur";
            // 
            // txtKelime
            // 
            txtKelime.Location = new Point(37, 416);
            txtKelime.Name = "txtKelime";
            txtKelime.Size = new Size(851, 43);
            txtKelime.TabIndex = 2;
            // 
            // btnKelime
            // 
            btnKelime.Location = new Point(637, 465);
            btnKelime.Name = "btnKelime";
            btnKelime.Size = new Size(251, 63);
            btnKelime.TabIndex = 3;
            btnKelime.Text = "Kelime Oluştur";
            btnKelime.UseVisualStyleBackColor = true;
            btnKelime.Click += btnKelime_Click;
            // 
            // _12_KelimeOyunu1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 595);
            Controls.Add(btnKelime);
            Controls.Add(txtKelime);
            Controls.Add(button1);
            Controls.Add(grpButonlar);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "_12_KelimeOyunu1";
            Text = "_12_KelimeOyunu1";
            Load += _12_KelimeOyunu1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private GroupBox grpButonlar;
        private TextBox txtKelime;
        private Button btnKelime;
    }
}