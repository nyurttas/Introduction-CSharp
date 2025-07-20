namespace _2_Ado.Net
{
    partial class Form2
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
            label1 = new Label();
            cmbCategories = new ComboBox();
            lblProductCount = new Label();
            label3 = new Label();
            lstProductList = new ListBox();
            dgwDetails = new DataGridView();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwDetails).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 29);
            label1.Name = "label1";
            label1.Size = new Size(326, 37);
            label1.TabIndex = 0;
            label1.Text = "Lütfen bir kategori seçiniz:";
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(26, 69);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(717, 45);
            cmbCategories.TabIndex = 1;
            cmbCategories.SelectedIndexChanged += cmbCategories_SelectedIndexChanged;
            // 
            // lblProductCount
            // 
            lblProductCount.AutoSize = true;
            lblProductCount.Location = new Point(749, 69);
            lblProductCount.Name = "lblProductCount";
            lblProductCount.Size = new Size(152, 37);
            lblProductCount.TabIndex = 0;
            lblProductCount.Text = "Ürün Adedi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 131);
            label3.Name = "label3";
            label3.Size = new Size(154, 37);
            label3.TabIndex = 0;
            label3.Text = "Ürün Listesi";
            // 
            // lstProductList
            // 
            lstProductList.FormattingEnabled = true;
            lstProductList.ItemHeight = 37;
            lstProductList.Location = new Point(26, 171);
            lstProductList.Name = "lstProductList";
            lstProductList.Size = new Size(309, 411);
            lstProductList.TabIndex = 2;
            lstProductList.SelectedIndexChanged += lstProductList_SelectedIndexChanged;
            // 
            // dgwDetails
            // 
            dgwDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwDetails.Location = new Point(357, 171);
            dgwDetails.Name = "dgwDetails";
            dgwDetails.Size = new Size(850, 411);
            dgwDetails.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(357, 131);
            label4.Name = "label4";
            label4.Size = new Size(208, 37);
            label4.TabIndex = 0;
            label4.Text = "Sipariş Detayları";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 602);
            Controls.Add(dgwDetails);
            Controls.Add(lstProductList);
            Controls.Add(cmbCategories);
            Controls.Add(lblProductCount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgwDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbCategories;
        private Label lblProductCount;
        private Label label3;
        private ListBox lstProductList;
        private DataGridView dgwDetails;
        private Label label4;
    }
}