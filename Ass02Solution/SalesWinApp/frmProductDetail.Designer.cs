namespace SalesWinApp
{
    partial class frmProductDetail
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
            txtProductId = new TextBox();
            label2 = new Label();
            txtCategoryId = new TextBox();
            label3 = new Label();
            txtProductName = new TextBox();
            label4 = new Label();
            txtWeight = new TextBox();
            label5 = new Label();
            txtUnitPrice = new TextBox();
            label6 = new Label();
            txtUnitsInStock = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 47);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Product ID";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(185, 44);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(140, 27);
            txtProductId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 90);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 0;
            label2.Text = "Category ID";
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(185, 87);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(140, 27);
            txtCategoryId.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 136);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 0;
            label3.Text = "Product Name";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(185, 133);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(140, 27);
            txtProductName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 180);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 0;
            label4.Text = "Weight";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(185, 177);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(140, 27);
            txtWeight.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 223);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 0;
            label5.Text = "Unit Price";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(185, 220);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(140, 27);
            txtUnitPrice.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 271);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 0;
            label6.Text = "Units In Stock";
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(185, 268);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(140, 27);
            txtUnitsInStock.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(58, 339);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(195, 339);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmProductDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtUnitsInStock);
            Controls.Add(label6);
            Controls.Add(txtUnitPrice);
            Controls.Add(label5);
            Controls.Add(txtWeight);
            Controls.Add(label4);
            Controls.Add(txtProductName);
            Controls.Add(label3);
            Controls.Add(txtCategoryId);
            Controls.Add(label2);
            Controls.Add(txtProductId);
            Controls.Add(label1);
            Name = "frmProductDetail";
            Text = "frmProductDetail";
            Load += frmProductDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProductId;
        private Label label2;
        private TextBox txtCategoryId;
        private Label label3;
        private TextBox txtProductName;
        private Label label4;
        private TextBox txtWeight;
        private Label label5;
        private TextBox txtUnitPrice;
        private Label label6;
        private TextBox txtUnitsInStock;
        private Button btnSave;
        private Button btnCancel;
    }
}