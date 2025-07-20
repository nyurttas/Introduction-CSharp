namespace Introduction
{
    partial class _13_KelimeOyunu2
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
            btnBasla = new Button();
            flwKelime = new FlowLayoutPanel();
            flwAlfabe = new FlowLayoutPanel();
            lblHak = new Label();
            lblDogru = new Label();
            SuspendLayout();
            // 
            // btnBasla
            // 
            btnBasla.Location = new Point(12, 12);
            btnBasla.Name = "btnBasla";
            btnBasla.Size = new Size(662, 100);
            btnBasla.TabIndex = 0;
            btnBasla.Text = "Kelime Seç ve Başla";
            btnBasla.UseVisualStyleBackColor = true;
            btnBasla.Click += btnBasla_Click;
            // 
            // flwKelime
            // 
            flwKelime.Location = new Point(12, 118);
            flwKelime.Name = "flwKelime";
            flwKelime.Size = new Size(1094, 199);
            flwKelime.TabIndex = 1;
            // 
            // flwAlfabe
            // 
            flwAlfabe.Location = new Point(12, 332);
            flwAlfabe.Name = "flwAlfabe";
            flwAlfabe.Size = new Size(1094, 348);
            flwAlfabe.TabIndex = 2;
            // 
            // lblHak
            // 
            lblHak.Location = new Point(680, 12);
            lblHak.Name = "lblHak";
            lblHak.Size = new Size(209, 100);
            lblHak.TabIndex = 3;
            lblHak.Text = "Hak";
            // 
            // lblDogru
            // 
            lblDogru.Location = new Point(906, 12);
            lblDogru.Name = "lblDogru";
            lblDogru.Size = new Size(200, 100);
            lblDogru.TabIndex = 3;
            lblDogru.Text = "Doğru";
            // 
            // _13_KelimeOyunu2
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 709);
            Controls.Add(lblDogru);
            Controls.Add(lblHak);
            Controls.Add(flwAlfabe);
            Controls.Add(flwKelime);
            Controls.Add(btnBasla);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "_13_KelimeOyunu2";
            Text = "_13_KelimeOyunu2";
            Load += _13_KelimeOyunu2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBasla;
        private FlowLayoutPanel flwKelime;
        private FlowLayoutPanel flwAlfabe;
        private Label lblHak;
        private Label lblDogru;
    }
}