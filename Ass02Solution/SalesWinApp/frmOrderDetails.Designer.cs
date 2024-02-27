namespace SalesWinApp
{
    partial class frmOrderDetails
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
            txtOrderId = new TextBox();
            label2 = new Label();
            txtProductId = new TextBox();
            label3 = new Label();
            txtUnitPrice = new TextBox();
            label4 = new Label();
            txtQuantity = new TextBox();
            label5 = new Label();
            txtDiscount = new TextBox();
            btnCancel = new Button();
            btnUpdate = new Button();
            cUpdate = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 57);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Order ID";
            // 
            // txtOrderId
            // 
            txtOrderId.Enabled = false;
            txtOrderId.Location = new Point(147, 54);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(184, 27);
            txtOrderId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 117);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 0;
            label2.Text = "Product ID";
            // 
            // txtProductId
            // 
            txtProductId.Enabled = false;
            txtProductId.Location = new Point(147, 114);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(184, 27);
            txtProductId.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 178);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 0;
            label3.Text = "Unit Price";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(147, 175);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(184, 27);
            txtUnitPrice.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 236);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 0;
            label4.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(147, 233);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(184, 27);
            txtQuantity.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 293);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 0;
            label5.Text = "Discount";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(147, 290);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(184, 27);
            txtDiscount.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(237, 371);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.DialogResult = DialogResult.OK;
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(91, 371);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cUpdate
            // 
            cUpdate.AutoSize = true;
            cUpdate.Location = new Point(147, 12);
            cUpdate.Name = "cUpdate";
            cUpdate.Size = new Size(80, 24);
            cUpdate.TabIndex = 3;
            cUpdate.Text = "Update";
            cUpdate.UseVisualStyleBackColor = true;
            cUpdate.CheckedChanged += cUpdate_CheckedChanged;
            // 
            // frmOrderDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 450);
            Controls.Add(cUpdate);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(txtDiscount);
            Controls.Add(label5);
            Controls.Add(txtQuantity);
            Controls.Add(label4);
            Controls.Add(txtUnitPrice);
            Controls.Add(label3);
            Controls.Add(txtProductId);
            Controls.Add(label2);
            Controls.Add(txtOrderId);
            Controls.Add(label1);
            Name = "frmOrderDetails";
            Text = "frmOrderDetails";
            Load += frmOrderDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtOrderId;
        private Label label2;
        private TextBox txtProductId;
        private Label label3;
        private TextBox txtUnitPrice;
        private Label label4;
        private TextBox txtQuantity;
        private Label label5;
        private TextBox txtDiscount;
        private Button btnCancel;
        private Button btnUpdate;
        private CheckBox cUpdate;
    }
}