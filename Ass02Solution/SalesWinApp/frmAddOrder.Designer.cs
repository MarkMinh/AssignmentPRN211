namespace SalesWinApp
{
    partial class frmAddOrder
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
            txtMemberId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFreight = new TextBox();
            label6 = new Label();
            txtProductId = new TextBox();
            label7 = new Label();
            txtUnitPrice = new TextBox();
            label8 = new Label();
            txtQuantity = new TextBox();
            label9 = new Label();
            txtDiscount = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            dtpOrderDate = new DateTimePicker();
            dtpRequiredDate = new DateTimePicker();
            dtpShippedDate = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 39);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "Member ID";
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(202, 36);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(125, 27);
            txtMemberId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 87);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 0;
            label2.Text = "Order Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 141);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 0;
            label3.Text = "Required Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 196);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 0;
            label4.Text = "Shipped Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 250);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 0;
            label5.Text = "Freight";
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(202, 247);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(125, 27);
            txtFreight.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(364, 39);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 0;
            label6.Text = "Product ID";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(459, 36);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(125, 27);
            txtProductId.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(364, 87);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 0;
            label7.Text = "Unit Price";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(459, 84);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(125, 27);
            txtUnitPrice.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(364, 141);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 0;
            label8.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(459, 138);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(364, 196);
            label9.Name = "label9";
            label9.Size = new Size(67, 20);
            label9.TabIndex = 0;
            label9.Text = "Discount";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(459, 193);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(125, 27);
            txtDiscount.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(202, 350);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(405, 350);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(202, 87);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(125, 27);
            dtpOrderDate.TabIndex = 3;
            // 
            // dtpRequiredDate
            // 
            dtpRequiredDate.Location = new Point(202, 136);
            dtpRequiredDate.Name = "dtpRequiredDate";
            dtpRequiredDate.Size = new Size(125, 27);
            dtpRequiredDate.TabIndex = 3;
            // 
            // dtpShippedDate
            // 
            dtpShippedDate.Location = new Point(202, 191);
            dtpShippedDate.Name = "dtpShippedDate";
            dtpShippedDate.Size = new Size(125, 27);
            dtpShippedDate.TabIndex = 3;
            // 
            // frmAddOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 450);
            Controls.Add(dtpShippedDate);
            Controls.Add(dtpRequiredDate);
            Controls.Add(dtpOrderDate);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtDiscount);
            Controls.Add(label9);
            Controls.Add(txtQuantity);
            Controls.Add(label8);
            Controls.Add(txtUnitPrice);
            Controls.Add(label7);
            Controls.Add(txtProductId);
            Controls.Add(label6);
            Controls.Add(txtFreight);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMemberId);
            Controls.Add(label1);
            Name = "frmAddOrder";
            Text = "frmAddOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMemberId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtFreight;
        private Label label6;
        private TextBox txtProductId;
        private Label label7;
        private TextBox txtUnitPrice;
        private Label label8;
        private TextBox txtQuantity;
        private Label label9;
        private TextBox txtDiscount;
        private Button btnSave;
        private Button btnCancel;
        private DateTimePicker dtpOrderDate;
        private DateTimePicker dtpRequiredDate;
        private DateTimePicker dtpShippedDate;
    }
}