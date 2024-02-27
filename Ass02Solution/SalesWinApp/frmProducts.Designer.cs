namespace SalesWinApp
{
    partial class frmProducts
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
            dgvProducts = new DataGridView();
            label1 = new Label();
            txtProductId = new TextBox();
            label2 = new Label();
            txtCategoryId = new TextBox();
            label3 = new Label();
            txtWeight = new TextBox();
            label4 = new Label();
            txtUnitPrice = new TextBox();
            label5 = new Label();
            txtUnitsInStock = new TextBox();
            label6 = new Label();
            txtProductName = new TextBox();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            txtSearchId = new TextBox();
            btnSearchId = new Button();
            txtSearchName = new TextBox();
            btnSearchName = new Button();
            label7 = new Label();
            label8 = new Label();
            cbUnitPrice = new ComboBox();
            cbUnitsInStock = new ComboBox();
            btnSearchUnitsInStock = new Button();
            btnSearchUnitPrice = new Button();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(212, 195);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(576, 254);
            dgvProducts.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 15);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 1;
            label1.Text = "Product ID";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(315, 12);
            txtProductId.Name = "txtProductId";
            txtProductId.ReadOnly = true;
            txtProductId.Size = new Size(125, 27);
            txtProductId.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 60);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Category ID";
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(315, 57);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.ReadOnly = true;
            txtCategoryId.Size = new Size(125, 27);
            txtCategoryId.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(494, 15);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 1;
            label3.Text = "Weight";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(608, 12);
            txtWeight.Name = "txtWeight";
            txtWeight.ReadOnly = true;
            txtWeight.Size = new Size(125, 27);
            txtWeight.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(494, 60);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 1;
            label4.Text = "Unit Price";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(608, 57);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(125, 27);
            txtUnitPrice.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(494, 97);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 1;
            label5.Text = "Units In Stock";
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(608, 94);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.ReadOnly = true;
            txtUnitsInStock.Size = new Size(125, 27);
            txtUnitsInStock.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(212, 97);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 1;
            label6.Text = "Product Name";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(315, 94);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 2;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(236, 146);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(421, 146);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 3;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(608, 146);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearchId
            // 
            txtSearchId.Location = new Point(22, 40);
            txtSearchId.Name = "txtSearchId";
            txtSearchId.Size = new Size(125, 27);
            txtSearchId.TabIndex = 2;
            // 
            // btnSearchId
            // 
            btnSearchId.Location = new Point(112, 5);
            btnSearchId.Name = "btnSearchId";
            btnSearchId.Size = new Size(94, 29);
            btnSearchId.TabIndex = 3;
            btnSearchId.Text = "Search";
            btnSearchId.UseVisualStyleBackColor = true;
            btnSearchId.Click += btnSearch_Click;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(22, 155);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(125, 27);
            txtSearchName.TabIndex = 2;
            // 
            // btnSearchName
            // 
            btnSearchName.Location = new Point(123, 120);
            btnSearchName.Name = "btnSearchName";
            btnSearchName.Size = new Size(94, 29);
            btnSearchName.TabIndex = 3;
            btnSearchName.Text = "Search";
            btnSearchName.UseVisualStyleBackColor = true;
            btnSearchName.Click += btnSearchName_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 1;
            label7.Text = "Search by ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 122);
            label8.Name = "label8";
            label8.Size = new Size(114, 20);
            label8.TabIndex = 1;
            label8.Text = "Search by name";
            // 
            // cbUnitPrice
            // 
            cbUnitPrice.FormattingEnabled = true;
            cbUnitPrice.Items.AddRange(new object[] { "0 - 100 ", "100 - 1000", "1000 - 10000 ", "> 10000" });
            cbUnitPrice.Location = new Point(22, 241);
            cbUnitPrice.Name = "cbUnitPrice";
            cbUnitPrice.Size = new Size(151, 28);
            cbUnitPrice.TabIndex = 4;
            // 
            // cbUnitsInStock
            // 
            cbUnitsInStock.FormattingEnabled = true;
            cbUnitsInStock.Items.AddRange(new object[] { "0 - 10", "10 - 100 ", "100 - 1000 ", "1000 - 10000", "> 10000" });
            cbUnitsInStock.Location = new Point(22, 375);
            cbUnitsInStock.Name = "cbUnitsInStock";
            cbUnitsInStock.Size = new Size(151, 28);
            cbUnitsInStock.TabIndex = 4;
            // 
            // btnSearchUnitsInStock
            // 
            btnSearchUnitsInStock.Location = new Point(53, 409);
            btnSearchUnitsInStock.Name = "btnSearchUnitsInStock";
            btnSearchUnitsInStock.Size = new Size(94, 29);
            btnSearchUnitsInStock.TabIndex = 3;
            btnSearchUnitsInStock.Text = "Search";
            btnSearchUnitsInStock.UseVisualStyleBackColor = true;
            btnSearchUnitsInStock.Click += btnSearchUnitsInStock_Click;
            // 
            // btnSearchUnitPrice
            // 
            btnSearchUnitPrice.Location = new Point(53, 275);
            btnSearchUnitPrice.Name = "btnSearchUnitPrice";
            btnSearchUnitPrice.Size = new Size(94, 29);
            btnSearchUnitPrice.TabIndex = 3;
            btnSearchUnitPrice.Text = "Search";
            btnSearchUnitPrice.UseVisualStyleBackColor = true;
            btnSearchUnitPrice.Click += btnSearchUnitPrice_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 218);
            label9.Name = "label9";
            label9.Size = new Size(108, 20);
            label9.TabIndex = 1;
            label9.Text = "Filter unit price";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(42, 352);
            label10.Name = "label10";
            label10.Size = new Size(131, 20);
            label10.TabIndex = 1;
            label10.Text = "Filter units in stock";
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbUnitsInStock);
            Controls.Add(cbUnitPrice);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnSearchUnitPrice);
            Controls.Add(btnSearchUnitsInStock);
            Controls.Add(btnSearchName);
            Controls.Add(btnSearchId);
            Controls.Add(btnLoad);
            Controls.Add(txtUnitsInStock);
            Controls.Add(label5);
            Controls.Add(txtUnitPrice);
            Controls.Add(label4);
            Controls.Add(txtWeight);
            Controls.Add(label3);
            Controls.Add(txtSearchName);
            Controls.Add(txtSearchId);
            Controls.Add(txtProductName);
            Controls.Add(label6);
            Controls.Add(txtCategoryId);
            Controls.Add(label2);
            Controls.Add(txtProductId);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(dgvProducts);
            Name = "frmProducts";
            Text = "frmProducts";
            Load += frmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private Label label1;
        private TextBox txtProductId;
        private Label label2;
        private TextBox txtCategoryId;
        private Label label3;
        private TextBox txtWeight;
        private Label label4;
        private TextBox txtUnitPrice;
        private Label label5;
        private TextBox txtUnitsInStock;
        private Label label6;
        private TextBox txtProductName;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private TextBox txtSearchId;
        private Button btnSearchId;
        private TextBox txtSearchName;
        private Button btnSearchName;
        private Label label7;
        private Label label8;
        private ComboBox cbUnitPrice;
        private ComboBox cbUnitsInStock;
        private Button btnSearchUnitsInStock;
        private Button btnSearchUnitPrice;
        private Label label9;
        private Label label10;
    }
}