namespace Introduction
{
    partial class _11_RegularExpression
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
            txtDeger = new TextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(23, 101);
            button1.Name = "button1";
            button1.Size = new Size(537, 67);
            button1.TabIndex = 0;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtDeger
            // 
            txtDeger.Location = new Point(23, 52);
            txtDeger.Name = "txtDeger";
            txtDeger.Size = new Size(537, 43);
            txtDeger.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(23, 174);
            button2.Name = "button2";
            button2.Size = new Size(537, 64);
            button2.TabIndex = 2;
            button2.Text = "Harf Test";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(23, 244);
            button3.Name = "button3";
            button3.Size = new Size(537, 73);
            button3.TabIndex = 3;
            button3.Text = "Email Kotrol";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // _11_RegularExpression
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(814, 507);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtDeger);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "_11_RegularExpression";
            Text = "_11_RegularExpression";
            Load += _11_RegularExpression_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtDeger;
        private Button button2;
        private Button button3;
    }
}